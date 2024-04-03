using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.RepoAbstraction;

namespace MediaPlayer.Infrastructure.Repo
{
    public class UserRepo : IUserRepo
    {
        private HashSet<User> _usersList;
        public UserRepo()
        {
            
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