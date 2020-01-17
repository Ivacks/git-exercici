using System;

namespace Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entra el teu nom: \n");
            string nom = Console.ReadLine();
            char[] desglossat_nom = nom.ToCharArray();
            int i;
            Console.Write("El teu nom desglossat és així: ");
            for ( i = 0; i < desglossat_nom.Length ; i++)
            { 
                Console.Write(desglossat_nom[i] + " ");
            }
            Console.ReadKey(true);
        }
        
    }
}
