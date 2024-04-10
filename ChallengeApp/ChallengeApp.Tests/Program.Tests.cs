// Zadanie domowe - dzień 9

namespace ChallengeApp.Tests
{
    public class ProgramTests
    {
        [Test]
        public void emploeeInstanceComparison()
        {
            var emploee1 = new Emploee("Grześ", "Grzesiowski");
            var emploee2 = new Emploee("Adaś", "Adasiowski");

            Assert.AreNotEqual(emploee1.Name + emploee1.Surname, emploee2.Name + emploee2.Surname);
        }
    }
}