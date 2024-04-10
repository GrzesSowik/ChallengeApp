// Zadanie domowe - dzień 6

namespace CHallengeApp
{
    public class Emploee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public Emploee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        private List<int> score = new List<int>();

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            score.Add(number);
        }
    }
}