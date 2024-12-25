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
            int count_1 = 0;
            int count_2 = 0;
            Random random = new Random();
            for(int x=0;x <12;x++)
            {
                int number = random.Next(-50,50);
                Console.WriteLine(number);
                if (number > 0) count_1++;
                else if (number < 0) count_2++;
            }
            Console.WriteLine($"больше нуля: {count_1}");
            Console.WriteLine($"меньше нуля: {count_2}");
        }
    }
}
