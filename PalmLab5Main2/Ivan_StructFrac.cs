namespace PalmLab5
{
    struct MyFrac
    {
        public long nom, denom;
        public MyFrac(long nom_, long denom_)
        {
            nom = nom_;
            denom = denom_;
            if (nom < 0 & denom < 0)
            {
                nom = -nom;
                denom = -denom;
            }
            if (nom >= 0 & denom < 0)
            {
                nom = -nom;
                denom = -denom;
            }
            long a = Math.Abs(nom), b = denom;
            while (b != 0)
            {
                long temp = a % b;
                a = b;
                b = temp;
            }
            nom /= a; denom /= a;
        }
        public override string ToString()
        {
            if (denom == 1)
            {
                return nom.ToString();
            }
            else if (Math.Abs(nom) > denom)
            {
                long whole = nom / denom;
                long numerator = Math.Abs(nom) % denom;
                if (numerator == 0)
                {
                    return $"{whole}";
                }
                else
                {
                    return $"{whole}({numerator}/{denom})";
                }
            }
            else
            {
                return $"{nom}/{denom}";
            }
        }
    }
}