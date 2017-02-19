using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static bool isPrime(int x)
        {

            for (int i = 2; i <= Math.Sqrt(x); i ++)
                if (x % i == 0) return false;
            return true;
        }
        static bool isReprTwoPrime(int x)
        {
            if (x % 2 == 0)
            {
                if (isPrime(x / 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(x); i+=2)
                {
                    if (x % i == 0 && isPrime(i) && isPrime(x/i))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (isReprTwoPrime(x))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
