// See https://aka.ms/new-console-template for more information

using Übung_10;

Auto auto1 = new Auto("VW Lupo", 2, 120);
Auto auto2 = new Auto("RR Phantom", 3, 680);
Auto auto3 = new Auto("X6", 3, 565);
Auto auto4 = new Auto("Mercedes A3", 1, 344);
Auto auto5 = new Auto("Supra", 2, 453);
Auto auto6 = new Auto("Supra", 2, 453);

var autos = new Dictionary<int, Auto>();

autos.Add(0, auto1);
autos.Add(1, auto2);
autos.Add(2, auto3);
autos.Add(3, auto4);
autos.Add(4, auto5);
autos.Add(5, auto6);

Console.WriteLine("########################################################");
foreach (var vAuto in autos)
{
    Console.WriteLine(vAuto);
}

Console.WriteLine("########################################################");

var autos_values = autos.Values;
foreach (var vAutosValue in autos_values)
{
    if (vAutosValue.Model == "Supra")
    {
        vAutosValue.Hubraum = vAutosValue.Hubraum * 1.1;
        break;
    }
}

var vAuto3 = autos[3];
autos.Remove(3, out auto3);

KeyValuePair<int, Auto> temp;
foreach (var vAutoValue in autos)
{
    temp = vAutoValue;
    
     
}


Console.WriteLine("########################################################");