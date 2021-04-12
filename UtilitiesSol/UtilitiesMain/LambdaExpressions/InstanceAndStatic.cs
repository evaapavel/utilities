using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UtilitiesMain.LambdaExpressions
{



    public class InstanceAndStatic
    {



        internal int instanceData;




        public InstanceAndStatic(int data)
        {
            instanceData = data;
        }




        public string InstanceMethod(bool parameterData)
        {
            if (parameterData == true)
            {
                return this.instanceData.ToString();
            }
            return "n/a";
        }



        //public static string StaticMethod(InstanceAndStatic instanceRef, bool parameterData)
        //{
        //    if (parameterData == true)
        //    {
        //        return instanceRef.instanceData.ToString();
        //    }
        //    return "n/a";
        //}






        public void ReturnNothing(int a, int b)
        {
            Console.WriteLine($"a = {a}, b = {b}");
            return;
        }



    }






}
