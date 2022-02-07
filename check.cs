using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    public class CheckPrime
    {
        public bool Isvalid(int year, int month, int day)
        {
            if (year % 4 == 0 && year > 0)
            {
                if (month == 2)
                {
                    if (day > 0 && day <= 29)
                    {

                    }
                }
                return true;
            }
            else if (year > 0)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day > 0 && day <= 31)
                    {
                        Console.WriteLine("");
                    }
                }
                return true;
            }
            else if (year > 0)
            {
                if (month == 4 || month == 6 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 0 && day <= 30)
                    {

                    }
                }

                return true;
            }
            else
            {
                Console.WriteLine("enter a valid date your date is false:");

                return false;
            }
        }
    }
    class Calendercheck
    {
        public static void Main()
        {
            CheckPrime c = new CheckPrime();
            bool all = c.Isvalid(2016, 2, 28);
            Console.WriteLine($"Your date format is  {all} ");

        }



    }
}

