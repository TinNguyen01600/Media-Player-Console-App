namespace MediaPlayer.Service.Abstraction
{
    public interface IMediaPlayerService
    {
        public bool CreatePlaylist(string title);
        public bool RemovePlaylist(Guid playlistId);
        public bool AddMediaToPlaylist(Guid mediaId, Guid playlistId);
        public bool RemoveMediaFromPlaylist(Guid mediaId, Guid playlistId);
        public void PlayMedia(Guid mediaId);
        public void PauseMedia(Guid mediaId);
    }
}