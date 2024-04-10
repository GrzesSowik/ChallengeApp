// Zadanie domowe - dzień 9

namespace ChallengeApp
{
    public class Emploee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Emploee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        private List<float> grades = new List<float>();

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;
            return statistics;
        }
    }
}