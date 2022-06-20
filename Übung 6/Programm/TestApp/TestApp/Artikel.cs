namespace TestApp;

public class Artikel
{
    private string _name;

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (!(value == null))
            {
                _name = value;
            }
        }
    }

    private string _einheit;

    public string Einheit
    {
        get;
        set;
    }

    private int _menge;

    public int Menge
    {
        get;
        set;
    }

    public Artikel(string name, string einheit, int menge)
    {
        Name = name;
        Einheit = einheit;
        Menge = menge;
    }
}