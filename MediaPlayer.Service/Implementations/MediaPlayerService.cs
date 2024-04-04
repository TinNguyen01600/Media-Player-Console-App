using MediaPlayer.Core.RepoAbstraction;

namespace MediaPlayer.Service.Implementation
{
    public class MediaPlayerService
    {
        private IMediaPlayerRepo _mediaRepo;
        public MediaPlayerService(IMediaPlayerRepo repo)
        {
            _mediaRepo = repo;
        }
        public bool CreatePlaylist(string title)
        {
            return _mediaRepo.CreatePlaylist(title);
        }
        public bool RemovePlaylist(Guid playlistId)
        {
            return _mediaRepo.RemovePlaylist(playlistId);
        }
        public bool AddMediaToPlaylist(Guid mediaId, Guid playlistId)
        {
            return _mediaRepo.AddMediaToPlaylist(mediaId, playlistId);
        }
        public bool RemoveMediaFromPlaylist(Guid mediaId, Guid playlistId)
        {
            return _mediaRepo.RemoveMediaFromPlaylist(mediaId, playlistId);
        }
        public void PlayMedia(Guid mediaId)
        {
            _mediaRepo.PlayMedia(mediaId);
        }
        public void PauseMedia(Guid mediaId)
        {
            _mediaRepo.PauseMedia(mediaId);
        }
    }
}