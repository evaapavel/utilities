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

            Functions.TestFunc();

            Console.WriteLine("Hello, my darling!".ToUpperAndLowerAlternately());
            Console.WriteLine("Eyjafjallajökull".ToUpperAndLowerAlternately());
        }

    }
}
