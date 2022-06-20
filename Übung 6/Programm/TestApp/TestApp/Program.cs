// See https://aka.ms/new-console-template for more information

using TestApp;

string path = "Einkaufsliste.txt";


StreamWriter streamWriter = new StreamWriter(path);
streamWriter.WriteLine("Du,Hurenson!");
streamWriter.WriteLine(",Ich Box dich");
streamWriter.Close();

StreamReader streamReader = new StreamReader(path);
string hilfe = streamReader.ReadLine();
hilfe.Split(",");

foreach (var VARIABLE in hilfe)
{
    Console.WriteLine(VARIABLE);    
}

