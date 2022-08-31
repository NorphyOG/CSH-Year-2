namespace Übung_11;

public class Schueler
{
    private string _kennung;

    public string Kennung
    {
        get
        {
            return _kennung;
        }
        set
        {
            _kennung = value;
        }
    }
    
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

    public Schueler(string kenneung, string vorName, string nachName)
    {
        _kennung = kenneung;
        _vorName = vorName;
        _nachName = nachName;
    }

    public override string ToString()
    {
        return $"{nameof(Kennung)}: {Kennung}, {nameof(VorName)}: {VorName}, {nameof(Nachname)}: {Nachname}";
    }
}