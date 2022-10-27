using System.Runtime.Serialization.Formatters.Binary;
using Übung_14;

List<Artikel> artikels= new List<Artikel>();

artikels.Add(new Artikel("Ananas",1));
artikels.Add(new Artikel("Dirtea",2));
artikels.Add(new Artikel("Karroten",3));
artikels.Add(new Artikel("Pepsi",6));
artikels.Add(new Artikel("Handy",1));
artikels.Add(new Artikel("Müller Milch",10));
artikels.Add(new Artikel("Red Bull",100));

foreach (var vArtikel in artikels)
{
    Console.WriteLine(vArtikel);
}

Files file = new Files();

file.load(artikels);

     

