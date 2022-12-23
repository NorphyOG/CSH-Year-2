namespace Übung_15;

public class Menu
{
    public void MenuOne(List<Person> persons, ElektronischesTelefonbuch filesTelefonbuchtate)
    {
        filesTelefonbuchtate.ReadAllFiles();
     while (true)
        {
            string input;

            Console.WriteLine("{0, -20}:{1, -3}", "Standartsuche", "1");
            Console.WriteLine("{0, -20}:{1, -3}", "Rückwertssuche", "2");
            Console.WriteLine("{0, -20}:{1, -3}", "Liste anzeigen", "3");
            Console.WriteLine("{0, -20}:{1, -3}", "Beenden", "4");
            Console.Write("{0, -20}:{1, 0}", "Eingabe: ", "");
            input = Console.ReadLine();


            switch (input)
            {
                case "1":
                    //Standartsuche
                    filesTelefonbuchtate.StandardSuche();
                    break;
                case "2":
                    //Rückwertssuche
                   filesTelefonbuchtate.RueckwaertsSuche();
                    break;
                case "3":
                    //Liste anzeigen
                    Console.WriteLine();
                    foreach (var vPerson in persons)
                    {
                        Console.WriteLine(vPerson);
                    }
                    break;
                case "4":
                    //Beenden
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Keine Gültige eingabe!!");
                    break;
            }
            filesTelefonbuchtate.save();
        }
    }
}