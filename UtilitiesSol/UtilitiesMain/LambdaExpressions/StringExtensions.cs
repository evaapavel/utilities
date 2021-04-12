using System;
using System.Text;



namespace UtilitiesMain.LambdaExpressions
{



    public static class StringExtensions
    {



        public static string ConcatAndToUpper(this string s1, string s2, string s3)
        {
            string s = s1 + s2 + s3;
            string result = s.ToUpper();
            return result;
        }



        public static string ToUpperAndLowerAlternately(this string input)
        {
            StringBuilder sb = new StringBuilder(input);
            bool thisTimeToUpper = true;
            for (int i = 0; i < sb.Length; i++)
            {
                if (thisTimeToUpper)
                {
                    sb[i] = char.ToUpper(sb[i]);
                    thisTimeToUpper = false;
                }
                else
                {
                    sb[i] = char.ToLower(sb[i]);
                    thisTimeToUpper = true;
                }
            }
            return sb.ToString();
        }



    }



}
