namespace Übung_9;

public class Schueler
{
    private string _vorName;

    public string VorName
    {
        get
        {
            return _vorName;
        }
        set
        {
            _vorName = value;
        }
    }

    private string _nachName;

    public string Nachname
    {
        get
        {
            return _nachName;
        }
        set
        {
            _nachName = value;
        }
    }

    public Schueler(string vorName, string nachName)
    {
        _vorName = vorName;
        _nachName = nachName;
    }

    public override string ToString()
    {
        return $"{nameof(VorName)}: {VorName}, {nameof(Nachname)}: {Nachname}";
    }
}