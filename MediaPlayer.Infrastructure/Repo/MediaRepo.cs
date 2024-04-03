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
            throw new NotImplementedException();
        }
        public bool RemoveMedia(Guid mediaId)
        {
            return true;
        }
        public void AddMedia(Media media)
        {
            _mediasList.Add(media);
        }
    }
}