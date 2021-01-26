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
            userPreferences.SerializeToFile(serializeDir);
        }



    }



}
