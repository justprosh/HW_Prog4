using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variations
{
    class Program
    {
        static IEnumerable<string> Str()
        {
            yield return "a";
            yield return "b";
            yield return "c";
            foreach(var s in Str())
            {
                switch (s[0])
                {
                    case 'a':
                        yield return 'b' + s;
                        yield return 'c' + s;
                        break;
                    case 'b':
                        yield return 'a' + s;
                        yield return 'c' + s;
                        break;
                    case 'c':
                        yield return 'a' + s;
                        yield return 'b' + s;
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            foreach(string s in Str().Take(100))
            {
                Console.WriteLine(s);
            }
        }
    }
}