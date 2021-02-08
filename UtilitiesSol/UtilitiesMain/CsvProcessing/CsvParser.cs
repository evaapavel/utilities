using System;
using System.Collections.Generic;
using System.IO;



namespace UtilitiesMain.CsvProcessing
{



    public class CsvParser
    {



        public List<President> LoadCsv(string pathToPresidents)
        {
            List<President> presidents = new List<President>();
            using (StreamReader sr = new StreamReader(pathToPresidents))
            {
                bool isFirstLine = true;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (isFirstLine)
                    {
                        isFirstLine = false;
                    }
                    else
                    {
                        President president = ToPresident(line);
                        presidents.Add(president);
                    }
                }
            }
            return presidents;
        }



        private President ToPresident(string line)
        {
            string[] tokens = line.Split(',');
            President president = new President();
            president.FirstName = tokens[0];
            president.LastName = tokens[1];
            if (!string.IsNullOrEmpty(tokens[2]))
            {
                president.Born = Convert.ToInt32(tokens[2]);
            }
            else
            {
                president.Born = 0;
            }
            if (!string.IsNullOrEmpty(tokens[3]))
            {
                president.Died = Convert.ToInt32(tokens[3]);
            }
            else
            {
                president.Died = 0;
            }
            //president.Citizenship = tokens[4];
            president.Citizenship = (Country) Enum.Parse(typeof(Country), tokens[4]);

            return president;
        }



    }



}
