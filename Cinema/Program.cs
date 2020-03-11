using System;
using System.Collections.Generic;
using System.Linq;

namespace Grafs
{
    class Program
    {
        static void Main(string[] args)
        {
            Node mainNod = new Node();
            Console.WriteLine("Введите общее время работы кинотеатра");
            int timeLeft = Convert.ToInt32(Console.ReadLine());
            mainNod.Value = timeLeft;

            Console.WriteLine("Введите количество фильмов:");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите название и длительность сеанса №{i + 1} в минутах.");
                string filmName = Console.ReadLine();
                int filmDuration = Convert.ToInt32(Console.ReadLine());

                mainNod.films.Add(new Film(filmName, filmDuration));
            }

            GraphTree graphTree = new GraphTree(mainNod);
            graphTree.CreateShedules();
            graphTree.DisplayAnswer();

            //Console.WriteLine("Могут ли повторяться фильмы?(да/нет)");
            //string answ = Console.ReadLine();
            //bool allowReiteration = false;
            //if (answ == "да")
            //{
            //    allowReiteration = true;
            //}


            //CinemaTimeManager gl = new CinemaTimeManager(new Node(timeLeft, names, duration, "РАСПИСАНИЕ: \n", new List<string>()), allowReiteration);
            //gl.CreateShedules();
            //gl.DisplayAnswer();
        }
    }
}
