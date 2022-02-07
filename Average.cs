using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Average
    {
        static void Main(string[] args)
        {
            int i = 1;
            double ptotal = 0;
            double ntotal = 0;
            int pcount = 0;
            int ncount = 0;
            double pavg = 0;
            double navg = 0;
            while(i<=10)
            {
                Console.WriteLine($"Enter the {i} numbers");
                double num = double.Parse(Console.ReadLine());
                if(num>=0)
                {
                    pcount = pcount + 1;
                    ptotal = ptotal + num;
                    pavg = ptotal / pcount;
                }
                else
                {
                    ncount = ncount + 1;
                    ntotal = ntotal + num;
                    navg = ntotal / ncount;
                }
                i++;
                Console.WriteLine($"Positive average number is{pavg}: ");
                Console.WriteLine($"Negative average number is{navg}:");
            }
        }
    }
}
