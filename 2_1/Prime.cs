using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_4
{
    class Program
    {
        static bool isPrime(int x)
        {
            double fr = Math.Sqrt(x);
            for (int i = 2; i <= fr; i++)
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
                for (int i = 3; i <= x / 2; i += 2)
                {
                    if (x % i == 0)
                    {
                        if (isPrime(x / i))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
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
