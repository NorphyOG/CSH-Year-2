using System.Collections.Generic;

namespace Übung_13
{
    public class Person
    {
        public string Vorname
        {
            get;
            set;
        }
        
        public string Nachname
        {
            get;
            set;
        } 
        
        public string Adresse
        {
            get;
            set;
        }

        public Dictionary<string, string> KontaktlistPersons = new Dictionary<string, string>();

        public Person(string vorname, string nachname, string adresse, Dictionary<string, string> kontaktlistPersons)
        {
            Vorname = vorname;
            Nachname = nachname;
            Adresse = adresse;
            KontaktlistPersons = kontaktlistPersons;
        }

        public override string ToString()
        {
            return $"{nameof(Vorname)}: {Vorname}, {nameof(Nachname)}: {Nachname}, {nameof(Adresse)}: {Adresse}, {nameof(KontaktlistPersons)}: {KontaktlistPersons}";
        }
    }
}