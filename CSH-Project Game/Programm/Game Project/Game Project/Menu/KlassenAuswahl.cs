using Game_Project.Character;
using Game_Project.Character.Enemy;
using Game_Project.Kampfsystem;

namespace Game_Project.Menu;

public class Klassenauswahl : StandardMenu
{
    
    public void KaMenu0(CreateCharacter createCharacter, Klassenauswahl klassenauswahl, KampfMenu kampfMenu, SaveState saveState, Skills skills ,Kampf kampf)
    {
        Console.Clear();
        
        string[] lineStrings = new string[15];

        lineStrings[0] = "╔════════════════════════════════════════════════════════════{ RPG Mini Game }════════════════════════════════════════════════════════════╗";
        lineStrings[1] = "║                                                              Klassenauswahl                                                             ║";
        lineStrings[2] = "╠═════════════════════════════════════════════╦═════════════════════════════════════════════╦═════════════════════════════════════════════╣";
        lineStrings[3] = String.Format("{0,1}{1,45}{2,1}{3,45}{4,1}{5,45}{6,1}",
            "║", "", "║", "", "║", "", "║");
        lineStrings[4] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "› " + createCharacter.BogenSchuetze.CharacterName, "║", "› " + createCharacter.Ritter.CharacterName, "║", "› " + createCharacter.Megier.CharacterName, "║");
        lineStrings[5] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "¦ Level " + createCharacter.BogenSchuetze.Level, "║", "¦ Level " + createCharacter.Ritter.Level, "║", "¦ Level " + createCharacter.Megier.Level, "║");
        lineStrings[6] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "¦ Attack " + FormatNumberULong(createCharacter.BogenSchuetze.Schaden), "║", "¦ Attack " + FormatNumberULong(createCharacter.Ritter.Schaden),
            "║", "¦ Attack " + FormatNumberULong(createCharacter.Megier.Schaden), "║");
        lineStrings[7] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "¦ Leben " + FormatNumberULong(createCharacter.BogenSchuetze.AktuellesLeben) + "/" + FormatNumberULong(createCharacter.BogenSchuetze.MaxLeben),
            "║", "¦ Leben " + FormatNumberULong(createCharacter.Ritter.AktuellesLeben) + "/" + FormatNumberULong(createCharacter.Ritter.MaxLeben),
            "║", "¦ Leben " + FormatNumberULong(createCharacter.Megier.AktuellesLeben) + "/" + FormatNumberULong(createCharacter.Megier.MaxLeben), "║");
        lineStrings[8] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "¦ AP " + FormatNumberULong(createCharacter.BogenSchuetze.AktuelleActionPoints) + "/" + FormatNumberULong(createCharacter.BogenSchuetze.MaxActionPoints),
            "║", "¦ AP " + FormatNumberULong(createCharacter.Ritter.AktuelleActionPoints) + "/" + FormatNumberULong(createCharacter.Ritter.MaxActionPoints),
            "║", "¦ AP " + FormatNumberULong(createCharacter.Megier.AktuelleActionPoints) + "/" + FormatNumberULong(createCharacter.Megier.MaxActionPoints), "║");
        lineStrings[9] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "¦ Skill Points " + FormatNumberULong(createCharacter.BogenSchuetze.SkillPoints),
            "║", "¦ Skill Points " + FormatNumberULong(createCharacter.Ritter.SkillPoints),
            "║", "¦ Skill Points " + FormatNumberULong(createCharacter.Megier.SkillPoints), "║");
        lineStrings[10] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "¦ XP " + FormatNumberDouble(createCharacter.BogenSchuetze.AktuelleErfahrung) + "/" + FormatNumberDouble(createCharacter.BogenSchuetze.MaxErfahrung),
            "║", "¦ XP " + FormatNumberDouble(createCharacter.Ritter.AktuelleErfahrung) + "/" + FormatNumberDouble(createCharacter.Ritter.MaxErfahrung),
            "║", "¦ XP " + FormatNumberDouble(createCharacter.Megier.AktuelleErfahrung) + "/" + FormatNumberDouble(createCharacter.Megier.MaxErfahrung), "║");
        lineStrings[11] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", XpBar(createCharacter.BogenSchuetze), "║", XpBar(createCharacter.Ritter), "║", XpBar(createCharacter.Megier), "║");
        lineStrings[12] = "╠═════════════════════════════════════════════╬═════════════════════════════════════════════╬═════════════════════════════════════════════╣";
        lineStrings[13] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Bogi/1", "║", "›Eingebe Ritter/2", "║", "›Eingebe Mage/3", "║");
        lineStrings[14] = "╠═════════════════════════════════════════════╩═════════════════════════════════════════════╩═════════════════════════════════════════════╝";
        
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
                    sMenu0(createCharacter.BogenSchuetze, klassenauswahl, createCharacter, kampfMenu, saveState, skills, kampf);
                    break;
                case "bogi":
                    sMenu0(createCharacter.BogenSchuetze, klassenauswahl, createCharacter, kampfMenu, saveState, skills, kampf);
                    break;
                case "2":
                    sMenu0(createCharacter.Ritter, klassenauswahl, createCharacter, kampfMenu, saveState, skills, kampf);
                    break;
                case "ritter":
                    sMenu0(createCharacter.Ritter, klassenauswahl, createCharacter, kampfMenu, saveState, skills, kampf);
                    break;
                case "3":
                    sMenu0(createCharacter.Megier, klassenauswahl, createCharacter, kampfMenu, saveState, skills, kampf);
                    break;
                case "mage":
                    sMenu0(createCharacter.Megier, klassenauswahl, createCharacter, kampfMenu, saveState, skills, kampf);
                    break;
                default:
                    Console.WriteLine("\n≡");
                    Console.Write("╚› ");
                    break;
            }
        }
    }
}