using MediaPlayer.Core.Entity.Person;

namespace MediaPlayer.Core.RepoAbstraction
{
    public interface IAdminRepo
    {
        public void AddAdmin(params Admin[] admins);
        public bool RemoveAdmin(Guid adminId);
    }
}