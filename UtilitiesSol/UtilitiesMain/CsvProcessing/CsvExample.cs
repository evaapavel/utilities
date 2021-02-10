using System;
using System.Collections.Generic;



namespace UtilitiesMain.CsvProcessing
{



    public class CsvExample
    {



        public static void Go()
        {

            // CSV processing test.
            string fileToPeople = @"X:\MyFiles\CSV_files\people.csv";
            CsvParser parser = new CsvParser();
            List<President> presidents = parser.LoadCsv(fileToPeople);
            foreach (President president in presidents)
            {
                Console.WriteLine($"first name: {president.FirstName}, last name: {president.LastName}, born: {president.Born}, died: {president.Died}, citizenship: {president.Citizenship}");
            }

            // CSV creation test.
            string pathToNewPresidents = @"X:\MyFiles\CSV_files\newPresidents.csv";
            // ***
            President masaryk = new President("Tomáš", "Garrigue Masaryk", 1850, 1937, Country.CZ);
            President degaulle = new President("Charles", "de Gaulle", 1890, 1970, Country.FR);
            President steinmeier = new President("Frank-Walter", "Steinmeier", 1956, 0, Country.DE);
            President walesa = new President("Lech", "Wałęsa", 1943, 0, Country.PL);
            // ***
            List<President> newPresidents = new List<President> { masaryk, degaulle, steinmeier, walesa };
            // ***
            CsvCreator creator = new CsvCreator();
            creator.SaveCsv(pathToNewPresidents, newPresidents);

        }



    }



}
