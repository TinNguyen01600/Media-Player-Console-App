using MediaPlayer.Core.Entity.PlaylistEntity;

namespace MediaPlayer.Core.RepoAbstraction
{
    public interface IMediaPlayerRepo
    {
        public Playlist GetPlaylistById(Guid playlistId);
        public bool CreatePlaylist(string title);
        public bool RemovePlaylist(Guid playlistId);
        public bool AddMediaToPlaylist(Guid mediaId, Guid playlistId);
        public bool RemoveMediaFromPlaylist(Guid mediaId, Guid playlistId);
    }
}