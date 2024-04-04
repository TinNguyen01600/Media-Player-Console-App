using MediaPlayer.Core.Entity.Media;
using MediaPlayer.Service.Utils;

namespace MediaPlayer.Service.Abstraction
{
    public interface IMediaService
    {
        public Media GetMediaById(Guid mediaId);
        public bool RemoveMedia(Guid mediaId);
        public void AddMedia(MediaType mediaType);
        public void ChangeVolume(Guid mediaId, int vol);
        public void ChangeBrightness(Guid mediaId, int bright);
        public void ChangeSoundEffect(Guid mediaId,int soundEffect);
    }
}