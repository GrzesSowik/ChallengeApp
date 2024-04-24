namespace ChallengeApp
{
    public class EmploeeInFile : EmploeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private const string fileName = "C:\\Users\\grzes\\OneDrive\\Pulpit\\ChallengeApp\\grades.txt";

        public EmploeeInFile(string name, string surname) : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {

                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid Grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = "";
                    while ((line = reader.ReadLine()) != null)
                    {
                        var grade = float.Parse(line);
                        statistics.AddGrade(grade);
                    }
                }
            }
            return statistics;
        }
    }
}