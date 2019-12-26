using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    public class ArrayList
    {

        private int[] array;
        private int realLength;

        public ArrayList()
        {
            array = new int[10];
            realLength = 0;
        }

        public ArrayList(int[] array)
        {
            this.array = array;
            realLength = array.Length;
        }
        private int[] arrayOneElementIncrease(int[] array)
        {
            int[] newArray = new int [array.Length*3/2 + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        private int[] arrayOneElementReduce(int[] array)
        {
            int[] newArray = new int[2*(array.Length-1)/3];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        private int[] arrayIncrease(int[] array, int valsLength)
        {
            int[] newArray = new int[array.Length + valsLength*3/2 + 1 ];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        

        //Добавляет элемент
        public void Add(int val)
        {
            if (array.Length == realLength)
            {
                array = arrayOneElementIncrease(array);
            }
            array[realLength] = val;
            realLength++;
        }

        // Добавляет элемент на определенную позицию
        public void Add(int indx, int val)
        {
            if (array.Length == realLength)
            {
                array = arrayOneElementIncrease(array);
            }

            for (int i = realLength; i >= indx; i--)
            {
                array[i+1] = array[i];
            }
            array[indx] = val;
            realLength++;
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
        public void AddAll(int[] vals)
        {
           // if (realLength + vals.Length >= array.Length)
            int[] newArray = arrayIncrease(array, vals.Length);
            int numberOfElement = 0;
            for (int i = realLength; i < realLength + vals.Length; i++)
            {
                newArray[i] = vals[numberOfElement];
                numberOfElement++;
            }
            array = newArray;
            realLength += vals.Length;
        }


        //Добавить массив с определенного индекса
        public int[] AddAll(int indx, int[] vals)
        {
            int[] newArray = arrayIncrease(array, vals.Length);
            int numberOfElement = 0;

            for (int i = indx; i < vals.Length + indx; i++)
            {
                newArray[i+indx+1] = newArray[i];
            }

            for (int i = indx; i < vals.Length + indx ; i++)
            {
                newArray[i] = vals[numberOfElement];
                numberOfElement++;
            }
            array = newArray;
            realLength += vals.Length;
            return array;
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
            if (array.Length - realLength == Math.Round(0.5 * array.Length)-1)
            {
                array = arrayOneElementReduce(array);
            }

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
                for (int i = indexOfElement + 1; i < realLength-1; i++)
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

        public int[] toArray()
        {
            int[] newArray = new int[realLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

    }


}
