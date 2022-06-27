using Game_Project.Character;
using Game_Project.Character.Klassen;

namespace Game_Project.Menu;

public class KampfMenu : StandardMenu
{
    public void KpfMenu0(StandardKlasse standardKlasse, Klassenauswahl klassenauswahl, CreateCharacter createCharacter)
    {
        
        string[] lineStrings = new string[14];

        lineStrings[0] = "╔════════════════════════════════════════════════════════════{ RPG Mini Game }════════════════════════════════════════════════════════════╗";
        lineStrings[1] = "║                                                                Haubtmenu                                                                ║";
        lineStrings[2] = "╠═══════════════════════════════════════════════════════════════════════════════════════════╦═════════════════════════════════════════════╣";
        lineStrings[3] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "› " + standardKlasse.CharacterName, "║");
        lineStrings[4] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " Im Kampfsystem kannst du kleine Mobs und Bosse Töten um XP", "║", "¦ Level " + standardKlasse.Level, "║");
        lineStrings[5] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " zu bekommen und stärker zu werden!", "║", "¦ Attack " + FormatNumberULong(standardKlasse.Schaden), "║");
        lineStrings[6] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ Leben " + FormatNumberULong(standardKlasse.AktuellesLeben) + "/" + FormatNumberULong(standardKlasse.MaxLeben), "║");
        lineStrings[7] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " Um deine Skills zu Verbessern kannst du in das Upgrade Menu gehen...", "║", "¦ AP " + FormatNumberULong(standardKlasse.AktuelleActionPoints) + "/" + FormatNumberULong(standardKlasse.MaxActionPoints), "║");
        lineStrings[8] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ Skill Points " + FormatNumberULong(standardKlasse.SkillPoints), "║");
        lineStrings[9] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " Mit Level 10 kannst du dir außerdem einen Begleiter besorgen...", "║", "¦ XP " + FormatNumberDouble(standardKlasse.AktuelleErfahrung) + "/" + FormatNumberDouble(standardKlasse.MaxErfahrung), "║");
        lineStrings[10] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", XpBar(standardKlasse), "║");
        lineStrings[11] = "╠═════════════════════════════════════════════╦═════════════════════════════════════════════╬═════════════════════════════════════════════╣";
        lineStrings[12] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Kampf/1", "║", "›Eingebe Upgrade/2", "║", "›Eingebe Klasse/3", "║");
        lineStrings[13] = "╠═════════════════════════════════════════════╩═════════════════════════════════════════════╩═════════════════════════════════════════════╝";

        foreach (var vLine in lineStrings)
        {
            Console.WriteLine(vLine);
        }

        Console.Write("╚› ");
        
        bool run = true;
        while (run)
        {
            
            string input = Console.ReadLine();
            try
            {
                input = input.ToLower();
            }
            catch (Exception e)
            {
                //TODO
            }

            switch (input)
            {
                case "1":
                    //TODO
                    break;
                case "kampf":
                    //TODO
                    break;
                case "2":
                    //TODO
                    break;
                case "upgrade":
                    //TODO
                    break;
                case "3":
                    klassenauswahl.KaMenu0(createCharacter, klassenauswahl);
                    break;
                case "klasse":
                    klassenauswahl.KaMenu0(createCharacter, klassenauswahl);
                    break;
                default:
                    Console.WriteLine("\n≡");
                    Console.Write("╚› ");
                    break;
            }
        }
        
    }
}