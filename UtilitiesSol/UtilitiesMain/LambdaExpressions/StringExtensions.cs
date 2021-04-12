using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
