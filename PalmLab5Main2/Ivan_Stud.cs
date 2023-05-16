namespace PalmLab5
{
    public class Ivan_Stud
    {
        public static void Main() 
        {
            string str = ReadFile();
            Student stud = new Student(str);
            PrintSurnames(stud);
        }
        static string ReadFile()
        {
            return File.ReadAllText("input.txt");
        }
        static void PrintSurnames(Student stud)
        {
            if (stud.mathematicsMark >= 3 & stud.physicsMark >= 3 & stud.informaticsMark >= 3 & stud.scholarship == 0)
            {
                Console.WriteLine($"{stud.surName} - цей студент підходить");
            }
            else
            {
                Console.WriteLine("Таких студентiв немає");
            }
        }
    }
}
