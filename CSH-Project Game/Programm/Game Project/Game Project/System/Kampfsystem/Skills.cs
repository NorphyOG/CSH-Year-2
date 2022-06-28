using Game_Project.Character;
using Game_Project.Character.Enemy;
using Game_Project.Character.Klassen;

namespace Game_Project.Kampfsystem;

public class Skills
{

    public void Skill1(StandardKlasse standardKlasse, Kampf kampf, SaveState saveState, CreateCharacter createCharacter, StandardEnemy standardEnemy)
    {
        Console.Write(" XP Cheat Skill : ");
        string xp = Console.ReadLine();
        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            kampf.AddXp(saveState, createCharacter, standardKlasse, Convert.ToUInt64(xp), standardEnemy);
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            kampf.AddXp(saveState, createCharacter, standardKlasse, Convert.ToUInt64(xp), standardEnemy);
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            kampf.AddXp(saveState, createCharacter, standardKlasse, Convert.ToUInt64(xp), standardEnemy);
        }
    }

    private bool isEnemyDead(StandardEnemy standardEnemy, ulong dmg)
    {
        return dmg >= standardEnemy.AktuellesLeben;
    }
    
    public void Skill2(StandardKlasse standardKlasse, StandardEnemy standardEnemy, SaveState saveState, CreateCharacter createCharacter, Kampf kampf)
    {
        ulong apKosten = kampf.ApSkillWert(standardKlasse, 1);

        if (isEnemyDead(standardEnemy, standardKlasse.Schaden))
        {
            ApHeal(standardKlasse, saveState, createCharacter);
            Heal(standardKlasse, saveState, createCharacter);
            
            kampf.AddXp(saveState, createCharacter, standardKlasse, kampf.MobXp(standardEnemy), standardEnemy);

            standardKlasse.AktuelleActionPoints -= apKosten;
        }

        if (RemoveHeal(standardKlasse, apKosten))
        {
            standardKlasse.AktuelleErfahrung -= apKosten;
        }
        
        saveState.Save(createCharacter);
    }

    public void Skill3(StandardKlasse standardKlasse, SaveState saveState, CreateCharacter createCharacter, StandardEnemy standardEnemy, Kampf kampf)
    {
        ulong schaden = 0;
        ulong apKosten = kampf.ApSkillWert(standardKlasse, 5);

        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            schaden = (ulong) Math.Round(standardKlasse.Schaden * 1.03, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            schaden = (ulong) Math.Round(standardKlasse.Schaden * 1.05, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            schaden = (ulong) Math.Round(standardKlasse.Schaden * 1.02, 0);
        }
        
        if (isEnemyDead(standardEnemy, schaden))
        {
            ApHeal(standardKlasse, saveState, createCharacter);
            Heal(standardKlasse, saveState, createCharacter);
            
            kampf.AddXp(saveState, createCharacter, standardKlasse, kampf.MobXp(standardEnemy), standardEnemy);
            
            standardKlasse.AktuelleActionPoints -= apKosten;
        }

        if (RemoveHeal(standardKlasse, apKosten))
        {
            standardKlasse.AktuelleErfahrung -= apKosten;
        }
        
        saveState.Save(createCharacter);
    }
    
    public void Skill4(StandardKlasse standardKlasse, SaveState saveState, CreateCharacter createCharacter, StandardEnemy standardEnemy, Kampf kampf)
    {
        ulong schaden = 0;
        ulong apKosten = kampf.ApSkillWert(standardKlasse, 20);

        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            schaden = (ulong) Math.Round(standardKlasse.Schaden * 1.03, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            schaden = (ulong) Math.Round(standardKlasse.Schaden * 1.05, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            schaden = (ulong) Math.Round(standardKlasse.Schaden * 1.02, 0);
        }
        
        if (isEnemyDead(standardEnemy, schaden))
        {
            ApHeal(standardKlasse, saveState, createCharacter);
            Heal(standardKlasse, saveState, createCharacter);
            
            kampf.AddXp(saveState, createCharacter, standardKlasse, kampf.MobXp(standardEnemy), standardEnemy);
            
            standardKlasse.AktuelleActionPoints -= apKosten;
        }

        if (RemoveHeal(standardKlasse, apKosten))
        {
            standardKlasse.AktuelleErfahrung -= apKosten;
        }
        
        saveState.Save(createCharacter);
    }
    
    public void Heal(StandardKlasse standardKlasse, SaveState saveState, CreateCharacter createCharacter)
    {
        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            standardKlasse.AktuellesLeben += (ulong) Math.Round(standardKlasse.AktuellesLeben * 1.15, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            standardKlasse.AktuellesLeben += (ulong) Math.Round(standardKlasse.AktuellesLeben * 1.20, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            standardKlasse.AktuellesLeben += (ulong) Math.Round(standardKlasse.AktuellesLeben * 1.10, 0);
        }
        
        if (standardKlasse.AktuellesLeben > standardKlasse.MaxLeben)
        {
            standardKlasse.AktuellesLeben = standardKlasse.MaxLeben;
        }
        
        saveState.Save(createCharacter);
    }
    
    public void ApHeal(StandardKlasse standardKlasse, SaveState saveState, CreateCharacter createCharacter)
    {
        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            standardKlasse.AktuelleActionPoints += (ulong) Math.Round(standardKlasse.AktuelleActionPoints * 1.04, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            standardKlasse.AktuelleActionPoints += (ulong) Math.Round(standardKlasse.AktuelleActionPoints * 1.02, 0);
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            standardKlasse.AktuelleActionPoints += (ulong) Math.Round(standardKlasse.AktuelleActionPoints * 1.08, 0);
        }
        
        if (standardKlasse.AktuelleActionPoints > standardKlasse.MaxActionPoints)
        {
            standardKlasse.AktuelleActionPoints = standardKlasse.MaxActionPoints;
        }
        
        saveState.Save(createCharacter);
    }
    
    private bool RemoveHeal(StandardKlasse standardKlasse, ulong ap)
    {
        return ap >= standardKlasse.AktuelleActionPoints;
    }
}