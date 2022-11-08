using System.Runtime.Serialization.Formatters.Binary;

namespace Übung_14._1;

public class Files
{

    public void DateiInBinaerSpeichern(List<Artikel> list)
    {
        FileStream fs = new FileStream("einkaufliste.txt", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs,list);
    
        fs.Close();
    
    }
    
    public List<Artikel> DateiInBinaerAnzeigen()
    {
        List<Artikel> a;
        FileStream fs2 = new FileStream("einkaufliste.txt", FileMode.Open);
        BinaryFormatter bf2 = new BinaryFormatter();
        a = (List<Artikel>)bf2.Deserialize(fs2);
        fs2.Close();
        return a;
    }

    public void ArtikelHinzufuegen(Artikel artikel)
    {
        List<Artikel> a;
        FileStream fs2 = new FileStream("einkaufliste.txt", FileMode.Open);
        BinaryFormatter bf2 = new BinaryFormatter();
        a = (List<Artikel>)bf2.Deserialize(fs2);
        fs2.Close();

        foreach (var variabArtikel in a.ToList())
        {
            
            if (!variabArtikel.Artikelname.Equals(artikel.Artikelname))
            {
                a.Add(artikel);
            }
            
        }
    }
}