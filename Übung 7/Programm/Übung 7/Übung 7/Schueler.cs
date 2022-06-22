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
        get => _vorname;
        set => _vorname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Nachname
    {
        get => _nachname;
        set => _nachname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Kennung
    {
        get => _kennung;
        set => _kennung = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Fehlzeiten
    {
        get => _fehlzeiten;
        set => _fehlzeiten = value;
    }

    public int UnentschuldigtenFehlzeiten
    {
        get => _unentschuldigtenFehlzeiten;
        set => _unentschuldigtenFehlzeiten = value;
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