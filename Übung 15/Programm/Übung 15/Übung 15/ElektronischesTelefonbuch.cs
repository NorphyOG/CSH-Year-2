namespace Übung_15;

public class ElektronischesTelefonbuch
{
    public List<Person> Persons = new List<Person>();


        private string[] paths =
        {
            "daten.txt"
        };

        public void ReadAllFiles()
        {
            foreach (var vPath in paths)
            {
                string[] lines = ReadFile(vPath);

                int num = 4;

                string vorname = "";
                string nachname = "";
                string adresse = "";
                int konAnz = 0;
                bool test = false;
                bool sw = true;


                Dictionary<string, string> dictionary = null;

                foreach (var vLine in lines)
                {

                    if (konAnz == 0 && !test)
                    {
                        switch (num)
                        {
                            case 4:
                                nachname = vLine;
                                break;
                            case 3:
                                vorname = vLine;
                                break;
                            case 2:
                                adresse = vLine;
                                break;
                            case 1:
                                konAnz = Convert.ToInt32(vLine);
                                break;
                            default:
                                break;
                        }

                        num--;
                    }
                    else
                    {
                        if (sw)
                        {
                            dictionary = new Dictionary<string, string>();
                            sw = false;
                        }
                        string[] a = vLine.Split(';');
                        dictionary.Add(a[0], a[1]);
                        konAnz--;
                        if (konAnz == 0)
                        {
                            test = true;
                        }
                    }

                    if (test)
                    {
                        Person person = new Person(vorname, nachname, adresse, null);
                        Persons.Add(person);
                        foreach (var vPerson in Persons)
                        {
                            if (vPerson.Equals(person))
                            {
                                //vPerson.KontaktlistPersons = new Dictionary<string, string>();
                                vPerson.KontaktlistPersons = dictionary;

                            }
                        }
                        num = 4;
                        sw = true;
                        test = false;
                    }

                }

            }
        }
        public void StandardSuche()
        {
            Console.WriteLine("Bitte geben Sie den Vorname ein");
            string vorname = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den Nachname ein");
            string nachname = Console.ReadLine();
            
            foreach (var vPerson in Persons)
            {
                if (vPerson.Vorname == vorname && vPerson.Nachname == nachname)
                {
                    Console.WriteLine(vPerson);
                }
            }
        }
        public void RueckwaertsSuche()
        {
            Console.WriteLine("Bitte geben Sie die Telefonnummer ein");
            string telefonnummer = Console.ReadLine();
            foreach (Person p in Persons)
            {
                foreach (KeyValuePair<string, string> kvp in p.KontaktlistPersons)
                {
                    if (kvp.Value.Contains(telefonnummer))
                    {
                        Console.WriteLine(p);
                    }
                }
            }
        }

        public string[] ReadFile(string path)
        {
            string[] line = File.ReadAllLines(path);

            if (line.Length == 0) throw new InvalidOperationException("Die Datei enthält keine Zeilen.");

            return line;
        }


        public void save()
        {
            string[] list = new string[99];
            foreach (var vPerson in Persons)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] == null)
                    {
                        list[i] = "Vorname: " + vPerson.Vorname + " | Nachname: " + vPerson.Nachname + 
                                  " | Adresse: " +vPerson.Adresse + " | Tel: " +vPerson.KontaktlistPersons.Keys + 
                                  " | Art: " +vPerson.KontaktlistPersons.Values;
                        break;
                    }
                }
            }

            File.WriteAllLines("test.txt", list);
        }
    }
    
