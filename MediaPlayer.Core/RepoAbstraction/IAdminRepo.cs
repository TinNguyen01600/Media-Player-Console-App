using MediaPlayer.Core.Entity.Person;

namespace MediaPlayer.Core.RepoAbstraction
{
    public interface IAdminRepo
    {
        public void AddUser(params User[] users);
        public bool RemoveUser(Guid userId);
    }
}