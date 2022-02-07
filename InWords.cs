using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class InWords
    {
        static void PrintWords(int num)
        {
            string[] words = { "Zero", "One", "two", "three", "four", "five", "six", "eight", "nine" };
            int i = 0; int j = 0; int digit = 0;
            
            int[] digit_array = new int[10];
            while (num > 0)
            {
                digit = num % 10;
                
                digit_array[i++] = digit;
                num = num / 10;
            }
            for ( j = i - 1; j >= 0; j--)
            {
                Console.WriteLine(words[digit_array[j]] + " ");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int num;

            Console.Write("Enter the number:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Number in words:");
            PrintWords(num);
        }
    }
}
       /* public static String[] units = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
"Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public static String[] tens = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty",
"Ninety" };

        public static String convert(int n)
        {
            if (n < 0)
            {
                return "Minus " + Math.Abs(n)
;
            }
            if (n < 20)
            {
                return units[n];
            }
            if (n < 100)
            {
                return tens[n / 10] + " " + units[n % 10];
            }
            if (n < 1000)
            {
                return units[n / 100] + " Hundred " + ((n % 100 != 0) ? "And " : "") + convert(n % 100);
            }
            if (n < 100000)
            {
                return convert(n / 1000) + " Thousand " + convert(n % 1000);
            }
            if (n < 10000000)
            {
                return convert(n / 100000) + " Lakh " + convert(n % 100000);
            }
            return convert(n / 10000000) + " Crore " + convert(n % 10000000);
        }

        public static void Main(String[] args)
        {

            Console.WriteLine("Enter the digit to get in words");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(InWords.convert(amount));
        }
    }*/


