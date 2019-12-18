using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    public class HomeWork3
    {
        public int DigitInNumber(int[] arrOfNumbers, int digit)
        {
            int count = 0;
            for (int i = 0; i < arrOfNumbers.Length; i++)
            {
                int temp = arrOfNumbers[i];

                while(temp > 0)
                {
                    if (temp % 10 == digit)
                    {
                        count++;
                    }
                    temp = (temp - temp % 10) / 10;
                }
            }
            return count;
        }

        public string[,] RectangleDrawing(int rectangleLength, int rectangleHeight, string outerFrame, string innerContent)
        {
            string[,] arrOfString = new string [rectangleHeight, rectangleLength];
            
            for (int i = 0; i < rectangleHeight; i++)
            {
                if (i == 0 || i == rectangleHeight - 1)
                {
                    for (int j = 0; j < rectangleLength; j++)
                    {
                        arrOfString [i,j] = outerFrame;
                    }
                }
                else
                {
                    for (int j = 0; j < rectangleLength; j++)
                    {
                        if (j == 0 || j == rectangleLength - 1)
                        {
                            arrOfString [i,j] = outerFrame;
                        }
                        else
                        {
                            arrOfString [i,j] = innerContent;
                        }
                    }
                }  
            }
            return arrOfString;
        }

        public int CountOfDividers(int minValue, int maxValue, int countOfDividers)
        {
            int countOfNumbers = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count >= countOfDividers) 
                {
                    countOfNumbers++;
                }
            }
            return countOfNumbers;
        }

        public string[,] TicTacToe(int fieldSize)
        {
            Random rnd = new Random();
            Methods mtd = new Methods();

            string[,] field = new string[fieldSize, fieldSize];

            //Создание массива из +
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = "+";
                }
            }

        initialize:
            Console.WriteLine("Введите режим: ");
            Console.WriteLine("Игрок против игрока - 1");
            Console.WriteLine("Игрок против ПК - 2 ");
            Console.WriteLine("ПК против ПК - 3");
            string mode = Console.ReadLine();

            if (mode == "1")
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

                    mtd.TicTacToeCheck(field, currentMarker, row, column);

                    markedCellsCount++;
                }

                while (markedCellsCount < 25);

                return field;

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

                    mtd.TicTacToeCheck(field, currentMarker, row, column);

                    markedCellsCount++;
                }

                while (markedCellsCount < 25);

                return field;

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

                    mtd.TicTacToeCheck(field, currentMarker, row, column);

                    markedCellsCount++;
                    System.Threading.Thread.Sleep(1000);

                }

                while (markedCellsCount < 25);

                return field;

            }
            else 
            {
                goto initialize;
            }
        }

        public int[,] DiagonalElementsChange(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int temp = matrix[i, i];
                matrix[i, i] = matrix[i, matrix.GetLength(1) - i - 1];
                matrix[i, matrix.GetLength(1) - i - 1] = temp;
            }
            return matrix;
        }

        public int[] GreaterNumberInCentralCell(int[,] matrix)
        {
            int counter = 0;

            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] > matrix[i - 1, j] && matrix[i, j] > matrix[i + 1, j] && matrix[i, j] > matrix[i, j - 1] && matrix[i, j] > matrix[i, j + 1])
                    {
                        counter++;
                    }
                }
            }
            
            int[] greaterNumbers = new int[counter];
            int counterGreaterNumbers = 0;
            
            for (int i = 1; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] > matrix[i - 1, j] && matrix[i, j] > matrix[i + 1, j] && matrix[i, j] > matrix[i, j - 1] && matrix[i, j] > matrix[i, j + 1])
                    {
                        greaterNumbers[counterGreaterNumbers] = matrix[i,j];
                        counterGreaterNumbers++;
                    }
                }
            }
            
            return greaterNumbers;
        }
    }
}
