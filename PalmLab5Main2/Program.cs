using PalmLab5;

while (true)
{
    Console.WriteLine("Введіть цифру відповідну номеру учня\n" +
                      "1 Марченко А.І.\n2 Каюк І.В.\n" +
                      "3 Мартиненко О.С.\n4 Шафієв Д.Ю.");
    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Введіть номер блоку -> ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Спочатку створіть екземпляр структури MyTimeAndrey\n" +
                                      "передайте 3 числових значення через пропус у ворматі (години хвилини секунди)");
                    int[] values = (from num in Console.ReadLine().Trim().Split() select int.Parse(num)).ToArray();
                    MyTimeAndrey mt = new MyTimeAndrey(values[0], values[1], values[2]);
                    Console.WriteLine("Введіть цифру відповідну дії яку ви бажаєте виконати:\n" +
                    "1 — перетворити вказаний час (вигляду MyTime) у кількість секунд, що пройшли від початку доби;\n" +
                    "2 — перетворити кількість секунд, що пройшли від початку доби, у час у форматі MyTime;\n" +
                    "3 — додати до структури одну секунду\n" +
                    "4 — додати до структури одну хвилину\n" +
                    "5 — додати до структури одну годину\n" +
                    "6 — додати до структури задану кількість секунд\n" +
                    "7 — отримати різницю між двома моментами, заданими структурами MyTime\n" +
                    "8 — отримати інформацію про те яка зараз пара\n");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine(Andrey.TimeSinceMidnight(mt));
                            break;
                        case "2":
                            Console.WriteLine("Введіть кількість секунд, що пройшли від початку доби");
                            Console.WriteLine(Andrey.TimeSinceMidnightIntToMyTime(int.Parse(Console.ReadLine())));
                            break;
                        case "3":
                            Console.WriteLine($"До додавання: {mt}");
                            Console.WriteLine($"Після додавання: {Andrey.AddOneSecond(mt)}");
                            break;
                        case "4":
                            Console.WriteLine($"До додавання: {mt}");
                            Console.WriteLine($"Після додавання: {Andrey.AddOneMinute(mt)}");
                            break;
                        case "5":
                            Console.WriteLine($"До додавання: {mt}");
                            Console.WriteLine($"Після додавання: {Andrey.AddOneHour(mt)}");
                            break;
                        case "6":
                            Console.WriteLine("Введіть кількість секунд яку бажаєте додати до структури:");
                            int secondsToAdd = int.Parse(Console.ReadLine());
                            Console.WriteLine($"До додавання: {mt}");
                            Console.WriteLine($"Після додавання: {Andrey.AddSeconds(mt, secondsToAdd)}");
                            break;
                        case "7":
                            Console.WriteLine("Потрібно створити другий екземпляр структури MyTimeAndrey\n" +
                                              "передайте 3 числових значення через пропус у ворматі (години хвилини секунди)");
                            int[] valuesForCase7 = (from num in Console.ReadLine().Trim().Split() select int.Parse(num)).ToArray();
                            MyTimeAndrey mt2 = new MyTimeAndrey(valuesForCase7[0], valuesForCase7[1], valuesForCase7[2]);
                            Console.WriteLine($"Різниця: {Andrey.Difference(mt, mt2)}");
                            break;
                        case "8":
                            Console.WriteLine(Andrey.WhatLesson(mt));
                            break;
                        default:
                            Console.WriteLine("Некоректне значення");
                            break;
                    }

                    break;
                case "2":
                    Andrey.GetStudentsYounger16(Andrey.GetDataList());
                    break;
                default:
                    Console.WriteLine("Некоректне значення");
                    break;
            }
            break;
        case "2":
            Console.Write("Введіть номер блоку -> ");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    
                    break;
                default:
                    Console.WriteLine("Некоректне значення");
                    break;
            }
            break;
        case "3":
            Console.Write("Введіть номер блоку -> ");
            switch (Console.ReadLine())
            {
                case "1":
                    Lexa lexa = new Lexa();
                    lexa.SetStartTime();
                    break;
                case "2":
                    StudLexa studLexa = new StudLexa();
                    studLexa.StartBlock();
                    break;
                default:
                    Console.WriteLine("Некоректне значення");
                    break;
            }
            break;
        case "4":
            Console.Write("Введіть номер блоку -> ");
            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    Console.WriteLine("Некоректне значення");
                    break;
            }
            break;
        default:
            Console.WriteLine("Некоректне занчення");
            break;
    }
    Console.WriteLine("Якщо бажаєте вийти введіть q");
    if (string.Compare(Console.ReadLine(), "q", StringComparison.OrdinalIgnoreCase) == 0)
    {
        break;
    }
}