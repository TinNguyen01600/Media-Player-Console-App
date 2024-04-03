using MediaPlayer.Core.Entity.Media;
using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Service.Abstraction;
using MediaPlayer.Service.Utils;

namespace MediaPlayer.Service.Implementation
{
    public class MediaService : IMediaService
    {
        private IMediaRepo _mediaRepo;
        public MediaService(IMediaRepo mediaRepo)
        {
            _mediaRepo = mediaRepo;
        }
        public Media GetMediaById(Guid mediaId)
        {
            throw new NotImplementedException();
        }
        public bool RemoveMedia(Guid mediaId)
        {
            return true;
        }
        public void AddMedia(MediaType mediaType)
        {
            var mediaFactory = new MediaFactory();
            var media = mediaFactory.Create(mediaType);
            if (media is not null)  _mediaRepo.AddMedia(media);
        }
    }
}