using PalmLab5;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class StudLexa
{
    static void OutputStud(Student stud)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool check = false;
        if (Convert.ToInt32(stud.physicsMark.ToString()) == 5)
        {
            double gpa = (Convert.ToInt32(stud.mathematicsMark.ToString()) + Convert.ToInt32(stud.informaticsMark.ToString()) + Convert.ToInt32(stud.physicsMark.ToString())) / 3;
            Console.WriteLine($"Прізвище: {stud.surName}\n" +
                              $"Ім'я: {stud.firstName}\n" +
                              $"По батькові: {stud.patronymic}\n" +
                              $"Середній бал: {gpa}\n" +
                              $"Стипендія: {stud.scholarship}\n");
            check = true;
        }
        if (check == false)
        {
            Console.WriteLine("Таких студентів немає(");
        }
    }
    static string WorkWichFile()
    {
        StreamReader sr = File.OpenText("input.txt");

        string input = "";
        while (sr.ReadLine() != null)
        {
            input = sr.ReadLine();
        }
        sr.Close();

        return input;
    }
    public void StartBlock()
    {
        string elementInFile = WorkWichFile();
        Student stud = new Student(elementInFile);
        OutputStud(stud);
    }
}