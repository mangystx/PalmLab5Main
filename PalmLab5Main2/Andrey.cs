namespace PalmLab5;

public class Andrey
{
    #region FirstBlock
static int TimeSinceMidnight(MyTimeAndrey t)
{
    return (t.Hour * 60 + t.Minute) * 60 + t.Second;
}
static MyTimeAndrey TimeSinceMidnightIntToMyTime(int t)
{
    int seconds = t % 60;
    t = (t - seconds) / 60;
    int minutes = t % 60;
    t = (t - minutes) / 60;
    return new MyTimeAndrey(t, minutes, seconds);
}

static MyTimeAndrey AddOneSecond(MyTimeAndrey t)
{
    return new MyTimeAndrey(t.Hour, t.Minute, t.Second + 1);
}

static MyTimeAndrey AddOneMinute(MyTimeAndrey t)
{
    return new MyTimeAndrey(t.Hour, t.Minute + 1, t.Second);
}

static MyTimeAndrey AddOneHour(MyTimeAndrey t)
{
    return new MyTimeAndrey(t.Hour + 1, t.Minute, t.Second );
}

static MyTimeAndrey AddSeconds(MyTimeAndrey t, int s)
{
    if (s >= 0)
    {
        return new MyTimeAndrey(t.Hour, t.Minute, t.Second + s);
    }

    return TimeSinceMidnightIntToMyTime(TimeSinceMidnight(t) + s);
}

static int Difference(MyTimeAndrey t1, MyTimeAndrey t2)
{
    MyTimeAndrey mt = t1 - t2;
    Console.WriteLine(mt);
    int t1InSec = TimeSinceMidnight(t1);
    int t2InSec = TimeSinceMidnight(t2);
    if (t1InSec < t2InSec)
    {
        return -(t2InSec - t1InSec);
    }
    return TimeSinceMidnight(mt);
}

static string WhatLesson(MyTimeAndrey t)
{
    int tIndSec = TimeSinceMidnight(t);
    if (tIndSec < TimeSinceMidnight(new MyTimeAndrey(8, 0, 0)))
    {
        return "пари ще не почалися";
    }
    
    if(tIndSec >= TimeSinceMidnight(new MyTimeAndrey(8, 0, 0)) &&
       tIndSec < TimeSinceMidnight(new MyTimeAndrey(9, 20, 0)))
    {
        return "1-а пара";
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(9, 20, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(9, 40, 0)))
    {
        return "перерва між 1-ю та 2-ю парами";
    }
    
    if(tIndSec >= TimeSinceMidnight(new MyTimeAndrey(9, 40, 0)) &&
       tIndSec < TimeSinceMidnight(new MyTimeAndrey(11, 0, 0)))
    {
        return "2-а пара";
    }

    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(11, 0, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(11, 20, 0)))
    {
        return "перерва між 2-ю та 3-ю парою";
    }

    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(11, 20, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(12, 40, 0)))
    {
        return "3-а пара";  
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(12, 40, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(13, 0, 0)))
    {
        return "перерва між 3-ю та 4-ю парою";
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(13, 0, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(14, 20, 0)))
    {
        return "4-а пара";  
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(14, 20, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(14, 40, 0)))
    {
        return "перерва між 4-ю та 5-ю парою";
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(14, 40, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(16, 00, 0)))
    {
        return "5-а пара";  
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(16, 0, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(16, 20, 0)))
    {
        return "перерва між 5-ю та 6-ю парою";
    }
    
    if (tIndSec >= TimeSinceMidnight(new MyTimeAndrey(16, 20, 0)) &&
        tIndSec < TimeSinceMidnight(new MyTimeAndrey(17, 40, 0)))
    {
        return "6-а пара";  
    }

    return "пари вже скінчилися";
}
#endregion

#region SecondBlock
static List<Student> GetDataList()
{
    List<Student> dataList = new List<Student>();
    using (StreamReader sr = File.OpenText("input.txt"))
    {
        string input;
        while ((input = sr.ReadLine()) != null)
        {
            dataList.Add(new Student(input));
        }
    }

    return dataList;
}

static void GetStudentsYounger16(List<Student> list)
{
    List<Student> resultList = new List<Student>();
    foreach (var st in list)
    {
        int[] date = (from num in st.dateOfBirth.Split('.') select int.Parse(num)).ToArray();
        if (DateTime.Now.Year - date[2] - 1 < 16)
        {
            if (DateTime.Now.Year - date[2] - 1 == 15)
            {
                if (date[1] > DateTime.Now.Month)
                {
                    continue;
                }

                if (date[1] == DateTime.Now.Month && date[0] > DateTime.Now.Day)
                { 
                    continue;
                }
            }
            resultList.Add(st);
        }
    }

    Console.WriteLine($"Кількість студентів молодше 16 років: {resultList.Count}");
    foreach (var st in resultList)
    {
        Console.WriteLine(st);
        Console.WriteLine("\n***************************************************\n");
    }
}
#endregion
}