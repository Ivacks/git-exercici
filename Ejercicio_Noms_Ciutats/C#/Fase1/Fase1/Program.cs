using System;

namespace Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix el nom de la ciutat 1");
            string ciutat1 = Console.ReadLine();
            Console.WriteLine("Introdueix el nom de la ciutat 2");
            string ciutat2 = Console.ReadLine();
            Console.WriteLine("Introdueix el nom de la ciutat 3");
            string ciutat3 = Console.ReadLine();
            Console.WriteLine("Introdueix el nom de la ciutat 4");
            string ciutat4 = Console.ReadLine();
            Console.WriteLine("Introdueix el nom de la ciutat 5");
            string ciutat5 = Console.ReadLine();
            Console.WriteLine("Introdueix el nom de la ciutat 6");
            string ciutat6 = Console.ReadLine();

            Console.WriteLine($"Las ciudades introducidas son las siguientes: {ciutat1}, {ciutat2}, {ciutat3}, {ciutat4}, {ciutat5}, {ciutat6}.");

            Console.ReadKey();


        }
    }
}
