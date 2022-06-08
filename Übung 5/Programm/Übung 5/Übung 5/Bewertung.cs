namespace Übung_5;

public class Bewertung
{
    private int stern;
    public int Stern
    {
        get
        {
            return stern;
        }
        set
        {
            if (value >= 0)
            {
                if (value <= 5)
                {
                    stern = value;
                }
                else
                {
                    throw new Exception("Darf nicht über 5 sein!");
                }
            }
            else
            {
                throw new Exception("Darf nicht weniger als 0 sein!");
            }
        }
    }

    private string kommentar;
    public string Kommentar
    {
        get
        {
            return kommentar;
        }
        set
        {
            kommentar = value;
        }
    }
}