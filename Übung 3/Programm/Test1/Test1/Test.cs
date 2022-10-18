namespace Test1;

public class Test
{

    private int note;
    public int Note
    {
        get
        {
            return note;
        }
        set
        {
            if (this.DateTime - DateTime.Now < new TimeSpan(30, 0,0,0,0))
            {
                if (value >= 0 && value <= 6)
                {
                    note = value;
                }
                else
                {
                    throw new Exception("Is Null or bigger then 6");
                }
            }
        }
    }
    
    private DateTime dateTime;
    public DateTime DateTime
    {
        get
        {
            return dateTime;
        }
        set
        {
            if (value - DateTime.Now < new TimeSpan(30, 0,0,0,0))
            {
                dateTime = value;
            }
            else
            {
                throw new Exception("Is near the Now Date");
            }
        }
    }

    public Test(int note, DateTime dateTime)
    {
        Note = note;
        DateTime = dateTime;
    }
    
    public override string ToString()
    {
        return Note + "\n" + DateTime;
    }

}