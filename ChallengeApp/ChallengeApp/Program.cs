// Zadanie domowe - dzień 11


using ChallengeApp;

var emploee = new Emploee("Grześ", "Sowik");
emploee.AddGrade("2");
emploee.AddGrade(5);
emploee.AddGrade(0.5);
var statistics1 = emploee.GetStatisticsForEach();
var statistics2 = emploee.GetStatisticsDoWhile();
var statistics3 = emploee.GetStatisticsWhile();
var statistics4 = emploee.GetStatisticsFor();
Console.WriteLine(emploee.Name + " " + emploee.Surname + " Grady:");
Console.WriteLine();
Console.WriteLine("Loop 'for each'");
Console.WriteLine($"Agerage: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine();
Console.WriteLine("Loop 'do while'");
Console.WriteLine($"Agerage: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine();
Console.WriteLine("Loop 'while'");
Console.WriteLine($"Agerage: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine();
Console.WriteLine("Loop 'for'");
Console.WriteLine($"Agerage: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");