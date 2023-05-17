namespace PalmLab5
{
    public class Ivan_Stud
    {
        public void Main()
        {
            string input;
            using (StreamReader stream = File.OpenText("input.txt"))
            {
                bool yes = true;
                while ((input = stream.ReadLine()) != null)
                {
                    Student stud = new Student(input);
                    PrintSurnames(stud, ref yes);
                }
                if (yes) Console.WriteLine($"Таких студентiв немає");
            }
        }
        static void PrintSurnames(Student stud, ref bool yes)
        {
            if (stud.mathematicsMark >= 3 & stud.physicsMark >= 3 & stud.informaticsMark >= 3 & stud.scholarship == 0)
            {
                Console.WriteLine($"{stud.surName} - цей студент підходить");
                yes = false;
            }
        }
    }
}
