using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class SumOfPrime

    {
        private static bool CheckPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {

                    return false;

                }
            }
            return true;
        }
        private static int SumPrime(int a, int b)
        {
            int sum = 0;
            a = 4;
            b = 13;

            for (int i = b; i >= 1; i--)
            {
                bool isPrime = CheckPrime(i);
                if (isPrime)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

            static void Main(string[] args)
            {
                Console.WriteLine("SumPrime(a,b)");
            }

        }
    }

