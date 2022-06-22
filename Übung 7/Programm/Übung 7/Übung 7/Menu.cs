namespace Übung_7;

public class Menu
{

    public void Start()
    {

        Klasse klasse = new Klasse("BBM3H20");
        klasse.UpdateState();

        try
        {
            bool run = true;
            
            
            while (run)
            {
                
                Console.Write("\na -> Schüler Anzeigen\n" +
                              "f -> Fehlzeit Hinzufügen\n" +
                              "u -> Unentschuldigte Fehlzeit Hinzufügen\n" +
                              "e -> Programm Beenden\nEingabe: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "a":
                        Console.WriteLine(klasse.Anzeigen());
                        break;
                    case "f":
                        bool runFehlzeit = true;
                        string tempKennung = "";
                        int tempFehlzeit = 0;
                        while (runFehlzeit)
                        {
                            Console.WriteLine("\nb <- Back\n" +
                                              "Fehlzeit Hinzufügen:" +
                                              "\nk -> Kennung: " + tempKennung +
                                              "\nz -> Fehlzeit: " + tempFehlzeit + 
                                              "\nf -> Fertig");

                            input = Console.ReadLine();

                            switch (input)
                            {
                                case "b":
                                    runFehlzeit = false;
                                    break;
                                case "k":
                                    Console.Write("\nKennung eingeben: ");
                                    input = Console.ReadLine();
                                    tempKennung = input;
                                    break;
                                case "z":
                                    Console.Write("\nFehlstunden eingeben: ");
                                    try
                                    {
                                        input = Console.ReadLine();
                                        tempFehlzeit = Convert.ToInt32(input);
                                    }
                                    catch (Exception e)
                                    {
                                        input = "";
                                    }
                                    break;
                                case "f":
                                    try
                                    {
                                        klasse.addFehlzeiten(tempKennung, tempFehlzeit);
                                        klasse.UpdateState();
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e);
                                    }
                                    break;
                                default:
                                    input = "";
                                    throw new Exception("Keine Gültige eingabe!");
                                    break;
                            }

                            input = "";
                        }
                        break;
                    case "u":
                        bool runUFehlzeit = true;
                        string tempKennung2 = "";
                        int tempUFehlzeit = 0;
                        while (runUFehlzeit)
                        {
                            Console.WriteLine("\nb <- Back\n" +
                                              "Unentschuldigte Fehlzeit Hinzufügen:" +
                                              "\nk -> Kennung: " + tempKennung2 +
                                              "\nz -> Unentschuldigte Fehlzeit: " + tempUFehlzeit + 
                                              "\nf -> Fertig");
                            
                            input = Console.ReadLine();


                            switch (input)
                            {
                                case "b":
                                    runUFehlzeit = false;
                                    break;
                                case "k":
                                    Console.Write("\nKennung eingeben: ");
                                    input = Console.ReadLine();
                                    tempKennung2 = input;
                                    break;
                                case "z":
                                    Console.Write("\nUnentschuldigte Fehlstunden eingeben: ");
                                    try
                                    {
                                        input = Console.ReadLine();
                                        tempUFehlzeit = Convert.ToInt32(input);
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e);
                                        input = "";
                                        
                                    }
                                    break;
                                case "f":
                                    try
                                    {
                                        klasse.addUnentschuldigtenFehlzeiten(tempKennung2, tempUFehlzeit);
                                        klasse.UpdateState();
                                    }
                                    catch (Exception e)
                                    {
                                        input = "";
                                        
                                    }
                                    break;
                                default:
                                    input = "";
                                    throw new Exception("Keine Gültige eingabe!");
                                    break;
                            }

                            input = "";
                            
                        }
                        break;
                    case "e":
                        Console.WriteLine("Bye...");
                        run = false;
                        break;
                    default:
                        throw new Exception("Keine Gültige eingabe!");
                        break;
                }

                input = "";
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }
    
}