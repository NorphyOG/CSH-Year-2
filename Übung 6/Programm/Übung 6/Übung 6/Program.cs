// See https://aka.ms/new-console-template for more information

using Übung_6;
using Übung_6.Schiffe;

Person[] besatzung = {new Person("Kevin", DateTime.Now), new Person("Frank", new DateTime(1800, 1, 7)), new Person("Tim", new DateTime(2002, 4, 30)) };

FrachtSchiff frachtSchiff = new FrachtSchiff("Holland", new Person("Rudi Carrell", new DateTime(1980, 1, 1)), 3, besatzung, 1000, 700);

Console.WriteLine("Max Ladung: " + frachtSchiff.MaxLadung + "\nAktuelle Ladung:" + frachtSchiff.AktuelleLadung);
frachtSchiff.Beladen(300);
Console.WriteLine("Max Ladung: " + frachtSchiff.MaxLadung + "\nAktuelle Ladung:" + frachtSchiff.AktuelleLadung);
frachtSchiff.Entladen(400);
Console.WriteLine("Max Ladung: " + frachtSchiff.MaxLadung + "\nAktuelle Ladung:" + frachtSchiff.AktuelleLadung);
frachtSchiff.Entladen(400);
Console.WriteLine("Max Ladung: " + frachtSchiff.MaxLadung + "\nAktuelle Ladung:" + frachtSchiff.AktuelleLadung);
frachtSchiff.Beladen(300);
Console.WriteLine("Max Ladung: " + frachtSchiff.MaxLadung + "\nAktuelle Ladung:" + frachtSchiff.AktuelleLadung);


Ausflugsboot ausflugsboot = new Ausflugsboot("Rheinblick", new Person("Egon Meier", new DateTime(2000, 10, 5)), 3, besatzung);

