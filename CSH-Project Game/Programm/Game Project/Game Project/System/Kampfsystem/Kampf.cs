using Game_Project.Character;
using Game_Project.Character.Klassen;

namespace Game_Project.Kampfsystem;

public class Kampf
{
    public void AddXp(SaveState saveState, CreateCharacter createCharacter, StandardKlasse standardKlasse, double xp)
    {
        standardKlasse.AktuelleErfahrung += xp;

        bool run = true;
        while (run){

            if (standardKlasse.AktuelleErfahrung >= standardKlasse.MaxErfahrung){
                standardKlasse.AktuelleErfahrung = (standardKlasse.AktuelleErfahrung - standardKlasse.MaxErfahrung);
                LevelUp(standardKlasse);
            } else {
                run = false;
            }
            if (standardKlasse.AktuelleErfahrung <= standardKlasse.MaxErfahrung){
                run = false;
            }
            
        }
        
        saveState.Save(createCharacter);
    }

    private void LevelUp(StandardKlasse standardKlasse)
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
        
}