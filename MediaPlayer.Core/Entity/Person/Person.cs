namespace MediaPlayer.Core.Entity.Person
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public abstract new string ToString();
        protected Person(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public override bool Equals(object? obj)
        {
            var person = obj as Person;
            return
                person is not null &&
                person.Id == Id &&
                person.Name == Name;
        }
        public static bool operator ==(Person left, Person right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Person left, Person right)
        {
            return !left.Equals(right);
        }
    }
}