﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Loopinginteger
    {
        static void Main()
        {
            Loop();
        }
        static void Loop()
        {
            int count = 0;
            List<object> loop = new List<object>();
            for (int i = 0; i <= loop.Count(); i++)
            {
                Console.WriteLine($"Enter the number{i + 1}:");
                var madhu = (object)Console.ReadLine();
                loop.Add(madhu);

                Console.WriteLine("If You want to stop the loop Press {No} and if u want to continue press any key:");
                string Y = Console.ReadLine();
                if (Y == "No")
                {
                    Console.WriteLine("The total count is :" + loop.Count());
                    Console.WriteLine($"Your loop will be stopped: and integer count is {count}");
                    Console.WriteLine("Non integer values count is : " + (loop.Count() - count));
                    break;
                }
                count++;
            }
            foreach (var i in loop)
            {
                Console.Write(i + "  ");
            }

        }
    }
}
