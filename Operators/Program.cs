using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;

            var b = 2;

            var c = 3;

            Console.WriteLine( c > b || c == a);

            /*
            Console.WriteLine(a + b * c);// 1 + (2 * 3) = 7
            Console.WriteLine((a + b) * c);// (1 + 2) *3 = 9
            Console.WriteLine((float)a / (float)b);
            */
        }
    }
}
 