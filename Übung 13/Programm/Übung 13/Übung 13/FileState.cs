using System;
using System.Collections.Generic;
using System.IO;

namespace Übung_13
{
    public class FileState
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


                Dictionary<string, string> dictionary = new Dictionary<string, string>();

                foreach (var vLine in lines)
                {

                    if (konAnz == 0 && !test)
                    {
                        switch (num)
                        {
                            case 4:
                                vorname = vLine;
                                break;
                            case 3:
                                nachname = vLine;
                                break;
                            case 2:
                                adresse = vLine;
                                break;
                            case 1:
                                konAnz = Convert.ToInt32(vLine);
                                break;
                            default:
                                num = 4;
                                break;
                        }

                        num--;
                    }
                    else
                    {
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

                        Persons.Add(new Person(vorname, nachname, adresse, dictionary));
                        test = false;
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
}