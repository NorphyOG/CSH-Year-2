using Game_Project.Character;
using Game_Project.Character.Enemy;
using Game_Project.Character.Klassen;

namespace Game_Project;

public class SaveState
{
    private string path = "save.txt";
    
    public void Save(CreateCharacter createCharacter)
    {
        StreamWriter streamWriter = new StreamWriter(path, false);
        
        streamWriter.WriteLine(createCharacter.BogenSchuetze + "|" + createCharacter.Ritter + "|" + createCharacter.Megier + "|" + createCharacter.Antonio + "|" +
                               createCharacter.Adrian + "|" + createCharacter.Johannes + "|" + createCharacter.Goblin + "|" + createCharacter.GoblinMiniBoss + "|" +
                               createCharacter.GoblinBoss + "|" + createCharacter.Oger + "|" + createCharacter.OgerMiniBoss + "|" + createCharacter.OgerBoss + "|" +
                               createCharacter.Cyclope + "|" + createCharacter.CyclopeMiniBoss + "|" + createCharacter.CyclopeBoss);
        
        streamWriter.Close();
    }
    
    public CreateCharacter Load()
    {
        string saveDate = "";
        
        StreamReader streamReader = new StreamReader(path);
            
        while (!streamReader.EndOfStream)
        {
            saveDate += streamReader.ReadLine();
        }

        string[] temp0 = saveDate.Split("|");
        
        StandardKlasse _bogenSchuetze = null;
        StandardKlasse _ritter = null;
        StandardKlasse _megier = null;

        Begleiter _antonio = null;
        Begleiter _adrian = null;
        Begleiter _johannes = null;

        StandardEnemy _goblin = null;
        MiniBoss _goblinMiniBoss = null;
        Boss _goblinBoss = null;
    
        StandardEnemy _oger = null;
        MiniBoss _ogerMiniBoss = null;
        Boss _ogerBoss = null;
    
        StandardEnemy _cyclope = null;
        MiniBoss _cyclopeMiniBoss = null;
        Boss _cyclopeBoss = null;
        
        for (int i = 0; i < temp0.Length; i++)
        {
            string[] temp1 = temp0[i].Split(";");

            switch (i)
            {
                case 0:
                    _bogenSchuetze = new StandardKlasse(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]),
                        Convert.ToUInt64(temp1[5]),
                        Convert.ToUInt64(temp1[6]),
                        Convert.ToUInt64(temp1[7]),
                        Convert.ToUInt64(temp1[8]),
                        Convert.ToUInt64(temp1[9]));
                    break;
                case 1:
                    _ritter = new StandardKlasse(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]),
                        Convert.ToUInt64(temp1[5]),
                        Convert.ToUInt64(temp1[6]),
                        Convert.ToUInt64(temp1[7]),
                        Convert.ToUInt64(temp1[8]),
                        Convert.ToUInt64(temp1[9]));
                    break;
                case 2:
                    _megier = new StandardKlasse(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]),
                        Convert.ToUInt64(temp1[5]),
                        Convert.ToUInt64(temp1[6]),
                        Convert.ToUInt64(temp1[7]),
                        Convert.ToUInt64(temp1[8]),
                        Convert.ToUInt64(temp1[9]));
                    break;
                case 3:
                    _antonio = new Begleiter(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]),
                        Convert.ToUInt64(temp1[5]),
                        Convert.ToUInt64(temp1[6]),
                        Convert.ToUInt64(temp1[7]),
                        Convert.ToUInt64(temp1[8]),
                        Convert.ToUInt64(temp1[9]));
                    break;
                case 4:
                    _adrian = new Begleiter(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]),
                        Convert.ToUInt64(temp1[5]),
                        Convert.ToUInt64(temp1[6]),
                        Convert.ToUInt64(temp1[7]),
                        Convert.ToUInt64(temp1[8]),
                        Convert.ToUInt64(temp1[9]));
                    break;
                case 5:
                    _johannes = new Begleiter(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]),
                        Convert.ToUInt64(temp1[5]),
                        Convert.ToUInt64(temp1[6]),
                        Convert.ToUInt64(temp1[7]),
                        Convert.ToUInt64(temp1[8]),
                        Convert.ToUInt64(temp1[9]));
                    break;
                case 6:
                    _goblin = new StandardEnemy(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 7:
                    _goblinMiniBoss = new MiniBoss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 8:
                    _goblinBoss = new Boss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 9:
                    _oger = new StandardEnemy(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 10:
                    _ogerMiniBoss = new MiniBoss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 11:
                    _ogerBoss = new Boss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 12:
                    _cyclope = new StandardEnemy(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 13:
                    _cyclopeMiniBoss = new MiniBoss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 14:
                    _cyclopeBoss = new Boss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                default:
                    throw new Exception("To Many Character in save.txt");
                    break;
            }

        }

        streamReader.Close();
        
        return new CreateCharacter(_bogenSchuetze, _ritter, _megier, _antonio, _adrian, _johannes,
            _goblin, _goblinMiniBoss, _goblinBoss, _oger, _ogerMiniBoss, _ogerBoss, _cyclope, _cyclopeMiniBoss,
            _cyclopeBoss);
    }
}