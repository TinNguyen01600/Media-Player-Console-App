namespace MediaPlayer.Core.Entity.Media
{
    public class Video : Media
    {
        public Video(string title) : base(title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"ID: {Id}; Title: {Title}; Type: Video";
        }
    }
}