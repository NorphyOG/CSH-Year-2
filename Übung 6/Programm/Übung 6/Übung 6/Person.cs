namespace Übung_6;

public class Person
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
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    private DateTime _gebDateTime;

    public DateTime GebDateTime
    {
        get
        {
            return _gebDateTime;
        }
        private set
        {
            if (!(value == null))
            {
                _gebDateTime = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }

    public Person(string name, DateTime gebDateTime)
    {
        Name = name;
        GebDateTime = gebDateTime;
    }
    
    
}