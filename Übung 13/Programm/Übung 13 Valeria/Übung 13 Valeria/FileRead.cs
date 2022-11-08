namespace Übung_13_Valeria;

public class FileRead
{
    public List<Person> person = new List<Person>();
    
    
    private string[] paths =
    {
        "daten.txt"
    };

    public void AlleDateiLesen()
    {
        foreach (var vPath in paths)
        {
            string[] lines = DateiLesen(vPath);
            int nummer = 4;

            string vorname = "";
            string nachname = "";
            string adresse = "";
            int anzahlK = 0;
            bool test = false;


            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            foreach (var vLine in lines)
            {
                if (anzahlK == 0 && !test)
                {
                    switch (nummer)
                    {
                        case 1:
                            vorname = vLine;
                            break;
                        case 2:
                            nachname = vLine;
                            break;
                        case 3:
                            adresse = vLine;
                            break;
                        case 4:
                            anzahlK = Convert.ToInt32(vLine);
                            break;
                        default:
                            nummer = 4;
                            break;
                    }

                    nummer--;
                }
                else
                {
                    string[] kontakt = vLine.Split(';');
                    dictionary.Add(kontakt[0], kontakt[1]);
                    anzahlK--;
                    if (anzahlK == 0)
                    {
                        test = true;
                    }
                }

                if (test)
                {
                    person.Add(new Person(vorname, nachname,adresse,dictionary));
                    test = false;
                }
            }
        }
       
    }
    public string[] DateiLesen(string path)
    {
        string[] line = File.ReadAllLines(path);
        
        if (line.Length == 0) throw new InvalidOperationException("Die Datei enthält keine Zeilen.");

        return line;
    }

    public void speichern()
    {
        string[] kontaktliste = new string [10];
        foreach  (var vPerson in person )
        {
            for (int i = 0; i < kontaktliste.Length; i++)
            {
                if (kontaktliste[i] == null)
                {
                    kontaktliste[i]="Vorname: " + vPerson.Vorname + " | Nachname: " + vPerson.Nachname + 
                                    " | Adresse: " +vPerson.Adresse + " | Tel: " +vPerson.Kontakte.Keys + 
                                    " | Art: " +vPerson.Kontakte.Values;
                    break;
                }
                
            }
            
        }
        File.WriteAllLines("kontaktliste.txt",kontaktliste);
    }
    
    
}