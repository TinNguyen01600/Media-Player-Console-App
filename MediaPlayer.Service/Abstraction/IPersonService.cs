using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Service.Utils;

namespace MediaPlayer.Service.Abstraction
{
    public interface IPersonService
    {
        public Person GetPersonById(Guid personId);
        public bool RemovPerson(Guid personId);
        public void AddPerson(PersonType personType);
    }
}