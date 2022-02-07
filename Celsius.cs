using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Celsius
    {       
        static void Main(String[] args)
         {
             double fahrenheit;
            double celsius = 32;
             Console.WriteLine("celsius:" + celsius);

             Console.WriteLine("Enter the value of temperture in Fahrenheite:");
             fahrenheit = double.Parse(Console.ReadLine());

             fahrenheit = (celsius * 18) / 10 + 32;
             Console.WriteLine("Fahrenheit:" + fahrenheit);

             Console.ReadLine();
         }
    }
}
