using System;
using System.Linq;

namespace Fase1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var numbers_odd = numbers.Where(x => x % 2 != 1);

            foreach(int odd in numbers_odd)
            {
                Console.WriteLine($"Este numero es par: {odd}");
            }

            Console.ReadKey();

        }
    }
}
