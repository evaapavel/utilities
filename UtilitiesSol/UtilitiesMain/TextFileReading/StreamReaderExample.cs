using System;
using System.Collections.Generic;
using System.IO;



namespace UtilitiesMain.TextFileReading
{
    public class StreamReaderExample
    {


        public static void Go()
        {
            try
            {
                string pathToTestFile = @"X:\MyFiles\Input\InputText.txt";
                StreamReader sr = new StreamReader(pathToTestFile);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                sr.Close();
                sr.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
