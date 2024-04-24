namespace ChallengeApp.Tests
{
    public class ProgramTests
    {
        [Test]
        public void emploeeInstanceComparison()
        {
            var emploee1 = new EmploeeInMemory("Grześ", "Grzesiowski");
            var emploee2 = new EmploeeInMemory("Adaś", "Adasiowski");

            Assert.AreNotEqual(emploee1.Name + emploee1.Surname, emploee2.Name + emploee2.Surname);
        }
    }
}