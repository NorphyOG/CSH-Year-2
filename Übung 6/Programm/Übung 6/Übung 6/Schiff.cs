namespace Übung_6;

public class Schiff
{
    private string _schiffsName;

    public string SchiffsName
    {
        get
        {
            return _schiffsName;
        }
        private set
        {
            if (!(value == null))
            {
                _schiffsName = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    private Person _kapitaPerson;

    public Person KapitaPerson
    {
        get
        {
            return _kapitaPerson;
        }
        set
        {
            if (!(value == null))
            {
                _kapitaPerson = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    private Person[] _besatzung;

    public Person[] Besatzung
    {
        get
        {
            return _besatzung;
        }
        set
        {
            if (!(value == null))
            {
                _besatzung = value;
            }
        }
    }

    public Schiff(string schiffsName, Person kapitaPerson, int besatzungsGeroesse, Person[] besatzung)
    {
        _besatzung = new Person[besatzungsGeroesse];
        SchiffsName = schiffsName;
        KapitaPerson = kapitaPerson;
        Besatzung = besatzung;
    }
}