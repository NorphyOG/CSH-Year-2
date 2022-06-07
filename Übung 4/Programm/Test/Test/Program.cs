// See https://aka.ms/new-console-template for more information

using Test;

public void Main(string[] args)
{
    Fussballverein fcKöln = new Fussballverein();
    fcKöln = fcKöln + new Spieler("Hans", "Dieter", new DateTime(2002, 04, 30));
}