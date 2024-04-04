using MediaPlayer.Core.Entity.Media;
using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Infrastructure.Data;

namespace MediaPlayer.Infrastructure.Repo
{
    public class MediaRepo : IMediaRepo
    {
        private HashSet<Media> _mediasList;
        public MediaRepo(Database dtb)
        {
            _mediasList = dtb._mediasList;
        }
        public Media GetMediaById(Guid mediaId)
        {
            try
            {
                Media? found = _mediasList.FirstOrDefault(m => m.Id == mediaId);
                if (found is null) throw new Exception($"Cannot found media file with Id {mediaId}.");
                return found;
            }
            catch (Exception e)
            {
                throw new Exception($"Error getting media file by Id. {e}");
            }
        }
        public bool RemoveMedia(Guid mediaId)
        {
            try
            {
                Media? found = _mediasList.FirstOrDefault(m => m.Id == mediaId);
                if (found is null) throw new Exception($"Cannot found media file with Id {mediaId}.");
                _mediasList.Remove(found);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception($"Error removing media file by Id. {e}");
            }
        }
        public void AddMedia(Media media)
        {
            try
            {
                _mediasList.Add(media);
            }
            catch (Exception e)
            {
                throw new Exception($"Error adding media file. {e}");
            }
        }
        public void ChangeVolume(Guid mediaId, int vol)
        {
            try
            {
                Media? found = _mediasList.FirstOrDefault(m => m.Id == mediaId);
                if (found is null) throw new Exception($"Cannot found media file with Id {mediaId}.");
                found.Volume = vol;
            }
            catch (Exception e)
            {
                throw new Exception($"Error changing volume of media file. {e}");
            }
        }
        public void ChangeBrightness(Guid mediaId, int bright)
        {
            try
            {
                Media? found = _mediasList.FirstOrDefault(m => m.Id == mediaId);
                if (found is null) throw new Exception($"Cannot found media file with Id {mediaId}.");
                found.Brightness = bright;
            }
            catch (Exception e)
            {
                throw new Exception($"Error changing brightness of media file. {e}");
            }
        }
        public void ChangeSoundEffect(Guid mediaId, int soundEffect)
        {
            try
            {
                Media? found = _mediasList.FirstOrDefault(m => m.Id == mediaId);
                if (found is null) throw new Exception($"Cannot found media file with Id {mediaId}.");
                found.SoundEffect = soundEffect;
            }
            catch (Exception e)
            {
                throw new Exception($"Error changing sound effect of media file. {e}");
            }
        }
    }
}