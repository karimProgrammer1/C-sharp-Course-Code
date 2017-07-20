using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("Min value = {0} max value = {1}", flMin, flMax);

            float flVar = 1f / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;
            Console.WriteLine("\nFloat value = {0}\nDouble Value = {1}\nDecimal Value = {2}\n", flVar, dlVar, dcVar);

            Console.ReadKey();
        }
    }
}
