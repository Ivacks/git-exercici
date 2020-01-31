using System;
using System.Linq;


namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] noms = {"David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };

            var noms_O = from nom in noms
                         where nom.Contains("O")
                         orderby nom descending
                         select nom;

            var noms_lenght = from nom in noms
                              where nom.Length >= 6
                              orderby nom descending
                              select nom;

            var noms_sort = from nom in noms
                            orderby nom descending
                            select nom;


            foreach (string ou in noms_O)
            {
                Console.WriteLine($"Aquest nom comença per O: {ou}.");
            }

            Console.WriteLine("****");

            foreach (string lenght in noms_lenght)
            {
                Console.WriteLine($"Aquest nom supera els 6 caracteres: {lenght}.");
            }

            Console.WriteLine("****");

            foreach (string descend in noms_sort)
            {
                Console.WriteLine($"{descend}");
            }

            Console.ReadKey();

        }
    }
}
