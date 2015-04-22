using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm sexy and i know it");
            Console.WriteLine();
            ClassForRoman roman = new ClassForRoman() { Name = "Roman" };
            Console.WriteLine(roman);
            ClassForRoman.OutputToConsole("Hello!");
            Console.ReadLine();
        }
    }
}
