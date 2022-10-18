// See https://aka.ms/new-console-template for more information

using Test1;

Test test = new Test(5, new DateTime(2001, 2, 20));

test.Note = 2;

Console.WriteLine(test.DateTime + "\n");
Console.WriteLine(test.ToString());
