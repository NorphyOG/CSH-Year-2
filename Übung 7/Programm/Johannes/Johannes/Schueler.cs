using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fehlzeitenVerwaltung
{
    class Schueler
    {
        public string nachname { get; set; }
        public string vorname { get; set; }
        public string kennung { get; set; }
        public int fehlzeiten;
        public int unentschuldigteFehlzeiten;

        public int UnentschuldigteFehlzeiten { 
        
            get { return unentschuldigteFehlzeiten; }
            set { unentschuldigteFehlzeiten = value; 
            
                if (unentschuldigteFehlzeiten > fehlzeiten) { 
                
                throw new Exception("Die unentschuldigten fehlstunden können nicht mehr als die entschuligten sein");
                }
            
            }

        
        }


        public string Kennung
        {

            get { return kennung; }
            set
            {
                kennung = value;

                if (value == "")
                {

                    throw new Exception("Es muss eine Kennung geben");

                }

            }


        }

        public override string ToString()
        {
            return nachname + ";" + vorname + ";" + Kennung + ";" + fehlzeiten + ";" + unentschuldigteFehlzeiten;
        }


        public Schueler(string _nachname, string _vorname, string _kennung, int _fehlzeiten, int _unentschuldigteFehlzeiten)
        {

            nachname = _nachname;
            vorname = _vorname;
            kennung = _kennung;
            fehlzeiten = _fehlzeiten;
            unentschuldigteFehlzeiten = _unentschuldigteFehlzeiten;

        }

    }
}
