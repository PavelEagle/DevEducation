using System;
using System.Collections.Generic;
using System.Text;

namespace Grafs
{
    public class Node
    {
        // Осталось всего времени
        public int Value { get; set; }

        // Список фильмов
        public List<Film> films { get; set; }


        // Список дочерних вершин.
        public List<Node> Children { get; set; }

        //Лист для исключения повторений
        public List<string> list = new List<string>();

        //строка для добавления названия фильма в ответ
        public string variantOfShedule { get; }

        public Node(int value, List<Film> films, string variantOfShedule, List<string> list)
        {
            Value = value;
            this.films = films;
            this.variantOfShedule = variantOfShedule;
            Children = new List<Node>();
            this.list = list;
        }
        public Node()
        {
            films = new List<Film>();
            Children = new List<Node>();
        }
    }
}
