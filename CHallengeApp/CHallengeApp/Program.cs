// Zadanie domowe - dzień 4

bool isFemale = true;
var name = "Ewa";
var age = 30;

if (isFemale == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 30 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 30");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Męszczyzna ponieżej 18 lat");
    }
}