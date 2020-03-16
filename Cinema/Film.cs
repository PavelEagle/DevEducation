namespace Grafs
{
    public class Film
    {
        public string FileName { get; set; }
        public int FilmDuration { get; set; }

        public Film(string name, int duration)
        {
            FileName = name;
            FilmDuration = duration;
        }
        public Film () { }
    }
}