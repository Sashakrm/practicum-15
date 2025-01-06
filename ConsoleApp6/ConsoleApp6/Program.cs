using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }

        static void Func()
        {
            int value = 0;
            for (int x=10; x <= 99; x++)
            {
                if (x %2== 0)
                {
                    Console.WriteLine(x);
                    value++;
                }
            }
            Console.WriteLine($"всего:{value}");
        }
    }
}