using System.Collections;

namespace Übung_7;

public class SaveState
{
    private Schueler[] schuelerListe = new Schueler[30];
    private string info;
    


    public void Read()
    {
        StreamReader streamReader = new StreamReader("bbm3h20.txt");
        
        while (!streamReader.EndOfStream)
        {
            string temp = streamReader.ReadLine();
            
            if (!(temp.StartsWith("//")))
            {
                for (int i = 0; i < schuelerListe.Length; i++)
                {
                    if (schuelerListe[i] == null)
                    {
                        string[] temp1 = temp.Split(";");

                        for (int j = 0; j < temp1.Length; j++)
                        {
                            temp1[j] = temp1[j].Replace(" ", "");
                        }
                        
                        schuelerListe[i] = new Schueler(
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
                info = temp;
            }
        }
        
        streamReader.Close();
    }

    public void Write()
    {
        StreamWriter streamWriter = new StreamWriter("bbm3h20.txt", false);

        streamWriter.WriteLine(info);
        
        foreach (Schueler vSchuelerArray in schuelerListe)
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