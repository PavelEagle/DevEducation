using System;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree<int> tree = new AVLTree<int>();

            tree.Add(22);
            tree.Add(1);
            tree.Add(14);
            tree.Add(23);
            tree.Add(10);
            tree.Add(15);
            tree.Add(6);

            tree.Remove(6);


            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }

        }


    }
}
