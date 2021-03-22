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
            Fax fax1 = new Fax(mm);

            // Create a pager.
            Pager pager1 = new Pager(mm);

            // Send email #1.
            mm.SimulateArrivingMsg("pavel", "petr", "Ahoj", "Ahoj, jak se máš? Já dobře.");

            // Send email #2.
            mm.SimulateArrivingMsg("jim", "fireworks", "Fire!", "Please come, here is a fire!");

        }

    }
}
