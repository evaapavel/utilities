using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.GenericClasses
{
    public class Monuple<T>
    {
        public T Value { get; set; }

        public Monuple(T value)
        {
            this.Value = value;
        }
    }
}
