using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year_one = 1948;
            Console.Write("Entra el teu any de naixement: ");
            string enter_year = Console.ReadLine();
            int my_year = Convert.ToInt32(enter_year);
            bool transition_year_check = false; 
            


            do
            {
                year_one++;
              if (( (year_one % 4 == 0) && (year_one % 100 != 0)) || ((year_one % 100 == 0) && (year_one % 400 == 0)))
                {
                    if (year_one == my_year)
                    {
                        transition_year_check = true;
                    }
                    Console.Write($"El {year_one} és any de traspàs. \n");
                }
            } while (year_one <= my_year);
            if (transition_year_check)
            {
                Console.Write($"El teu any de naixement {my_year} és de traspàs. \n");
            } else
            {
                Console.Write($"El teu any de naixement {my_year} no és de traspàs. \n");
            }
            


            Console.ReadKey(true);
        }
    }
}
