﻿using Palm_Laba_5;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class StudLexa
{
    static void Print(Student[] stud)
    {
        bool check = false;
        for (int i = 0; i < stud.Length; i++)
        {
            if (Convert.ToInt32(stud[i].PhysicsMark.ToString()) == 5)
            {
                double gpa = (Convert.ToInt32(stud[i].MathematicsMark.ToString()) + Convert.ToInt32(stud[i].InformaticsMark.ToString()) + Convert.ToInt32(stud[i].PhysicsMark.ToString())) / 3;
                Console.WriteLine($"Прізвище: {stud[i].SurName}\n" +
                                  $"Ім'я: {stud[i].FirstName}\n" +
                                  $"По батькові: {stud[i].Patronymic}\n" +
                                  $"Середній бал: {gpa}\n" +
                                  $"Стипендія: {stud[i].Scholarship}\n");
                check = true;
            }
        }
        if (check == false)
        {
            Console.WriteLine("Таких студентів немає(");
        }
    }
    static string[] WorkWichFile()
    {
        StreamReader fstream = new StreamReader("data.txt", Encoding.UTF8);

        string line = fstream.ReadToEnd();

        line = Regex.Replace(line, @"\s+", " ");

        string[] elementInFile = line.Split(' ');

        fstream.Close();
        return elementInFile;
    }
    static int CountStud(int lenghtFile)
    {
        int countStud = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (lenghtFile >= 9 * i)
            {
                countStud++;
            }
            else
            {
                break;
            }
        }
        return countStud;
    }
    public void FillStruct()
    {
        string[] elementInFile = WorkWichFile();
        Student[] stud = new Student[CountStud(elementInFile.Length)];
        for (int i = 0; i < stud.Length; i++)
        {
            stud[i].SurName = elementInFile[9 * i];

            stud[i].FirstName = elementInFile[9 * i + 1];

            stud[i].Patronymic = elementInFile[9 * i + 2];

            stud[i].Sex = char.Parse(elementInFile[9 * i + 3]);

            stud[i].DateOfBirth = elementInFile[9 * i + 4];

            stud[i].MathematicsMark = char.Parse(elementInFile[9 * i + 5]);

            stud[i].PhysicsMark = char.Parse(elementInFile[9 * i + 6]);

            stud[i].InformaticsMark = char.Parse(elementInFile[9 * i + 7]);

            stud[i].Scholarship = Convert.ToInt32(elementInFile[9 * i + 8]);
        }
        Console.OutputEncoding = Encoding.UTF8;
        Print(stud);
    }
}