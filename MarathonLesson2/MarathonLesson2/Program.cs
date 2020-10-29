using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace MarathonLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Celsius, Kelvin, Fahrenheit;

            Console.WriteLine("Introdu temperatura: ");
            Celsius = Convert.ToDecimal(Console.ReadLine());

            Kelvin = Celsius + 275.15m;

            Fahrenheit = Celsius * 1.8m + 32m;

            Console.WriteLine("Kelvin: " + Kelvin);
            Console.WriteLine("Fahrenheit:" + Fahrenheit);












        }
    }
}
