using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
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
            Random random = new Random();
            for(int x=0;x <12;x++)
            {
                int number = random.Next(-50,50);
                Console.Write(number);
                if (number > 0)
                {
                    Console.WriteLine("-положительное");
                }
                else if (number<0)
                {
                    Console.WriteLine("-отрицательное");
                }
            }
           
        }
    }
}
