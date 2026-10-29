using System;

Console.WriteLine("Willkommen zu deinem persönlichen Taschengeldrechner!");

string[] häufigkeiten = { "täglich", "wöchentlich", "monatlich", "jährlich" };
int[] tage = { 1, 7, 30, 365 };
string[] zeiträume = { "pro Tag", "pro Woche", "pro Monat", "pro Jahr" };
double[] beträge = new double[4];

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
Console.WriteLine("Wie viel Geld möchtest du von diesem Betrag sparen?");
double sparbetrag = Convert.ToDouble(Console.ReadLine());
double restbetrag = beträge[index] - sparbetrag;
Console.WriteLine("Du hast noch " + restbetrag + " Franken übrig, wenn du " + sparbetrag + " Franken sparen willst.");
Console.WriteLine("Was möchtest du mit dem restlichen Geld machen? (z.B. ausgeben oder investieren)");
string verwendung = Console.ReadLine();
Console.WriteLine("Wie viel Geld möchtest du für " + verwendung + " ausgeben?");

double ausgaben = Convert.ToDouble(Console.ReadLine());
restbetrag = restbetrag - ausgaben;

Console.WriteLine("Du hast " + ausgaben + " Franken für " + verwendung + " ausgegeben.");
Console.WriteLine("Du hast noch " + restbetrag + " Franken übrig.");
string weiter = "ja";

while (weiter == "ja")
{
    Console.WriteLine("Möchtest du noch eine Ausgabe hinzufügen? (ja/nein)");
    weiter = Console.ReadLine().ToLower();

    if (weiter == "ja")
    {
        Console.WriteLine("Wofür möchtest du Geld ausgeben?");
        string weitereVerwendung = Console.ReadLine();

        Console.WriteLine("Wie viel möchtest du für " + weitereVerwendung + " ausgeben?");
        double weitereAusgaben = Convert.ToDouble(Console.ReadLine());

        restbetrag = restbetrag - weitereAusgaben;

        Console.WriteLine("Du hast noch " + restbetrag + " Franken übrig.");
    }
}

Console.WriteLine("Deine endgültige Übersicht:");
Console.WriteLine("Taschengeld: " + beträge[index] + " Franken");
Console.WriteLine("Gespart: " + sparbetrag + " Franken");
Console.WriteLine("Übrig: " + restbetrag + " Franken");

Console.ReadKey();