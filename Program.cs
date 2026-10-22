Console.WriteLine("Willkommen zum Number Guesser.");
Console.WriteLine("Zwischen welchen Zahlen willst du raten?");
Console.WriteLine("Gib die kleinste Zahl ein:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Gib die grösste Zahl ein:");
int max = Convert.ToInt32(Console.ReadLine());
while (min >= max)
{
    Console.WriteLine("Die grösste Zahl muss grösser sein!");
    Console.WriteLine("Gib die grösste Zahl erneut ein:");
    max = Convert.ToInt32(Console.ReadLine());
}
Random random = new Random();
int Zahl = random.Next(min, max + 1);
Console.WriteLine("Errate die Zahl zwischen " + min + " und " + max + ".");
Console.WriteLine("Welche Zahl möchtest du eingeben?");
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
