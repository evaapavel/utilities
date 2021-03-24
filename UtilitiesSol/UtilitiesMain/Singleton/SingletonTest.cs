using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.Singleton
{
    public class SingletonTest
    {

        public static void Go()
        {

            //Single single = new Single();

            ClientOne clientOne = new ClientOne();
            //ClientOne clientOne = new ClientOne(single);
            clientOne.DisplayGreetingOne();

            ClientTwo clientTwo = new ClientTwo();
            //ClientTwo clientTwo = new ClientTwo(single);
            clientTwo.DisplayGreetingTwo();
            clientTwo.DisplayGreetingTwo();

        }

    }
}
