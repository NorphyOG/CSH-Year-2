namespace Übung_14;

[Serializable]
public class Artikel
{
    public string Artikelname
    {
        get; set;
        
    }

    public int Anzahl
    {
        get; set;
        
    }

    public Artikel(string artikelname, int anzahl)
    {
        Artikelname = artikelname;
        Anzahl = anzahl;
    }

    public override string ToString()
    {
        return $"Artikelname: {Artikelname}, Anzahl: {Anzahl}";
    }
}