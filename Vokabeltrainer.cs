Console.WriteLine("Vokabeltrainer Französisch");
Console.WriteLine("Aus welcher Lektion möchten Sie Vokabeln lernen? (Lektion 3 E, Lektion 3 A, Lektion 3 B, Lektion 4 E, Lektion 4 A, Lektion 4 B)");
string lektion = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Deine Auswahlen:");
Console.WriteLine("===== Lektion: " + lektion + "=====");
Console.WriteLine();
Console.WriteLine("Drücke eine Taste, um mit dem Lernen zu beginnen.");

string[] deutsch =
{ "möglich", "sich mit jdm. austauschen", "regelmässig", "ein Austausch", "eine Postkarte", "der Sommer", "draussen", "eine Felsbucht", "der Kajak", "von jdm./etw. Fan sein", "ein Abonnement", "Das ist der Wahnsinn", "ein Korken", "ein Gefängnis", "ein Freund/eine Freundin"};
string[] französisch =
{ "possible", "échanger avec qn.", "régulièrement", "un échange", "une carte postale", "l'été", "dehors", "une crique", "le kayak", "être fan de qn./qc.", "un abonnement", "C'est la folie!", "un bouchon", "une prison", "un ami/une amie" };


string[] deutschA =
{"eine Gebrauchsanweisung","ein Marathon","eine Broschüre","etwas verpassen / versäumen","nachdenken (über); überlegen","Angst haben, etwas zu tun","das Heimweh","ein Zweifel","sofort","jemanden ermutigen","eine Erfahrung","einzigartig","ein Fortschritt","eine Kultur","schliesslich, zum Schluss","sich entscheiden",
"eine Website","leicht","sich für etwas interessieren","eine Anzeige","mit jemandem chatten","etwas behalten","ein Ordner; eine Akte; Bewerbungsunterlagen","etwas regeln","Ostern","hinunterfahren","ungeduldig","weggehen","sich fühlen","ein Couscous"};
string[] französischA =
{"un mode d'emploi","un marathon","une brochure","manquer qc","réfléchir (à)","avoir peur de faire qc","le mal du pays","un doute","tout de suite","encourager qn","une expérience","unique","un progrès","une culture","finalement","se décider","un site","facile","s'intéresser à qc",
"une annonce","chatter avec qn","garder qc","un dossier","régler qc","Pâques (f. pl.)","descendre à (+Ortsname)","impatient, impatiente","s'en aller","se sentir","un couscous"};


string[] deutschB =
{"Höhen und Tiefen","aufgeregt; nervös","sich Mühe geben","langsam","ein Akzent (eine Art der Aussprache)","der südfranzösische Akzent","am folgenden Tag","am Verhungern sein","sich an etwas/jemanden gewöhnen","sich Sorgen machen","gut gehen","sich über jdn/etw lustig machen","durchhalten, dranbleiben",
    "geduldig","jdn./etw. verbessern, korrigieren","besser","vor allem","die französische Umgangssprache","ein Lachanfall","etw. garantieren","auf jdn./etw. voll abfahren (ugs.)","ich lach mich tot (ugs.)","Es ist etwas los.","leben","ein Lebensmittelhändler, eine Lebensmittelhändlerin","über etw. Bescheid wissen",
    "ein Arzt/eine Ärztin","ein Krankenhaus/Krankenhäuser","ein Paradies","ein Eindruck","ein Bericht","(wieder) weggehen; wegfahren","jdn/etw. wiedersehen","jdn abholen (kommen)","jdm. für etw. danken, sich bei jdm. für etw. bedanken","sich auf etw. vorbereiten","höflich","etw. wiederholen","das Gegenteil (von)"};
string[] französischB =
{"des hauts et des bas (m. pl.)","nerveux/nerveuse","faire des efforts","lent/lente","un accent","l'accent du Midi","le lendemain","être mort de faim","s'habituer à qc/qn","se faire du souci","bien se passer","se moquer de qn/qc","s'accrocher","patient, patiente","corriger qn/qc","mieux","surtout","le français familier",
    "un fou rire","garantir qc","kiffer qn/qc (fam.)","mort de rire (fam.)","Il y a de l'animation. (f.)","vivre","un épicier/une épicière","être au courant de qc","un médecin/une femme médecin","un hôpital/des hôpitaux","un paradis","une impression","un rapport","repartir","revoir qn/qc","venir chercher qn","remercier qn de/pour qc",
    "se préparer à qc","poli, polie","répéter qc","le contraire (de)"};

string[] deutsch4E =
{
"eine Sprache","Belgien","das Herz","im Herzen von","Luxemburg","die Niederlande","Wallonien (Region in Belgien)","Flandern (Region in Belgien)","Flämisch (in Belgien gesprochenes Niederländisch)","eine Million",
"ein Einwohner/eine Einwohnerin","eine Amtssprache","Niederländisch","ein Symbol","eine Hauptstadt","kosmopolitisch","zweisprachig","ein Ziel, ein Bestimmungsort","die Entspannung",
"die Nordsee","ein Belgier/eine Belgierin","Pommes frites","eine Waffel","belgisch","ein Zeichner/eine Zeichnerin"
};

string[] französisch4E =
{
"une langue","la Belgique","le coeur","au coeur de","le Luxembourg","les Pays-Bas","la Wallonie","la Flandre","le flamand","un million","un habitant, une habitante","une langue officielle",
"le néerlandais","un symbole","une capitale","cosmopolite","bilingue","une destination","la détente","la mer du Nord","un Belge/une Belge","des frites","une gaufre","belge",
"un dessinateur/une dessinatrice"
};

string[] deutsch4A =
{
"eine Kampagne","etw. herausstellen","eine Nationalität, eine Staatsangehörigkeit","ein Drittel des/der","ein Ursprung, eine Herkunft","ausländisch, fremd","ein Ereignis, eine Veranstaltung","Kultur-, kulturell",
"ein Reporter/eine Reporterin","jdn interviewen","das Studium","studieren","dort, dorthin, daran","eine Arbeit/(Bau)Arbeiten","daher, von dort, daraus, darüber","das Ausland","eine Universität",
"ein Student/eine Studentin","lebendig","die Miete","jdn./etw. nützen; jdn./etw. ausnutzen; von jdm./etw. profitieren; etw. geniessen","ein Übersetzer/eine Übersetzerin","eine (Sprech)Blase",
"im Grunde genommen, eigentlich","die Qualität","ideal","eine Miesmuschel","der Kongo","eine Kolonie","ein Stipendium","ein Kongolese/eine Kongolesin","afrikanisch","Afrika","Grossbritannien",
"Österreich","die Vereinigten Staaten","Portugal","Russland","die Schweiz","die Türkei"
};

string[] französisch4A =
{
"une campagne","mettre qc en avant","une nationalité","un tiers de","une origine","étranger/étrangère","un évènement","culturel, culturelle",
"un reporter/une reporter","interviewer qn","les études (f. pl.)","faire ses études","y","un travail/des travaux","en","l'étranger (m.)","une université",
"un étudiant/une étudiante","vivant, vivante","le loyer","profiter de qn/qc","un traducteur/une traductrice","une bulle",
"en fait","la qualité","idéal/idéale/idéaux/idéales","une moule","le Congo","une colonie","une bourse","un Congolais/une Congolaise","africain/africaine","l'Afrique","la Grande-Bretagne",
"l'Autriche (f.)","les Etats-Unis (m. pl.)","le Portugal","la Russie","la Suisse","la Turquie"
};

string[] deutsch4B =
{
"ein Schritt","auf den Spuren von","Welt-","ohne etw. zu tun","übertreiben","spontan","spontan","Wen...?","vermutlich","mehr als",
"bevor man etw. tut","geboren","Bezeichnung für die Comic-Kunst","spazieren gehen","denn","jdn/etw. anziehen","Was...?","unterhaltsam, lustig","gerade etw. tun","als erster",
"nächster/nächste/nächstes","zahlreich","französischsprachig","japanisch","hinter","eine Tastatur","eine Person (Literatur, Film, Theater); eine Figur","unter","ein Dichter/eine Dichterin","eine Uniform",
"eine Waffe","gerade etw. getan haben","etw. illustrieren","das Imaginäre","ein Pirat","ein Hexenmeister/eine Hexe","ein Einhorn","jdm gefallen","ein Projekt","ein Märchen",
"jdn. inspirieren","sich auf etw. einstimmen","ein Seemann; ein Matrose","jdm. erlauben, etw. zu tun; jdm. etw. ermöglichen","etw. schaffen; gründen","ein Tier/Tiere","ein Auge/Augen","braun","böse, gemein","langweilig",
"ein Charakter"
};

string[] französisch4B =
{
"un pas","sur les pas de","mondial/mondiale/mondiaux/mondiales","sans faire qc","exagérer","spontané, spontanée","spontanément","Qui est-ce que...?","sans doute","plus de",
"avant de faire qc","né/née","le 9e art","se promener","car","attirer qn/qc","Qu'est-ce qui...?","amusant, amusante","être en train de faire qc","en premier",
"prochain, prochaine","nombreux/nombreuse","francophone","japonais, japonaise","derrière","un clavier","un personnage","parmi","un poète/une poète","un uniforme",
"une arme","venir de faire qc","illustrer qc","l'imaginaire","un pirate","un sorcier/une sorcière","une licorne","plaire à qn","un projet","un conte",
"inspirer qn","se mettre en condition","un marin","permettre à qn de faire qc","créer qc","un animal/des animaux","un oeil/des yeux","marron","méchant, méchante","ennuyeux/ennuyeuse",
"un caractère"
};


string[] fragen;
string[] antworten;

string auswahl = lektion.ToLower().Trim();

if (auswahl == "lektion 3 e")
{
    fragen = deutsch;
    antworten = französisch;
}
else if (auswahl == "lektion 3 a")
{
    fragen = deutschA;
    antworten = französischA;
}
else if (auswahl == "lektion 3 b")
{
    fragen = deutschB;
    antworten = französischB;
}
else if (auswahl == "lektion 4 e")
{
    fragen = deutsch4E;
    antworten = französisch4E;
}

else
{
    Console.WriteLine("Ungültige Eingabe. Bitte starte das Programm neu.");
    Console.ReadKey();
    return;
}
Console.ReadKey();
Console.WriteLine();
int punkte = 0;

for (int i = 0; i < fragen.Length; i++)
{
    Console.WriteLine("Deutsch: " + fragen[i]);
    Console.Write("Französisch: ");
    string eingabe = Console.ReadLine();

    if (eingabe.Trim().ToLower() == antworten[i].ToLower())
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Richtig!");
        Console.ResetColor();
        punkte++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Falsch. Richtig wäre: " + antworten[i]);
        Console.ResetColor ();
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("===== Deine erreichte Punktzahl ist: " + punkte + " von " + fragen.Length + "=====");
Console.ReadKey();