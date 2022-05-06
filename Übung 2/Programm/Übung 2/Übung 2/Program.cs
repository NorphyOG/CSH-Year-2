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
            Console.WriteLine("\n    Bruch a eingeben ............ (a)");
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
            Bruch[] bruch = {new Bruch(), new Bruch(), new Bruch(), new Bruch()};
            
            char wahl = 'a';

            while (wahl != 'q')
            {
                Console.SetCursorPosition(0, 0);
                Console.Clear();
                wahl = menue();

                foreach (Bruch vBruch in bruch)
                {
                    vBruch.Kuerzen();
                }
                
                bruch[2] = bruch[0];
                bruch[3] = bruch[1];

                switch (wahl)
                    {
                        case 'a':
                            bruch[0].Eingeben();
                            break;
                        case 'b':
                            bruch[1].Eingeben();
                            break;
                        case 'p':
                            int num = 1;
                            for (int i = 0; i < bruch.Length; i++)
                            {
                                if (i == 2)
                                {
                                    break;
                                }
                                Console.WriteLine("[" + num + "]>- " + bruch[i].Print());
                                num++;
                            }

                            break;
                        case '+':
                            Console.WriteLine(bruch[0].Addieren(bruch[1]).Print());
                            break;
                        case '-':
                            Console.WriteLine(bruch[0].Subtrahieren(bruch[1]).Print());
                            break;
                        case '*':
                            Console.WriteLine(bruch[0].Multiplizieren(bruch[1]).Print());
                            break;
                        case '/':
                            Console.WriteLine(bruch[0].Dividieren(bruch[1]).Print());
                            break;
                        case 't':
                            bruch[0] = bruch[3];
                            bruch[1] = bruch[2];
                            break;
                        case 'g':
                            if (bruch[0].Equals(bruch[1]))
                            {
                                Console.WriteLine(bruch[0].Print() + " == " + bruch[1].Print() + " = true");
                            }
                            else
                            {
                                Console.WriteLine(bruch[0].Print() + " == " + bruch[1].Print() + " = false");
                            }
                            break;
                        case 'u':
                            if (!bruch[0].Equals(bruch[1]))
                            {
                                Console.WriteLine(bruch[0].Print() + " != " + bruch[1].Print() + " = true");
                            }
                            else
                            {
                                Console.WriteLine(bruch[0].Print() + " != " + bruch[1].Print() + " = false");
                            }
                            break;
                        case 'e':
                            Console.WriteLine("int number: " + bruch[0].bToInt());
                            break;
                        case 'i':
                            Console.WriteLine("int number: " + bruch[0].bToDouble());
                            break;
                        case 'q':
                            Console.WriteLine("Bye");
                            break;
                        
                    }
                
                    Thread.Sleep(1500);

                
                
            }
        }
    }
}
