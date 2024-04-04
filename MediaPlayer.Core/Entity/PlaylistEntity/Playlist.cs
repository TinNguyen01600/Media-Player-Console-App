using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlayer.Core.Entity.Media;

namespace MediaPlayer.Core.Entity.PlaylistEntity
{
    public class Playlist
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public HashSet<MediaInPlaylist> Medias { get; set; }

        public Playlist(string title)
        {
            Id = Guid.NewGuid();
            Title = title;
            Medias = new HashSet<MediaInPlaylist>();
        }
    }
}