using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.LambdaExpressions
{
    public class LambdaTest
    {

        public static void Go()
        {
            //InstanceAndStatic instanceAndStatic = new InstanceAndStatic(5);
            //string result = instanceAndStatic.InstanceMethod(true);
            //Console.WriteLine(result);

            //string result2 = InstanceAndStatic.StaticMethod(instanceAndStatic, true);
            //Console.WriteLine(result2);

            //string result2 = instanceAndStatic.StaticMethod(true);
            //Console.WriteLine(result2);

            //object o = instanceAndStatic.ReturnNothing(5, 6);
            //instanceAndStatic.ReturnNothing(5, 6);

            //string r = StringExtensions.ConcatAndToUpper("Ahoj ", "Jane ", "Nováku!");
            string ahoj = "Ahoj ";
            string r = ahoj.ConcatAndToUpper("Jane ", "Nováku!");
            Console.WriteLine(r);
        }





    }
}
