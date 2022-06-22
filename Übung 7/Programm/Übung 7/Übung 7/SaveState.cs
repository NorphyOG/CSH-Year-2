using System.Collections;

namespace Übung_7;

public class SaveState
{
    private Schueler[] _schuelerListe = new Schueler[30];
    private string _info;

    public Schueler[] SchuelerListe
    {
        get => _schuelerListe;
        set => _schuelerListe = value ?? throw new ArgumentNullException(nameof(value));
    }


    public void Read()
    {
        StreamReader streamReader = new StreamReader("bbm3h20.txt");
        
        while (!streamReader.EndOfStream)
        {
            string temp = streamReader.ReadLine();
            
            if (!(temp.StartsWith("//")))
            {

                if (temp == "" || temp == null)
                {
                    temp = "none;none;none;0;0";
                }
                
                for (int i = 0; i < _schuelerListe.Length; i++)
                {
                    if (_schuelerListe[i] == null)
                    {
                        
                        string[] temp1 = temp.Split(";");
                        


                        for (int j = 0; j < temp1.Length; j++)
                        {
                            temp1[j] = temp1[j].Replace(" ", "");
                        }
                        
                        _schuelerListe[i] = new Schueler(
                            temp1[0], 
                            temp1[1], 
                            temp1[2], 
                            Convert.ToInt32(temp1[3]), 
                            Convert.ToInt32(temp1[4])
                        );
                        break;
                        
                    }
                }
            }
            else
            {
                _info = temp;
            }
        }
        
        streamReader.Close();
    }

    public void Write()
    {
        StreamWriter streamWriter = new StreamWriter("bbm3h20.txt", false);

        streamWriter.WriteLine(_info);
        
        foreach (Schueler vSchuelerArray in _schuelerListe)
        {
            string temp = "";
            if (vSchuelerArray != null)
            {
                temp += vSchuelerArray.Nachname + ";" + vSchuelerArray.Vorname + ";" + vSchuelerArray.Kennung + ";" + vSchuelerArray.Fehlzeiten + ";" + vSchuelerArray.UnentschuldigtenFehlzeiten;
            }
            streamWriter.WriteLine(temp);
        }
        streamWriter.Close();
    }
}