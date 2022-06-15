namespace Übung_6.Schiffe;

public class Ausflugsboot : Schiff
{
    private static Person[] _passagies = new Person[10];

    public Person[] Passagies
    {
        get
        {
            return _passagies;
        }
        set
        {
            if (!(value == null))
            {
                _passagies = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein");
            }
        }
    }

    public static bool operator +(Ausflugsboot ausflugsboot, Person person)
    {
        for (int i = 0; i < _passagies.Length; i++)
        {
            if (_passagies == null)
            {
                _passagies[i] = person;
                return true;
            }
        }

        return false;
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
        
        string outPassagier = "";
        for (int i = 0; i < Passagies.Length; i++)
        {
            outPassagier += "Matrose " + i+1 + ":\nName -> " + Passagies[i].Name +
                            "\nGeburtstag -> " + Passagies[i].GebDateTime.Day + "." + Passagies[i].GebDateTime.Month + "." + Passagies[i].GebDateTime.Year +
                            "\n";
        }
        
        return "Kapitän:\nName -> " + KapitaPerson.Name +
               "\nGeburtstag -> " + KapitaPerson.GebDateTime.Day + "." + KapitaPerson.GebDateTime.Month + "." + KapitaPerson.GebDateTime.Year +
               "\n\n" + outBesatung + "\n" + outPassagier;
    }

    public int Statistik()
    {
        int returnMenge = 0;

        foreach (Person vPassagie in Passagies)
        {
            if ((vPassagie.GebDateTime > new DateTime(vPassagie.GebDateTime.Year - 18, vPassagie.GebDateTime.Month, vPassagie.GebDateTime.Day)))
            {
                returnMenge++;
            }
        }

        foreach (Person vBesatzung in Besatzung)
        {
            if ((vBesatzung.GebDateTime > new DateTime(vBesatzung.GebDateTime.Year - 18, vBesatzung.GebDateTime.Month, vBesatzung.GebDateTime.Day)))
            {
                returnMenge++;
            }
        }
        
        if ((KapitaPerson.GebDateTime > new DateTime(KapitaPerson.GebDateTime.Year - 18, KapitaPerson.GebDateTime.Month, KapitaPerson.GebDateTime.Day)))
        {
            returnMenge++;
        }
        
        return returnMenge;
    }


    public Ausflugsboot(string schiffsName, Person kapitaPerson, int besatzungsGeroesse, Person[] besatzung) : base(schiffsName, kapitaPerson, besatzungsGeroesse, besatzung)
    {
    }
}