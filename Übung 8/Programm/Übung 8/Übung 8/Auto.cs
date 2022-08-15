using System.Collections;

namespace Übung_8;

public class Auto : IComparable<int>, IComparable<Auto>
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


    public int CompareTo(int other)
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{nameof(Modell)}: {Modell}, {nameof(Hubraum)}: {Hubraum}, {nameof(PS)}: {PS}";
    }
    
    public int CompareTo(Auto? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var modellComparison = string.Compare(_modell, other._modell, StringComparison.Ordinal);
        if (modellComparison != 0) return modellComparison;
        var hubraumComparison = _hubraum.CompareTo(other._hubraum);
        if (hubraumComparison != 0) return hubraumComparison;
        return _ps.CompareTo(other._ps);
    }
}