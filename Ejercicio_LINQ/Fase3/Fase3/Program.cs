using System;
using System.Linq;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            var higher_than_5 = numbers.Where(x => x > 5);

            var lower_than_5 = numbers.Where(x => x < 5);

            int[] higher = new int[numbers.Length];

            int[] lower = new int[numbers.Length];

            int i = 0;

            foreach (int high in higher_than_5 )
            {
                if (high > 5)
                {
                    i++;
                    higher[i-1] = high;
                }
            }

            foreach (int low in lower_than_5)
            {
                if (low < 5)
                {
                    i++;
                    lower[i - 1] = low;
                }
            }

            foreach (int show_higher in higher)
            {
                Console.Write(show_higher + "");
            }

            Console.WriteLine();

            foreach (int show_lower in lower)
            {
                Console.Write(show_lower + "");
            }



            Console.ReadKey();
        }
    }
}
