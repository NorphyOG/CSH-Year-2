namespace Übung_6.Schiffe;

public class FrachtSchiff : Schiff
{
    private int _maxLadung;

    public int MaxLadung
    {
        get
        {
            return _maxLadung;
        }
        set
        {
            if (!(value == null) && value > 0)
            {
                _maxLadung = value;
            } 
        }
    }

    private int _aktuelleLadung;

    public int AktuelleLadung
    {
        get
        {
            return _aktuelleLadung;
        }
        set
        {
            if (value <= 0 && value <= MaxLadung)
            {
                _aktuelleLadung = value;
            }
            else
            {
                throw new Exception("Darf nicht weniger als 0 sein und nicht mehr als überhaubt drauf passt!");
            }
        }
    }

    public FrachtSchiff(string schiffsName, Person kapitaPerson, int besatzungsGeroesse, Person[] besatzung, int maxLadung, int aktuelleLadung) : base(schiffsName, kapitaPerson, besatzungsGeroesse, besatzung)
    {
        _maxLadung = maxLadung;
        _aktuelleLadung = aktuelleLadung;
    }
    
    public bool Entladen(int menge)
    {
        try
        {
            AktuelleLadung = AktuelleLadung - menge;
            return true;
        }
        catch (Exception e)
        {
            AktuelleLadung = 0;
            Console.WriteLine("Alles was da war wurde Entaden!");
            return false;
        }
    }

    public bool Beladen(int menge)
    {
        try
        {
            AktuelleLadung = AktuelleLadung + menge;
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Wurde Full Geladen!");
            return false;
        }
    }
    
    public string PersonenlisteAnzeigen()
    {
        string outBesatung = "";
        for (int i = 0; i < Besatzung.Length; i++)
        {
            outBesatung += "Matrose " + i+1 + ":\nName -> " + Besatzung[i].Name +
                           "\nGeburtstag -> " + Besatzung[i].GebDateTime.Day + "." + Besatzung[i].GebDateTime.Month + "." + Besatzung[i].GebDateTime.Year +
                           "\n";
        }
        
        return "Kapitän:\nName -> " + KapitaPerson.Name +
               "\nGeburtstag -> " + KapitaPerson.GebDateTime.Day + "." + KapitaPerson.GebDateTime.Month + "." + KapitaPerson.GebDateTime.Year +
               "\n\n" + outBesatung;
    }
    
}