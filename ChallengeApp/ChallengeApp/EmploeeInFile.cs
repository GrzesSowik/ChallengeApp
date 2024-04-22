namespace ChallengeApp
{
    internal class EmploeeInFile : EmploeeBase
    {
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
            }
            else
            {
                throw new Exception("Invalid Grade value");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            var gradesCount = 0;

            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = "";
                    while ((line =reader.ReadLine())!= null)
                    {
                        var grade = float.Parse(line);
                        statistics.Max = Math.Max(statistics.Max, grade);
                        statistics.Min = Math.Min(statistics.Min, grade);
                        statistics.Average += grade;
                        gradesCount++;
                    }
                }

                statistics.Average /= gradesCount;

                switch (statistics.Average)
                {
                    case var average when average >= 80:
                        statistics.AverageLetter = 'A';
                        break;
                    case var average when average >= 60:
                        statistics.AverageLetter = 'B';
                        break;
                    case var average when average >= 40:
                        statistics.AverageLetter = 'C';
                        break;
                    case var average when average >= 20:
                        statistics.AverageLetter = 'D';
                        break;
                    default:
                        statistics.AverageLetter = 'E';
                        break;
                }
            }
            return statistics;
        }
    }
}