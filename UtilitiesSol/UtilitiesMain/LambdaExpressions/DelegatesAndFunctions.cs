using System;
using System.Collections.Generic;



namespace UtilitiesMain.LambdaExpressions
{



    public static class DelegatesAndFunctions
    {



        public delegate double OneParameterDelegate(double param1);

        public delegate double TwoParameterDelegate(double param1, double param2);

        public delegate TwoParameterDelegate CombineDelegatesDelegate(TwoParameterDelegate twoParameterDelegate, OneParameterDelegate oneParameterDelegate);



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
            return H(G(x, y));
        }



        public static TwoParameterDelegate Combine(TwoParameterDelegate fn2args, OneParameterDelegate fn1arg)
        {
            return (x, y) => fn1arg(fn2args(x, y));
        }



        public static void TestFunctions()
        {

            // (0; 0; 0,5), (-1; 0; -1,5), (1; 1; 1,5) 
            double x1 = 0;
            double y1 = 0;
            double z1 = G(x1, y1);

            double x2 = -1;
            double y2 = 0;
            double z2 = G(x2, y2);

            double x3 = 1;
            double y3 = 1;
            double z3 = G(x3, y3);

            Console.WriteLine($"({x1}; {y1}; {z1})");
            Console.WriteLine($"({x2}; {y2}; {z2})");
            Console.WriteLine($"({x3}; {y3}; {z3})");

            Console.WriteLine();

            // (0; 0; 0,5), (-1; 0; -1,5), (1; 1; 1,5) 
            double x4 = 0;
            double y4 = 0;
            double z4 = D(x4, y4);

            double x5 = -1;
            double y5 = 0;
            double z5 = D(x5, y5);

            double x6 = 1;
            double y6 = 1;
            double z6 = D(x6, y6);

            Console.WriteLine($"({x4}; {y4}; {z4})");
            Console.WriteLine($"({x5}; {y5}; {z5})");
            Console.WriteLine($"({x6}; {y6}; {z6})");

            Console.WriteLine();

        }



        public static void DisplayArrays(double[] x, double[] y, double[] z)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"({x[i]}; {y[i]}; {z[i]})");
            }
            Console.WriteLine();
        }



        public static void CalculateZValuesUsingG(double[] x, double[] y, double[] z)
        {
            for (int i = 0; i < x.Length; i++)
            {
                z[i] = G(x[i], y[i]);
            }
        }



        public static void CalculateZValuesUsingD(double[] x, double[] y, double[] z)
        {
            for (int i = 0; i < x.Length; i++)
            {
                z[i] = D(x[i], y[i]);
            }
        }



        public static void CalculateZValuesUsingDelegate(double[] x, double[] y, double[] z, TwoParameterDelegate fn)
        {
            for (int i = 0; i < x.Length; i++)
            {
                z[i] = fn(x[i], y[i]);
            }
        }



        public static void CalculateZValuesUsingDelegateOnDelegates(double[] x, double[] y, double[] z, TwoParameterDelegate fn2, OneParameterDelegate fn1, CombineDelegatesDelegate comb)
        {
            for (int i = 0; i < x.Length; i++)
            {
                z[i] = (comb(fn2, fn1))(x[i], y[i]);
            }
        }



        public static void TestDelegates()
        {

            double[] x = new double[3];
            double[] y = new double[3];
            double[] z = new double[3];

            x[0] = 0;
            y[0] = 0;

            x[1] = -1;
            y[1] = 0;

            x[2] = 1;
            y[2] = 1;

            Console.WriteLine("Arrays just created. No z values yet.");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingG(x, y, z);

            Console.WriteLine("After CalculateZValuesUsingG...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingD(x, y, z);

            Console.WriteLine("After CalculateZValuesUsingD...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingDelegate(x, y, z, G);

            Console.WriteLine("After CalculateZValuesUsingDelegate (G)...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingDelegate(x, y, z, D);

            Console.WriteLine("After CalculateZValuesUsingDelegate (D)...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingDelegate(x, y, z, (px, py) => 2 * px - py + 0.5 );

            Console.WriteLine("After CalculateZValuesUsingDelegate (G-like lambda)...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingDelegate(x, y, z, ((px, py) => (new OneParameterDelegate(ha => ha + 3)) ( (new TwoParameterDelegate((gx, gy) => 2 * gx - gy + 0.5)) (px, py) )) );

            Console.WriteLine("After CalculateZValuesUsingDelegate (D-like lambda)...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingDelegateOnDelegates(x, y, z, (gx, gy) => 2 * gx - gy + 0.5, ha => ha + 3, (fn2, fn1) => (cx, cy) => fn1(fn2(cx, cy)));

            Console.WriteLine("After CalculateZValuesUsingDelegateOnDelegates (D=H(G)-like lambda)...");
            DisplayArrays(x, y, z);

            CalculateZValuesUsingDelegate(x, y, z, (px, py) => px * px + py * py);

            Console.WriteLine("After CalculateZValuesUsingDelegate (custom lambda)...");
            DisplayArrays(x, y, z);

        }



        public static void TestLambdas()
        {
            TwoParameterDelegate p = (x, y) => -0.5 * x + 3 * y - 1.3;
            Console.WriteLine("p = (x, y) => -0.5 * x + 3 * y - 1.3");
            Console.WriteLine($"p(0; 0) = {p(0, 0)}");
            Console.WriteLine($"p(1; 1) = {p(1, 1)}");
            Console.WriteLine($"p(2; 2) = {p(2, 2)}");

            // Does not work.
            //double result = ((x, y) => 2 * x + 3 * y)(0.4, 0.5);
            // Does not work.
            //double result = ((double x, double y) => 2 * x + 3 * y)(0.4, 0.5);
            // Works ok.
            //double result = (new TwoParameterDelegate((x, y) => 2 * x + 3 * y))(0.4, 0.5);
            // Works ok.
            double result = ((TwoParameterDelegate)((x, y) => 2 * x + 3 * y))(0.4, 0.5);
            // Works ok.
            //double result = (new Func<double, double, double>((x, y) => 2 * x + 3 * y))(0.4, 0.5);
            // Works ok.
            //double result = ((Func<double, double, double>)((x, y) => 2 * x + 3 * y))(0.4, 0.5);
        }



    }



}
