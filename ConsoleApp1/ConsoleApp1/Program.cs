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
            Func();
            Console.Read();
        }

        static void Func()
        {
            Random random = new Random();
            for (int x = 0; x < 8; x++)
            {
                int number = random.Next(-30, 30);
                Console.Write(number);
                if (number > 0)
                {
                    Console.Write("-положительное");
                }
                else if (number<0)
                {
                    Console.Write("-отрицательное");
                }
                else 
                {
                    Console.WriteLine("нейтральное");
                }

                if (number != 0)
                { 
                    if(number%2==0)
                    {
                        Console.WriteLine("-четное");
                    }
                    else
                    {
                        Console.WriteLine("-нечетное");
                    }
                }
            }
        }
    }
}