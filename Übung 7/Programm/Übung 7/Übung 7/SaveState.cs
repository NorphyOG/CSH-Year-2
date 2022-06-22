using System.Collections;

namespace Übung_7;

public class SaveState
{
    private Array[] liste = new Array[30];
    

    public void Read()
    {
        StreamReader streamReader = new StreamReader("bbm3h20.txt");
        
        while (!streamReader.EndOfStream)
        {
            string temp = streamReader.ReadLine();
            
            if (!(temp.StartsWith("//")))
            {
                for (int i = 0; i < liste.Length; i++)
                {
                    if (liste[i] == null)
                    {
                        liste[i] = temp.Split(";");
                        break;
                    }
                }
            }
        }
        
        streamReader.Close();
    }
}