namespace MediaPlayer.Core.Entity.Media
{
    public class Audio : Media
    {
        public Audio(string title) : base(title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"ID: {Id}; Title: {Title}; Type: Audio";
        }
    }
}