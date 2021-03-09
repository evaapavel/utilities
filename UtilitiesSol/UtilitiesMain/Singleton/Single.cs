using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.Singleton
{
    public class Single : SelfCountingObject
    {

        private static Single instance = null;

        public static Single Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Single();
                }
                return instance;
            }
        }

        private Single()
        {
            Console.WriteLine("Constructor of Single got called");
        }

        public string GetGreeting(string name)
        {
            return $"Hello {name}!";
        }

    }
}
