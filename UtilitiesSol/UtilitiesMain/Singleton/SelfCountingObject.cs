using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.Singleton
{
    public class SelfCountingObject
    {

        private static int counter = 0;

        private int ordinal;

        public SelfCountingObject()
        {
            counter++;
            this.ordinal = counter;
        }

        public int Ordinal
        {
            get { return this.ordinal; }
        }

    }
}
