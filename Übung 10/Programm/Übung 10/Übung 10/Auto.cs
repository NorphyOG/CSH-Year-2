namespace Übung_10;

public class Auto
{
    public string Model
    {
        get;
        set;
    }

    public double Hubraum
    {
        get;
        set;
    }

    public int PS
    {
        get;
        set;
    }

    public Auto(string model, double hubraum, int ps)
    {
        Model = model;
        Hubraum = hubraum;
        PS = ps;
    }

    public override string ToString()
    {
        return $"{nameof(Model)}: {Model}, {nameof(Hubraum)}: {Hubraum}, {nameof(PS)}: {PS}";
    }
}