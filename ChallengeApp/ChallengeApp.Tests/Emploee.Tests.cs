// Zadnie domowe - dzieñ 9

namespace ChallengeApp.Tests
{
    public class EmploeeTests
    {
        [Test]
        public void emploeeGradePositiveAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade(10);
            user.AddGrade(20);
            user.AddGrade(60);

            var result = user.GetStatistics();

            Assert.AreEqual(30, result.Average);
            Assert.AreEqual(10, result.Min);
            Assert.AreEqual(60, result.Max);
        }
        [Test]
        public void emploeeGradeMixedAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade(-10);
            user.AddGrade(20);
            user.AddGrade(50);

            var result = user.GetStatistics();

            Assert.AreEqual(20, result.Average);
            Assert.AreEqual(-10, result.Min);
            Assert.AreEqual(50, result.Max);
        }
        [Test]
        public void emploeeGradeNegativeAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade(-10);
            user.AddGrade(-20);
            user.AddGrade(-60);

            var result = user.GetStatistics();

            Assert.AreEqual(-30, result.Average);
            Assert.AreEqual(-60, result.Min);
            Assert.AreEqual(-10, result.Max);
        }
    }
}