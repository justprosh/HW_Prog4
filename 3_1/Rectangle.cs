using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Tuple<int, int>> rect = new Dictionary<int, Tuple<int,int>>();
            int a = 0, b = 0;
            for (;;)
            {
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Nope");
                    break;
                }
                b = int.Parse(Console.ReadLine());
                if (rect.ContainsKey(a * b))
                {
                    Console.WriteLine("Yep");
                    Console.WriteLine("First Rectangle: {0} : {1} \nSecond Rectangle: {2} : {3}", 
                                                        rect[a * b].Item1, rect[a * b].Item2, a, b);
                    break;
                }
                rect.Add(a * b, new Tuple<int, int>(a, b));
            }

        }
    }
}
