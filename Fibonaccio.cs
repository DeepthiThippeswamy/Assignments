using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Fibonacci
    {
        static void Main()
        {
            fib(1000);
        }

        public static void fib(int num)
        {
            int a = 0;
            int b = 1;
            int i = 0;
            int c = 0;

            Console.Write(a + "," + b);
            for (i = 1; i < 10; i++)
            {
                c = a + b;
                Console.Write("," + c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
           
        
    

