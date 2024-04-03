using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Service.Abstraction;

namespace MediaPlayer.Service.Implementation
{
    public class UserService : IUserService
    {
        private IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateNewPlaytrack()
        {
            return true;
        }
        public void AddMediasToPlayTrack()
        {

        }
    }
}