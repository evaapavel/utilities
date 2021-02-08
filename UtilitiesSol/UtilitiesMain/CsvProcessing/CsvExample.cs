using System;
using System.Collections.Generic;



namespace UtilitiesMain.CsvProcessing
{



    public class CsvExample
    {



        public static void Go()
        {
            string fileToPeople = @"X:\MyFiles\CSV_files\people.csv";
            CsvParser parser = new CsvParser();
            List<President> presidents = parser.LoadCsv(fileToPeople);
            foreach (President president in presidents)
            {
                Console.WriteLine($"first name: {president.FirstName}, last name: {president.LastName}, born: {president.Born}, died: {president.Died}, citizenship: {president.Citizenship}");
            }
        }



    }



}
