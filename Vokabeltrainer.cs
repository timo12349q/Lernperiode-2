Console.WriteLine("Vokabeltrainer Französisch");
Console.WriteLine("Aus welcher Lektion möchten Sie Vokabeln lernen? (Lektion 3 entrée, Lektion 3 A, Lektion 3 B");
string lektion = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Deine Auswahlen:");
Console.WriteLine("Lektion: " + lektion);
Console.WriteLine();
Console.WriteLine("Drücke eine Taste, um mit dem Lernen zu beginnen.");

string[] deutsch = 
{ "möglich", "sich mit jdm. austauschen", "regalmässig", "ein Austausch", "eine Postkarte", "der Sommer", "draussen", "eine Felsbucht", "der Kajak", "von jdm./etw. Fan sein", "ein Abonnement", "Das ist der Wahnsinn", "ein Korken", "ein Gefängnis", "ein Freund/eine Freundin"};
string[] französisch = 
{ "possible", "échanger avec qn.", "régulièrement", "un échange", "une carte postale", "l'été", "dehors", "une crique", "le kayak", "être fan de qn./qc.", "un abonnement", "C'est la folie!", "un bouchon", "une prison", "un ami/une amie" };


string[] deutschA =
{"eine Gebrauchsanweisung","ein Marathon","eine Broschüre","etwas verpassen / versäumen","nachdenken (über); überlegen","Angst haben, etwas zu tun","das Heimweh","ein Zweifel","sofort","jemanden ermutigen","eine Erfahrung","einzigartig","ein Fortschritt","eine Kultur","schliesslich, zum Schluss","sich entscheiden",
"eine Website","leicht","sich für etwas interessieren","eine Anzeige","mit jemandem chatten","etwas behalten","ein Ordner; eine Akte; Bewerbungsunterlagen","etwas regeln","Ostern","hinunterfahren","ungeduldig","weggehen","sich fühlen","ein Couscous"};
string[] französischA =
{"un mode d'emploi","un marathon","une brochure","manquer qc","réfléchir (à)","avoir peur de faire qc","le mal du pays","un doute","tout de suite","encourager qn","une expérience","unique","un progrès","une culture","finalement","se décider","un site","facile","s'intéresser à qc",
"une annonce","chatter avec qn","garder qc","un dossier","régler qc","Pâques (f. pl.)","descendre à (+Ortsname)","impatient, impatiente","s'en aller","se sentir","un couscous"};


Console.ReadKey();