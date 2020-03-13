using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema
{
    public class Seans
    {
        public string filmName { get; set; }
        public DateTime filmStart { get; set; }

        public DateTime filmEnd { get; set; }

        public Seans(string name, DateTime start, DateTime end)
        {
            filmName = name;
            filmStart = start;
            filmEnd = end;

        }
        public Seans()
        { }

    }
}
