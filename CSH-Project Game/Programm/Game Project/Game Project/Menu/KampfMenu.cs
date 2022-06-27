using Game_Project.Character;
using Game_Project.Character.Enemy;
using Game_Project.Character.Klassen;
using Game_Project.Kampfsystem;

namespace Game_Project.Menu;

public class KampfMenu : StandardMenu
{
    public void KpfMenu0(StandardKlasse standardKlasse, CreateCharacter createCharacter, Klassenauswahl klassenauswahl, SaveState saveState, Skills skills, Kampf kampf)
    {
        
        string[] lineStrings = new string[18];

        lineStrings[0] = "╔════════════════════════════════════════════════════════════{ RPG Mini Game }════════════════════════════════════════════════════════════╗";
        lineStrings[1] = "║                                                                Kampfmenu                                                                ║";
        lineStrings[2] = "╠═══════════════════════════════════════════════════════════════════════════════════════════╦═════════════════════════════════════════════╣";
        lineStrings[3] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "", "║");
        lineStrings[4] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " Hier kannst du viele verschiedene Gegner Töten!", "║", "› " + standardKlasse.CharacterName, "║");
        lineStrings[5] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " jedoch sind machne Gegner etwas Stärker...", "║", "¦ Level " + standardKlasse.Level, "║");
        lineStrings[6] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ Attack " + FormatNumberULong(standardKlasse.Schaden), "║");
        lineStrings[7] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " Du kannst dich jederzeit mit einem Heil Zauber am leben halten!", "║", "¦ Leben " + FormatNumberULong(standardKlasse.AktuellesLeben) + "/" + FormatNumberULong(standardKlasse.MaxLeben), "║");
        lineStrings[8] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ AP " + FormatNumberULong(standardKlasse.AktuelleActionPoints) + "/" + FormatNumberULong(standardKlasse.MaxActionPoints), "║");
        lineStrings[9] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", " Btw das Mini hinter den ersten Mobs heißt das es ein Mini Boss ist!", "║", "¦ Skill Points " + FormatNumberULong(standardKlasse.SkillPoints), "║");
        lineStrings[10] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ XP " + FormatNumberDouble(standardKlasse.AktuelleErfahrung) + "/" + FormatNumberDouble(standardKlasse.MaxErfahrung), "║");
        lineStrings[11] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", XpBar(standardKlasse), "║");
        lineStrings[12] = "╠═════════════════════════════════════════════╦═════════════════════════════════════════════╬═════════════════════════════════════════════╣";
        lineStrings[13] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Goblin/1", "║", "›Eingebe GoblinMini/2", "║", "›Eingebe GoblinBoss/3", "║");
        lineStrings[14] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Oger/4", "║", "›Eingebe OgerMini/5", "║", "›Eingebe OgerBoss/6", "║");
        lineStrings[15] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Cyclope/7", "║", "›Eingebe CyclopeMini/8", "║", "›Eingebe CyclopeBoss/9", "║");
        lineStrings[16] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "", "║", "", "║", "›Eingebe Back/10", "║");
        lineStrings[17] = "╠═════════════════════════════════════════════╩═════════════════════════════════════════════╩═════════════════════════════════════════════╝";

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
                    KpfMenu1(standardKlasse, createCharacter.Goblin, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "goblin":
                    KpfMenu1(standardKlasse, createCharacter.Goblin, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "2":
                    KpfMenu1(standardKlasse, createCharacter.GoblinMiniBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "goblinmini":
                    KpfMenu1(standardKlasse, createCharacter.GoblinMiniBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "3":
                    KpfMenu1(standardKlasse, createCharacter.GoblinBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "goblinboss":
                    KpfMenu1(standardKlasse, createCharacter.GoblinBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "4":
                    KpfMenu1(standardKlasse, createCharacter.Oger, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "oger":
                    KpfMenu1(standardKlasse, createCharacter.Oger, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "5":
                    KpfMenu1(standardKlasse, createCharacter.OgerMiniBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "ogermini":
                    KpfMenu1(standardKlasse, createCharacter.OgerMiniBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "6":
                    KpfMenu1(standardKlasse, createCharacter.OgerBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "ogerboss":
                    KpfMenu1(standardKlasse, createCharacter.OgerBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "7":
                    KpfMenu1(standardKlasse, createCharacter.Cyclope, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "cyclope":
                    KpfMenu1(standardKlasse, createCharacter.Cyclope, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "8":
                    KpfMenu1(standardKlasse, createCharacter.CyclopeMiniBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "cyclopemini":
                    KpfMenu1(standardKlasse, createCharacter.CyclopeMiniBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "9":
                    KpfMenu1(standardKlasse, createCharacter.CyclopeBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "cyclopeboss":
                    KpfMenu1(standardKlasse, createCharacter.CyclopeBoss, createCharacter, saveState, klassenauswahl, skills, kampf);
                    break;
                case "10":
                    sMenu0(standardKlasse, klassenauswahl, createCharacter, this, saveState, skills, kampf);
                    break;
                case "back":
                    sMenu0(standardKlasse, klassenauswahl, createCharacter, this, saveState, skills, kampf);
                    break;
                default:
                    Console.WriteLine("\n≡");
                    Console.Write("╚› ");
                    break;
                
                
            }
        }
        
    }
    
    public void KpfMenu1(StandardKlasse standardKlasse, StandardEnemy standardEnemy, CreateCharacter createCharacter,SaveState saveState, Klassenauswahl klassenauswahl, Skills skills, Kampf kampf)
    {

        string[] lineStrings = new string[17];

        lineStrings[0] = "╔════════════════════════════════════════════════════════════{ RPG Mini Game }════════════════════════════════════════════════════════════╗";
        lineStrings[1] = "║                                                                Kampfmenu                                                                ║";
        lineStrings[2] = "╠═══════════════════════════════════════════════════════════════════════════════════════════╦═════════════════════════════════════════════╣";
        lineStrings[3] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "", "║");
        lineStrings[4] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "> " + standardEnemy.EnemyName , "║", "› " + standardKlasse.CharacterName, "║");
        lineStrings[5] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", ") Level " + standardEnemy.Level, "║", "¦ Level " + standardKlasse.Level, "║");
        lineStrings[6] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", ") Attack " + FormatNumberULong(standardEnemy.Schaden), "║", "¦ Attack " + FormatNumberULong(standardKlasse.Schaden), "║");
        lineStrings[7] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", ") Leben " + FormatNumberULong(standardEnemy.AktuellesLeben) + "/" + FormatNumberULong(standardEnemy.MaxLeben), "║", "¦ Leben " + FormatNumberULong(standardKlasse.AktuellesLeben) + "/" + FormatNumberULong(standardKlasse.MaxLeben), "║");
        lineStrings[8] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ AP " + FormatNumberULong(standardKlasse.AktuelleActionPoints) + "/" + FormatNumberULong(standardKlasse.MaxActionPoints), "║");
        lineStrings[9] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ Skill Points " + FormatNumberULong(standardKlasse.SkillPoints), "║");
        lineStrings[10] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", "¦ XP " + FormatNumberDouble(standardKlasse.AktuelleErfahrung) + "/" + FormatNumberDouble(standardKlasse.MaxErfahrung), "║");
        lineStrings[11] = String.Format("{0,1}{1,-91}{2,1}{3,-45}{4,1}",
            "║", "", "║", XpBar(standardKlasse), "║");
        lineStrings[12] = "╠═════════════════════════════════════════════╦═════════════════════════════════════════════╬═════════════════════════════════════════════╣";
        lineStrings[13] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Skill1/1", "║", "›Eingebe Skill2/2", "║", "›Eingebe Skill3/3", "║");
        lineStrings[14] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "", "║", "", "║", "", "║");
        lineStrings[15] = String.Format("{0,1}{1,-45}{2,1}{3,-45}{4,1}{5,-45}{6,1}",
            "║", "›Eingebe Heal/4", "║", "›Eingebe APHeal/5", "║", "›Eingebe Back/6", "║");
        lineStrings[16] = "╠═════════════════════════════════════════════╩═════════════════════════════════════════════╩═════════════════════════════════════════════╝";

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
                    skills.Skill1(standardKlasse, kampf, saveState, createCharacter);
                    break;
                case "skill1":
                    
                    break;
                case "2":

                    break;
                case "skill2":
                    
                    break;
                case "3":
                    
                    break;
                case "skill3":
                    
                    break;
                case "4":

                    break;
                case "heal":
                    
                    break;
                case "5":
                    
                    break;
                case "apheal":
                    
                    break;
                case "6":
                    KpfMenu0(standardKlasse, createCharacter, klassenauswahl, saveState, skills, kampf);
                    break;
                case "back":
                    KpfMenu0(standardKlasse, createCharacter, klassenauswahl, saveState, skills, kampf);
                    break;
                default:
                    Console.WriteLine("\n≡");
                    Console.Write("╚› ");
                    break;
                
                
            }
        }
        
    }
}