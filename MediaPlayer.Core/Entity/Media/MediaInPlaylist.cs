using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaPlayer.Core.Entity.Media
{
    public class MediaInPlaylist : Media
    {
        public MediaInPlaylist(string title) : base(title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"ID: {Id}; Title: {Title}; Type: Media in Playlist";
        }
    }
}