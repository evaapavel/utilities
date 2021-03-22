using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.CustomEvents
{



    public class CustomEventTest
    {



        public static void Go()
        {

            // Create a mail manager.
            MailManager mm = new MailManager();

            // Create a fax.
            //Fax fax1 = new Fax(mm);
            Fax fax1 = new Fax(mm, "Fax #1");

            // Create a pager.
            //Pager pager1 = new Pager(mm);
            Pager pager1 = new Pager(mm, "Pager #1");

            // Create another pager.
            //Pager pager2 = new Pager(mm);
            Pager pager2 = new Pager(mm, "Pager #2");

            // Send email #1.
            mm.SimulateArrivingMsg("pavel", "petr", "Ahoj", "Ahoj, jak se máš? Já dobře.");
            Console.WriteLine();
            Console.WriteLine();

            // Send email #2.
            mm.SimulateArrivingMsg("jim", "fireworks", "Fire!", "Please come, there is a fire in my office!");
            Console.WriteLine();
            Console.WriteLine();

            // Unregister fax #1.
            fax1.Unregister(mm);
            Console.WriteLine();
            Console.WriteLine();

            // Send email #3.
            mm.SimulateArrivingMsg("petr", "pavel", "RE: Ahoj", "Já se mám také dobře.");

        }



    }



}
