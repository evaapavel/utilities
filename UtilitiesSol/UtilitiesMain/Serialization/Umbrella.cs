using System;



namespace UtilitiesMain.Serialization
{



    /// <summary>
    /// An umbrella in stock.
    /// </summary>
    public class Umbrella : StockItem
    {



        /// <summary>Type of the umbrella (telescopic, automatic, etc.).</summary>
        public string Type { get; set; }



        protected override void StoreFieldsIntoArray()
        {
            base.StoreFieldsIntoArray();
            fields[firstUnused] = Type;
            firstUnused++;
        }



        protected override void LoadFieldsFromArray()
        {
            base.LoadFieldsFromArray();
            Type = (string)fields[currentToRead];
            currentToRead++;
        }



    }



}
