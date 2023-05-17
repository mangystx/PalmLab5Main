
namespace PalmLab5
{
    public struct MyTimeLexa
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get { return hour; }
            set
            {
                if (value < 0)
                {
                    value = Math.Abs(value);
                    value = value > 24 ? value % 24 : 24 - value;
                }
                if (value >= 24)
                {
                    value %= 24;
                }
                hour = value;
            }
        }
        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0)
                {
                    value = Math.Abs(value);
                    int diffMin = value / 60;
                    Hour -= diffMin == 0 ? diffMin + 1 : diffMin;
                    value = value > 60 ? value % 60 : 60 - value;
                }
                if (value >= 60)
                {
                    Hour += value / 60;
                    value %= 60;
                }
                minute = value;
            }
        }
        public int Second
        {
            get { return second; }
            set
            {
                if (value < 0)
                {
                    value = Math.Abs(value);
                    int diffMin = value / 60;
                    Minute -= diffMin == 0 ? diffMin + 1 : diffMin;
                    value = value > 60 ? value % 60 : 60 - value;
                }
                if (value >= 60)
                {
                    Minute += value / 60;
                    value %= 60;
                }
                second = value;
            }
        }
        public MyTimeLexa(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }
        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}:{Second:D2}";
        }
    };
}