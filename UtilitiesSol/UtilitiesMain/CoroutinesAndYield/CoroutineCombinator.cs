using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UtilitiesMain.CoroutinesAndYield
{



    public class CoroutineCombinator<T>
    {


        public static IEnumerable<T> Combine(CoroutineDelegate<T> coroutineA, CoroutineDelegate<T> coroutineB)
        {
            IEnumerator<T> enumeratorA = coroutineA().GetEnumerator();
            IEnumerator<T> enumeratorB = coroutineB().GetEnumerator();
            bool wereThereMoreFromA = true;
            bool wereThereMoreFromB = true;
            for (;;)
            {

                bool areThereMoreFromA = false;
                if (wereThereMoreFromA)
                {
                    areThereMoreFromA = enumeratorA.MoveNext();
                    if (areThereMoreFromA)
                    {
                        yield return enumeratorA.Current;
                    }
                }

                bool areThereMoreFromB = false;
                if (wereThereMoreFromB)
                {
                    areThereMoreFromB = enumeratorB.MoveNext();
                    if (areThereMoreFromB)
                    {
                        yield return enumeratorB.Current;
                    }
                }

                if ( ! (areThereMoreFromA || areThereMoreFromB) )
                {
                    break;
                }

                //if (areThereMoreFromA)
                //{
                //    yield return enumeratorA.Current;
                //}
                //if (areThereMoreFromB)
                //{
                //    yield return enumeratorB.Current;
                //}

                wereThereMoreFromA = areThereMoreFromA;
                wereThereMoreFromB = areThereMoreFromB;

            }
                    
        }



    }



}

