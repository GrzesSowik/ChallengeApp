// Zadnie domowe - dzień 8

using CHallengeApp;

namespace ChallengeApp.Tests
{

    public class TypeTests
    {
        [Test]
        public void IntegerTest()
        {
            int number1 = 2;
            int number2 = 2;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void floatTest()
        {
            float number1 = 13.48f;
            float number2 = 13.48f;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void StringTest()
        {
            string name1 = "Grześ";
            string name2 = "Grześ";

            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ReferenceTest()
        {
            var emploee1 = new Emploee("Grześ", "Grzesiowski", 34);
            var emploee2 = new Emploee("Grześ", "Grzesiowski", 34);

            Assert.AreNotEqual(emploee1, emploee2);
            Assert.AreEqual(emploee1.Name, emploee2.Name);
        }
        private Emploee GetUser(string name, string surname, int age)
        {
            return new Emploee(name, surname, age);
        }
    }
}