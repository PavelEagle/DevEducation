﻿using System;

namespace ProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
           HomeWork1 hw1 = new HomeWork1();
            //double[] credit = hw1.CalcCreditPayments(1000, 2, 0.1);
            HomeWork3 hw3 = new HomeWork3();
            int[] arrOfNumbers = { 11, 23, 54, 68, 93, 35, 79, 55 };

            Console.WriteLine(hw3.TicTacToe(5));

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
