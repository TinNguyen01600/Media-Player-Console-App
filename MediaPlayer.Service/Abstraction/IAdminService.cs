using MediaPlayer.Core.Entity.Person;

namespace MediaPlayer.Service.Abstraction
{
    public interface IAdminService
    {
        public void AddUser(params User[] users);
        public bool RemoveUser(Guid userId);
    }
}