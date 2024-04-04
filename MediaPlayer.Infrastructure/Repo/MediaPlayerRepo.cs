using MediaPlayer.Core.Entity.Media;
using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.Entity.PlaylistEntity;
using MediaPlayer.Infrastructure.Data;

namespace MediaPlayer.Infrastructure.Repo
{
    public class MediaPlayerRepo
    {
        private HashSet<MediaInPlaylist> _mediasList;
        private User _user;
        public MediaPlayerRepo(User user)
        {
            _mediasList = new HashSet<MediaInPlaylist>();
            _user = user;
        }
        public Playlist GetPlaylistById(Guid playlistId)
        {
            throw new NotImplementedException();
        }
        public bool CreatePlaylist(string title)
        {
            Playlist newPlaylist = new(title);
            _user._playlistsList.Add(newPlaylist);
            return true;
        }
        public bool RemovePlaylist(Guid playlistId)
        {
            try
            {
                Playlist? found = _user._playlistsList.FirstOrDefault(c => c.Id == playlistId);
                if (found is null)
                {
                    return false;
                }
                _user._playlistsList.RemoveWhere(c => c.Id == playlistId);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error removing playlist. {e}");
            }
        }
        public bool AddMediaToPlaylist(Guid mediaId, Guid playlistId)
        {
            try
            {
                Playlist? foundPlaylist = _user._playlistsList.FirstOrDefault(c => c.Id == playlistId);
                MediaInPlaylist? foundMedia = _mediasList.FirstOrDefault(c => c.Id == mediaId);
                if (foundMedia is null || foundPlaylist is null) return false;
                foundPlaylist.Medias.Add(foundMedia);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error adding media to playlist. {e}");
            }
        }
        public bool RemoveMediaFromPlaylist(Guid mediaId, Guid playlistId)
        {
            try
            {
                Playlist? foundPlaylist = _user._playlistsList.FirstOrDefault(c => c.Id == playlistId);
                MediaInPlaylist? foundMedia = _mediasList.FirstOrDefault(c => c.Id == mediaId);
                if (foundMedia is null || foundPlaylist is null) return false;
                foundPlaylist.Medias.Remove(foundMedia);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error removing media to playlist. {e}");
            }
        }
    }
}