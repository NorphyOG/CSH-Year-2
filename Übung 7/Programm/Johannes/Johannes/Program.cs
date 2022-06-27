// See https://aka.ms/new-console-template for more information

using fehlzeitenVerwaltung;

Klasse bbm3h20amr = new Klasse("bbm3h20amr");

bool run = true;

while (run)
{
    Console.WriteLine(
        "Wählen sie ein case \n a für alle schüler... \n f für fehlstrunden verwaltung... \n uf unentschuldigte stunden verwalten... \n unter e können sie das programm verlassen... ");
    string var = Console.ReadLine();

    switch (var)
    {
        case "a":
            Console.WriteLine("Hier werden alle schüler wie auch fehlzeiten angezeigt");
            bbm3h20amr.Anzeigen();
            break;
        case "f":
            Console.WriteLine("Hier weden alle fehlzeiten angezeigt");
            Console.Write("Kennung..? ");
            string kennung1 = Console.ReadLine();
            Console.Write("Fehlstunden..? ");
            int fehlstunden = Console.Read();
            bbm3h20amr.FehlzeitenerHoehen(kennung1, fehlstunden);
            break;

        case "uf":
            Console.WriteLine("Hier werden die unentschuldigten angezeigt");
            Console.Write("Kennung..? ");
            string kennung2 = Console.ReadLine();
            Console.Write("Unent..? ");
            int unentschuldigteFehlzeiten = Console.Read();
            bbm3h20amr.UnentschuldigtefehlzeitenErhoehen(kennung2, unentschuldigteFehlzeiten);
            break;
        case "e":
            run = false;
            break;
        default:
            throw new Exception("Starten sie das programm neu ");
            break;

    }


}