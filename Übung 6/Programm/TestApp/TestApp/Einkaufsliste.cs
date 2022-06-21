using System.Collections;

namespace TestApp;

public class Einkaufsliste
{
    private ArrayList _liste = new ArrayList();
    public ArrayList Liste
    {
        get => _liste;
        set => _liste = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Anzeigen()
    {
        string r = "";
        foreach (Artikel vArtikel in Liste)
        {
            r += vArtikel.Anzeigen() + "\n";
        }

        return r;
    }
    
    
}