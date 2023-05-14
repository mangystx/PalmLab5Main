namespace PalmLab5
{

    public struct UrumaFrac
    {
        public long Numerator, Denominator;
        public UrumaFrac(long Numerator_, long Denominator_)
        {
            Numerator = Numerator_;
            Denominator = Denominator_;
            if ((Denominator < 0 && Numerator >= 0) || (Denominator < 0 && Numerator < 0))
            {
                Denominator *= -1;
                Numerator *= -1;
            }
            long a = Math.Abs(Numerator);
            long b = Math.Abs(Denominator);
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            Numerator /= a;
            Denominator /= a;
        }

        public override string ToString() => Denominator != 1 ? $"{Numerator}/{Denominator}" : $"{Numerator}";

        /*
        public override string ToString()
        {
            if (Denominator == 1)
            {
                return $"{Numerator}";
            }
            else if (Math.Abs(Numerator) > Denominator)
            {
                int whole = Numerator / Denominator;
                int numerator = Math.Abs(Numerator) % Denominator;
                return $"{whole}({numerator}/{Denominator})";
            }
            else
            {
                return $"({Numerator}/{Denominator})";
            }
        }
        */
    }
}
