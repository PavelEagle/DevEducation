using System;

namespace ProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork1 hw1 = new HomeWork1();
            HomeWork2 hw2 = new HomeWork2();
            HomeWork3 hw3 = new HomeWork3();
            ArrayList arrList = new ArrayList(new int[] { 1, 1, 1, 1, 1, 1, 1 });
            arrList.Add(2);
            int[] newArr = arrList.toArray();
            arrList.PrintArr(newArr);
            //int[] newArr = arrList.RemoveVal(1);
            //arrList.PrintArr(newArr);
            //Console.WriteLine();
            //newArr = arrList.RemoveVal(1);
            //arrList.PrintArr(newArr);
            //Console.WriteLine();
            //newArr = arrList.RemoveVal(1);
            //arrList.PrintArr(newArr);
            //Console.WriteLine();
            //newArr = arrList.RemoveVal(1);
            //arrList.PrintArr(newArr);


            //Console.WriteLine($"{newArr[0]},{newArr[1]}, {newArr[2]}");

            int[] arrOfNumbers = { 11, 23, 54, 68, 93, 35, 79, 55 };

            //Console.WriteLine(hw1.CalcHypotenuse(54,76));

            //Console.WriteLine(hw1.CalcCreditPayments(5000,5,0.15)[0]);

            //Console.WriteLine(hw1.EquationOfLine(1, 1, 2, 2)[1]);

            //Console.WriteLine(hw1.MultiplyAndSumDigitsOfNumber(1230)[0]);

            // Console.WriteLine(hw1.CalcQuadraticQquation(2,8,3)[1]);

            //Console.WriteLine(hw1.CalcExpression(-4,8,6));

            //double[] arr = hw1.SolutionsOfEquation(5,15,2);

            //for (int i=0; i<arr.Length; i++)
            //{
            //    Console.Write(arr[i]+" ");
            //}

            //Console.WriteLine(hw1.CalcQuadraticQquation(1,8,-3)[1]);

            //Console.WriteLine(hw2.Calculator(96, 30, "/"));

            //Console.WriteLine(hw2.SumBetweenMinMax(new int[] { -14, 16, 3, 0, 21, 9 }));

            //Console.WriteLine(hw3.CountOfDividers(7, 77, 9));

            //Console.WriteLine(hw3.TicTacToe(4));

            //Human ant = new Human("Ant");
            //ant.GetInfo();
            //Human vas = new Human(2);
            //vas.GetInfo();
            //Human andr = new Human("Andrej", 33);
            //andr.GetInfo();

            //Human kirill = new Human() { name = "Kir", age = 22 };
            //kirill.GetInfo();



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
