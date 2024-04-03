using MediaPlayer.Core.Entity.Media;
using MediaPlayer.Core.Entity.Person;

namespace MediaPlayer.Infrastructure.Data
{
    public class Database
    {
        public HashSet<User> _usersList;
        public HashSet<Admin> _adminsList;
        public HashSet<Media> _mediasList;
        private static Database? _instance;
        private Database()
        {
            _adminsList = [
                new Admin("admin1"),
                new Admin("admin2"),
            ];

            _usersList = [
                new User("user1"),
                new User("user2"),
                new User("user3"),
            ];
            _mediasList = [
                new Video("video1"),
                new Video("video1"),
                new Video("video1"),
                new Audio("audio1"),
                new Audio("audio2"),
            ];
        }
        public static Database GetDatabase()
        {
            if (_instance is null)
            {
                _instance = new Database();
            }
            return _instance;
        }

    }
}