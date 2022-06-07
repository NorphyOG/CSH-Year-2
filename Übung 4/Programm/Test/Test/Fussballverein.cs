namespace Test;

public class Fussballverein
{
    private Spieler[] mannschaft;

    public Fussballverein()
    {
        mannschaft = new Spieler[11];
    }

    public static Spieler[] operator + (Fussballverein team, Spieler a)
    {
        for (int i = 0; i < team.mannschaft.Length; i++)
        {
            if (team.mannschaft[i] == null)
            {
                team.mannschaft[i] = a;
            }
            else
            {
                throw new Exception("ist bereits Voll");
            }
        }

        return team.mannschaft;
    }
}