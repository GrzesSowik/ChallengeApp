namespace ChallengeApp
{
    public abstract class EmploeeBase : IEmploee
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public EmploeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public abstract void AddGrade(float grade);

        public virtual void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public virtual void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public virtual void AddGrade(char grade)
        {
            grade = char.ToUpper(grade);
            switch (grade)
            {
                case 'A':
                    AddGrade(100);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(60);
                    break;
                case 'D':
                    AddGrade(40);
                    break;
                case 'E':
                    AddGrade(20);
                    break;
                case 'F':
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public virtual void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                if (grade.Length == 1)
                {
                    char character = grade[0];
                    AddGrade(character);
                }
                else
                {
                    throw new Exception("String is not float");
                }
            }
        }

        public abstract Statistics GetStatistics();
    }
}