using System;

namespace UtilitiesMain.DataClasses
{
    public class Publisher
    {

        public string name;
        public int since;
        public long ico;

        public Publisher(string name, int since, long ico)
        {
            this.name = name;
            this.since = since;
            this.ico = ico;
        }
    }
}
