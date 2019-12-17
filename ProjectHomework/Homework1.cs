using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
     public class HomeWork1
        {
        public double[] CalcCreditPayments(int amount, int years, double percent)
        {
            double paymentPerMouth, totalAmount;

            paymentPerMouth = (amount * percent * Math.Pow((1 + percent), years)) / (12 * (Math.Pow((1 + percent), years) - 1));
            totalAmount = paymentPerMouth * 12 * years;

            double[] result = { paymentPerMouth, totalAmount };

            return result;
        }

        public double[] CalcHypotenuse(int a, int b)
        {

            double c;

            c = Math.Sqrt(a * a + b * b);
            double[] result = { a, b, c };

            return result;


        }

        public int[] EquationOfLine(int x1, int y1, int x2, int y2)
        {
            // preX * x + preY * y + pre = 0

            int preX, preY, pre;

            preY = x2 - x1;
            preX = y1 - y2;
            pre = x1 * y2 - x2 * y1;

            int[] result = { preX, preY, pre};

            return result;

        }

        public double[] CalcQuadraticQquation(int a, int b, int c)
        {
            // a*x^2 + b*x + c = 0

            double d, x1, x2;
            double[] result = { 0, 0 };

            d = b * b - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                result[0] = x1;
                result[1] = x2;
            }

            else if (d == 0)
            {
                x1 = -b / (2 * a);
                result[0] = x1;
            }

            return result;

        }

        public int CalcExpression(int a, int b, int c)
        {
            // max(a+b+c,a*b*c) + 3

            int result;

            result = a * b * c > a + b + c ? a * b * c + 3 : a + b + c + 3;

            return result;
        }



        public int[] Division(int divisor, int divident)
        {
            int division, reminder;

            division = divisor / divident;
            reminder = divisor % divident;

            if (divident == 0)
            {
                division = 0;
                reminder = 0;
            }

            int[] result = { division, reminder };

            return result;
        }


        public int FindCoordinateQuarter(int x, int y)
        {
            int quarter = 0;
            
            if (x > 0)
            {
                if (y > 0)
                {
                    quarter = 1;
                }
                else
                {
                    quarter = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    quarter = 2;
                }
                else
                {
                    quarter = 3;
                }
            }

            return quarter;
        }

        public bool PointInsideOutsideCircle(int x, int y, int radius)
        {
            double rXY;

            rXY = Math.Sqrt(x * x + y * y);

            if (rXY <= radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalcFactorial(int factorialEndNumber)
        {
            int factorial = 1;

            for (int i = 1; i <= factorialEndNumber; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
        public double[] SolutionsOfEquation(int min, int max, int step)
        {
            // y = -0.23*x^2 +x

            int amountOfNumber=(max-min)/step , count = 0;

            double[] arrOfEquationSolutions = new double[amountOfNumber+1];


            for (int i = min; i <= max; i += step)
            {
                arrOfEquationSolutions[count] = -0.23 * i * i + i;
                count++;
            }

            return arrOfEquationSolutions;
        }

        public int[] MultiplyAndSumDigitsOfNumber(int number)
        {
            int sum, multiply;

            sum = 0;
            multiply = 1;

            while (number > 0)
            {
                int temp = number % 10;
                sum += temp;
                multiply *= temp;
                number /= 10;
            }

            int[] result = { sum, multiply };

            return result;

        }


        public bool ProveTheEquation(int number)
        {
            // 1+2+...+n = n(n+1)/2 ?

            int sum;

            sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            if (sum == number * (number + 1) / 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
