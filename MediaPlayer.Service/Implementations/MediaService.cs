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
            return _mediaRepo.GetMediaById(mediaId);
        }
        public bool RemoveMedia(Guid mediaId)
        {
            return _mediaRepo.RemoveMedia(mediaId);
        }
        public void AddMedia(MediaType mediaType)
        {
            var mediaFactory = new MediaFactory();
            var media = mediaFactory.Create(mediaType);
            if (media is not null) _mediaRepo.AddMedia(media);
        }
        public void ChangeVolume(Guid mediaId, int vol)
        {
            _mediaRepo.ChangeVolume(mediaId, vol);
        }
        public void ChangeBrightness(Guid mediaId, int bright)
        {
            _mediaRepo.ChangeBrightness(mediaId, bright);
        }
        public void ChangeSoundEffect(Guid mediaId, int soundEffect)
        {
            _mediaRepo.ChangeSoundEffect(mediaId, soundEffect);
        }
    }
}