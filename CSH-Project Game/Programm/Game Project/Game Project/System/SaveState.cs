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
                               createCharacter.GoblinBoss + "|" + createCharacter.Oga + "|" + createCharacter.OgaMiniBoss + "|" + createCharacter.OgaBoss + "|" +
                               createCharacter.Cyclope + "|" + createCharacter.CyclopeMiniBoss + "|" + createCharacter.CyclopeBoss);
        
        streamWriter.Close();
    }
    
    public bool Load(CreateCharacter createCharacter)
    {
        string saveDate = "";
        
        StreamReader streamReader = new StreamReader(path);
            
        while (!streamReader.EndOfStream)
        {
            saveDate += streamReader.ReadLine();
        }

        string[] temp0 = saveDate.Split("|");

        for (int i = 0; i < temp0.Length; i++)
        {
            string[] temp1 = temp0[i].Split(";");

            switch (i)
            {
                case 0:
                    createCharacter.BogenSchuetze = new StandardKlasse(temp1[0],
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
                    createCharacter.Ritter = new StandardKlasse(temp1[0],
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
                    createCharacter.Megier = new StandardKlasse(temp1[0],
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
                    createCharacter.Antonio = new Begleiter(temp1[0],
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
                    createCharacter.Adrian = new Begleiter(temp1[0],
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
                    createCharacter.Johannes = new Begleiter(temp1[0],
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
                    createCharacter.Goblin = new StandardEnemy(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 7:
                    createCharacter.GoblinMiniBoss = new MiniBoss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 8:
                    createCharacter.GoblinBoss = new Boss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 9:
                    createCharacter.Oga = new StandardEnemy(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 10:
                    createCharacter.OgaMiniBoss = new MiniBoss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 11:
                    createCharacter.OgaBoss = new Boss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 12:
                    createCharacter.Cyclope = new StandardEnemy(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 13:
                    createCharacter.CyclopeMiniBoss = new MiniBoss(temp1[0],
                        Convert.ToUInt64(temp1[1]),
                        Convert.ToUInt64(temp1[2]),
                        Convert.ToUInt64(temp1[3]),
                        Convert.ToUInt64(temp1[4]));
                    break;
                case 14:
                    createCharacter.CyclopeBoss = new Boss(temp1[0],
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

        return !saveDate.Equals("");
    }
}