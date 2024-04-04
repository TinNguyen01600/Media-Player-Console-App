using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Infrastructure.Data;
using MediaPlayer.Infrastructure.Repo;
using MediaPlayer.Service.Implementation;

internal class Program
{
    private static void Main(string[] args)
    {
        var database = Database.Instance;
        var mediaRepo = new MediaRepo(database);
        var peopleRepo = new PersonRepo(database);
        var mediaPlayerRepo = new MediaPlayerRepo(new User("user1"));
        var mediaService = new MediaService(mediaRepo);
    }
}