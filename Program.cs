using System;

Console.WriteLine("Willkommen zu deinem persönlichen Taschengeldrechner!");
string[] häufigkeiten = { "täglich", "wöchentlich", "monatlich", "jährlich" };
int[] tage = { 1, 7, 30, 365 };
string[] zeiträume = { "pro Tag", "pro Woche", "pro Monat", "pro Jahr" };
double[] beträge = new double[4];

string[] kategorien = { "Essen", "Games", "Kleidung", "Freizeit" };
double[] ausgabenProKategorie = new double[4];
int index = -1;
while (index == -1)
{
    Console.WriteLine("Wie oft bekommst du Taschengeld? (täglich, wöchentlich, monatlich, jährlich)");
    string eingabe = Console.ReadLine().ToLower();
    index = Array.IndexOf(häufigkeiten, eingabe);

    if (index == -1)
    {
        Console.WriteLine("Diese Häufigkeit gibt es nicht.");
    }
}
Console.WriteLine("Wie viel Taschengeld bekommst du?");
double betrag = Convert.ToDouble(Console.ReadLine());
beträge[index] = betrag;
Console.WriteLine("Du bekommst " + beträge[index] + " Franken " + häufigkeiten[index] + ".");
double proTag = betrag / tage[index];
Console.WriteLine();
Console.WriteLine("Das entspricht ungefähr:");
for (int i = 0; i < zeiträume.Length; i++)
{
    Console.WriteLine(zeiträume[i] + ": " + Math.Round(proTag * tage[i], 2) + " Franken");
}
double wochenBudget = proTag * 7;
Console.WriteLine();
Console.WriteLine("Wie viel Geld brauchst du ungefähr pro Woche?");
double wochenBedarf = Convert.ToDouble(Console.ReadLine());
if (wochenBedarf <= wochenBudget)
{
    Console.WriteLine("Das passt! Du hast pro Woche noch ca. " + Math.Round(wochenBudget - wochenBedarf, 2) + " Franken übrig.");
}
else
{
    Console.WriteLine("Achtung: Dir fehlen pro Woche ca. " + Math.Round(wochenBedarf - wochenBudget, 2) + " Franken.");
}
Console.WriteLine();
Console.WriteLine("Wie viel Prozent von deinem Taschengeld möchtest du sparen? (z.B. 40)");
double prozent = Convert.ToDouble(Console.ReadLine());
double sparbetrag = betrag * prozent / 100;
double restbetrag = betrag - sparbetrag;
Console.WriteLine("Sparziel: " + prozent + "% von " + betrag + " Franken sind " + sparbetrag + " Franken.");
Console.WriteLine("Du hast noch " + restbetrag + " Franken zum Ausgeben.");
Console.WriteLine();
string weiter = "ja";
while (weiter == "ja")
{
    Console.WriteLine("Für welche Kategorie möchtest du Geld ausgeben? (Essen, Games, Kleidung, Freizeit)");
    string eingabeKategorie = Console.ReadLine().ToLower();

    int kategorieIndex = -1;
    for (int i = 0; i < kategorien.Length; i++)
    {
        if (eingabeKategorie == kategorien[i].ToLower())
        {
            kategorieIndex = i;
        }
    }
    if (kategorieIndex == -1)
    {
        Console.WriteLine("Diese Kategorie gibt es nicht.");
    }
    else
    {
        Console.WriteLine("Wie viel möchtest du für " + kategorien[kategorieIndex] + " ausgeben?");
        double ausgabe = Convert.ToDouble(Console.ReadLine());

        if (ausgabe <= restbetrag)
        {
            restbetrag = restbetrag - ausgabe;
            ausgabenProKategorie[kategorieIndex] = ausgabenProKategorie[kategorieIndex] + ausgabe;
            Console.WriteLine("Du hast " + ausgabe + " Franken für " + kategorien[kategorieIndex] + " ausgegeben.");
            Console.WriteLine("Du hast noch " + restbetrag + " Franken übrig.");
        }
        else
        {
            Console.WriteLine("Das reicht nicht! Dir fehlen " + (ausgabe - restbetrag) + " Franken.");
        }
    }
    Console.WriteLine("Möchtest du noch eine Ausgabe hinzufügen? (ja/nein)");
    weiter = Console.ReadLine().ToLower();
}
Console.WriteLine();
Console.WriteLine("Möchtest du prüfen, ob dein Geld für etwas Bestimmtes reicht? (ja/nein)");
string prüfen = Console.ReadLine().ToLower();

while (prüfen == "ja")
{
    Console.WriteLine("Was möchtest du kaufen?");
    string wunsch = Console.ReadLine();
    Console.WriteLine("Wie viel kostet " + wunsch + "?");
    double preis = Convert.ToDouble(Console.ReadLine());

    if (preis <= restbetrag)
    {
        Console.WriteLine("Ja, das reicht! Danach hättest du noch " + (restbetrag - preis) + " Franken übrig.");
    }
    else if (preis <= restbetrag + sparbetrag)
    {
        Console.WriteLine("Mit deinem Restgeld reicht es nicht (es fehlen " + (preis - restbetrag) + " Franken), aber mit deinem Ersparten schon.");
    }
    else
    {
        Console.WriteLine("Das reicht leider nicht. Dir fehlen " + (preis - restbetrag - sparbetrag) + " Franken, selbst mit deinem Ersparten.");
    }

    Console.WriteLine("Möchtest du noch etwas prüfen? (ja/nein)");
    prüfen = Console.ReadLine().ToLower();
}
Console.WriteLine();
Console.WriteLine("Deine fertige Übersicht:");
Console.WriteLine("Taschengeld: " + beträge[index] + " Franken");
Console.WriteLine("Gespart: " + sparbetrag + " Franken (" + prozent + "%)");
for (int i = 0; i < kategorien.Length; i++)
{
    Console.WriteLine("Ausgaben " + kategorien[i] + ": " + ausgabenProKategorie[i] + " Franken");
}
Console.WriteLine("Übrig: " + restbetrag + " Franken");
Console.WriteLine();

Console.ReadKey();