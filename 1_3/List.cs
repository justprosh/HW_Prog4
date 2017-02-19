using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Func(int i)
        {
            return i * i;
        }
        static void PrintTable(int from, int to, Func<int, int> f)
        {
            for (int i = from; i < to; i++)
            {
                Console.WriteLine("{0} {1}", i, f(i));
            }
        }

        static void Main(string[] args)
        {
            List<List<int>> l = new List<List<int>>() { new List<int>(){ 1, 4, 5, 6, 325 }, 
							new List<int>() { 55, 4, 5, 3, 4, 10 }, 
							new List<int>() { 4, 5, 20, 4, 5, 6 } };
            bool boo = l.All(x => x.Any(y => y % 10 == 0));
            Console.WriteLine(boo);
        }
    }
}
