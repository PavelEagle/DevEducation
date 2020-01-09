using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    public class Gauss
    {
        double[,] coefficients;

        public Gauss()
        {
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    coefficients[i, j] = rnd.Next(1, 10);
                }
            }
        }

        public Gauss(double[,] arr)
        {
            coefficients = arr;
        }

        public void One()
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
                    coefficients[i, j] = coefficients[i, j] / temp;
                }
            }
        }

        private double[] Result()
        {
            double[] result = new double[coefficients.GetLength(0)];
            int length = coefficients.GetLength(0) - 1;
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                result[i] = coefficients[length,coefficients.GetLength(1)-1];
                length--;
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($" {result[i]} ");
            }

            return result;
        }

        public void Calculate()
        {
            double[] result = new double[coefficients.GetLength(1)];

            for (int k = 0; k < coefficients.GetLength(0); k++)
            {
                for (int i = 0; i < coefficients.GetLength(0) - 1 - k; i++)
                {
                    double temp = coefficients[i, k];
                    for (int j = 0; j < coefficients.GetLength(1); j++)
                    {
                        coefficients[i, j] = coefficients[i, j] - coefficients[coefficients.GetLength(0) - 1 - k, j] * temp;
                    }
                }
            }   
        }


        public void Test()
        {
            One();
            Calculate();
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

    }
}
