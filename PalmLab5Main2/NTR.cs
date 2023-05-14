using System;
using System.IO;

namespace PalmLab5
{
    internal class NTR
    {
        public static void Ntr()
        {
            try
            {
                string[] studs = File.ReadAllLines("input.txt");
                foreach (string data in studs)
                {
                    Student student = new Student(data);

                    if (student.scholarship == 0)
                    {
                        double averageMark = Convert.ToDouble((student.mathematicsMark + student.physicsMark + student.informaticsMark) / 3);

                        Console.WriteLine($"{student.surName} {student.firstName} {student.patronymic} - середнiй бал: {averageMark}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
