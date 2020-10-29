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
            decimal elev1, elev2, elev3, elev4, elev5, media, scorul;

            Console.WriteLine("Introduceti punctajul: ");
            Console.Write("Elevul 1: ");
            elev1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Elevul 2: ");
            elev2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Elevul 3: ");
            elev3 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Elevul 4: ");
            elev4 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Elevul 5: ");
            elev5 = Convert.ToDecimal(Console.ReadLine());

            media = (elev1 + elev2 + elev3 + elev4 + elev5) / 5m;
            scorul = elev1 + elev2 + elev3 + elev4 + elev5;

            Console.WriteLine("Media este: " + media);
            Console.WriteLine("Scorul total este: " + scorul);












        }
    }
}
