Console.WriteLine("Willkommen zum Number Guesser.");
Console.WriteLine("Errate die Zahl zwischen 1 und 100.");
Console.WriteLine("Welche Zahl möchtest du eingeben?");
Random random = new Random();
int Zahl = random.Next(1, 101);
int tipp = Convert.ToInt32(Console.ReadLine());
while (tipp != Zahl)
{
    if (tipp < Zahl)
    {
        Console.WriteLine("Höher!");
    }
    else
    {
        Console.WriteLine("Niedriger!");
    }

    Console.WriteLine("Rate nochmal!");
    tipp = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Richtig! Du hast gewonnen!");
Console.ReadKey();