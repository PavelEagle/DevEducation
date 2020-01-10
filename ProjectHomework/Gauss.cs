using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    public class Gauss
    {
        double[,] coefficients;
        double[] result;

        public Gauss()
        {
            Random rnd = new Random();
            coefficients = new double[4, 5];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4-i; j++)
                {
                    coefficients[i, j] = rnd.Next(1, 10);
                }
                coefficients[i, 4] = rnd.Next(1, 10);
            }
            result = new double[coefficients.GetLength(0)];
        }

        public Gauss(double[,] arr)
        {
            coefficients = arr;
            result = new double[coefficients.GetLength(0)];
        }

        
        public void ChangingDiagonalOfOne()
        {
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                int count = 0;
                for (int c = 0; c < coefficients.GetLength(1)-1; c++)
                {
                    if(coefficients[i,c] != 0)
                    {
                        count++;
                    }
                }
                double temp = coefficients[i, count - 1];
                for (int j = 0; j < coefficients.GetLength(1); j++)
                {
                    coefficients[i, j] = Math.Round(coefficients[i, j] / temp,2);
                }
            }
        }

        public void CalculateX()
        {
            double[] result = new double[coefficients.GetLength(1)];

            for (int k = 0; k < coefficients.GetLength(0); k++)
            {
                for (int i = 0; i < coefficients.GetLength(0) - 1 - k; i++)
                {
                    double temp = coefficients[i, k];
                    for (int j = 0; j < coefficients.GetLength(1); j++)
                    {
                        coefficients[i, j] = Math.Round(coefficients[i, j] - coefficients[coefficients.GetLength(0) - 1 - k, j] * temp,2);
                    }
                }
            }
        }

        private void Result()
        {
            int length = coefficients.GetLength(0) - 1;
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                result[i] = coefficients[length, coefficients.GetLength(1) - 1];
                length--;
            }
        }

        public void SolutionOfGaussEquation()
        {
            ChangingDiagonalOfOne();
            CalculateX();
            Console.WriteLine();
            PrintArr();
            Console.WriteLine();
            Result();
        }

        public void PrintArr()
        {
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                for (int j = 0; j < coefficients.GetLength(1); j++)
                {
                    Console.Write($" {coefficients[i,j]} ");
                }
                Console.WriteLine();
            }

        }

        public void printResult()
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"x{i+1} = {result[i]}");
            }
        }

    }
}
