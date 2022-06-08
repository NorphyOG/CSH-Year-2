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
                    setSternTxt(stern);
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

    public Bewertung(int stern, string kommentar)
    {
        this.stern = stern;
        this.kommentar = kommentar;
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

    private string outputStern;
    public string OutputStern
    {
        get
        {
            setSternTxt(stern);
            return outputStern;
        }
    }

    private void setSternTxt(int stern)
    {
        outputStern = "";
        for (int i = 0; i < stern; i++)
        {
            outputStern += "*";
        }
    }
}