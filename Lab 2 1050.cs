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

            int number1; 
            int number2; 
            int sum;

            Console.Write(6);
            number1 = int.Parse(Console.ReadLine());

            Console.Write(82);
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}");

            int x = 12;
            int y = 14;
            int z = 7;
            int solution = (x + y) * (z + 10);

            Console.WriteLine("Solution is (0)", Solution);


            Console.WriteLine("Hello \t World");
            Console.WriteLine("Hello \n World");
            Console.WriteLine("\" Hello World \"");
            Console.WriteLine("Hello \\ World");
        }
    }
}
