using System;
using System.Collections.Generic;
using System.Text;

namespace Brueche2
{
    class Bruch
    {
        private int zaehler;
        private int nenner;
        public int Nenner
        {
            // Property fertigstellen, mit Plausibilitätsprüfung: ein Nenner darf nie 0 sein!
            get
            {
                return nenner;
            }
            set
            {
                if (value != 0)
                {
                    nenner = value;
                }
                else
                {
                    throw new Exception("Nenner is Null");
                }
                
            }
        }

        public Bruch()
        {
           // Defaultbruch anlegen, Achtung:Nenner 0 nicht erlaubt
           zaehler = 0;
           nenner = 1;
           
        }

        public Bruch(int z, int n)
        {
            // Konstruktor fertigstellen, Achtung:Nenner 0 nicht erlaubt
            if (n != 0)
            { 
                nenner = n;
            }
            else
            {
                throw new Exception("Nenner is Null");
            }
            zaehler = z;
        }

        public Bruch(string zk)
        {
            // Fertigstellen
            // Zerlegung der Zeichenkette in zaehler und nenner

            string[] zkZerlegt = zk.Split("/");
            zaehler = Convert.ToInt32(zkZerlegt[0]);
            nenner = Convert.ToInt32(zkZerlegt[1]);
            
        }
        

        public string Print()
        {
           //Ausgabe des Bruchs auf der Console
           return zaehler + "/" + nenner;
        }

       
        public Bruch Addieren(Bruch b)    // Operator +
        {
           //?    zwei Brüche sollen addiert werden
          //  1/2 + 2/3 = 3/6 + 4/6 = 7/6
          int neuZaehler = zaehler * b.nenner + b.zaehler * nenner;
          int neuNenner  = nenner * b.nenner;

          return new Bruch(neuZaehler, neuNenner);
        }

        public Bruch Subtrahieren(Bruch b)  // Operator -
        {
          //?     Subtraktion eines Bruches von einem anderen Bruch
          // 1/2 - 2/3 = 3/6 - 4/6 = -1/6
          int neuZaehler = zaehler * b.nenner - b.zaehler * nenner;
          int neuNenner  = nenner * b.nenner;

          return new Bruch(neuZaehler, neuNenner);
        }

        public Bruch Multiplizieren(Bruch b)   // Operator *
        {
           //?    zwei Brüche sollen multipliziert werden
          // 1/2 * 2/3 = 2/6 = 1/3
          int neuZaehler = zaehler * b.zaehler;
          int neuNenner  = nenner * b.nenner;

          return new Bruch(neuZaehler, neuNenner);
        }

        public Bruch Dividieren(Bruch b)   // Operator /
        {
           //?  
          // (1/2) / (2/3) = 1/2 * 3/2 = 3/4 
          int neuZaehler = zaehler / b.zaehler;
          int neuNenner  = nenner % b.nenner;

          return new Bruch(neuZaehler, neuNenner);
        }

        public void Eingeben()      
        {
            Console.Write("\nBruch in der Form 3/4 (Zähler/Nenner):  ");
            
            // String eingeben lassen, zerlegen und in Instanzvariablen speichern
            string zk = Console.ReadLine();
            string[] zkZerlegt = zk.Split("/");
            zaehler = Convert.ToInt32(zkZerlegt[0]);
            nenner = Convert.ToInt32(zkZerlegt[1]);
        }


        public int bToInt()
        {
            return zaehler / nenner;
        }

        public double bToDouble()
        {
            return (double) zaehler / nenner;
        }

        public void Kuerzen()
        {
            if (zaehler != 0 && nenner != 0)
            {
                int ggt = GGT(zaehler, nenner);
                zaehler /= ggt;
                nenner /= ggt;
            }
        }
        
        private int GGT(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GGT(b, a % b);
            }
        }

    }

    
}
