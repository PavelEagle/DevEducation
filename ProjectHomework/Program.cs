using System;

namespace ProjectHomework
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double[,] arr = { { 5, 4, -2, 1, 11 }, { 2, -1, 4, 0, 12 }, { 3, 2, 0, 0, 7 }, { 4, 0, 0, 0, 4 } };

            //Gauss gs = new Gauss(arr);

            //gs.PrintArr();
            //gs.SolutionOfGaussEquation();
            //gs.printResult();

            //DoublyLinkedList dl = new DoublyLinkedList();
            //dl.AddFirst(1);
            //dl.AddLast(3);
            //dl.AddLast(5);
            //dl.AddLast(7);
            //dl.AddLast(9);

            //dl.PrintList();
            //Console.WriteLine();
            //dl.Reverse();
            //dl.PrintList();

            LinkedList ll = new LinkedList();
            ll.Add(new LinkedList.Node(1));
            ll.Add(new LinkedList.Node(2));
            ll.Add(new LinkedList.Node(3));
            ll.Add(new LinkedList.Node(4));
            ll.Add(new LinkedList.Node(5));
            ll.PrintList();
            ll.Reverse();
            ll.PrintList();
        }

        int[] arrOfNumbers = { 11, 23, 54, 68, 93, 35, 79, 55 };

        }
    }

    
