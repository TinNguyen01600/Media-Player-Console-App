using MediaPlayer.Core.Entity.Media;
using MediaPlayer.Service.Utils;

namespace MediaPlayer.Service.Abstraction
{
    public interface IMediaService
    {
        public Media GetMediaById(Guid mediaId);
        public bool RemoveMedia(Guid mediaId);
        public void AddMedia(MediaType mediaType);
    }
}