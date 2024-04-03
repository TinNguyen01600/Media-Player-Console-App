using MediaPlayer.Core.Entity.Media;

namespace MediaPlayer.Service.Utils
{
    public enum MediaType { Audio, Video };
    public class MediaFactory
    {
        public MediaFactory() { }
        public Media? Create(MediaType mediaType)
        {
            Media? media = null;
            if (mediaType == MediaType.Audio) media = new Audio("");
            else if (mediaType == MediaType.Video) media = new Video("");
            return media;
        }
    }
}