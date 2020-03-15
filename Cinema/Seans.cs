using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Seans
    {
        public string FilmName { get; set; }
        public DateTime FilmStart { get; set; }
        public DateTime FilmEnd { get; set; }

        public Seans(string name, DateTime start, DateTime end)
        {
            FilmName = name;
            FilmStart = start;
            FilmEnd = end;

        }
        public Seans()
        { }

    }
}
