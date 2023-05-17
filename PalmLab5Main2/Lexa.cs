

namespace PalmLab5
{
    public class Lexa
    {
        static int TimeSinceMidnight(MyTimeLexa t)
        {
            int second = t.Hour * 60 * 60 + t.Minute * 60 + t.Second;
            Console.WriteLine($"Ваш час в секундах від початку доби {second}");
            return second;
        }
        static MyTimeLexa TimeSinceMidnight()
        {
            int t = int.Parse(Console.ReadLine());
            MyTimeLexa stud = new MyTimeLexa(0,0,t);
            Console.WriteLine(stud);
            return stud;
        }
        static MyTimeLexa AddOneSecond(MyTimeLexa t)
        {
            t.Second += 1;
            Console.WriteLine(t);
            return t;
        }
        static MyTimeLexa AddOneMinute(MyTimeLexa t)
        {
            t.Minute += 1;
            Console.WriteLine(t);
            return t;
        }
        static MyTimeLexa AddOneHour(MyTimeLexa t)
        {
            t.Hour += 1;
            Console.WriteLine(t);
            return t;
        }
        static MyTimeLexa AddSeconds(MyTimeLexa t)
        {
            int s = int.Parse(Console.ReadLine());
            t.Second += s;
            Console.WriteLine(t);
            return t;
        }
        static void Difference(MyTimeLexa[] mt)
        {
            double[] resTimeOfMT = new double[mt.Length * 3];
            for (int i = 0; i < mt.Length; i++)
            {
                Console.WriteLine($"Введіть {i + 1} час");
                int[] time = Array.ConvertAll(Console.ReadLine().Trim().Split(':', '.', ','), int.Parse);
                mt[i].Hour = time[0];
                mt[i].Minute = time[1];
                mt[i].Second = time[2];
                resTimeOfMT[i * 3] = mt[i].Hour + Convert.ToDouble(mt[i].Minute) / 60 + Convert.ToDouble(mt[i].Second) / 120;
                resTimeOfMT[i * 3 + 1] = mt[i].Hour * 60 + mt[i].Minute + Convert.ToDouble(mt[i].Second) / 60;
                resTimeOfMT[i * 3 + 2] = mt[i].Hour * 60 * 60 + mt[i].Minute * 60 + mt[i].Second;
            }
            for (int i = 0; i < mt.Length; i += 2)
            {
                double resDiffInHour = resTimeOfMT[i * 3] - resTimeOfMT[i * 3 + 3];
                Console.WriteLine($"Різниця часу в годинах {resDiffInHour}");
                double resDiffInMin = resTimeOfMT[i * 3 + 1] - resTimeOfMT[i * 3 + 4];
                Console.WriteLine($"Різниця часу в хвилинах {resDiffInMin}");
                double resDiffInSec = resTimeOfMT[i * 3 + 2] - resTimeOfMT[i * 3 + 5];
                Console.WriteLine($"Різниця часу в секундах {resDiffInSec}\n");
            }
        }
        static void WhatLesson(MyTimeLexa mt)
        {
            double[] time = { mt.Hour, Convert.ToDouble(mt.Minute) / 100 };
            if (time[0] + time[1] >= 0 && time[0] + time[1] < 8)
            {
                Console.WriteLine("Пари ще не почались");
            }
            if (time[0] + time[1] >= 8 && time[0] + time[1] <= 9.20)
            {
                Console.WriteLine("Зараз йде 1 пара");
            }
            if (time[0] + time[1] > 9.20 && time[0] + time[1] < 9.40)
            {
                Console.WriteLine("Перерва між 1 та 2 парою");
            }
            if (time[0] + time[1] >= 9.40 && time[0] + time[1] <= 11)
            {
                Console.WriteLine("Зараз йде 2 пара");
            }
            if (time[0] + time[1] > 11 && time[0] + time[1] < 11.20)
            {
                Console.WriteLine("Перерва між 2 та 3 парою");
            }
            if (time[0] + time[1] >= 11.20 && time[0] + time[1] <= 12.40)
            {
                Console.WriteLine("Зараз йде 3 пара");
            }
            if (time[0] + time[1] > 12.40 && time[0] + time[1] < 13)
            {
                Console.WriteLine("Перерва між 3 та 4 парою");
            }
            if (time[0] + time[1] >= 13 && time[0] + time[1] <= 14.20)
            {
                Console.WriteLine("Зараз йде 4 пара");
            }
            if (time[0] + time[1] > 14.20 && time[0] + time[1] < 14.40)
            {
                Console.WriteLine("Перерва між 4 та 5 парою");
            }
            if (time[0] + time[1] >= 14.40 && time[0] + time[1] <= 16)
            {
                Console.WriteLine("Зараз йде 5 пара");
            }
            if (time[0] + time[1] > 16 && time[0] + time[1] < 16.20)
            {
                Console.WriteLine("Перерва між 5 та 6 парою");
            }
            if (time[0] + time[1] >= 16.20 && time[0] + time[1] <= 17.40)
            {
                Console.WriteLine("Зараз йде 6 пара");
            }
            if (time[0] + time[1] > 17.40 && time[0] + time[1] < 17.50)
            {
                Console.WriteLine("Перерва між 6 та 7 парою");
            }
            if (time[0] + time[1] >= 17.50 && time[0] + time[1] <= 19.10)
            {
                Console.WriteLine("Зараз йде 7 пара");
            }
            if (time[0] + time[1] > 19.10 || time[0] + time[1] < 0)
            {
                Console.WriteLine("Пари вже скінчились");
            }

        }
        public void WorkWithTime(MyTimeLexa t)
        {
            string select;
            do
            {
                Console.WriteLine("Введіть бажаний варіант\t\t Для часу введіть t\\time\\9\n" +
                    "1) Перетворюватиме вказаний час у кількість секунд, що пройшли від початку доби\n" +
                    "2) Перетворюватиме кількість секунд, що пройшли від початку доби\n" +
                    "3) Додаватиме до структури одну секунду\n" +
                    "4) Додаватиме до структури одну хвилину\n" +
                    "5) Додаватиме до структури одну годину\n" +
                    "6) Додаватиме до структури вказану кількість секунд s (яка може бути довільною, в тому числі більшою 60, і навіть більшою 24×60×60 = 86400, а також від’ємною)\n" +
                    "7) Різниця між двома моментами часу\n" +
                    "0) Вихід");
                select = Console.ReadLine();
                switch (select)
                {
                    case "t":
                    case "time":
                    case "н":
                    case "y":
                    case "9":
                        SetStartTime();
                        break;
                    case "1":
                        TimeSinceMidnight(t);
                        break;
                    case "2":
                        TimeSinceMidnight();
                        break;
                    case "3":
                        t = AddOneSecond(t);
                        break;
                    case "4":
                        t = AddOneMinute(t);
                        break;
                    case "5":
                        t = AddOneHour(t);
                        break;
                    case "6":
                        t = AddSeconds(t);
                        break;
                    case "7":
                        MyTimeLexa[] MyTimeLexas = new MyTimeLexa[2];
                        Difference(MyTimeLexas);
                        break;
                    case "8":
                        WhatLesson(t);
                        break;
                    default:
                        break;
                }
            } while (select != "0");

        }
        public void SetStartTime()
        {
            Console.WriteLine("Введіть ваш час");
            int[] time = Array.ConvertAll(Console.ReadLine().Trim().Split(':', '.', ',', ' '), int.Parse);
            MyTimeLexa t = new MyTimeLexa(time[0], time[1], time[2]);
            Console.WriteLine(t);
            WorkWithTime(t);
        }
    }
}