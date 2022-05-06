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
        }

        public Bruch()
        {
           // Defaultbruch anlegen, Achtung:Nenner 0 nicht erlaubt
        }

        public Bruch(int z, int n)
        {
            // Konstruktor fertigstellen, Achtung:Nenner 0 nicht erlaubt
        }

        public Bruch(string zk)
        {
            // Fertigstellen
            // Zerlegung der Zeichenkette in zaehler und nenner
        }
        

        public void Print()
        {
           //Ausgabe des Bruchs auf der Console
        }

       
        public Bruch Addieren(Bruch b)    // Operator +
        {
           //?    zwei Brüche sollen addiert werden
          //  1/2 + 2/3 = 3/6 + 4/6 = 7/6
          
        }

        public Bruch Subtrahieren(Bruch b)  // Operator -
        {
          //?     Subtraktion eines Bruches von einem anderen Bruch
          // 1/2 - 2/3 = 3/6 - 4/6 = -1/6
        }

        public Bruch Multiplizieren(Bruch b)   // Operator *
        {
           //?    zwei Brüche sollen multipliziert werden
          // 1/2 * 2/3 = 2/6 = 1/3
        }

        public Bruch Dividieren(Bruch b)   // Operator /
        {
           //?  
          // (1/2) / (2/3) = 1/2 * 3/2 = 3/4 
        }

        public void Eingeben()      
        {
            Console.Write("\nBruch in der Form 3/4 (Zähler/Nenner):  ");
            
            // String eingeben lassen, zerlegen und in Instanzvariablen speichern
        }

       



    }

    
}
