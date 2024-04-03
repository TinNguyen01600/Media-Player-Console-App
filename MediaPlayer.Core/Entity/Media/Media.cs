namespace MediaPlayer.Core.Entity.Media
{
    public abstract class Media
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public abstract new string ToString();
        protected Media(string name)
        {
            Id = Guid.NewGuid();
            Title = name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title);
        }
        public override bool Equals(object? obj)
        {
            var media = obj as Media;
            return
                media is not null &&
                media.Id == Id &&
                media.Title == Title;
        }
        public static bool operator ==(Media left, Media right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Media left, Media right)
        {
            return !left.Equals(right);
        }
    }
}