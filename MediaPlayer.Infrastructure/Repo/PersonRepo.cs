using MediaPlayer.Core.Entity.Person;
using MediaPlayer.Infrastructure.Data;

namespace MediaPlayer.Infrastructure.Repo
{
    public class PersonRepo
    {
        private HashSet<Person> _peopleList;
        public PersonRepo(Database dtb)
        {
            _peopleList = dtb._peopleList;
        }
        public Person GetPersonById(Guid personId)
        {
            throw new NotImplementedException();
        }
        public bool RemovPerson(Guid personId)
        {
            return _peopleList.RemoveWhere(p => p.Id == personId) != 0;
        }
        public void AddPerson(Person person)
        {
            _peopleList.Add(person);
        }
    }
}