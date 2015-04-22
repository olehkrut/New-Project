using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ClassForRoman
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("{0} say: Give me a blow job!", Name);
        }
        public static void OutputToConsole(string msg)
        {
            Console.WriteLine("RomanClass say: {0}", msg);
        }
    }
}
