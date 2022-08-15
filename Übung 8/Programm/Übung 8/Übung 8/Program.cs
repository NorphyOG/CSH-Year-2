// See https://aka.ms/new-console-template for more information

using System.Collections;
using Übung_8;

/*
List<Auto> _autos = new List<Auto>();

_autos.Add(new Auto("VW Lupo (Aufgemotzt)", 2, 400));
_autos.Clear();
_autos.Contains(new Auto("VW Lupo (Aufgemotzt)", 2, 400));
_autos.Exists(x => x.Modell == "VW");
_autos.Find(x => x.Modell.Contains("VW"));
_autos.ForEach(delegate(Auto modell)
{
    Console.WriteLine(modell);
});
_autos.IndexOf(new Auto("Test", 2, 2));
_autos.Insert(2, new Auto("a", 1, 1));
_autos.Remove(new Auto("a", 1, 1));
_autos.Reverse(1, 2);
_autos.Sort();
*/

Auto auto1 = new Auto("VW Lupo", 2, 120);
Auto auto2 = new Auto("RR Phantom", 3, 680);
Auto auto3 = new Auto("X6", 3, 565);
Auto auto4 = new Auto("Mercedes A3", 1, 344);
Auto auto5 = new Auto("Supra", 2, 453);
Auto auto6 = new Auto("Supra", 2, 453);

List<Auto> _autoList = new List<Auto>();
_autoList.Add(auto1);
_autoList.Add(auto2);
_autoList.Add(auto3);
_autoList.Add(auto4);
_autoList.Add(auto5);
_autoList.Add(auto6);

_autoList.Insert(6, new Auto(auto6.Modell, auto6.Hubraum * 0.1, auto6.PS));
_autoList.RemoveAt(3);

_autoList.ForEach(delegate(Auto auto)
{
    Console.WriteLine(auto);
});

_autoList.Sort();

_autoList.ForEach(delegate(Auto auto)
{
    Console.WriteLine(auto);
});

/*
 * ArrayList und LinkedList implementieren beide die List-Schnittstelle
 * und behalten die Einfügungsreihenfolge bei. Beides sind nicht synchronisierte
 * Klassen.
 *
 * 1) ArrayList verwendet intern ein dynamisches Array , um die Elemente zu speichern.	LinkedList verwendet intern eine doppelt verknüpfte Liste , um die Elemente zu speichern.
 * 2) Die Manipulation mit ArrayList ist langsam , da sie intern ein Array verwendet. Wenn ein Element aus dem Array entfernt wird, werden alle Bits im Speicher verschoben.	Die Manipulation mit LinkedList ist schneller als ArrayList, da eine doppelt verknüpfte Liste verwendet wird, sodass im Speicher keine Bitverschiebung erforderlich ist.
 * 3) Eine ArrayList-Klasse kann nur als Liste fungieren, weil sie nur List implementiert.	Die LinkedList-Klasse kann sowohl als Liste als auch als Warteschlange fungieren, da sie List- und Deque-Schnittstellen implementiert.
 * 4) ArrayList ist besser zum Speichern und Zugreifen auf Daten.	LinkedList eignet sich besser zum Manipulieren von Daten.
 */

