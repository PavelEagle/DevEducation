namespace Grafs
{
    public class Film
    {
        public string fileNmae { get; set; }
        public int filmDuration { get; set; }

        public Film(string name, int duration)
        {
            fileNmae = name;
            filmDuration = duration;
        }
    }
}