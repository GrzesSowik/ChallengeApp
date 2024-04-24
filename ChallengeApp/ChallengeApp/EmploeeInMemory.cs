namespace ChallengeApp
{
    public class EmploeeInMemory : EmploeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        public EmploeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        private List<float> grades = new List<float>();

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}