
using System;

Console.WriteLine("Willkommen zu deinem persönlichen Taschengeldrechner!");
Console.WriteLine("Wie oft bekommst du Taschengeld? (täglich, wöchentlich, monatlich, jährlich)");
string eingabe = Console.ReadLine();
string[] häufigkeiten = { "täglich", "wöchentlich", "monatlich", "jährlich" };
double[] beträge = new double[4];
bool gefunden = false;
for (int i = 0; i < häufigkeiten.Length; i++)
{
    if (eingabe.ToLower() == häufigkeiten[i])
    {
        Console.WriteLine("Wie viel Taschengeld bekommst du?");
        double betrag = Convert.ToDouble(Console.ReadLine());

        beträge[i] = betrag;

        Console.WriteLine("Du bekommst " + beträge[i] + " Franken " + häufigkeiten[i] + ".");
        gefunden = true;
    }
}
if (gefunden == false)
{
    Console.WriteLine("Diese Häufigkeit gibt es nicht.");
}

Console.WriteLine("Wie viel Geld möchtest du von diesem Betrag sparen?");
double sparbetrag = Convert.ToDouble(Console.ReadLine());
double restbetrag = beträge[Array.IndexOf(häufigkeiten, eingabe.ToLower())] - sparbetrag;
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
Console.WriteLine("Taschengeld: " + beträge[Array.IndexOf(häufigkeiten, eingabe.ToLower())] + " Franken");
Console.WriteLine("Gespart: " + sparbetrag + " Franken");
Console.WriteLine("Übrig: " + restbetrag + " Franken");


Console.ReadKey();