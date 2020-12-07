using System;
//using UtilitiesMain.MethodExtraction.Example;
//using UtilitiesMain.MethodExtraction.Exercise;
using UtilitiesMain.DataClasses;

namespace UtilitiesMain
{
    class Program
    {
        static void Main(string[] args)
        {


            //// The code provided will print ‘Hello World’ to the console.
            //// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            ////Console.WriteLine("Hello World!");
            ////Console.ReadKey();

            //// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 


            //// Try the "method extraction" example.
            //PersonService personService = new PersonService();
            //personService.MethodToRefactor();
            //Console.WriteLine();
            //Console.WriteLine();
            //personService.RefactoredMethod();

            //// Merge files.
            //string pathToFileA = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileA.txt";
            //string pathToFileB = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileB.txt";
            //string pathToFileC = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileC.txt";
            //string pathToFileD = @"C:\pfoltyn\MyProjects\Utilities\20201012_hodina\UtilitiesSol\Resources\InputFileD.txt";
            //FileService fileService = new FileService();
            //fileService.MergeFiles(pathToFileA, pathToFileB, pathToFileC, pathToFileD);


            ShowDataClasses();
			
			// Ahoj Olgo!

        }

        static void ShowDataClasses()
        {

            // Persons
            Person pavel = new Person("Pavel", "Novák", new DateTime(1992, 9, 26), true);
            Person jana = new Person("Jana", "Výborná", new DateTime(1987, 2, 4), false);
            Console.WriteLine($"Jméno: {pavel.firstName}, Příjmení: {pavel.lastName}, Datum narození: {pavel.dateOfBirth}, Občan ČR: {pavel.isCitizenCZ}");
            Console.WriteLine($"Jméno: {jana.firstName}, Příjmení: {jana.lastName}, Datum narození: {jana.dateOfBirth}, Občan ČR: {jana.isCitizenCZ}");

            // Publishers
            //Albatros, založeno 1949, IČO: 28377141
            //Academia, založeno 1953, IČO: 60457856
            //Garamond, založeno 1997, IČO: 25126202

            Publisher albatros = new Publisher("Albatros", 1949, 28377141);
            Publisher academia = new Publisher("Academia", 1953, 60457856);
            Publisher garamond = new Publisher("Garamond", 1997, 25126202);

            Console.WriteLine($"Název: {albatros.name}  Založeno: {albatros.since}  IČO: {albatros.ico}  ");
            Console.WriteLine($"Název: {academia.name}  Založeno: {academia.since}  IČO: {academia.ico}  ");
            Console.WriteLine($"Název: {garamond.name}  Založeno: {garamond.since}  IČO: {garamond.ico}  ");



            Console.WriteLine();
            Console.WriteLine();

            // Books
            //Jiří Padevět, nar. 20. července 1966, občan ČR
            Person padevet = new Person("Jiří", "Padevět", new DateTime(1966, 7, 20), true);
            //Sylvain Tesson, nar. 26. dubna 1972, není občan ČR
            Person tesson = new Person("Sylvain", "Tesson", new DateTime(1972, 4, 26), false);
            Person rowlingova = new Person("J. K.", "Rowlingová", new DateTime(1965, 7, 31), false);
            Person macourek = new Person("Miloš", "Macourek", new DateTime(1926, 12, 2), true);


            //Průvodce protektorátní Prahou, 2013, (Jiří Padevět, nar. 20.července 1966, občan ČR), (Academia, zal. 1953, IČO: 60457856) 
            Book pruvodce = new Book();
            pruvodce.title = "Průvodce protektorátní Prahou";
            pruvodce.publishedIn = 2013;
            pruvodce.author = padevet;
            pruvodce.publisher = academia;

            //Sněžný levhart, 2020, (Sylvain Tesson, nar. 26.dubna 1972, není občan ČR), (Garamond, zal. 1997, IČO: 25126202)
            Book levhart = new Book();
            levhart.title = "Sněžný levhart";
            levhart.publishedIn = 2020;
            levhart.author = tesson;
            levhart.publisher = garamond;

            //Ikabog, 2020, (J. K. Rowlingová, nar. 31. července 1965, není občankou ČR), (Albatros, zal. 1949, IČO: 28377141)
            Book ikabog = new Book();
            ikabog.title = "Ikabog";
            ikabog.publishedIn = 2020;
            ikabog.author = rowlingova;
            ikabog.publisher = albatros;

            //Mach a Šebestová v historii, 2009, (Miloš Macourek, nar. 2. prosince 1926, občan ČR), (Albatros, zal. 1949, IČO: 28377141)
            Book machASebestova = new Book();
            machASebestova.title = "Mach a Šebestová v historii";
            machASebestova.publishedIn = 2009;
            machASebestova.author = macourek;
            machASebestova.publisher = albatros;

            DisplayBook(pruvodce);
            //Console.WriteLine();
            DisplayBook(levhart);
            //Console.WriteLine();
            DisplayBook(ikabog);
            //Console.WriteLine();
            DisplayBook(machASebestova);


            Console.WriteLine();
            Console.WriteLine();


            // EBookshop
            EBookshop eBookshop = new EBookshop("https://www.mojeskveleknihy.cz");
            eBookshop.books.Add(pruvodce);
            eBookshop.books.Add(levhart);
            eBookshop.books.Add(ikabog);
            eBookshop.books.Add(machASebestova);
            
            DisplayEBookshop(eBookshop);

            Console.ReadKey(true);
        }


        static void DisplayBook(Book book)
        {
            Console.Write($"Název: {book.title}   ");
            Console.Write($"Vydáno: {book.publishedIn}   ");
            Console.WriteLine("Autor:");
            Console.WriteLine($"Jméno: {book.author.firstName}, Příjmení: {book.author.lastName}, Datum narození: {book.author.dateOfBirth}, Občan ČR: {book.author.isCitizenCZ}");
            Console.WriteLine("Nakladatelství:");
            Console.WriteLine($"Název: {book.publisher.name}  Založeno: {book.publisher.since}  IČO: {book.publisher.ico}  ");

            Console.WriteLine();
        }


        static void DisplayEBookshop(EBookshop eBookshop)
        {
            Console.WriteLine(eBookshop.url);
            Console.WriteLine("Knihy, které nabízíme:");

            //Console.WriteLine(eBookshop.books[0].author.lastName);
            for (int i = 0; i < eBookshop.books.Count; i++)
            {
                DisplayBook(eBookshop.books[i]);
            }

            Console.WriteLine();
        }

    }
}
