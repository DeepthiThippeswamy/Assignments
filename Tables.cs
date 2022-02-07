using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Tables
    {
        public static void Main(String[] args)
        {
            
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine(a+"*"+i+"="+i*a);
                i++;
            }
            

        }
    }
}
