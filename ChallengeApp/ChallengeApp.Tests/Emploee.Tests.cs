// Zadnie domowe - Dzieñ 7

using CHallengeApp;

namespace ChallengeApp.Tests
{

    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectOnlyPositiveScores_ShouldReturnCorrectResult()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski", 34);
            user.AddScore(5);
            user.AddScore(6);

            var result = user.Result;

            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenEmployeeCollectMorePositiveThanNegativeScores_ShouldReturnCorrectResult()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski", 34);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-1);

            var result = user.Result;

            Assert.AreEqual(10, result);
        }
        [Test]
        public void WhenEmployeeCollectTheSamePositiveAndNegativeScores_ShouldReturnCorrectResult()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski", 34);
            user.AddScore(-3);
            user.AddScore(3);

            var result = user.Result;

            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenEmployeeCollectLessPositiveThanNegativeScores_ShouldReturnCorrectResult()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski", 34);
            user.AddScore(5);
            user.AddScore(-6);
            user.AddScore(-1);

            var result = user.Result;

            Assert.AreEqual(-2, result);
        }
        [Test]
        public void WhenEmployeeCollectOnlyNegativeScores_ShouldReturnCorrectResult()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski", 34);
            user.AddScore(-5);
            user.AddScore(-6);

            var result = user.Result;

            Assert.AreEqual(-11, result);
        }
    }
}