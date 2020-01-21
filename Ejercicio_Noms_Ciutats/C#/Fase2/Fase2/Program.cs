using System;

namespace Fase2
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

            string[] ciutats = new string[6];
            ciutats[0] = ciutat1;
            ciutats[1] = ciutat2;
            ciutats[2] = ciutat3;
            ciutats[3] = ciutat4;
            ciutats[4] = ciutat5;
            ciutats[5] = ciutat6;

            Array.Sort(ciutats);

            Console.WriteLine("Las ciudades introducidas son las siguientes: ");
            for (int i = 0; i < ciutats.Length; i++)
            {
                Console.Write(ciutats[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
