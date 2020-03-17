using Cinema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grafs
{
    public class Node
    {
        // Осталось всего времени
        public int TimeLeft { get; set; }

        // Список фильмов
        public List<Film> Films { get; set; }

        // Список дочерних вершин.
        public List<Node> Children { get; set; }

        public List<Seans> Seanses { get; set; }

        public Node(int timeLeft, List<Film> films, List<Seans> seanses)
        {
            this.TimeLeft = timeLeft;
            this.Films = films;
            Children = new List<Node>();
            Seanses = seanses;
        }
        public Node()
        {
            Films = new List<Film>();
            Children = new List<Node>();
            Seanses = new List<Seans>();
        }
    }
}
