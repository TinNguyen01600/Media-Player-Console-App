using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.RepoAbstraction;

namespace MediaPlayer.Infrastructure.Repo
{
    public class AdminRepo : IAdminRepo
    {
        private HashSet<Admin> _adminsList;
        public AdminRepo()
        {
            
        }
        public void AddUser(params User[] users)
        {

        }
        public bool RemoveUser(Guid userId)
        {
            return true;
        }
    }
}