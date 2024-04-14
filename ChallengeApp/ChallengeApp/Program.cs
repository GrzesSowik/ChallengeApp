// Zadanie domowe - dzień 15

using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witamy w programie do oceny Pracowników");
        Console.WriteLine("=======================================");
        Console.WriteLine();

        var supervisor = new Supervisor("Grześ", "Sowik");

        while (true)
        {
            Console.WriteLine("Podaj kolejną ocenę Kierownika: ");
            var input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            try
            {
                supervisor.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        var statistics = supervisor.GetStatistics();
        Console.WriteLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();
        Console.WriteLine(supervisor.Name + " " + supervisor.Surname + " - Ocena: " + statistics.AverageLetter);
        Console.WriteLine();
        Console.WriteLine("Wyniki szczegółowe:");
        Console.WriteLine($"Średnia: {statistics.Average:N2}");
        Console.WriteLine($"Min: {statistics.Min}");
        Console.WriteLine($"Max: {statistics.Max}");
    }
}