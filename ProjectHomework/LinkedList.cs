using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    class LinkedList
    {

        LinkedList<int> linkedList = new LinkedList<int>();


        //Добавляет элемент
        public void Add(int val)
        {
            linkedList.AddLast(val);
        }

        // Добавляет элемент на определенную позицию
        public void Add(int indx, int val)
        {
        }

        // Заменяет элемент массива
        public void Set(int indx, int val)
        {
            linkedList.Find(77);
        }

        


        //Возвращает элемент по индексу
        public void Get(int indx)
        {
        }


        //Возвращает размер массива
        public int Size(int[] array)
        {
            return array.Length;
        }


        //Содержит ли массив эелмент
        public void Contains(int val)
        {

        }


        //Добавить массив
        public void AddAll(int[] vals)
        {

        }


        //Добавить массив с определенного индекса
        public void AddAll(int indx, int[] vals)
        {

        }

        //Возвращает индекс первого совпадения
        public LinkedListNode<int> IndexOf(int val)
        {
            LinkedListNode<int> nodes = null;           
            var matchNode = linkedList.Nodes().FirstOrDefault(n => n.Value.Id == myId);

            return nodes;
        }

        //Возвращает индексы совпадающих элементов
        public void Search(int val)
        {
           
        }

        //Удаляет элемент по значению
        public void RemoveVal(int val)
        {
   
        }

        //Удаляет элемент по индексу
        public void RemoveIndx(int indx)
        {
    
        }

        //Удаляет все индексы с определенным значением
        public void RemoveAll(int val)
        {

        }

        public void PrintList()
        {
            for (var node = linkedList.First; node != null; node = node.Next)
                Console.Write(node.Value + "\t");
        }

        public void ToArray()
        {

        }
    }
}
