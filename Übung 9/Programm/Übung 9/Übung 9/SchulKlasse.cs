namespace Übung_9;

public class SchulKlasse
{
    private string _name;

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

    public SchulKlasse(string name, List<Schueler> schuelerList)
    {
        _name = name;
        _schuelerList = schuelerList;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(SchuelerList)}: {SchuelerList}";
    }
}