// Zadanie domowe - dzień 6

using CHallengeApp;

Emploee emploee1 = new Emploee("Jaś", "Jasialski", 36);
Emploee emploee2 = new Emploee("Krzyś", "Krzysialski", 43);
Emploee emploee3 = new Emploee("Kasia", "Kasialska", 27);

emploee1.AddScore(3);
emploee1.AddScore(2);
emploee1.AddScore(4);

emploee2.AddScore(1);
emploee2.AddScore(4);
emploee2.AddScore(1);

emploee3.AddScore(3);
emploee3.AddScore(4);
emploee3.AddScore(5);

List<Emploee> emploees = new List<Emploee>()
    { emploee1, emploee2, emploee3 };

int maxResult = -1;
Emploee emploeeWithMaxResult = null;

foreach (var emploee in emploees)
{
    if (emploee.Result > maxResult)
    {
        maxResult = emploee.Result;
        emploeeWithMaxResult = emploee;
    }
}
Console.WriteLine(emploeeWithMaxResult.Name + " " + emploeeWithMaxResult.Surname + ", lat" + emploeeWithMaxResult.Age);
Console.WriteLine("Suma ocen: " + maxResult);