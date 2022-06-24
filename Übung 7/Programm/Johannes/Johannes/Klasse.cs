using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace fehlzeitenVerwaltung
{
    class Klasse
    {


        public Schueler[] liste { get; }
        private string name;

        public Klasse(string name)
        {
            this.name = name;
            liste = new Schueler[30];
            ListeAusDateilesen();

        }

        public void Hinzufuegen(Schueler schueler)
        {

            for (int i = 0; i < liste.Length; i++)
            {
                if (liste[i] == null)
                {
                    liste[i] = schueler;
                    break;
                }
            }

        }

        public void Anzeigen()
        {
            foreach (Schueler item in liste)
            {
                Console.WriteLine(item);
            }
        }


        public void ListeInDateiSpeichern()
        {
            StreamWriter sw = new StreamWriter("bbm3h20 1.txt", false);
            foreach (Schueler item in liste)
            {
                sw.WriteLine(item);
            }

            sw.Close();

        }

        public void ListeAusDateilesen()
        {
            StreamReader sr = new StreamReader("bbm3h20 1.txt");
            while (!sr.EndOfStream)
            {

                string hilfe = sr.ReadLine();
                if (hilfe.StartsWith("//"))
                {
                    continue;
                }

                string[] temp = hilfe.Split(';');
                Hinzufuegen(new Schueler(temp[0], temp[1], temp[2], Convert.ToInt32(temp[3]),
                    Convert.ToInt32(temp[4])));
                
            }


        }

        public void FehlzeitenerHoehen(string kennung, int fehlstunden)
        {

            foreach (Schueler SV in liste)
            {
                
                Console.WriteLine(SV.kennung + SV.fehlzeiten);
                    if(SV.Equals(kennung)) {  
                    
                    SV.fehlzeiten = SV.fehlzeiten + fehlstunden;
                    }
            }
        }

        public void UnentschuldigtefehlzeitenErhoehen(string kennung, int unentschuldigteFehlzeiten)
        {

            foreach (Schueler SV in liste)
            {

                Console.WriteLine(SV.kennung + SV.fehlzeiten + SV.unentschuldigteFehlzeiten);
                if (SV.Equals(kennung))
                {
                    if (SV.fehlzeiten <= SV.unentschuldigteFehlzeiten)
                    {

                        SV.unentschuldigteFehlzeiten = SV.unentschuldigteFehlzeiten + unentschuldigteFehlzeiten;

                    }
                }
            }
        }
    }
}