namespace Projeto001.Entities
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + LastName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Person))
            {
                return false;
            }

            Person other = obj as Person;
            return FirstName.Equals(other.FirstName) && LastName.Equals(other.LastName);
        }
    }
}
