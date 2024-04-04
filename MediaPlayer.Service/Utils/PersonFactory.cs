using MediaPlayer.Core.Entity.Person;

namespace MediaPlayer.Service.Utils
{
    public enum PersonType { Admin, User };
    public class PersonFactory
    {
        public PersonFactory() { }
        public Person? Create(PersonType personType)
        {
            Person? person = null;
            if (personType == PersonType.Admin) person = new User("");
            else if (personType == PersonType.User) person = new Admin("");
            return person;
        }
    }
}