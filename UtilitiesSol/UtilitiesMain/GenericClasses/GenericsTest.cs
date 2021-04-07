using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.GenericClasses
{
    public class GenericsTest
    {


        public static void Go()
        {
            //Monuple<int> m1 = new Monuple<int>(4);
            //Monuple<int> m2 = new Monuple<int>(7);
            //Console.WriteLine($"m1: {m1.Value}");
            //Console.WriteLine($"m2: {m2.Value}");

            //Monuple<string> ms1 = new Monuple<string>("Slunce");
            //Monuple<string> ms2 = new Monuple<string>("Země");
            //Console.WriteLine($"ms1: {ms1.Value}");
            //Console.WriteLine($"ms2: {ms2.Value}");

            //// Jméno tělesa a jeho průměr v km
            //Couple<string, double> b1 = new Couple<string, double>("Slunce", 1392684.0);
            //Couple<string, double> b2 = new Couple<string, double>("Země", 12756.3);

            //Console.WriteLine($"b1: {b1.FirstValue} {b1.SecondValue}");
            //Console.WriteLine($"b2: {b2.FirstValue} {b2.SecondValue}");

            //Person john = new Person("John", 25);
            //Person martha = new Person("Martha", 21);
            //Couple<Person, Person> c = new Couple<Person, Person>(john, martha);

            //Console.WriteLine($"Married: {c.FirstValue.Name} {c.SecondValue.Name}");

            //bool[] isPrime = new bool[8];
            //isPrime[0] = false;
            //isPrime[1] = true;
            //isPrime[2] = true;
            //isPrime[3] = true;
            //isPrime[4] = false;
            //isPrime[5] = true;
            //isPrime[6] = false;
            //isPrime[7] = true;

            //for (int i = 0; i < isPrime.Length; i++)
            //{
            //    //Console.WriteLine($"Flag #{i}:  {isPrime[i]}");
            //    Console.WriteLine($"{i} is prime?  {isPrime[i]}");
            //}

            Dictionary<string, bool> tasks = new Dictionary<string, bool>();
            string taskName = "Maths excercise";
            bool isCompleted = false;
            tasks.Add(taskName, isCompleted);
            taskName = "Wash up";
            isCompleted = true;
            tasks.Add(taskName, isCompleted);
            foreach (string myTask in tasks.Keys)
            {
                Console.WriteLine($"Task {myTask} completed? { (tasks[myTask] ? "Yes" : "No") }");
            }

        }


    }
}
