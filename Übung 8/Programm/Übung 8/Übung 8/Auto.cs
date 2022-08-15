using System.Collections;

namespace Übung_8;

public class Auto
{
    private string _modell;

    public string Modell
    {
        get
        {
            return _modell;
        }
        set
        {
            value = _modell;
        }
    }

    private double _hubraum;

    public double Hubraum
    {
        get
        {
            return _hubraum;
        }
        set
        {
            value = _hubraum;
        }
    }

    private int _ps;

    public int PS
    {
        get
        {
            return _ps;
        }
        set
        {
            value = _ps;
        }
    }

    public Auto(string modell, double hubraum, int ps)
    {
        _modell = modell;
        _hubraum = hubraum;
        _ps = ps;
    }


    public override string ToString()
    {
        return $"{nameof(Modell)}: {Modell}, {nameof(Hubraum)}: {Hubraum}, {nameof(PS)}: {PS}";
    }
}