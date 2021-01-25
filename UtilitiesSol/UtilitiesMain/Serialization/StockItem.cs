using System;



namespace UtilitiesMain.Serialization
{



    public class StockItem : SerializableObject
    {



        /// <summary>Price of the item.</summary>
        public decimal Price { get; set; }

        /// <summary>Item's bar code.</summary>
        public string Ean { get; set; }



    }



}
