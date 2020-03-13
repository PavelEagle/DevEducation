using Cinema;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grafs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Film> films = new List<Film>();

            Console.WriteLine("Введите количество залов в кинотеатре:");
            int countOfHall = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество фильмов:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите название и длительность сеанса №{i + 1} в минутах.");
                string filmName = Console.ReadLine();
                int filmDuration = Convert.ToInt32(Console.ReadLine());

                films.Add(new Film(filmName, filmDuration));
            }


            GraphTree graphTree = new GraphTree(new Node(840, films, new List<Seans>(), new List<string>()), countOfHall);
            graphTree.Create();
            graphTree.DisplayTimeTable();
        }
    }
}
