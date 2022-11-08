// See https://aka.ms/new-console-template for more information

using Übung_14._1;

Menu menu = new Menu();
List<Artikel> artikels= new List<Artikel>();


artikels.Add(new Artikel("Ananas",1));
artikels.Add(new Artikel("Dirtea",2));
artikels.Add(new Artikel("Karroten",3));
artikels.Add(new Artikel("Pepsi",6));
artikels.Add(new Artikel("Handy",1));
artikels.Add(new Artikel("Müller Milch",10));
artikels.Add(new Artikel("Red Bull",100));



menu.MenuOne(artikels);
