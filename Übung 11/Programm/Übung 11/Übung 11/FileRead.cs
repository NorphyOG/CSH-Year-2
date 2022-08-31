namespace Übung_11;

public class FileRead
{
    
    private string[] paths = {
        "bbm3h15.txt",
        "bbm3h20.txt",
        "pools.txt"
    };
    
    
    public void ReadAllFiles(Dictionary<string, SchulKlasse> schulKlassen, List<Pool> pools)
    {
        foreach (var vPath in paths)
        {
            string[] lines = ReadFile(vPath);

            List<Schueler> schuelers = new List<Schueler>();

            foreach (var vLine in lines)
            {
                if (!vLine.StartsWith("//"))
                {
                    string[] lineSplit = vLine.Split(",");

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
                        Schueler schueler = new Schueler(values[0], values[2], values[1]);
                        schuelers.Add(schueler);
                    }
                }
            }
            
            string[] klassenName = vPath.Split(".");
            if (!klassenName[0].StartsWith("po"))
            {
                schulKlassen.Add(klassenName[0], new SchulKlasse(schuelers));    
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