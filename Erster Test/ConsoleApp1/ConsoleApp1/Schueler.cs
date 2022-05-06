namespace ConsoleApp1;

public class Schueler
{
    private string vorname;
    private string nachname;
    private DateTime gebDate;

    //Propaties
    public string Vorname
    {
        get{ return vorname; }
        set { vorname = value; }
    }

    public Schueler(string vorname, string nachname, DateTime gebDate)
    {
        this.vorname = vorname;
        this.nachname = nachname;
        this.gebDate = gebDate;
    }

    public override string ToString()
    {
        return vorname + ", " + nachname + ", " + gebDate;
    }
}