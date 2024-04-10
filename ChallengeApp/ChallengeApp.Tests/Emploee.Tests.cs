// Zadnie domowe - dzieñ 12

namespace ChallengeApp.Tests
{
    public class EmploeeTests
    {
        [Test]
        public void emploeeGradeNumberInRangeAverageAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade(100);
            user.AddGrade(50);
            user.AddGrade(0);

            var result = user.GetStatistics();

            Assert.AreEqual(50, result.Average);
            Assert.AreEqual(0, result.Min);
            Assert.AreEqual(100, result.Max);
        }

        public void emploeeGradeDoubleInRangeAverageAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade(100);
            user.AddGrade(50);
            user.AddGrade(0);

            var result = user.GetStatistics();

            Assert.AreEqual(50, result.Average);
            Assert.AreEqual(0, result.Min);
            Assert.AreEqual(100, result.Max);
        }

        [Test]
        public void emploeeGradeNumberOutOfRangeMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade(-1);
            user.AddGrade(101);

            var result = user.GetStatistics();

            Assert.AreNotEqual(-1, result.Min);
            Assert.AreNotEqual(101, result.Max);
        }

        [Test]
        public void emploeeGradeExpectedUperCharacterAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade('A');
            user.AddGrade('B');
            user.AddGrade('C');
            user.AddGrade('D');
            user.AddGrade('E');

            var result = user.GetStatistics();

            Assert.AreEqual(60, result.Average);
            Assert.AreEqual(20, result.Min);
            Assert.AreEqual(100, result.Max);
        }

        [Test]
        public void emploeeGradeUnxpectedUperCharacterAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade('F');

            var result = user.GetStatistics();

            Assert.AreNotEqual(0, result.Average);
            Assert.AreNotEqual(0, result.Min);
            Assert.AreNotEqual(0, result.Max);
        }

        [Test]
        public void emploeeGradeExpectedLowerCharacterAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade('a');
            user.AddGrade('b');
            user.AddGrade('c');
            user.AddGrade('d');
            user.AddGrade('e');

            var result = user.GetStatistics();

            Assert.AreEqual(60, result.Average);
            Assert.AreEqual(20, result.Min);
            Assert.AreEqual(100, result.Max);
        }

        [Test]
        public void emploeeGradeUnxpectedLowerCharacterAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade('f');

            var result = user.GetStatistics();

            Assert.AreNotEqual(0, result.Average);
            Assert.AreNotEqual(0, result.Min);
            Assert.AreNotEqual(0, result.Max);
        }

        [Test]
        public void emploeeGradeExpectedLowerSignAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade("a");
            user.AddGrade("b");
            user.AddGrade("c");
            user.AddGrade("d");
            user.AddGrade("e");

            var result = user.GetStatistics();

            Assert.AreEqual(60, result.Average);
            Assert.AreEqual(20, result.Min);
            Assert.AreEqual(100, result.Max);
        }

        [Test]
        public void emploeeGradeUnxpectedLowerSignAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade("f");

            var result = user.GetStatistics();

            Assert.AreNotEqual(0, result.Average);
            Assert.AreNotEqual(0, result.Min);
            Assert.AreNotEqual(0, result.Max);
        }

        [Test]
        public void emploeeGradeUnxpectedStringAverageMinMax()
        {
            var user = new Emploee("Grzeœ", "Grzesiowski");
            user.AddGrade("f");

            var result = user.GetStatistics();

            Assert.AreNotEqual(0, result.Average);
            Assert.AreNotEqual(0, result.Min);
            Assert.AreNotEqual(0, result.Max);
        }
    }
}