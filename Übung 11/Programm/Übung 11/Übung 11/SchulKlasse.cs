namespace Übung_11;

public class SchulKlasse
{

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

    public SchulKlasse(List<Schueler> schuelerList)
    {
        _schuelerList = schuelerList;
    }

    
}