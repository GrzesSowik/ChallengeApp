// Zadanie domowe - dzień 5

var numberToCheck = 5677000;

char[] numberToString = numberToCheck.ToString().ToArray();
List<char> digitsInString = new List<char>();

for (var i = 0; i < 10; i++)
{
    digitsInString.Add((char)('0' + i));
}
Console.WriteLine("Wyniki dla liczby: " + numberToCheck);
foreach (var digit in digitsInString)
{
    var instance = 0;
    foreach (var sign in numberToString)
    {
        if (sign == digit)
        {
            instance++;
        }
    }
    Console.WriteLine(digit + " => " + instance);
}