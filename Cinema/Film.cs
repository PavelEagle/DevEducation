namespace Grafs
{
    public class Film
    {
        public string fileName { get; set; }
        public int filmDuration { get; set; }

        public Film(string name, int duration)
        {
            fileName = name;
            filmDuration = duration;
        }
        public Film () { }
    }
}