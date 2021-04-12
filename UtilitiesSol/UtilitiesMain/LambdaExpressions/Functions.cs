using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesMain.LambdaExpressions
{



    public class Functions
    {



        public static double F(double a)
        {
            return 3 * a;
        }



        public static double G(double x, double y)
        {
            return 2 * x - y + 0.5;
        }



        public static double H(double a)
        {
            return a + 3;
        }



        public static double D(double x, double y)
        {
            //double valueG = G(x, y);
            //double valueH = H(valueG);
            //return valueH;
            return H(G(x, y));
        }



        public static void TestFunc()
        {
            //double a1 = 100;
            //double v1 = F(a1);

            //double a2 = 500;
            //double v2 = F(a2);

            //Console.WriteLine($"{a1} gramů šunky stojí {v1} CZK.");
            //Console.WriteLine($"{a2} gramů šunky stojí {v2} CZK.");


            // (0; 0; 0,5), (-1; 0; -1,5), (1; 1; 1,5) 
            double x1 = 0;
            double y1 = 0;
            double z1 = G(x1, y1);

            Console.WriteLine($"({x1}; {y1}; {z1})");

            double x2 = -1;
            double y2 = 0;
            double z2 = G(x2, y2);

            double x3 = 1;
            double y3 = 1;
            double z3 = G(x3, y3);

            Console.WriteLine($"({x2}; {y2}; {z2})");
            Console.WriteLine($"({x3}; {y3}; {z3})");

        }



    }



}
