using static ChallengeApp.EmploeeBase;

namespace ChallengeApp
{
    public interface IEmploee
    {
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();
    }
}