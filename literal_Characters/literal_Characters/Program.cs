using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000U;
            
            float myFlVar = 1.5f;
            double myDVar = 100.5d;
            decimal myDecVar = 100.5m;

            Console.WriteLine("{0} {1}",myVar, myUVar);
            Console.WriteLine($"{myDVar},{myDecVar}");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
