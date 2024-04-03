using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Infrastructure.Data;

namespace MediaPlayer.Infrastructure.Repo
{
    public class AdminRepo : IAdminRepo
    {
        private HashSet<Admin> _adminsList;
        public AdminRepo(Database dtb)
        {
            _adminsList = dtb._adminsList;
        }
        public void AddAdmin(params Admin[] admins)
        {
            foreach (var i in admins) _adminsList.Add(i);
        }
        public bool RemoveAdmin(Guid adminId)
        {
            return _adminsList.RemoveWhere(a => a.Id == adminId) != 0;
        }
    }
}