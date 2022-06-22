namespace Übung_7;

public class Klasse
{

    private SaveState _saveState = new SaveState();
    private string _klassenName;

    public string KlassenName
    {
        get => _klassenName;
        set => _klassenName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Klasse(string klassenName)
    {
        _klassenName = klassenName;
    }

    public void UpdateState()
    {
        _saveState.Read();
        _saveState.Write();
    }

    public string Anzeigen()
    {
        string r = "";

        var header = String.Format("{0,-12}{1,-12}{2,-12}{3,-14}{4,-27}\n",
            "Vorname", "Nachname", "Kennung", "Fehlstunden", "Unentschuldigte Fehlstunden");
        r += header + "\n";
        foreach (var vSchueler in _saveState.SchuelerListe)
        {
            var output = String.Format("{0,-12}{1,-12}{2,-12}{3,-14}{4,-27}",
                vSchueler.Vorname, vSchueler.Nachname, vSchueler.Kennung, vSchueler.Fehlzeiten, vSchueler.UnentschuldigtenFehlzeiten);
            r += output + "\n";
        }
        
        return r;
    }
    public bool addFehlzeiten(string kennung, int fehlzeit)
    {
        foreach (Schueler vSchueler in _saveState.SchuelerListe)
        {
            if (kennung.Equals(vSchueler.Kennung))
            {
                vSchueler.Fehlzeiten = vSchueler.Fehlzeiten + fehlzeit;
                return true;
            }
            else
            {
                throw new Exception("Kein Schüler mit dieser Kennung!");
            }
        }

        return false;
    }
    
    public bool addUnentschuldigtenFehlzeiten(string kennung, int uFehlzeit)
    {
        foreach (Schueler vSchueler in _saveState.SchuelerListe)
        {
            if (kennung.Equals(vSchueler.Kennung))
            {
                if (vSchueler.Fehlzeiten >= uFehlzeit)
                {
                    vSchueler.UnentschuldigtenFehlzeiten = vSchueler.UnentschuldigtenFehlzeiten + uFehlzeit;   
                }
                return true;
            }
            else
            {
                throw new Exception("Kein Schüler mit dieser Kennung!");
            }
        }

        return false;
    }
    
    
    
}