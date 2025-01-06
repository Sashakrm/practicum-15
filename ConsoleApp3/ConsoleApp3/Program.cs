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
            int n = Input("До:");
            Func(n);
            Console.Read();
        }

        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static void Func(int n)
        {
            int sum = 0;
            for (int a = 1; a <= n; a++)
            {
                sum += a;
            }
            Console.WriteLine($"{sum}");
        }
    }
}