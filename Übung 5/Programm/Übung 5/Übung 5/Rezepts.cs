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
            if (value == null)
            {
                personenAnzahl = 2;
            }
            else
            {
                personenAnzahl = value;
            }
        }
    }

    private Zutat _zutat = new Zutat();
    private Bewertung _bewertung = new Bewertung();

    public string info()
    {
        
    }
}