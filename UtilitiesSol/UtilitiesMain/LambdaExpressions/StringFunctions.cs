using System;
using System.Collections.Generic;



namespace UtilitiesMain.LambdaExpressions
{



    public static class StringFunctions
    {



        //public static string EncryptForward(string input)
        //{
        //    string output = "";
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];
        //        char d = (char)(((int)c) + 1);
        //        output += d.ToString();
        //    }
        //    return output;
        //}



        //public static string EncryptBackward(string input)
        //{
        //    string output = "";
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];
        //        char d = (char)(((int)c) - 1);
        //        output += d.ToString();
        //    }
        //    return output;
        //}



        //public static string EncryptZigZag(string input)
        //{
        //    string output = "";
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];
        //        char d = (char)(((int)c) + (i % 2 == 0 ? +1 : -1));
        //        output += d.ToString();
        //    }
        //    return output;
        //}



        public static string Encrypt(string input, CodeShiftDelegate shiftFunction)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                char d = shiftFunction(c, i);
                output += d.ToString();
            }
            return output;
        }




        public static void TestFunc()
        {
            string password = "ABCDEFGH";
            //string password = "UVWXYZ";
            //string encrypted = EncryptForward(password);
            //string encrypted = EncryptBackward(password);
            //string encrypted = EncryptZigZag(password);
            //Console.WriteLine(encrypted);
        }



        //public static string EncryptZigZag(string input)
        //{
        //    string output = "";
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];
        //        char d;
        //        if (i % 2 == 0)
        //        {
        //            d = (char)(((int)c) + 1);
        //        }
        //        else
        //        {
        //            d = (char)(((int)c) - 1);
        //        }
        //        output += d.ToString();
        //    }
        //    return output;
        //}



    }



}
