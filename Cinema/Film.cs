namespace Grafs
{
    public class Film
    {
        public string FileName { get; set; }
        public int FilmDuration { get; set; }
        public bool IsMeet { get; set; }

        public Film(string name, int duration)
        {
            FileName = name;
            FilmDuration = duration;
            IsMeet = false;
        }
        public Film () { }
    }
}