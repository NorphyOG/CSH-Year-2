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
    
    
}