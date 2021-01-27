using System;
using System.IO;



namespace UtilitiesMain.TextFileWriting
{



    public class StreamWriterExample
    {

        public static void Go()
        {
            StreamWriter sw = null;
            try
            {
                DateTime now = DateTime.Now;
                string nowAsString = now.ToString("yyyyMMdd_HHmmss");
                string pathToTestFile = @"X:\MyFiles\Output\" + "OutputText" + "_" + nowAsString + ".txt";
                sw = new StreamWriter(pathToTestFile);

                sw.WriteLine("Ahoj, světe!");
                sw.WriteLine("Jak se máš?");
                sw.WriteLine("Já dobře!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }

        }

    }



}
