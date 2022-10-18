// See https://aka.ms/new-console-template for more information

using OperratorenUeberladen;

Ding ding1 = new Ding(8, "Hallo");
Ding ding2 = new Ding(1, "Ne Digga");

Ding ding3 = ding1 + ding2;

Console.WriteLine(ding3.ToString());