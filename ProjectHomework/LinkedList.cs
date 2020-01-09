using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHomework
{
    class LinkedList
    {

        Node head;

        public class Node
        {
            public int value;
            public Node next;

            public Node(int d)
            {
                value = d;
                next = null;
            }
        }




        //Добавляет элемент
        public void Add(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }


        public void Reverse()
        {

            Node tmp = head, lostLink = null;
            while (tmp.next != null)
            {
                lostLink = tmp.next; 
                tmp.next = tmp.next.next; 
                lostLink.next = head; 
                head = lostLink; 
                
            }
        }









        // Добавляет элемент на определенную позицию
        public void Add(int indx, int val)
        {
        }

        // Заменяет элемент массива
        //public void Set(int indx, int val)
        //{
        //    linkedList.Find(77);
        //}

        


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
        //public LinkedListNode<int> IndexOf(int val)
        //{
        //    //LinkedListNode<int> nodes = null;           
        //    //var matchNode = linkedList.Nodes().FirstOrDefault(n => n.Value.Id == myId);

        //    //return nodes;
        //}

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
            Node tmp = head;
            while (tmp != null)
            {
                Console.Write(tmp.value + " ");
                tmp = tmp.next;
            }
            Console.WriteLine();
        }

        public void ToArray()
        {

        }
    }
}
