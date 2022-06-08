namespace Übung_5;

public class Zutat
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        
    }

    private int kcal;
    public int Kcal
    {
        get
        {
            return kcal;
        }
        set
        {
            if (value >= 0)
            {
                kcal = value;
            }
            else
            {
                throw new Exception("Darf nicht Null sein!");
            }
        }
    }
    
    private int _mengeInMg;
    public int MengeInMg
    {
        get
        {
            return _mengeInMg;
        }
        
    }

    public Zutat(string name, int kcal, int mengeInMg)
    {
        this.name = name;
        this.kcal = kcal;
        this._mengeInMg = mengeInMg;
    }
}