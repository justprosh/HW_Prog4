using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hSet = new HashSet<int>();
            int x;
            while ((x = int.Parse(Console.ReadLine())) != 0)
            {
                int tmp = 100 - x;
                if (!hSet.Contains(tmp))
                {
                    hSet.Add(x);
                }
                else
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}
