namespace Übung_9;

public class Pool
{
    private string _name;

    public Pool(string name, int platz)
    {
        _name = name;
        _platz = platz;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    private int _platz;

    public int Platz
    {
        get
        {
            return _platz;
        }
        set
        {
            _platz = value;
        }
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Platz)}: {Platz}";
    }
}