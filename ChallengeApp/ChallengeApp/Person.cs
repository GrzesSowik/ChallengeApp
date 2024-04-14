// Zadanie domowe - dzień 15

namespace ChallengeApp
{
    public abstract class Person : IPerson
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}