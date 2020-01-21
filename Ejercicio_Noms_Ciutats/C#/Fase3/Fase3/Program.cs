using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ciutats = {"B4rcelon4", "M4drid", "V4lenci4", "M4l4l4", "C4dis", "S4nt4nder"};

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
