using System;
using System.Collections.Generic;



namespace UtilitiesMain.LambdaExpressions
{



    public class DelegatesAndFunctions
    {



        public delegate double OneParameterDelegate(double param1);

        public delegate double TwoParameterDelegate(double param1, double param2);



        public static double G(double x, double y)
        {
            return 2 * x - y + 0.5;
        }



        public static double H(double a)
        {
            return a + 3;
        }



        public static double D(double x, double y)
        {
            return H(G(x, y));
        }



        public static int GetSum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }



        //public static void SendMail(string from, string to, string subject)
        //{
        //    Mail.Send(from, to, subject);
        //}



        public static int Count(int iCount)
        {
            //iCount = iCount + 1;
            //return iCount;
            return iCount + 1;
        }



        public delegate string Hello(string sName);


        public delegate string ConcatDelegate(int times, string word);


        public delegate DateTime DateNow();


        public delegate DateTime dateTimeNow();



    }



}
