using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    class HomeWork3
    {
        static int DigitInNumber(int countOfNumbers, char digit)
        {
            int count = 0;
            Random rnd = new Random();

            for (int i = 0; i < countOfNumbers; i++)
            {
                string temp = rnd.Next(10, 100).ToString();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == digit)
                    {
                        count++;
                    }
                }
            }

            return count;

        }

        static void RectangleDrawing(int rectangleLength, int rectangleHeight, string outerFrame, string innerContent)
        {

            for (int i = 0; i < rectangleHeight; i++)
            {
                if (i == 0 || i == rectangleHeight - 1)
                {
                    for (int j = 0; j < rectangleLength; j++)
                    {
                        Console.Write("{0,2} ", outerFrame);
                    }
                }
                else
                {
                    for (int j = 0; j < rectangleLength; j++)
                    {
                        if (j == 0 || j == rectangleLength - 1)
                        {
                            Console.Write("{0,2} ", outerFrame);
                        }
                        else
                        {
                            Console.Write("{0,2} ", innerContent);
                        }
                    }
                }
            }

        }

        static void CountOfDividers(int minValue, int maxValue, int countOfDividers)
        {
            for (int i = minValue; i <= maxValue; i++)
            {
                string dividers = "";
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        dividers += $"{j} ";
                    }
                }
                if (count >= countOfDividers)
                {
                    Console.WriteLine($"{i} ({count}) : {dividers}");

                }

            }

        }

        static void TicTacToe(int fieldSize)
        {
            Random rnd = new Random();

            string[,] field = new string[fieldSize, fieldSize];


            //Создание массива из +
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = "+";
                    Console.Write(field[i, j] + " ");
                }
            }

        initialize:
            Console.WriteLine("Введите режим: ");
            Console.WriteLine("Игрок против игрока - 1");
            Console.WriteLine("Игрок против ПК - 2 ");
            Console.WriteLine("ПК против ПК - 3");
            string mode = Console.ReadLine();

            if (mode != "1" && mode != "2" && mode != "3")
            {
                Console.Write("Введите цифру от 1 до 3");
                goto initialize;
            }
            else if (mode == "1")
            {
                int markedCellsCount = 0;

                do
                {
                    Console.WriteLine("Введите номер строки: ");
                    int row, column;
                    try
                    {
                        row = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Неверное значение строки");
                        continue;
                    }

                    Console.WriteLine("Введите номер столбца: ");
                    try
                    {
                        column = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Неверное значение столбца");
                        continue;
                    }


                    if (field[row, column] != "+")
                    {
                        Console.WriteLine("Клетка занята!");
                        continue;
                    }

                    string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                    field[row, column] = currentMarker;



                    for (int i = 0; i < field.GetLength(0); i++)
                    {
                        for (int j = 0; j < field.GetLength(1); j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    int markersCount = 0;

                    if (row - 1 >= 0 && field[row - 1, column] == currentMarker)
                    {
                        markersCount = 2;

                        if (row - 2 >= 0 && field[row - 2, column] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row + 1 < 5 && field[row + 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row - 1 >= 0 && column + 1 < 5 && field[row - 1, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row - 2 >= 0 && column + 2 < 5 && field[row - 2, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row + 1 < 5 && column - 1 >= 0 && field[row + 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (column + 1 >= 5 && field[row, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (column + 2 >= 5 && field[row, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (column - 1 >= 0 && field[row, column - 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 < 5 && column + 1 < 5 && field[row + 1, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 < 5 && column + 2 < 5 && field[row + 2, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && column - 1 >= 0 && field[row - 1, column - 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 >= 5 && field[row + 1, column] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 >= 5 && field[row + 2, column] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && field[row - 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 < 5 && column - 1 >= 0 && field[row + 1, column - 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 < 5 && column - 2 >= 0 && field[row + 2, column - 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && column + 1 >= 0 && field[row - 1, column + 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }



                    markedCellsCount++;
                }

                while (markedCellsCount < 25);

                Console.WriteLine();

            }

            else if (mode == "2")
            {
                int markedCellsCount = 0, row = 0, column = 0;

                do
                {
                    if (markedCellsCount % 2 == 0)
                    {
                        Console.WriteLine("Введите номер строки: ");
                        try
                        {
                            row = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Неверное значение строки");
                            continue;
                        }

                        Console.WriteLine("Введите номер столбца: ");
                        try
                        {
                            column = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Неверное значение столбца");
                            continue;
                        }

                        if (field[row, column] != "+")
                        {
                            Console.WriteLine("Клетка занята!");
                            continue;
                        }
                    }

                    else if (markedCellsCount % 2 == 1)
                    {
                        row = rnd.Next(0, fieldSize - 1);
                        column = rnd.Next(0, fieldSize - 1);

                        if (field[row, column] != "-")
                        {
                            continue;
                        }
                    }


                    string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                    field[row, column] = currentMarker;


                    for (int i = 0; i < field.GetLength(0); i++)
                    {
                        for (int j = 0; j < field.GetLength(1); j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    int markersCount = 0;

                    if (row - 1 >= 0 && field[row - 1, column] == currentMarker)
                    {
                        markersCount = 2;

                        if (row - 2 >= 0 && field[row - 2, column] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row + 1 < 5 && field[row + 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row - 1 >= 0 && column + 1 < 5 && field[row - 1, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row - 2 >= 0 && column + 2 < 5 && field[row - 2, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row + 1 < 5 && column - 1 >= 0 && field[row + 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (column + 1 >= 5 && field[row, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (column + 2 >= 5 && field[row, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (column - 1 >= 0 && field[row, column - 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 < 5 && column + 1 < 5 && field[row + 1, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 < 5 && column + 2 < 5 && field[row + 2, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && column - 1 >= 0 && field[row - 1, column - 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 >= 5 && field[row + 1, column] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 >= 5 && field[row + 2, column] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && field[row - 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 < 5 && column - 1 >= 0 && field[row + 1, column - 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 < 5 && column - 2 >= 0 && field[row + 2, column - 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && column + 1 >= 0 && field[row - 1, column + 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }



                    markedCellsCount++;
                }

                while (markedCellsCount < 25);

                Console.WriteLine();

            }

            else if (mode == "3")
            {
                int markedCellsCount = 0;

                do
                {
                    int row = rnd.Next(0, fieldSize - 1);
                    int column = rnd.Next(0, fieldSize - 1);

                    if (field[row, column] != "+")
                    {
                        Console.WriteLine("Клетка занята!");
                        continue;
                    }

                    string currentMarker = markedCellsCount % 2 == 0 ? "X" : "0";
                    field[row, column] = currentMarker;

                    for (int i = 0; i < field.GetLength(0); i++)
                    {
                        for (int j = 0; j < field.GetLength(1); j++)
                        {
                            Console.Write(field[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    int markersCount = 0;

                    if (row - 1 >= 0 && field[row - 1, column] == currentMarker)
                    {
                        markersCount = 2;

                        if (row - 2 >= 0 && field[row - 2, column] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row + 1 < 5 && field[row + 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row - 1 >= 0 && column + 1 < 5 && field[row - 1, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row - 2 >= 0 && column + 2 < 5 && field[row - 2, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row + 1 < 5 && column - 1 >= 0 && field[row + 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (column + 1 >= 5 && field[row, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (column + 2 >= 5 && field[row, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (column - 1 >= 0 && field[row, column - 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 < 5 && column + 1 < 5 && field[row + 1, column + 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 < 5 && column + 2 < 5 && field[row + 2, column + 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && column - 1 >= 0 && field[row - 1, column - 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 >= 5 && field[row + 1, column] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 >= 5 && field[row + 2, column] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && field[row - 1, column] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    if (row + 1 < 5 && column - 1 >= 0 && field[row + 1, column - 1] == currentMarker)
                    {
                        markersCount = 2;

                        if (row + 2 < 5 && column - 2 >= 0 && field[row + 2, column - 2] == currentMarker)
                        {
                            markersCount = 3;
                        }
                        else if (row - 1 >= 0 && column + 1 >= 0 && field[row - 1, column + 1] == currentMarker)
                        {
                            markersCount = 3;
                        }

                    }

                    markedCellsCount++;
                    System.Threading.Thread.Sleep(1000);

                }

                while (markedCellsCount < 25);

                Console.WriteLine();

            }
        }





        static void DiagonalElementsChange()
        {
            Random rnd = new Random();

            int[,] matrix = new int[10, 10];

            Console.WriteLine("Исходный массив: ");

            //Вывходим массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = j;
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, i];
                matrix[i, i] = matrix[i, matrix.GetLength(1) - i - 1];
                matrix[i, matrix.GetLength(1) - i - 1] = temp;
            }

            Console.WriteLine("Измененный массив: ");
            //Вывходим массив
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }


        }

        static void GreaterNumberInCentralCell()
        {
            Random rnd = new Random();

            int[,] matrix = new int[6, 6];
            int counter = 0;

            // Создание рандомного массива
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-20, 20);
                    Console.Write("{0,3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }


            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] > matrix[i - 1, j] && matrix[i, j] > matrix[i + 1, j] && matrix[i, j] > matrix[i, j - 1] && matrix[i, j] > matrix[i, j + 1])
                    {
                        counter++;
                        Console.WriteLine(" Строка: " + i + " Столбец: " + j + " Число : " + matrix[i, j]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Всего совпадний: " + counter);
        }
    }
}
