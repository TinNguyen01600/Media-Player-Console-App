using MediaPlayer.Core.Entity.Person;

namespace MediaPlayer.Core.RepoAbstraction
{
    public interface IPersonRepo
    {
        public Person GetPersonById(Guid personId);
        public bool RemovPerson(Guid personId);
        public void AddPerson(Person person);
    }
}