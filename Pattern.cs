using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Patterns
    {
        public static void star()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            //Patterns p = new Patterns();
            star();
        }
    }
}
