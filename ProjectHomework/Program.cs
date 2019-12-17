using System;

namespace ProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
           HomeWork1 hw1 = new HomeWork1();
            //double[] credit = hw1.CalcCreditPayments(1000, 2, 0.1);
            HomeWork2 hw2 = new HomeWork2();
            int[] arrOfNumbers = { 7, 1, 2, 6, -4, 3 };
            Console.WriteLine(hw2.SumBetweenMinMax(arrOfNumbers));
            double a = 0.1;
            int x = 1, y = 1, z = 1;
            x = true ? ++y : ++z;
            Console.WriteLine(x +" "+ y +" "+ z);
        }
    }

    //int result = 0;
    //Console.WriteLine("Введите первое число:");
    //            try
    //            {
    //                number1 = Convert.ToInt32(Console.ReadLine());
    //            }
    //            catch
    //            {
    //                Console.WriteLine("Неверно задано значение первого числа");
    //                continue;
    //            }

    //            Console.WriteLine("Введите второе число:");
    //            try
    //            {
    //                number2 = Convert.ToInt32(Console.ReadLine());
    //            }
    //            catch
    //            {
    //                Console.WriteLine("Неверно задано значение второго числа");
    //                continue;
    //            }

    //            Console.WriteLine("Введите операцию: ");
    //            Console.WriteLine(" '-'- разность: ");
    //            Console.WriteLine("'+' - сумма: ");
    //            Console.WriteLine("'*' - умножение: ");
    //            Console.WriteLine("'/' - деление: ");
    //            Console.WriteLine("'0' - выход: ");
}
