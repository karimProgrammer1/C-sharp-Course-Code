using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringType
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Karim said this is a good course and I think";
            string myString2 = "Yes, It Is";
            string myString3 = myString + myString2;
            Console.WriteLine("{0}", myString3);
            Console.ReadKey();
        }
    }
}
