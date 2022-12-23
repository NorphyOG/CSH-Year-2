using System;

namespace PasswordGen;

public class Gen
{

    public string createPasswort(int launge, int menge, string abcKlein, string abcGross, string nums, string sonderZeichen, string anderes)
    {

        string passwortString = "";
        
        string zeichen = "";
                
        if (abcKlein != null)
        {
            zeichen += abcKlein;
        }

        if (abcGross != null)
        {
            zeichen += abcGross;
        }

        if (nums != null)
        {
            zeichen += nums;
        }

        if (sonderZeichen != null)
        {
            zeichen += sonderZeichen;
        }

        if (anderes != null)
        {
            zeichen += anderes;
        }

        int zeichenLenge = zeichen.Length;

        for (int i = 0; i < menge; i++)
        {
            if (passwortString.Length != 0)
            {
                passwortString += "\n";
            }
            passwortString += "» Passwort " + (i + 1) +
                              "\n› Nutzen: " +
                              "\n› Username: " +
                              "\n› Email: " +
                              "\n› Passwort: ";
            for (int j = 0; j < launge; j++)
            {
                Random random = new Random();
                int rdm = random.Next(zeichenLenge);

                passwortString += zeichen.ToCharArray()[rdm];
            }

            passwortString += "\n";
            
        }
        
        return passwortString;
    }

}