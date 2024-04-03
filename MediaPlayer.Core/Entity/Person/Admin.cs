namespace MediaPlayer.Core.Entity.Person
{
    public class Admin : Person
    {
        public Admin(string name) : base(name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"ID: {Id}; Name: {Name}; Role: Admin";
        }
    }
}