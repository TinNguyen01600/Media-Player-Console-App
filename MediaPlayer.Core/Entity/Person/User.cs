using MediaPlayer.Core.Entity.PlaylistEntity;

namespace MediaPlayer.Core.Entity.Person
{
    public class User : Person
    {
        public HashSet<Playlist> _playlistsList;
        public User(string name) : base(name)
        {
            Name = name;
            _playlistsList = new HashSet<Playlist>();
        }
        public override string ToString()
        {
            return $"ID: {Id}; Name: {Name}; Role: User";
        }
    }
}