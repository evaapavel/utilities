using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UtilitiesMain.LambdaExpressions
{



    public static class DelegateExample
    {



        //public static char ShiftForward(char c, int pos)
        //{
        //    return (char)(((int)c) + 1);
        //}

        //public static char ShiftBackward(char c, int pos)
        //{
        //    return (char)(((int)c) - 1);
        //}

        //public static char ShiftZigZag(char c, int pos)
        //{
        //    return (char)(((int)c) + (pos % 2 == 0 ? +1 : -1));
        //}



        public static void TestEncrypting()
        {

            string pwdA = "heslo";
            string pwdB = "p1$$w0rD";
            string pwdC = "karel77";

            //string encryptA = Encrypt(pwdA, new CodeShiftDelegate(ShiftForward));

            //string encryptA = Encrypt(pwdA, ShiftForward);
            //string encryptB = Encrypt(pwdB, ShiftBackward);
            //string encryptC = Encrypt(pwdC, ShiftZigZag);
            //string encryptA = StringFunctions.Encrypt(pwdA, ShiftForward);
            //string encryptB = StringFunctions.Encrypt(pwdB, ShiftBackward);
            //string encryptC = StringFunctions.Encrypt(pwdC, ShiftZigZag);

            string encryptA = StringFunctions.Encrypt(pwdA, (znak, pozice) => ((char) (((int) znak) + 1)) );
            string encryptB = StringFunctions.Encrypt(pwdB, (znak, pozice) => ((char) (((int) znak) - 1)) );
            string encryptC = StringFunctions.Encrypt(pwdC, (znak, pozice) => ((char) (((int) znak) + (pozice % 2 == 0 ? +1 : -1))));

            Console.WriteLine($"{pwdA} ---> {encryptA}");
            Console.WriteLine($"{pwdB} ---> {encryptB}");
            Console.WriteLine($"{pwdC} ---> {encryptC}");

        }



    }



}
