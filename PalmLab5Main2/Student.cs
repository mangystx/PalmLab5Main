using System;
using System.Text.RegularExpressions;

namespace PalmLab5
{
    public struct Student
    {
        public string surName;
        public string firstName;
        public string patronymic;
        public char sex;
        public string dateOfBirth;
        public char mathematicsMark;
        public char physicsMark;
        public char informaticsMark;
        public int scholarship;

        public Student(string lineWithAllData)
        {
            string[] studentData = Regex.Split(lineWithAllData, @"\s+");

            if (studentData.Length > 9 || studentData.Length == 0)
            {
                throw new Exception("Incorrect data format");
            }

            surName = studentData[0];
            firstName = studentData[1];
            patronymic = studentData[2];
            sex = Checkers.CheckSex(studentData[3]);
            dateOfBirth = Checkers.CheckDate(studentData[4]);
            mathematicsMark = Checkers.CheckMark(studentData[5]);
            physicsMark = Checkers.CheckMark(studentData[6]);
            informaticsMark = Checkers.CheckMark(studentData[7]);
            scholarship = Checkers.CheckScholarship(studentData[8]);
        }

        public override string ToString()
        {
            return
                $"{surName} {firstName} {patronymic} {sex} {dateOfBirth} {mathematicsMark} {physicsMark} {informaticsMark} {scholarship}";
        }
    }
}