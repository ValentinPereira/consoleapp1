using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            int x = 3;
            i = i + x;
            x = i - x;
            i = i - x;
            Console.WriteLine(i);
            Console.WriteLine(x);
        }
    }
}
