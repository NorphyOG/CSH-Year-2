using Game_Project.Character;
using Game_Project.Character.Klassen;

namespace Game_Project.Kampfsystem;

public class Skills
{
    public void Skill1(StandardKlasse standardKlasse, Kampf kampf, SaveState saveState, CreateCharacter createCharacter)
    {
        Console.Write("XP Cheat Skill : ");
        string xp = Console.ReadLine();
        if (standardKlasse.CharacterName.StartsWith("Bo"))
        {
            kampf.AddXp(saveState, createCharacter, standardKlasse, Convert.ToUInt64(xp));
        }

        if (standardKlasse.CharacterName.StartsWith("Ri"))
        {
            kampf.AddXp(saveState, createCharacter, standardKlasse, Convert.ToUInt64(xp));
        }

        if (standardKlasse.CharacterName.StartsWith("Ma"))
        {
            kampf.AddXp(saveState, createCharacter, standardKlasse, Convert.ToUInt64(xp));
        }
    }
}