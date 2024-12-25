using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
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
            int Count = 0;
            for(int x=10;x<=99;x++)
            {
                if(x%2==0)
                {
                    Console.WriteLine(x); Count++;
                }
            }
            Console.WriteLine($"count={Count}");
        }
    }
}
