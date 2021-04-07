using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.GenericClasses
{
    public class Couple<T, U>
    {
        public T FirstValue { get; set; }
        public U SecondValue { get; set; }

        public Couple(T firstValue, U secondValue)
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
        }
    }
}
