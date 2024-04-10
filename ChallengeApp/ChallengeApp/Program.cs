// Zadanie domowe - dzień 9

using ChallengeApp;

var emploee = new Emploee("Grześ", "Sowik");
emploee.AddGrade(2);
emploee.AddGrade(5);
emploee.AddGrade(7);
var statistics = emploee.GetStatistics();
Console.WriteLine(emploee.Name + " " + emploee.Surname + " Grady:");
Console.WriteLine($"Agerage: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");