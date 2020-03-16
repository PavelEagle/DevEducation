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
            int countOfHall = 0, countOfFilms = 0;
            List<Film> films = new List<Film>();
            while (countOfHall == 0)
            {
                Console.WriteLine("Введите количество залов в кинотеатре:");
                while (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    countOfHall = result;
                    break;
                }
            }


            while (countOfFilms == 0)
            {
                Console.WriteLine("Введите количество фильмов:");
                while (Int32.TryParse(Console.ReadLine(), out int result))
                {
                    countOfFilms = result;
                    break;
                }
            }

            
            for (int i = 0; i < countOfFilms; i++)
            {
                int filmDuration = 0;
                string filmName="";
                while (filmDuration == 0)
                {
                    Console.WriteLine($"Введите название и длительность сеанса №{i + 1} в минутах.");
                    filmName = Console.ReadLine();
                    while (Int32.TryParse(Console.ReadLine(), out int result))
                    {
                        filmDuration = result;
                        break;
                    }
                }

                films.Add(new Film(filmName, filmDuration));
            }


            GraphTree graphTree = new GraphTree(new Node(840, films, new List<Seans>(), new List<string>()), countOfHall);
            graphTree.Create();
            graphTree.DisplayTimeTable();
        }
    }
}
