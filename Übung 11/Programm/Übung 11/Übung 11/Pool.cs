namespace Übung_11;

public class Pool
{
    private string _name;

    public Pool(string name, int platz)
    {
        _name = name;
        _platz = platz;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private int _platz;

    public int Platz
    {
        get
        {
            return _platz;
        }
        set
        {
            _platz = value;
        }
    }

    private List<Schueler> _schuelerList;

    public List<Schueler> SchuelerList
    {
        get
        {
            return _schuelerList;
        }
        set
        {
            _schuelerList = value;
        }
    }
    
    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Platz)}: {Platz}, {nameof(SchuelerList)}: {SchuelerList}";
    }


    public void FillPool(SchulKlasse schulKlasse)
    {
        SchuelerList = new List<Schueler>();
        if (schulKlasse.SchuelerList.Count <= Platz)
        {
            List<int> usedSchuler = new List<int>();
            for (int i = 0; i < schulKlasse.SchuelerList.Count; i++)
            {
                Random random = new Random();
                int num;
                
                do
                { 
                    num = random.Next(schulKlasse.SchuelerList.Count);
                } while (usedSchuler.Contains(num));
                
                SchuelerList.Add(schulKlasse.SchuelerList.ElementAt(num));
                usedSchuler.Add(num);
            }
            

        }
    }
}