// Zadanie domowe - dzień 15

namespace ChallengeApp
{
    public interface IEmploee
    {
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        Statistics GetStatistics();
    }

}