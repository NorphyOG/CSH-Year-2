namespace Übung_6.Schiffe;

public class FrachtSchiff : Schiff
{
    private int _maxLadung;

    public int MaxLadung
    {
        get
        {
            return _maxLadung;
        }
        set
        {
            if (!(value == null))
            {
                _maxLadung = value;
            } 
        }
    }

    public FrachtSchiff(string schiffsName, Person kapitaPerson, int besatzungsGeroesse, Person[] besatzung, int maxLadung) : base(schiffsName, kapitaPerson, besatzungsGeroesse, besatzung)
    {
        MaxLadung = maxLadung;
    }
}