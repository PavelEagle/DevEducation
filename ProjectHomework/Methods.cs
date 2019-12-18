using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    class Methods
    {
        public int[] ArrRandomCreating(int massiveSize)
        {
            Random rnd = new Random();
            int[] arr = new int[massiveSize];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }

        public void arrViewer1D(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        
        public int TicTacToeCheck(int[] arr)
        {

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
            return markersCount;
        }
        
    }
}
