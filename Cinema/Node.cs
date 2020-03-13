using Cinema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grafs
{
    public class Node
    {
        // Осталось всего времени
        public int timeLeft { get; set; }

        // Список фильмов
        public List<Film> films { get; set; }

        // Список дочерних вершин.
        public List<Node> Children { get; set; }

        //Лист для исключения повторений
        public List<string> list = new List<string>();

        public List<Seans> Seanses { get; set; }

        public Node(int timeLeft, List<Film> films, List<Seans> seanses, List<string> list)
        {
            this.timeLeft = timeLeft;
            this.films = films;
            Children = new List<Node>();
            Seanses = seanses;
            this.list = list;
        }
        public Node()
        {
            films = new List<Film>();
            Children = new List<Node>();
            Seanses = new List<Seans>();
        }
    }
}
