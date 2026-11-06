using System;

Console.WriteLine("Willkommen zu deinem persönlichen Taschengeldrechner!");
string[] häufigkeiten = { "täglich", "wöchentlich", "monatlich", "jährlich" };
int[] tage = { 1, 7, 30, 365 };
string[] zeiträume = { "pro Tag", "pro Woche", "pro Monat", "pro Jahr" };
double[] beträge = new double[4];
string[] kategorien = { "Essen", "Games", "Kleidung", "Freizeit", "Snacks", "Handy", "Transport", "Hobbys", "Geschenke", "Sonstiges" };
double[] ausgabenProKategorie = new double[kategorien.Length];
string[] tipps = {
    "Koche öfter selbst oder nimm Verpflegung von zu Hause mit.",
    "Warte auf Aktionen oder tausche Games mit Freunden.",
    "Kaufe nur, was du wirklich brauchst, oder schau Secondhand.",
    "Suche gratis Aktivitäten, z.B. Spazieren, Sport im Freien oder Spieleabend.",
    "Kaufe Snacks im Grosspack im Laden statt einzeln im Kiosk.",
    "Prüfe, ob ein günstigeres Handyabo oder ein Prepaid-Tarif für dich reicht.",
    "Nimm wenn möglich das Velo oder geh zu Fuss, das kostet nichts.",
    "Leihe Material aus oder kaufe gebraucht, bevor du neues Hobby-Zubehör kaufst.",
    "Selbstgemachte Geschenke sind günstig und kommen oft besser an.",
    "Schreib auf, was unter Sonstiges fällt. So findest du versteckte Ausgaben."
};
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
double sparProWoche = wochenBudget * prozent / 100;
Console.WriteLine("Sparziel: " + prozent + "% von " + betrag + " Franken sind " + sparbetrag + " Franken.");
Console.WriteLine("Du hast noch " + restbetrag + " Franken zum Ausgeben.");
Console.WriteLine();
string zielName = "";
double zielFehlt = 0;
Console.WriteLine("Hast du ein bestimmtes Sparziel, z.B. ein neues Handy? (ja/nein)");
string zielAntwort = Console.ReadLine().ToLower();
if (zielAntwort == "ja")
{
    Console.WriteLine("Wofür sparst du?");
    zielName = Console.ReadLine();
    Console.WriteLine("Wie viel kostet " + zielName + "?");
    double zielBetrag = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Wie viel hast du dafür schon gespart?");
    double zielSchonGespart = Convert.ToDouble(Console.ReadLine());
    zielFehlt = zielBetrag - zielSchonGespart;
    Console.WriteLine("Sparziel: " + zielName + " (" + zielBetrag + " Franken). Dir fehlen noch " + Math.Max(zielFehlt, 0) + " Franken.");
    Console.WriteLine(Sparzeit(zielFehlt, sparProWoche));
}
Console.WriteLine();
string weiter = "ja";
while (weiter == "ja")
{
    Console.WriteLine("Für welche Kategorie möchtest du Geld ausgeben? (" + string.Join(", ", kategorien) + ")");
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
        Console.WriteLine(Sparzeit(preis - restbetrag - sparbetrag, sparProWoche));
    }

    Console.WriteLine("Möchtest du noch etwas prüfen? (ja/nein)");
    prüfen = Console.ReadLine().ToLower();
}
Console.WriteLine();
Console.WriteLine("Deine endgültige Übersicht:");
Console.WriteLine("Taschengeld: " + beträge[index] + " Franken");
Console.WriteLine("Gespart: " + sparbetrag + " Franken (" + prozent + "%)");
for (int i = 0; i < kategorien.Length; i++)
{
    Console.WriteLine("Ausgaben " + kategorien[i] + ": " + ausgabenProKategorie[i] + " Franken");
}
Console.WriteLine("Übrig: " + restbetrag + " Franken");
Console.WriteLine();
double gesamtAusgaben = 0;
int meisteKategorie = 0;
for (int i = 0; i < kategorien.Length; i++)
{
    gesamtAusgaben = gesamtAusgaben + ausgabenProKategorie[i];
    if (ausgabenProKategorie[i] > ausgabenProKategorie[meisteKategorie])
    {
        meisteKategorie = i;
    }
}
if (gesamtAusgaben > 0)
{
    Console.WriteLine("Am meisten Geld gibst du für " + kategorien[meisteKategorie] + " aus: " + ausgabenProKategorie[meisteKategorie] + " Franken (" + Math.Round(ausgabenProKategorie[meisteKategorie] / gesamtAusgaben * 100, 1) + "% deiner Ausgaben).");
}
else
{
    Console.WriteLine("Du hast noch nichts ausgegeben.");
}
Console.WriteLine();
Console.WriteLine("Deine Spartipps:");
int grössteKategorie = 0;
for (int i = 1; i < kategorien.Length; i++)
{
    if (ausgabenProKategorie[i] > ausgabenProKategorie[grössteKategorie])
    {
        grössteKategorie = i;
    }
}
if (ausgabenProKategorie[grössteKategorie] > 0)
{
    Console.WriteLine("- Du hast am meisten für " + kategorien[grössteKategorie] + " ausgegeben. " + tipps[grössteKategorie]);
}
if (prozent < 10)
{
    Console.WriteLine("- Du sparst weniger als 10%. Versuche, mindestens 10% von deinem Taschengeld zur Seite zu legen.");
}
else
{
    Console.WriteLine("- Gut gemacht, du sparst " + prozent + "% von deinem Taschengeld!");
}
if (restbetrag > 0)
{
    Console.WriteLine("- Du hast noch " + restbetrag + " Franken übrig. Leg sie doch zu deinem Ersparten dazu.");
}
if (gesamtAusgaben > 0 && ausgabenProKategorie[grössteKategorie] > gesamtAusgaben / 2)
{
    Console.WriteLine("- Mehr als die Hälfte deiner Ausgaben geht in eine einzige Kategorie. Hier lohnt sich Sparen am meisten.");
}
if (wochenBedarf > wochenBudget)
{
    Console.WriteLine("- Dein Wochenbedarf ist höher als dein Taschengeld. Überlege, was du streichen kannst oder ob du dir etwas dazuverdienen kannst.");
}
if (zielName != "")
{
    if (zielFehlt > 0)
    {
        double neuerProzent = Math.Min(prozent + 10, 100);
        Console.WriteLine("- Für dein Ziel \"" + zielName + "\": Wenn du " + neuerProzent + "% statt " + prozent + "% sparst, geht es schneller. " + Sparzeit(zielFehlt, wochenBudget * neuerProzent / 100));
    }
    else
    {
        Console.WriteLine("- Du hast dein Sparziel \"" + zielName + "\" schon erreicht. Super!");
    }
}
Console.ReadKey();
static string Sparzeit(double fehlend, double sparProWoche)
{
    if (fehlend <= 0)
    {
        return "Du hast das Geld schon zusammen!";
    }
    if (sparProWoche <= 0)
    {
        return "Wenn du nichts sparst, kommst du nie ans Ziel. Erhöhe deinen Sparanteil.";
    }
    double wochen = Math.Ceiling(fehlend / sparProWoche);
    double monate = Math.Round(wochen / 4.33, 1);
    return "Du müsstest ca. " + wochen + " Wochen (ca. " + monate + " Monate) sparen.";
}