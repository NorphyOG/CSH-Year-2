// See https://aka.ms/new-console-template for more information

using Übung_11;

FileRead fileRead = new FileRead();
var schulKlassen = new Dictionary<string, SchulKlasse>();
List<Pool> pools = new List<Pool>();


fileRead.ReadAllFiles(schulKlassen, pools);


foreach (var pairSchulKlasse in schulKlassen)
{
    string _schuler = "[ ";
    foreach (var vSchueler in pairSchulKlasse.Value.SchuelerList)
    {
        _schuler += "< " + vSchueler.Kennung + ": " + vSchueler.VorName + vSchueler.Nachname + " >";
    }
    _schuler += " ]";
    
    Console.WriteLine("\n" + pairSchulKlasse.Key + " | " + pairSchulKlasse.Value.SchuelerList.Count + " | " + _schuler);
}

Console.WriteLine();

foreach (var vPool in pools)
{
    foreach (var vSchulKlass in schulKlassen)
    {
        int count_SchuelerList = vSchulKlass.Value.SchuelerList.Count;
        int rdmNum = 0;
        List<int> alradyUsedNumbers = new List<int>();
        vPool.SchuelerList = new List<Schueler>();

        for (int i = 0; i < count_SchuelerList; i++)
        {
            do
            {
                Random random = new Random();
                rdmNum = random.Next(0, count_SchuelerList);
                alradyUsedNumbers.Add(rdmNum);
            } while (!alradyUsedNumbers.Contains(rdmNum));

            vPool.SchuelerList.Add(vSchulKlass.Value.SchuelerList[rdmNum]);
        }
        
    }
}




foreach (var vPool in pools)
{
    string schueler = "";
    int platzNum = 1;
    foreach (var vSchueler in vPool.SchuelerList)
    {
        schueler += "[" + platzNum + "] " + vSchueler.Kennung + ":" + vSchueler.VorName + vSchueler.Nachname + " ";
        platzNum++;
    }
    
    Console.WriteLine("\nPool: " + vPool.Name + " | Volumen: " + vPool.Platz + "\nPlätze: " + schueler);
}




