using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Infrastructure.Data;

namespace MediaPlayer.Infrastructure.Repo
{
    public class UserRepo : IUserRepo
    {
        private HashSet<User> _usersList;
        public UserRepo(Database dtb)
        {
            _usersList = dtb._usersList;
        }
        public void AddUser(params User[] users)
        {
            foreach (var i in users) _usersList.Add(i);
        }
        public bool RemoveUser(Guid userId)
        {
            return _usersList.RemoveWhere(a => a.Id == userId) != 0;
        }
    }
}