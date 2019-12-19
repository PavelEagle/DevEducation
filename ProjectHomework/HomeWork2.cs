using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    public class HomeWork2
    {
        public int NumberReverse(int number)
        {
            string stringNumber = number.ToString();
            char[] numberReverse = stringNumber.ToCharArray();
            int reversedNumber = 0;

            for (int i = 0; i < numberReverse.Length / 2; i++)
            {
                char temp = numberReverse[i];
                numberReverse[i] = numberReverse[numberReverse.Length - 1 - i];
                numberReverse[numberReverse.Length - 1 - i] = temp;
            }

            stringNumber = new String(numberReverse);
            reversedNumber = Convert.ToInt32(stringNumber);

            return reversedNumber;

        }

        public double Calculator(int number1, int number2, string operation)
        {
            if (operation == "+") return number1 + number2;
            else if (operation == "-") return number1 - number2;
            else if (operation == "*") return number1 * number2;
            else return (double)number1 / number2;
        }

        public double PrecentOfPositiveNumbers(int countOfNumber)
        {
            Random rnd = new Random();
            int counterPositive = 0;

            for (int i = 0; i < countOfNumber; i++)
            {
                int temp = rnd.Next(-100, 100);
                if (temp > 0)
                {
                    counterPositive += 1;
                }
            }

            return counterPositive * 100 / countOfNumber;
        }

        public void TestYourLuck(int number)
        {
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("Угадайте число от 0 до 100");
                int temp = Convert.ToInt32(Console.ReadLine());

                if (temp < number && temp >= 0)
                {
                    Console.WriteLine("Загаданное число больше");
                    counter += 1;
                    continue;
                }
                else if (temp > number && temp <= 100)
                {
                    Console.WriteLine("Загаданное число меньше");
                    counter += 1;
                    continue;
                }
                else if (temp == number)
                {
                    Console.WriteLine("Бинго!");
                    return;
                }
                else
                {
                    Console.WriteLine("Введите число от 0 о 100");
                    continue;
                }
            }

            if (counter == 10)
                Console.WriteLine("Nope! Загаданное число: " + number);
        }

        public int[] FibonacciNumbers(int lastFibNumber)
        {
            int fib0 = 0, fib1 = 1;
            int[] result = new int[lastFibNumber];

            for (int i = 0; i < lastFibNumber; i++)
            {
                int temp = fib0;
                fib0 = fib1;
                fib1 += temp;
                result[i] = fib1;
            }
            return result;
        }

        public int MaxElemInArr(int[] arrOfNumbers)
        {
            
            int max = int.MinValue;

            for (int j = 0; j < arrOfNumbers.Length; j++)
            {
                if (arrOfNumbers[j] > max)
                {
                    max = arrOfNumbers[j];
                }
            }

            return max;
        }

        public int[] ArrReverse(int[] arrOfNumbers) { 

            for (int i = arrOfNumbers.Length/2-1; i >= 0; i--)
            {
                int temp = arrOfNumbers[i];
                arrOfNumbers[i] = arrOfNumbers[arrOfNumbers.Length - 1 - i];
                arrOfNumbers[arrOfNumbers.Length - 1 - i] = temp;
            }
            return arrOfNumbers;

        }

        public int[] HalfArrReverse(int[] arrOfNumbers)
        {

            double midOfArr = Math.Ceiling((double)arrOfNumbers.Length / 2);


            for (int i = 0; arrOfNumbers.Length % 2 == 0 ? i < midOfArr : i < midOfArr - 1; i++)
            {
                int temp = arrOfNumbers[i];
                arrOfNumbers[i] = arrOfNumbers[i + (int)midOfArr];
                arrOfNumbers[i + (int)midOfArr] = temp;
            }

            return arrOfNumbers;
        }

        public int[] NumbersLessAverage(int[] arrOfNumbers)
        {
            int sum = 0, countOfPositiveNumbers = 0;

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                sum += arrOfNumbers[i];
            }

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
               
                if ((double)sum / arrOfNumbers.Length > arrOfNumbers[i])
                {
                    countOfPositiveNumbers++;
                }
            }

            int[] arrOfPositiveNumbers = new int[countOfPositiveNumbers];
            countOfPositiveNumbers = 0;

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if ((double)sum / arrOfNumbers.Length > arrOfNumbers[i])
                {
                    arrOfPositiveNumbers[countOfPositiveNumbers] = arrOfNumbers[i];
                    countOfPositiveNumbers++;
                }
            }
            return arrOfPositiveNumbers;
        }

        public int SumBetweenMinMax(int[] arrOfNumbers)
        {
            int min = int.MaxValue, max = int.MinValue, sum = 0, iMin = 0, iMax = 0;

            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                if (arrOfNumbers[i] > max)
                {
                    max = arrOfNumbers[i];
                    iMax = i;

                }
                if (arrOfNumbers[i] < min)
                {
                    min = arrOfNumbers[i];
                    iMin = i;
                }
            }

            if (iMin > iMax)
            {
                int temp = iMin;
                iMin = iMax;
                iMax = temp;
            }

            for (int i = iMin+1; i < iMax; i++)
            {
                sum += arrOfNumbers[i];
            }

            return sum;
        }
    }
}
