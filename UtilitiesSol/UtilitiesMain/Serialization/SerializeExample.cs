using System;
using System.IO;

namespace UtilitiesMain.Serialization
{



    public class SerializeExample
    {



        public static void Go()
        {
            UserPreferences userPreferences = new UserPreferences();
            userPreferences.Theme = Theme.Cyan;
            userPreferences.IsConfirmDelete = true;
            userPreferences.CurrentDirectory = Directory.GetCurrentDirectory();
            string serializeDir = @"X:\MyFiles\Output";
            string serializeFileUserPreferences = "UserPrefs.txt";
            string filePath = Path.Combine(serializeDir, serializeFileUserPreferences);
            //userPreferences.SerializeToFile(serializeDir);
            userPreferences.SerializeToFile(filePath);
            //Anorak anorak = new Anorak();
            //anorak.Price = 990;
            //anorak.Ean = "1946493894560";
            //anorak.Size = 16.75;
            //string serializeDir = @"X:\MyFiles\Output";
            //string serializeFileAnorak = "Anor.txt";
            //string filePath = Path.Combine(serializeDir, serializeFileAnorak);
            ////userPreferences.SerializeToFile(serializeDir);
            //anorak.SerializeToFile(filePath);
        }



        public static void TestIsAndAs()
        {
            SerializableObject sobj = new Umbrella();
            //...

            //sr.SerializeToFile(...);
            //sr.Price = 200;

            ChangeObject(ref sobj);

            // Using "is".
            if (sobj is Umbrella)
            {
                Umbrella um = (Umbrella)sobj;
                um.Price = 200;
                um.Ean = "123468904";
                um.Type = "automatic";
            }

            // Using "is".
            if (sobj is StockItem)
            {
                StockItem si = (StockItem)sobj;
                si.Price = 200;
                // Uncommenting this line causes a compile-time error.
                // A StockItem might be an umbrella, but it may also be an anorak, a pencil, whatever we sell on our e-shop.
                //si.Type = "automatic";
            }

            // Using "as".
            Anorak anorak = sobj as Anorak;
            if (anorak != null)
            {
                Console.WriteLine(anorak.Size);
            }

            // Using "as".
            // This compiles fine because SerializableObject and UserPreferences have a relationship "ancestor-descendant".
            UserPreferences preferences = sobj as UserPreferences;
            if (preferences != null)
            {
                preferences.Theme = Theme.Orange;
            }

            // Using "as".
            // This compiles fine because SerializableObject and StockItem have a relationship "ancestor-descendant".
            StockItem item = sobj as StockItem;
            if (item != null)
            {
                // The following lines do NOT compile because StockItem and UserPreferences do NOT have a relationship "ancestor-descendant".
                // The two types lie in different branches of the object hierarchy.
                //UserPreferences up = item as UserPreferences;
                //up.IsConfirmDelete = false;
            }

        }



        private static void ChangeObject(ref SerializableObject obj)
        {
            obj = new Anorak();
        }




    }



}
