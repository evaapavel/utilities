using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.Singleton
{
    public class ClientOne
    {

        private string name;

        private Single single;



        public ClientOne()
        {
            this.name = "One";
            //this.single = new Single();
            this.single = Single.Instance;
        }

        //public ClientOne(Single single)
        //{
        //    this.name = "One";
        //    //this.single = new Single();
        //    this.single = single;
        //}



        public string Name
        {
            get { return this.name; }
        }

        public void DisplayGreetingOne()
        {
            //Single single = new Single();
            Console.WriteLine($"Single #: {single.Ordinal}");
            Console.WriteLine(single.GetGreeting(this.name));
        }

    }
}
