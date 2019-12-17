using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    class Methods
    {
        public static int[] ArrRandomCreating(int massiveSize)
        {
            Random rnd = new Random();
            int[] arr = new int[massiveSize];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }

        public static void arrViewer1D(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
