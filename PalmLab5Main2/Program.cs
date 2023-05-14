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
                    break;
                case "2":
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
                    break;
                case "2":
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
                    JujikaNoRokuin.Uruma();
                    break;
                case "2":
                    NTR.Ntr();
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
