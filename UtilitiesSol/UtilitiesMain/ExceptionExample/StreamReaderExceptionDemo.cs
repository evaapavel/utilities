using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace UtilitiesMain.ExceptionExample
{
    public class StreamReaderExceptionDemo
    {

        public void ProcessFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"C:\MyDir\MyFile.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (ArgumentNullException e1)
            {
                Console.WriteLine("Given path is null.");
            }
            catch (ArgumentException e2)
            {
                Console.WriteLine("Given path is an empty string.");
            }
            catch (FileNotFoundException e3)
            {
                Console.WriteLine("The file cannot be found.");
            }
            catch (DirectoryNotFoundException e4)
            {
                Console.WriteLine("The specified path is invalid (unmapped drive).");
            }
            catch (IOException e5)
            {
                Console.WriteLine("An input/output error occurs.");
            }
            catch (Exception e6)
            {
                Console.WriteLine($"Unknown error: {e6.Message}");
            }

        }

    }
}
