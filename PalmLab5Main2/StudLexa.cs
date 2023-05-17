using PalmLab5;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class StudLexa
{
    static void OutputStud(Student stud,ref bool check)
    {
        Console.OutputEncoding = Encoding.UTF8; 
        if (stud.physicsMark.ToString() == "5")
        {
            check = true;
            double gpa = (Convert.ToInt32(stud.mathematicsMark.ToString()) + Convert.ToInt32(stud.informaticsMark.ToString()) + Convert.ToInt32(stud.physicsMark.ToString())) / 3;
            Console.WriteLine($"Прізвище: {stud.surName}\n" +
                              $"Ім'я: {stud.firstName}\n" +
                              $"По батькові: {stud.patronymic}\n" +
                              $"Середній бал: {gpa}\n" +
                              $"Стипендія: {stud.scholarship}\n");
        }
    }
    public void StartBlock()
    {
        StreamReader sr = File.OpenText("input.txt");
        bool check = false;
        string input = "";
        while ((input = sr.ReadLine()) != null)
        {
            Student stud = new Student(input);
            OutputStud(stud,ref check);
        }
        if (!check)
        {
            Console.WriteLine("Таких студентів немає(");
        }
    }
}