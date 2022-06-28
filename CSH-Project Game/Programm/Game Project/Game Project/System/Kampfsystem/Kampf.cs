using Game_Project.Character;
using Game_Project.Character.Enemy;
using Game_Project.Character.Klassen;

namespace Game_Project.Kampfsystem;

public class Kampf
{
    public void AddXp(SaveState saveState, CreateCharacter createCharacter, StandardKlasse standardKlasse, double xp, StandardEnemy standardEnemy)
    {
        standardKlasse.AktuelleErfahrung += xp;

        bool run = true;
        while (run){

            if (standardKlasse.AktuelleErfahrung >= standardKlasse.MaxErfahrung){
                standardKlasse.AktuelleErfahrung = (standardKlasse.AktuelleErfahrung - standardKlasse.MaxErfahrung);
                LevelUp(standardKlasse, standardEnemy);
            } else {
                run = false;
            }
            if (standardKlasse.AktuelleErfahrung <= standardKlasse.MaxErfahrung){
                run = false;
            }
            
        }
        
        saveState.Save(createCharacter);
    }

    private void LevelUp(StandardKlasse standardKlasse, StandardEnemy standardEnemy)
    {
        if (standardKlasse.Level <= 25)
        {
            standardKlasse.Level++;
            standardKlasse.MaxErfahrung += 10;
            standardKlasse.SkillPoints++;
            standardKlasse.MaxActionPoints++;
            standardKlasse.MaxLeben += 10;
            standardKlasse.Schaden++;
        }
        
        if (standardKlasse.Level is >= 26 and <= 50)
        {
            standardKlasse.Level++;
            standardKlasse.MaxErfahrung += 20;
            standardKlasse.SkillPoints++;
            standardKlasse.MaxActionPoints++;
            standardKlasse.MaxLeben += 15;
            standardKlasse.Schaden++;
        }
        
        if (standardKlasse.Level is >= 51 and <= 100)
        {
            standardKlasse.Level++;
            standardKlasse.MaxErfahrung += 30;
            standardKlasse.SkillPoints++;
            standardKlasse.MaxActionPoints += 2;
            standardKlasse.MaxLeben += 25;
            standardKlasse.Schaden += 2;
        }
        
        if (standardKlasse.Level >= 101) //Max Stats TODO
        {
            standardKlasse.Level++;
            standardKlasse.MaxErfahrung += 50;
            standardKlasse.SkillPoints += 2;
            standardKlasse.MaxActionPoints += 5;
            standardKlasse.MaxLeben += 50;
            standardKlasse.Schaden += 5;
        }

        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            standardKlasse.MaxActionPoints++;
            standardKlasse.MaxLeben++;
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            standardKlasse.MaxLeben += 5;
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            standardKlasse.MaxActionPoints += 2;
        }
        
    }

    public void UpdateEnemy(StandardKlasse standardKlasse, StandardEnemy standardEnemy, CreateCharacter createCharacter)
    {
        SetMobNormals(createCharacter);
        
        bool run = true;
        while (run){

            if (standardEnemy.Level < standardKlasse.Level){
                
                if (standardKlasse.Level <= 25)
                {
                    standardEnemy.Level++;
                    standardEnemy.MaxLeben++;
                    standardEnemy.Schaden++;
                }
        
                if (standardKlasse.Level is >= 26 and <= 50)
                {
                    standardEnemy.Level++;
                    standardEnemy.MaxLeben += 5;
                    standardEnemy.Schaden += 2;
                }
        
                if (standardKlasse.Level is >= 51 and <= 100)
                {
                    standardEnemy.Level++;
                    standardEnemy.MaxLeben += 10;
                    standardEnemy.Schaden += 5;
                }
        
                if (standardKlasse.Level >= 101) //Max Stats TODO
                {
                    standardEnemy.Level++;
                    standardEnemy.MaxLeben += 20;
                    standardEnemy.Schaden += 15;
                }

            } else {
                run = false;
            }
            
            
        }

        standardEnemy.AktuellesLeben = standardEnemy.MaxLeben;

    }

    public void EnemyAttack(StandardEnemy standardEnemy, StandardKlasse standardKlasse, SaveState saveState, CreateCharacter createCharacter)
    {
        ulong outSchaden = 0;
        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            outSchaden = (ulong) Math.Round(standardEnemy.Schaden * 1.10, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            outSchaden = (ulong) Math.Round(standardEnemy.Schaden * 1.05, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            outSchaden = (ulong) Math.Round(standardEnemy.Schaden * 1.15, 0);
        }

        if (outSchaden <= standardKlasse.AktuellesLeben)
        {
            standardKlasse.AktuellesLeben -= outSchaden;
        }
        else
        {
            Dead(standardKlasse);
        }
        
        saveState.Save(createCharacter);
    }
    
    public void Dead(StandardKlasse standardKlasse)
    {
        standardKlasse.AktuellesLeben = 0;
        standardKlasse.IsDead = true;
        
        //TODO DEAD
    }
    private void SetMobNormals(CreateCharacter createCharacter)
    {
        
        createCharacter.Goblin.Level = 1;
        createCharacter.Goblin.Schaden = 8;
        createCharacter.Goblin.MaxLeben = 10;
        createCharacter.Goblin.AktuellesLeben = 10;

        createCharacter.GoblinMiniBoss.Level = 1;
        createCharacter.GoblinMiniBoss.Schaden = 15;
        createCharacter.GoblinMiniBoss.MaxLeben = 75;
        createCharacter.GoblinMiniBoss.AktuellesLeben = 75;
        
        createCharacter.GoblinBoss.Level = 1;
        createCharacter.GoblinBoss.Schaden = 35;
        createCharacter.GoblinBoss.MaxLeben = 200;
        createCharacter.GoblinBoss.AktuellesLeben = 200;
        
        createCharacter.Oger.Level = 1;
        createCharacter.Oger.Schaden = 10;
        createCharacter.Oger.MaxLeben = 30;
        createCharacter.Oger.AktuellesLeben = 30;
        
        createCharacter.OgerMiniBoss.Level = 1;
        createCharacter.OgerMiniBoss.Schaden = 35;
        createCharacter.OgerMiniBoss.MaxLeben = 150;
        createCharacter.OgerMiniBoss.AktuellesLeben = 150;
        
        createCharacter.OgerBoss.Level = 1;
        createCharacter.OgerBoss.Schaden = 50;
        createCharacter.OgerBoss.MaxLeben = 300;
        createCharacter.OgerBoss.AktuellesLeben = 300;
        
        createCharacter.Cyclope.Level = 1;
        createCharacter.Cyclope.Schaden = 30;
        createCharacter.Cyclope.MaxLeben = 150;
        createCharacter.Cyclope.AktuellesLeben = 150;
        
        createCharacter.CyclopeMiniBoss.Level = 1;
        createCharacter.CyclopeMiniBoss.Schaden = 80;
        createCharacter.CyclopeMiniBoss.MaxLeben = 350;
        createCharacter.CyclopeMiniBoss.AktuellesLeben = 350;
        
        createCharacter.CyclopeBoss.Level = 1;
        createCharacter.CyclopeBoss.Schaden = 200;
        createCharacter.CyclopeBoss.MaxLeben = 1000;
        createCharacter.CyclopeBoss.AktuellesLeben = 1000;

    }

    public ulong MobXp(StandardEnemy standardEnemy)
    {
        ulong xp = 0;

        string input = standardEnemy.EnemyName;
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
                case "goblin":
                    xp = 1;
                    break;
                case "goblinmini":
                    xp = 2;
                    break;
                case "goblinboss":
                    xp = 5;
                    break;
                case "oger":
                    xp = 2;
                    break;
                case "ogermini":
                    xp = 5;
                    break;
                case "ogerboss":
                    xp = 10;
                    break;
                case "cyclope":
                    xp = 5;
                    break;
                case "cyclopemini":
                    xp = 10;
                    break;
                case "cyclopeboss":
                    xp = 25;
                    break;
                default:
                    //TODO
                    break;
                
                
            }
        
        
        if (standardEnemy.Level is >= 26 and <= 50)
        {
            xp = (ulong) Math.Round(xp * 1.5, 0);
        }
        
        if (standardEnemy.Level is >= 51 and <= 100)
        {
            xp = (ulong) Math.Round(xp * 3.0, 0);
        }
        
        if (standardEnemy.Level >= 101) //Max Stats TODO
        {
            xp = (ulong) Math.Round(xp * 6.0, 0);
        }
        
        return xp;
    }

    public ulong ApSkillWert(StandardKlasse standardKlasse, ulong ap)
    {
        ulong apWert = ap;

        if (standardKlasse.Level is >= 26 and <= 50)
        {
            apWert = (ulong) Math.Round(apWert * 1.5, 0);
        }
        
        if (standardKlasse.Level is >= 51 and <= 100)
        {
            apWert = (ulong) Math.Round(apWert * 3.0, 0);
        }
        
        if (standardKlasse.Level >= 101) //Max Stats TODO
        {
            apWert = (ulong) Math.Round(apWert * 6.0, 0);
        }

        return apWert;
    }
}