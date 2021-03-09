using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.Singleton
{
    public class ClientTwo
    {

        private string name;

        private Single single;



        public ClientTwo()
        {
            this.name = "Two";
            //this.single = new Single();
            this.single = Single.Instance;
        }

        //public ClientTwo(Single single)
        //{
        //    this.name = "Two";
        //    //this.single = new Single();
        //    this.single = single;
        //}



        public string Name
        {
            get { return this.name; }
        }

        public void DisplayGreetingTwo()
        {
            //Single single = new Single();
            Console.WriteLine($"Single #: {single.Ordinal}");
            Console.WriteLine(single.GetGreeting(this.name));
        }

    }
}
