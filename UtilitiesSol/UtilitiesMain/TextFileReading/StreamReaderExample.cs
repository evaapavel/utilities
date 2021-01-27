using System;
using System.Collections.Generic;
using System.IO;



namespace UtilitiesMain.TextFileReading
{
    public class StreamReaderExample
    {


        public static void Go()
        {
            StreamReader sr = null;

            try
            {
                string pathToTestFile = @"X:\MyFiles\Input\InputText.txt";
                sr = new StreamReader(pathToTestFile);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }


    }
}
