using System;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace PalmLab5
{
    public class Ivan_MainFrac
    {
        public static void Main()
        {
            Console.WriteLine($"Введiть чисельник i знаменник через пробiл для першого дробу");
            Out_MyFrac(out MyFrac strukt_1);


            Console.WriteLine($"\nВведiть чисельник i знаменник через пробiл для другого дробу");
            Out_MyFrac(out MyFrac strukt_2);

            Console.WriteLine();
            Console.WriteLine($"Дрiб ToStringWithIntegerPart рiвний {ToStringWithIntegerPart(strukt_1)}");
            Console.WriteLine($"Дрiб DoubleValue рiвний {DoubleValue(strukt_1)}");
            Console.WriteLine($"Дрiб Plus рiвний {Plus(strukt_1, strukt_2)}");
            Console.WriteLine($"Дрiб Minus рiвний {Minus(strukt_1, strukt_2)}");
            Console.WriteLine($"Дрiб Multiply рiвний {Multiply(strukt_1, strukt_2)}");
            Console.WriteLine($"Дрiб Divide рiвний {Divide(strukt_1, strukt_2)}");
            Console.WriteLine($"Значення виразу з коду рiвне {CalcSum1()}");
            Console.WriteLine($"Значення виразу з коду рiвне {CalcSum2()}");

            Console.ReadLine();
        }
        static void Out_MyFrac(out MyFrac strukt)
        {
            long[] str = Array.ConvertAll(Console.ReadLine().Trim().Split(), long.Parse);
            long n = str[0];
            long m = str[1];
            strukt = new MyFrac(n, m);
        }
        static void Switch()
        {
            Console.WriteLine("\nВведiть номер методу" +
                "\n1 - ToStringWithIntegerPart" +
                "\n2 - DoubleValue" +
                "\n3 - Plus" +
                "\n4 - Minus" +
                "\n5 - Multiply" +
                "\n6 - Divide" +
                "\n7 - CalcSum1" +
                "\n8 - CalcSum2\n");
        }
        static string ToStringWithIntegerPart(MyFrac strukt)
        {
            string sign = null;
            if (strukt.nom < 0)
            {
                strukt.nom = Math.Abs(strukt.nom);
                sign = "-";
            }
            long whole = strukt.nom / strukt.denom;
            long numerator = strukt.nom % strukt.denom;
            if (numerator == 0)
            {
                return $"{sign}{whole}";
            }
            else
            {
                return $"{sign}({whole}+{numerator}/{strukt.denom})";
            }
        }
        static double DoubleValue(MyFrac strukt)
        {
            return strukt.nom / (double)strukt.denom;
        }
        static MyFrac Plus(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom, f1.denom * f2.denom);
        }
        static MyFrac Minus(MyFrac f1, MyFrac f2)
        {
            f2.nom = -f2.nom;

            return Plus(f1, f2);
        }
        static MyFrac Multiply(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
        }
        static MyFrac Divide(MyFrac f1, MyFrac f2)
        {
            (f2.nom, f2.denom) = (f2.denom, f2.nom);

            return Multiply(f1, f2);
        }
        static int Out_N(int length)
        {
            Console.WriteLine("\nВведiть кiлькiсть доданкiв");
            int n = int.Parse(Console.ReadLine());
            while (n < length)
            {
                Console.WriteLine("\nВведiть допустиму кiлькiсть доданкiв");
                n = int.Parse(Console.ReadLine());
            }

            return n;
        }
        static MyFrac CalcSum1()
        {
            int n = Out_N(1);
            MyFrac f1 = new MyFrac(1, 2);

            for (int i = 2; i <= n; i++)
            {
                f1 = Plus(f1, new MyFrac(1, i * (i + 1)));
            }

            Console.WriteLine($"Значення виразу n/(n+1) рiвне {new MyFrac(n, n + 1)}");

            return f1;
        }
        static MyFrac CalcSum2()
        {
            int n = Out_N(2);
            MyFrac f1 = new MyFrac(3, 4);
            
            for (int i = 3; i <= n; i++)
            {
                f1 = Multiply(f1, Minus(new MyFrac(1, 1), new MyFrac(1, i * i)));
            }

            Console.WriteLine($"Значення виразу (n+1)/(2n) рiвне {new MyFrac(n + 1, 2 * n)}");

            return f1;
        }
    }
}
