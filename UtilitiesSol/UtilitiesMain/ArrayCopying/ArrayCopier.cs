using System;



namespace UtilitiesMain.ArrayCopying
{



    public class ArrayCopier
    {



        public static void Go()
        {
            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 10 - i;
            }

            int[] arr2 = new int[arr1.Length];

            ArrayCopier arrayCopier = new ArrayCopier();
            arrayCopier.Copy(arr1, arr2);

            Console.WriteLine("Array #1");
            foreach (int value in arr1)
            {
                Console.WriteLine(value);
            }


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Array #2");
            foreach (int value in arr2)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey(true);
        }



        public void Copy(int[] sourceArr, int[] destArray)
        {
            //Console.WriteLine(sourceArr[0]);
            //destArray[0] = 10;
            //destArray[0] = sourceArr[0];
            for (int i = 0; i < sourceArr.Length; i++)
            {
                destArray[i] = sourceArr[i];
            }
        }



    }



}
