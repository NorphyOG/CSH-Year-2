using Game_Project.Character;
using Game_Project.Character.Klassen;

namespace Game_Project.Kampfsystem;

public class Kampf
{
    public void AddXp(SaveState saveState, CreateCharacter createCharacter, StandardKlasse standardKlasse, double xp)
    {
        double xpState = standardKlasse.AktuelleErfahrung + xp;

        while (xpState > 0)
        {
            if (xpState >= standardKlasse.MaxErfahrung)
            {
                xpState -= standardKlasse.MaxErfahrung;

                LevelUp(standardKlasse);
            }
        }
        saveState.Save(createCharacter);
    }

    private void LevelUp(StandardKlasse standardKlasse)
    {
        standardKlasse.Level++;
        standardKlasse.MaxErfahrung += 10;
        standardKlasse.SkillPoints++;
        standardKlasse.MaxActionPoints++;
        standardKlasse.MaxLeben += 10;
    }
        
}