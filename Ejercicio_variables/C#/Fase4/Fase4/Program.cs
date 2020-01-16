using System;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom_cognom = "Ivan Navarro Vargas";
            string data_naixement = "04/06/1994";
            int any_naixement = DateTime.Parse(data_naixement).Year;


            Console.Write($"El meu nom és {nom_cognom}. \n");
            Console.Write($"Vaig néixer el {data_naixement}. \n");



            if ((((any_naixement % 4 == 0) && (any_naixement % 100 != 0)) || ((any_naixement % 100 == 0) && (any_naixement % 400 == 0))))
            {
                Console.Write("El meu any de naixement és de traspàs.");
            }
            else
            {
                Console.Write("El meu any de naixement no és de traspàs.");
            }

            Console.ReadKey(true);
        }
    }
}
