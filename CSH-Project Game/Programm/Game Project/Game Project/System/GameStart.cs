using Game_Project.Character;
using Game_Project.Character.Enemy;
using Game_Project.Character.Klassen;
using Game_Project.Menu;

namespace Game_Project;

public class GameStart
{
    private SaveState _saveState = new SaveState();
    private CreateCharacter _createCharacter;
    
    //Menu
    StandardMenu _standardMenu = new Klassenauswahl();
    Klassenauswahl _klassenauswahl = new Klassenauswahl();

    internal void Start()
    {
        try
        {
            _createCharacter = _saveState.Load();
        }
        catch (Exception e)
        {
            CreateDefault();
        }

        _klassenauswahl.KaMenu0(_createCharacter, _klassenauswahl);
        
    }

    private void CreateDefault()
    {
        _createCharacter = new CreateCharacter(
            new StandardKlasse("Bogenschütze", 1, 10, 0, 1, 75, 75, 15, 15, 5),
            new StandardKlasse("Ritter", 1, 10, 0, 1, 100, 100, 5, 5, 5),
            new StandardKlasse("Magier", 1, 10, 0, 1,50, 50, 20, 20, 5),
            new Begleiter("Antonio", 1, 10, 0, 1, 250, 250, 0, 0, 5),
            new Begleiter("Adrian", 1, 10, 0, 3, 65, 65, 10, 10, 5),
            new Begleiter("Johannes", 1, 10, 0, 2, 125, 125, 5, 5, 5),
            new StandardEnemy("Goblin", 1, 8, 10, 10),
            new MiniBoss("Goblin Mini Boss", 1, 15, 75, 75),
            new Boss("Goblin Boss", 1, 35, 200, 200), 
            new StandardEnemy("Oger", 1, 10, 30, 30),
            new MiniBoss("Oger Mini Boss", 1, 35, 150, 150),
            new Boss("Oger Boss", 1, 50, 300, 300),
            new StandardEnemy("Cyclope", 1, 30, 150, 150),
            new MiniBoss("Cyclope Mini Boss", 1, 80, 350, 350),
            new Boss("Cyclope Boss", 1, 200, 1000, 1000)
            );

        try
        {
            _saveState.Save(_createCharacter);
        }
        catch (Exception e)
        {
            //TODO
        }
    }
    
    
}