using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Char_String_Bool_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = Char.MinValue;
            int charMax = Char.MaxValue;
            int myVarValue = 'G';
            char myVar = 'G';
            char myVarValue2 = Convert.ToChar(myVarValue);
            Console.WriteLine("Min Char = {0} Max char = {1} My Character = {2} My Variable Number = {3} my conversion value is = {4}", charMin, charMax, myVar, myVarValue, myVarValue2);

            string myString = "This is my Variable";
            Console.WriteLine("\nmy string is {0}", myString);

            bool myBool = true;
            Console.WriteLine("My boolean Value is {0}", myBool);

            Console.ReadKey();
        }
    }
}
