using System.Collections;

namespace Übung_5;

public class Rezepts
{
    private string name;
    public string Name
    {
        get
        {
            return name;
        }
        
    }

    private string kategorie;
    public string Kategorie
    {
        get
        {
            return kategorie;
        }
        
    }

    private string anleitung;
    public string Anleitung
    {
        get
        {
            return anleitung;
        } 
        
    }

    private int personenAnzahl;
    public int PersonenAnzahl
    {
        get
        {
            return personenAnzahl;
        }
        set
        {
            if (value == null || value == 0)
            {
                personenAnzahl = 2;
            }
            else
            {
                personenAnzahl = value;
            }
        }
    }

    public Rezepts(string name, string kategorie, string anleitung, int personenAnzahl)
    {
        this.name = name;
        this.kategorie = kategorie;
        this.anleitung = anleitung;
        this.personenAnzahl = personenAnzahl;
    }

    private ArrayList _arrayListZutat = new ArrayList();
    public void AddZutat(Zutat zutat)
    {
        _arrayListZutat.Add(zutat);
    }
    
    private ArrayList _arrayListBewertung = new ArrayList();
    public void AddBewertung(Bewertung bewertung)
    {
        _arrayListBewertung.Add(bewertung);
    }
    

    public string formatierteAusgabe()
    {
        string sZutat = "", sBewertung = "";
        int gesKcal = 0;
        foreach (Zutat vZutat in _arrayListZutat)
        {
            gesKcal = gesKcal + vZutat.Kcal;
            sZutat += "\n" + vZutat.Name + "\n" + vZutat.Kcal + "kcal\n";
        }

        int avgStern = 0, avgSternOther = 0;
        foreach (Bewertung vBewertung in _arrayListBewertung)
        {
            avgStern = avgStern + vBewertung.Stern;
            avgSternOther++;
            sBewertung += "\nSterne: " + vBewertung.OutputStern + "\nKommentar: " + vBewertung.Kommentar + "\n";
        }

        double newAvgStern = avgStern / avgSternOther;
        
        
        return "Name: " + Name + "\nKategorie: " + Kategorie + "\nAnleitung: " + Anleitung + "\nPersonen Anzahl: " + PersonenAnzahl + "\n\nZutaten:\nGesamtkalorinen: " + gesKcal + "kcal" + sZutat + "\n\nBewertung:\nDurchschnitt Sterne: " + newAvgStern + "\n" + sBewertung;
    }
    
    private static String[] kategorieArten = {"Vorspeise", "Suppe", "Fleischgericht", "Gemuese", "Dessert"}; 
    public bool checkKategorie()
    {
        bool r = false;
        foreach (string vKategorie in kategorieArten)
        {
            if (kategorie.Equals(vKategorie, StringComparison.InvariantCultureIgnoreCase))
            {
                r = true;
            }
        }

        return r;
    }

    public double kcalProPerson()
    {
        int gesKcal = 0;
        foreach (Zutat vZutat in _arrayListZutat)
        {
            gesKcal = gesKcal + vZutat.Kcal;
        }

        return gesKcal / PersonenAnzahl;
    }

    public static bool operator + (Rezepts rezepts, Zutat zutat)
    {
        rezepts._arrayListZutat.Add(zutat);
        return true;
    }

    public static bool operator < (Rezepts rezepts1, Rezepts rezepts2)
    {
        if (rezepts1.personenAnzahl < rezepts2.personenAnzahl)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator > (Rezepts rezepts1, Rezepts rezepts2)
    {
        return !(rezepts1 < rezepts2);
    }
}