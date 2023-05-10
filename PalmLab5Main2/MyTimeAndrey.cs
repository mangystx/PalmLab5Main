namespace PalmLab5;

public struct MyTimeAndrey
{
    private int _hour;
    private int _minute;
    private int _second;
    public int Hour {
        get => _hour;
        set
        {
            if (value >= 0)
            {
                _hour = value % 24;
            }
            else
            {
                if (Math.Abs(value) > 23)
                {
                    value /= 60;
                }
                
                _hour = 24 + value;
            }
        }
    }

    public int Minute
    {
        get => _minute;
        set
        {
            if (value >= 0)
            {
                if (value > 59)
                {
                    Hour += value / 60;
                    value %= 60;
                }
                _minute = value;
            }
            else
            {
                Hour -= 1;
                if (Math.Abs(value) > 59)
                {
                    Hour += value / 60;
                    value %= 60;
                }

                _minute = 60 + value;
            }
        }
    }
    public int Second
    {
        get => _second;
        set
        {
            if (value >= 0)
            {
                if (value > 59)
                {
                    Minute += value / 60;
                    value %= 60;
                }
                _second = value;
            }
            else
            {
                Minute -= 1;
                if (Math.Abs(value) > 59)
                {
                    Minute += value / 60;
                    value %= 60;
                }

                _second = 60 + value;
            }
        }
    }

    public static MyTimeAndrey operator -(MyTimeAndrey t1, MyTimeAndrey t2)
    {
        return new MyTimeAndrey(t1.Hour - t2.Hour, t1.Minute - t2.Minute, t1.Second - t2.Second);
    }

    public MyTimeAndrey(int h, int m, int s)
    {
        Hour = h;
        Minute = m;
        Second = s;
    }
    public override string ToString()
    {
        return $"MyTime: Hour={Hour}, Minute={Minute:D2}, Second={Second:D2}";
    }
}