namespace Test;

public class Spieler
{
    private String vorname;

    public string Vorname
    {
        get
        {
            return vorname;
        }
        set
        {
            if (value != null)
            {
                vorname = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    private String nachname;

    public string Nachname
    {
        get
        {
            return nachname;
        }
        set
        {
            if (value != null)
            {
                nachname = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    private DateTime geburtsdatum;

    public DateTime Geburtsdatum
    {
        get
        {
            return geburtsdatum;
        }
        set
        {
            if (value != null)
            {
                geburtsdatum = value;

            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    public Spieler(string _vorname, string _nachname, DateTime _geburtsdatum)
    {
        Vorname = _vorname;
        Nachname = _nachname;
        Geburtsdatum = _geburtsdatum;
    }
    
    public static bool operator < (Spieler a, Spieler b)
    {
        if (a.Geburtsdatum < b.Geburtsdatum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public static bool operator > (Spieler a, Spieler b)
    {
        return !(a.Geburtsdatum < b.Geburtsdatum);
    }
    
}