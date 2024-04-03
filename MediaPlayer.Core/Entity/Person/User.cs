namespace MediaPlayer.Core.Entity.Person
{
    public class User : Person
    {
        public User(string name) : base(name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"ID: {Id}; Name: {Name}; Role: User";
        }
    }
}