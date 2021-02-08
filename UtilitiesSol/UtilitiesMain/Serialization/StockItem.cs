using System;



namespace UtilitiesMain.Serialization
{



    /// <summary>
    /// Represents an item that can be shopped on an eshop.
    /// </summary>
    public class StockItem : SerializableObject
    //public class StockItem
    {



        /// <summary>Price of the item.</summary>
        public decimal Price { get; set; }

        /// <summary>Item's bar code.</summary>
        public string Ean { get; set; }



        protected override void StoreFieldsIntoArray()
        {
            fields[firstUnused] = Price;
            firstUnused++;
            fields[firstUnused] = Ean;
            firstUnused++;
        }

        protected override void LoadFieldsFromArray()
        {
            Price = (decimal)fields[currentToRead];
            currentToRead++;
            Ean = (string)fields[currentToRead];
            currentToRead++;
        }



    }



}
