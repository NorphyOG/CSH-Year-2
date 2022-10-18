namespace OperratorenUeberladen;

public class Ding
{
    private int zahl;
    private string text;

    public int Zahl
    {
        get
        {
            return zahl;
        }
        set
        {
            if (value < 0)
            {
                throw new Exception("Darf nicht minus haben oder eine 0");
            }
            else
            {
                zahl = value;
            }
        }
    }

    public string Text
    {
        get
        {
            return text;
        }
        set
        {
            if (value == null || value == "")
            {
                throw new Exception("Keine eingabe");
            }
            else
            {
                text = value;
            }
        }
    }
        

    public Ding(int zahl, string text)
    {
        Zahl = zahl;
        Text = text;
    }

    public Ding(int _zahl)
    {
        zahl = _zahl;
    }

    public Ding Addieren(Ding ding)
    {
        int z = this.zahl + ding.zahl;
        string s = this.text + " " + ding.text;
        return new Ding(z, s);
    }
    
    public static Ding operator + (Ding a, Ding b)
    {
        return new Ding(a.Zahl + b.Zahl, a.Text + " " + b.Text);
    }
    
    public static bool operator < (Ding a, Ding b)
    {
        if (a.zahl < b.zahl)
        {
            return true;
            
        }
        else
        {
            return false;
        }
    }
    
    public static bool operator > (Ding a, Ding b)
    {
        return !(a < b);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}