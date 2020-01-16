using System;
using System.Collections.Generic;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int any_traspas = 1948;
            Console.Write("Entra el teu any de naixement: ");
            string enter_year = Console.ReadLine();
            int my_year = Convert.ToInt32(enter_year);
            int transition_year = 4;

            int yearsoftransition = (my_year - any_traspas) / transition_year;

            Console.WriteLine($"Del 1948 al teu naixement hi ha: {yearsoftransition} anys de traspàs.");

            Console.ReadKey(true);


            
            

        }
    }
}
