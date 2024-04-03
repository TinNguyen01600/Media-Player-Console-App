using MediaPlayer.Core.Entity.Media;

namespace MediaPlayer.Core.RepoAbstraction
{
    public interface IMediaRepo
    {
        public Media GetMediaById(Guid mediaId);
        public bool RemoveMedia(Guid mediaId);
        public void AddMedia(Media media);
    }
}