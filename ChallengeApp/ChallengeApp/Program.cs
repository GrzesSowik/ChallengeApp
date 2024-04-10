// Zadanie domowe - dzień 12

using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("=======================================");
Console.WriteLine();

var emploee = new Emploee("Grześ", "Sowik");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input.ToLower() == "q")
    {
        break;
    }
    emploee.AddGrade(input);
}

var statistics = emploee.GetStatistics();
Console.WriteLine();
Console.WriteLine("---------------------------------------");
Console.WriteLine();
Console.WriteLine(emploee.Name + " " + emploee.Surname + " - Ocena: " + statistics.AverageLetter);
Console.WriteLine();
Console.WriteLine("Wyniki szczegółowe:");
Console.WriteLine($"Średnia: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");