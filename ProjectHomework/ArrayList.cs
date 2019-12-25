using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    public class ArrayList
    {
        // + 30%
        private int[] array = { 1, 2, 3, 4, 5 };
        private int realLength = 5;

        private int[] arrayOneElementIncrease(int[] array, double percentIncrease)
        {
            int[] newArray = new int [array.Length + (int)Math.Round(percentIncrease/100 * array.Length)];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }


        //Добавляет элемент
        public int[] Add(int val)
        {
            array = arrayOneElementIncrease(array,30);
            array[realLength] = val;
            realLength++;
            return array;
        }

        // Добавляет элемент на определенную позицию
        public int[] Add(int indx, int val)
        {
            array = arrayOneElementIncrease(array,30);

            for (int i = realLength; i >= indx; i--)
            {
                array[i+1] = array[i];
            }
            array[indx] = val;
            realLength++;

            return array;
        }

        // Заменяет элемент массива
        public int[] Set(int indx, int val)
        {
            if (indx < realLength - 1)
            {
                array[indx] = val;
                return array;
            }
            else
            {
                throw new InvalidCastException("Array index out of bounds exception");
            }  
        }

        //Возвращает элемент по индексу
        public int Get(int indx)
        {
            if (indx < realLength - 1)
            {
                return array[indx];
            }
            else
            {
                throw new InvalidCastException("Array index out of bounds exception");
            }
        }


        //Возвращает размер массива
        public int Size(int[] array)
        {
            return array.Length;
        }


        //Содержит ли массив эелмент
        public bool Contains(int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    return true;
                }
            }
            return false;
        }


        //Добавить массив
        public int[] AddAll(int[] vals)
        {
            int [] newArray = arrayOneElementIncrease(array, 100);
            int numberOfElement = 0;
            for (int i = array.Length; i < array.Length + vals.Length; i++)
            {
                newArray[i] = vals[numberOfElement];
                numberOfElement++;
            }
            array = newArray;
            return array;
        }


        //Добавить массив с определенного индекса
        public void AddAll(int indx, int[] vals)
        {

        }

        //Возвращает индекс первого совпадения
        public int IndexOf(int val)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    return i;
                }
            }
            return -1;
        }

        //Возвращает индексы совпадающих элементов
        public int[] Search(int val)
        {
            int indexCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    indexCount++;
                }
            }
            int[] indexArray = new int[indexCount];
            int indexOfSearch = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (val == array[i])
                {
                    indexArray[indexOfSearch] = i;
                    indexOfSearch++;
                }
            }
            return indexArray;
        }

        //Удаляет элемент по значению
        public int[] RemoveVal(int val)
        {
            int indexOfElement = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                {
                    indexOfElement = i;
                    break;
                }
            }

            if (indexOfElement == -1)
            {
                throw new ArgumentException("Val not found");
            } 
            else
            {
                array[indexOfElement] = 0;
                for (int i = indexOfElement + 1; i < realLength; i++)
                {
                    array[i-1] = array[i];
                }
                array[realLength - 1] = 0;
                realLength--;
                return array;
            }
        }

        //Удаляет элемент по индексу
        public int[] RemoveIndx(int indx)
        {
            if (indx > array.Length)
            {
                throw new ArgumentException("Val not found");
            }
            else
            {
                array[indx] = 0;
                for (int i = indx + 1; i < realLength; i++)
                {
                    array[i-1] = array[i];
                }
                array[realLength-1] = 0;
                realLength--;
                return array;
            }
        }

        //Удаляет все индексы с определенным значением
        public int[] RemoveAll(int val)
        {
            int indexOfElement = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == val)
                {
                    array[i] = 0;
                    indexOfElement = i;
                }
            }

            if (indexOfElement == -1)
            {
                throw new ArgumentException("Val not found");
            }
            else
            {
                int countOfElements = 0;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i] == 0)
                    {
                        int temp = array[i];
                        array[i] = array[i+1];
                        array[i + 1] = temp;
                        countOfElements++;
                    }
                }
                realLength-= countOfElements;
                return array;
            }
        }

        public void PrintArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

    }


}
