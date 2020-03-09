using System;

namespace ProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double[,] arr = { { 5, 4, -2, 1, 11 }, { 2, -1, 4, 0, 12 }, { 3, 2, 0, 0, 7 }, { 4, 0, 0, 0, 4 } };

            Gauss gs = new Gauss(arr);

            gs.PrintArr();
            gs.SolutionOfGaussEquation();
            gs.printResult();

        }

        int[] arrOfNumbers = { 11, 23, 54, 68, 93, 35, 79, 55 };

        }
    }

    
