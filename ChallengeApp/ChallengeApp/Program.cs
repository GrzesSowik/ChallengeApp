using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witamy w programie do oceny Pracowników");
        Console.WriteLine("=======================================");
        Console.WriteLine();

        var emploee = new EmploeeInFile("Grześ", "Sowik");

        while (true)
        {
            Console.WriteLine("Podaj kolejną ocenę Pracownika: ");
            var input = Console.ReadLine();
            if (input.Equals("q",StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            try
            {
                emploee.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
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
    }
}