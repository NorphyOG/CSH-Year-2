namespace Übung_7;

public class Schueler
{
    private string _vorname;
    private string _nachname;
    private string _kennung;
    private int _fehlzeiten;
    private int _unentschuldigtenFehlzeiten;

    public string Vorname
    {
        get
        {
            return _vorname;
        }
    }

    public string Nachname
    {
        get
        {
            return _nachname;
        }
    }

    public string Kennung
    {
        get
        {
            return _kennung;
        }
    }

    public int Fehlzeiten
    {
        get
        {
            return _fehlzeiten;
        }
    }

    public int UnentschuldigtenFehlzeiten
    {
        get
        {
            return _unentschuldigtenFehlzeiten;
        }
    }

    public Schueler(string vorname, string nachname, string kennung, int fehlzeiten, int unentschuldigtenFehlzeiten)
    {
        _vorname = vorname;
        _nachname = nachname;
        _kennung = kennung;
        _fehlzeiten = fehlzeiten;
        _unentschuldigtenFehlzeiten = unentschuldigtenFehlzeiten;
    }
}