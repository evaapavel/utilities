using System;



namespace UtilitiesMain.Serialization
{



    /// <summary>
    /// An anorak in stock.
    /// </summary>
    public class Anorak : StockItem
    {



        /// <summary>Size of the item (European measure).</summary>
        public double Size { get; set; }



        protected override void StoreFieldsIntoArray()
        {
            base.StoreFieldsIntoArray();
            fields[firstUnused] = Size;
            firstUnused++;
        }



        protected override void LoadFieldsFromArray()
        {
            base.LoadFieldsFromArray();
            Size = (double) fields[currentToRead];
            currentToRead++;
        }


    }



}
