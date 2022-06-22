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
        get;
        set;
    }

    public string Nachname
    {
        get;
        set;
    }

    public string Kennung
    {
        get;
        set;
    }

    public int Fehlzeiten
    {
        get;
        set;
    }

    public int UnentschuldigtenFehlzeiten
    {
        get;
        set;
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