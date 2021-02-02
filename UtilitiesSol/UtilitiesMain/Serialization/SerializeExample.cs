using System;
using System.IO;

namespace UtilitiesMain.Serialization
{



    public class SerializeExample
    {



        public static void Go()
        {
            //UserPreferences userPreferences = new UserPreferences();
            //userPreferences.Theme = Theme.Cyan;
            //userPreferences.IsConfirmDelete = true;
            //userPreferences.CurrentDirectory = Directory.GetCurrentDirectory();
            //string serializeDir = @"X:\MyFiles\Output";
            //string serializeFileUserPreferences = "UserPrefs.txt";
            //string filePath = Path.Combine(serializeDir, serializeFileUserPreferences);
            ////userPreferences.SerializeToFile(serializeDir);
            //userPreferences.SerializeToFile(filePath);
            Anorak anorak = new Anorak();
            anorak.Price = 990;
            anorak.Ean = "1946493894560";
            anorak.Size = 16.75;
            string serializeDir = @"X:\MyFiles\Output";
            string serializeFileAnorak = "Anor.txt";
            string filePath = Path.Combine(serializeDir, serializeFileAnorak);
            //userPreferences.SerializeToFile(serializeDir);
            anorak.SerializeToFile(filePath);
        }



        public static void testIsAndAs()
        {
            SerializableObject sr = new Umbrella();
            //...


            //sr.SerializeToFile(...);
            //sr.Price = 200;

            ChangeObject(ref sr);

            if (sr is Umbrella)
            {
                Umbrella um = (Umbrella)sr;
                um.Price = 200;
                um.Ean = "123468904";
                um.Type = "automatic";
            }


            if (sr is StockItem)
            {
                StockItem si = (StockItem)sr;
                si.Price = 200;
                //si.Type = "automatic";
            }

        }



        private static void ChangeObject(ref SerializableObject obj)
        {
            obj = new Anorak();
        }




    }



}
