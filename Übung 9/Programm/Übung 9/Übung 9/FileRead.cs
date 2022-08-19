namespace Übung_9;

public class FileRead
{

    private string[] paths = {
        "bbm3h15.txt",
        "bbm3h20.txt",
        "pools.txt"
    };
    
    
    public void ReadAllFiles(List<SchulKlasse> schulKlassen, List<Pool> pools)
    {
        foreach (var vPath in paths)
        {
            string[] lines = ReadFile(vPath);

            List<Schueler> schuelers = new List<Schueler>();

            foreach (var vLine in lines)
            {
                if (!vLine.StartsWith("//"))
                {
                    string[] lineSplit = vLine.Split(";");

                    string[] values = new string[5];
                    bool isPool = false;

                    foreach (var vLineSplit in lineSplit)
                    {
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] == null)
                            {
                                values[i] = vLineSplit;
                                break;
                            }
                        }

                        try
                        {
                            int.Parse(vLineSplit);
                            isPool = true;
                        }
                        catch (Exception e)
                        {
                        }
                    }

                    if (isPool)
                    {
                        pools.Add(new Pool(values[0], int.Parse(values[1])));
                    }
                    else
                    {
                        Schueler schueler = new Schueler(values[1], values[0]);
                        schuelers.Add(schueler);
                    }
                    
                }
            }
            
            string[] klassenName = vPath.Split(".");
            if (!klassenName[0].StartsWith("po"))
            {
                schulKlassen.Add(new SchulKlasse(klassenName[0], schuelers));    
            }
            
        }
    }

    
    public string[] ReadFile(string path)
    {
        string[] line = File.ReadAllLines(path);

        if (line.Length == 0) throw new InvalidOperationException("Die Datei enthält keine Zeilen.");
        
        return line;
    }
}