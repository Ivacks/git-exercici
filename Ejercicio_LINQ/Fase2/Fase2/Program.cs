using System;
using System.Linq;

namespace Fase2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var max = numbers.Max();

            var min = numbers.Min();

            var avr = numbers.Average();

            Console.WriteLine($"El número màxim és: {max}.");
            Console.WriteLine($"El número mínim és: {min}." );
            Console.WriteLine($"La mitjana és: {avr}.");




        }
    }
}
