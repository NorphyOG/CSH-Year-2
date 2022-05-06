namespace Übung1;

public class Messung
{
    private Temperatur[] temperaturs = new Temperatur[24];
    
    
    private void CreateTemps()
    {
        double lastNum = 0;
        bool sw = true;
        DateTime dateTime = DateTime.Now;


        for (int i = 0; i < temperaturs.Length; i++)
        {
            double rdmNum = GetRandomNumber(-10, 30);

            while (sw)
            {
                if (!isInDistans(rdmNum, lastNum))
                {
                    rdmNum = GetRandomNumber(-10, 30);
                    sw = true;
                }
                else
                {
                    sw = false;
                }
            }

            if (i == 0)
            {
                temperaturs[i] = new Temperatur(dateTime, rdmNum);
                    
            }
            else
            {
                dateTime.AddHours(1);
                temperaturs[i] = new Temperatur(dateTime, rdmNum);
            }
            
            lastNum = rdmNum;

        }
    }
    
    private double GetRandomNumber(double minimum, double maximum)
    { 
        Random random = new Random();
        return random.NextDouble() * (maximum - minimum) + minimum;
    }

    private bool isInDistans(double numberNow, double numberLast)
    {
        if ((numberLast + 10 <= numberNow && numberLast - 10 <= numberNow) || (numberLast + 10 >= numberNow && numberLast - 10 >= numberNow))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
        
}

class Temperatur
{
    private DateTime date;
    private double temp;


    public DateTime Date
    {
        get => date;
        set => date = value;
    }

    public double Temp
    {
        get => temp;
        set => temp = value;
    }

    public Temperatur(DateTime date, double temp)
    {
        this.date = date;
        this.temp = temp;
    }
    
    
}