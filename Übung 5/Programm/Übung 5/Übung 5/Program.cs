// See https://aka.ms/new-console-template for more information

using Übung_5;

Rezepts rezepts1 = new Rezepts("Erbsensuppe", "Suppe", "Alles zusammenkippen ! Drei Stunden kochen !", 8);
rezepts1.AddZutat(new Zutat("Erbsen", 700, 1000));
rezepts1.AddZutat(new Zutat("Gemuesebruehe", 900, 10000));
rezepts1.AddZutat(new Zutat("Wuerstchen", 4000, 3000));
rezepts1.AddBewertung(new Bewertung(3, "Ganz ok"));
rezepts1.AddBewertung(new Bewertung(5, "Bombe"));
rezepts1.AddBewertung(new Bewertung(5, "War Super Lecker"));
rezepts1.AddBewertung(new Bewertung(5, "JA!"));
rezepts1.AddBewertung(new Bewertung(1, "Ich mochte es nicht"));
rezepts1.AddBewertung(new Bewertung(4, "War eigendlich ganz okey"));

Console.WriteLine(rezepts1.formatierteAusgabe());