using System;
using UtilitiesMain.MethodExtraction.Example;
using UtilitiesMain.MethodExtraction.Exercise;

namespace UtilitiesMain
{
    class Program
    {
        static void Main(string[] args)
        {


            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 


            // Try the "method extraction" example.
            PersonService personService = new PersonService();
            personService.MethodToRefactor();
            Console.WriteLine();
            Console.WriteLine();
            personService.RefactoredMethod();

            // Merge files.
            string pathToFileA = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileA.txt";
            string pathToFileB = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileB.txt";
            string pathToFileC = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileC.txt";
            string pathToFileD = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileD.txt";
            FileService fileService = new FileService();
            fileService.MergeFiles(pathToFileA, pathToFileB, pathToFileC, pathToFileD);

            // Ahoj

        }
    }
}
