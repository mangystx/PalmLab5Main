using System;

namespace PalmLab5;
{
    
    internal class JujikaNoRokuin
    {
        static string ToStringWithIntegerPart(UrumaFrac f)
        {
            var Numerator = f.Numerator;
            var Denominator = f.Denominator;
            if (Math.Abs(Numerator) > Math.Abs(Denominator))
            {
                return Numerator < 0 ? $"-({Math.Abs(Numerator / Denominator)} + {Math.Abs(Numerator % Denominator)}/{Denominator})" : $"{Numerator / Denominator} + {Numerator % Denominator}/{Denominator}";
            }
            else
            {
                return $"{Numerator}/{Denominator}";
            }
        }

        static double DoubleValue(UrumaFrac f)
        {
            return Convert.ToDouble(f.Numerator) / Convert.ToDouble(f.Denominator);
        }

        static UrumaFrac Plus(UrumaFrac f1, UrumaFrac f2)
        {
            long numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
            long Denominatorinator = f1.Denominator * f2.Denominator;
            return new UrumaFrac(numerator, Denominatorinator);
        }
        static UrumaFrac Minus(UrumaFrac f1, UrumaFrac f2)
        {
            long numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
            long Denominatorinator = f1.Denominator * f2.Denominator;
            return new UrumaFrac(numerator, Denominatorinator);
        }

        static UrumaFrac Multiply(UrumaFrac f1, UrumaFrac f2)
        {
            long numerator = f1.Numerator * f2.Numerator;
            long Denominatorinator = f1.Denominator * f2.Denominator;
            return new UrumaFrac(numerator, Denominatorinator);
        }
        static UrumaFrac Divide(UrumaFrac f1, UrumaFrac f2)
        {
            long numerator = f1.Numerator * f2.Denominator;
            long Denominatorinator = f1.Denominator * f2.Numerator;
            return new UrumaFrac(numerator, Denominatorinator);
        }

        static UrumaFrac CalcSum1(int n)
        {
        UrumaFrac first = new UrumaFrac(1, 2);
            for (int j = 2; j <= n; j++)
            {
            UrumaFrac flex = new UrumaFrac(1, j * (j + 1));
                first = Plus(first, flex);
            }
            return first;
        }
        static UrumaFrac CalcSum2(int n)
        {
        UrumaFrac first = new UrumaFrac(3, 4);
            for (int j = 3; j <= n; j++)
            {
            UrumaFrac cringe = new UrumaFrac(j * j - 1, j * j);
                first = Multiply(first, cringe);
            }
            return first;
        }
        public static void Uruma(string[] args)
        {
            Console.WriteLine("Введіть чисельник та знаменник першого дробу через пробіл:");
            string[] input1 = Console.ReadLine().Split();
        UrumaFrac res1 = new UrumaFrac(long.Parse(input1[0]), long.Parse(input1[1]));
            Console.WriteLine("Введіть чисельник та знаменник другого дробу через пробіл:");
            string[] input2 = Console.ReadLine().Split();
        UrumaFrac res2 = new UrumaFrac(long.Parse(input2[0]), long.Parse(input2[1]));
            Console.WriteLine($"Результат додавання двох дробів: {Plus(res1, res2)}");
            Console.WriteLine($"Результат віднімання двох дробів:{Minus(res1, res2)}");
            Console.WriteLine($"Результат множення двох дробів: {Multiply(res1, res2)}");
            Console.WriteLine($"Результат ділення двох дробів: {Divide(res1, res2)}");
            Console.WriteLine($"{CalcSum1(int.Parse(Console.ReadLine()))}");
            Console.WriteLine($"{CalcSum2(int.Parse(Console.ReadLine()))}");
        }
    }
}