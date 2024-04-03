using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Service.Abstraction;

namespace MediaPlayer.Service.Implementation
{
    public class AdminService : IAdminService
    {
        private IAdminRepo _adminRepo;
        public AdminService(IAdminRepo adminRepo)
        {
            _adminRepo = adminRepo;
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