// See https://aka.ms/new-console-template for more information

using Übung_15;

    ElektronischesTelefonbuch fileState = new ElektronischesTelefonbuch();
    Menu menu = new Menu();
    menu.MenuOne(fileState.Persons, fileState);
    
    foreach (var vPerson in fileState.Persons)
    {
        Console.WriteLine(vPerson);
    }


