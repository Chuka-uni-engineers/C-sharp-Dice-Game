using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            int a = 32;
            Decimal b = (Decimal)a / 2;
            Console.WriteLine(b);

            Console.WriteLine(@"    Lucky number generator!!\n");
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int luckyNumber = age / 2 * 3 + 1;
            Console.WriteLine($"Hello {name}\nYour lucky number is> {luckyNumber}");

            
            Console.ReadLine();
        }
    }
}
