using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Core.RepoAbstraction;
using MediaPlayer.Service.Utils;

namespace MediaPlayer.Service.Implementation
{
    public class PersonService
    {
        private IPersonRepo _personRepo;
        public PersonService(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }
        public Person GetPersonById(Guid personId)
        {
            throw new NotImplementedException();
        }
        public bool RemovPerson(Guid personId)
        {
            return _personRepo.RemovPerson(personId);
        }
        public void AddPerson(PersonType personType)
        {
            var personFactory = new PersonFactory();
            var person = personFactory.Create(personType);
            if (person is not null) _personRepo.AddPerson(person);
        }
    }
}