using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Übung_14;

public class Files
{
    
    public void load(List<Artikel> list)
    {
        DateiInBinaerSpeichern(list);
        DateiInBinaerAnzeigen();
      
        ArtikelHinzufuegen(new Artikel("Karroten",3));
    }
    
    private static void DateiInBinaerSpeichern(List<Artikel> list)
    {
        FileStream fs = new FileStream("einkaufliste.txt", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(fs,list);
    
        fs.Close();
    
    }
    
    private static List<Artikel> DateiInBinaerAnzeigen()
    {
        List<Artikel> a;
        FileStream fs2 = new FileStream("einkaufliste.txt", FileMode.Open);
        BinaryFormatter bf2 = new BinaryFormatter();
        a = (List<Artikel>)bf2.Deserialize(fs2);
        fs2.Close();
        return a;
    }

    private static void ArtikelHinzufuegen(Artikel artikel)
    {
        List<Artikel> a;
        FileStream fs2 = new FileStream("einkaufliste.txt", FileMode.Open);
        BinaryFormatter bf2 = new BinaryFormatter();
        a = (List<Artikel>)bf2.Deserialize(fs2);
        fs2.Close();

        foreach (var variabArtikel in a)
        {
            
            if (!variabArtikel.Artikelname.Equals(artikel.Artikelname))
            {
                a.Add(artikel);
            }
            
        }
    }

}
