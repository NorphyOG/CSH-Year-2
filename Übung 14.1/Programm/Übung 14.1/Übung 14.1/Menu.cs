namespace Übung_14._1;

public class Menu
{

    public void MenuOne(List<Artikel> artikels)
    {
        
        Files file = new Files();
        
        while (true)
        {

            string input;

            Console.WriteLine("{0, -20}:{1, -3}", "Artikel einfügen", "1");
            Console.WriteLine("{0, -20}:{1, -3}", "Artikel löschen", "2");
            Console.WriteLine("{0, -20}:{1, -3}", "Liste anzeigen", "3");
            Console.WriteLine("{0, -20}:{1, -3}", "Beenden", "4");
            Console.Write("{0, -20}:{1, 0}", "Eingabe: ", "");
            input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    //Artikel einfügen
                    string aName = "";
                    int aAnzahl = 0;

                    Console.Write("{0, -20}:", "Name eingeben");
                    aName = Console.ReadLine();

                    Console.Write("{0, -20}:", "Anzahl eingeben");
                    try
                    {
                        string tempNum = Console.ReadLine();
                        if (String.IsNullOrEmpty(tempNum))
                        {
                            tempNum = "0";
                        }
                        aAnzahl = Convert.ToInt32(tempNum);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Kein Int wert!");
                    }

                    Artikel tempA = new Artikel(aName, aAnzahl);
                    if (!artikels.Contains(tempA))
                    {
                        artikels.Add(tempA);
                        file.ArtikelHinzufuegen(tempA);
                    }
                    else
                    {
                        Console.WriteLine("Bereits vorhanden");
                    }
                    
                    break;
                case "2":
                    //Artikel löschen
                    string a2Name = "";

                    Console.Write("{0, -20}:", "Name eingeben");
                    a2Name = Console.ReadLine();
                    
                    
                    foreach (var v2Artikel in artikels.ToList())
                    {
                        if (v2Artikel.Artikelname.Equals(a2Name, StringComparison.InvariantCultureIgnoreCase))
                        {
                            artikels.Remove(v2Artikel);
                        }
                    }
                    
                    
                    break;
                case "3":
                    //Liste anzeigen
                    Console.WriteLine();
                    foreach (var vArtikel in artikels)
                    {
                        Console.WriteLine(vArtikel);
                    }

                    Console.WriteLine();
                    
                    file.DateiInBinaerAnzeigen();

                    Console.WriteLine();
                    break;
                case "4":
                    //Beenden
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Keine Gültige eingabe!!");
                    break;
            }

            Console.WriteLine();
            file.DateiInBinaerSpeichern(artikels);
        }
    }
    
}