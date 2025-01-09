using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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
            double price = 20.4;
            for (int a = 1; a <= 20; a++)
            {
                var totalprice = price * a;
                Console.WriteLine($"{a} товар стоит:{totalprice:F1} рублей");
            }
        }
    }
}