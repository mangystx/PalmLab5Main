using System;

namespace PalmLab5
{
    public class Checkers
    {
        public static char CheckSex(string sex)
        {
            try
            {
                char sex_ = Char.Parse(sex);
                switch (sex_)
                {
                    case 'M':
                    case 'М':
                    case 'Ч':
                    case 'F':
                    case 'Ж':
                        return sex_;
                    default:
                        throw new Exception($"Unknown gender: {sex}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }

        public static string CheckDate(string date)
        {
            try
            {
                string[] date_ = date.Split('.');
                if (date_.Length < 3 || date_.Length > 3)
                {
                    throw new Exception($"Invalid date of birth: {date}");
                }

                if (date_[0].Length == 2 && date_[1].Length == 2 && date_[2].Length == 4)
                {
                    return date;
                }

                throw new Exception($"Invalid date of birth: {date}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }

        public static char CheckMark(string mark)
        {
            try
            {
                char mark_ = Char.Parse(mark);

                if (mark == "-" || int.Parse(mark) >= 2 && int.Parse(mark) <= 5)
                {
                    return mark_;
                }

                throw new Exception($"Invalid mark: {mark}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }

        public static int CheckScholarship(string scholarship)
        {
            try
            {
                int scholarship_ = int.Parse(scholarship);
                if (scholarship_ >= 1234 && scholarship_ <= 4321 || scholarship_ == 0 || scholarship_ == 6000)
                {
                    return scholarship_;
                }

                throw new Exception($"Scholarship is invalid: {scholarship}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return 0;
            }
        }
    }
}
