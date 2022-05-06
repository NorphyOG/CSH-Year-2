using System;
using System.Collections.Generic;
using System.Text;

namespace Brueche2
{
    class Program
    {
        static char menue()
        {
           // Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n  Bruch a eingeben ............ (a)");
            Console.WriteLine("    Bruch b eingeben ............ (b)");
            Console.WriteLine("    Anzeige der beiden Brüche ... (p)");
            Console.WriteLine("    Rechne z = a + b  ........... (+)");
            Console.WriteLine("    Rechne z = a - b  ........... (-)");
            Console.WriteLine("    Rechne z = a x b  ........... (*)");
            Console.WriteLine("    Rechne z = a / b  ........... (/)");
            Console.WriteLine("    a und b tauschen ............ (t)");
            Console.WriteLine("    a ist gleich b .............. (g)");
            Console.WriteLine("    a ist ungleich b ............ (u)");
            Console.WriteLine("    expl. Typumw. von a in int... (e)");
            Console.WriteLine("    impl. Typumw. von a in double (i)");
            Console.WriteLine("    Programmende ................ (q)\n");
            Console.Write("    Eingabe .....................  ");

            return Console.ReadLine()[0]; // 1. Zeichen der Eingabe lesen
        }
        public static void stop()
        {
            Console.Write("\nWeiter [Return]  ");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Bruch a = new Bruch();
            Bruch b = new Bruch();
            Bruch c = new Bruch();
            Bruch z = new Bruch();
            char wahl = 'a';

            while (wahl != 'q')
            {
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                wahl = menue();


                switch (wahl)
                    {
                        // .....
                    }
                
                
            }
        }
    }
}
