using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.LambdaExpressions
{
    public static class Helper
    {
        public static string StaticMethod(this InstanceAndStatic instanceRef, bool parameterData)
        {
            if (parameterData == true)
            {
                return instanceRef.instanceData.ToString();
            }
            return "n/a";
        }

    }
}
