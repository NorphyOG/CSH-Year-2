// See https://aka.ms/new-console-template for more information

using Übung_9;

FileRead fileRead = new FileRead();
List<SchulKlasse> schulKlassen = new List<SchulKlasse>();
List<Pool> pools = new List<Pool>();

fileRead.ReadAllFiles(schulKlassen, pools);


Console.WriteLine("-----------------------------------------");
foreach (var vSchulKlass in schulKlassen)
{
    Console.WriteLine(vSchulKlass);

    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");
    foreach (var vSchueler in vSchulKlass.SchuelerList)
    {
        Console.WriteLine(vSchueler);
    }

    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++\n");
}

Console.WriteLine("-----------------------------------------");
foreach (var vPool in pools)
{
    Console.WriteLine(vPool);
}


