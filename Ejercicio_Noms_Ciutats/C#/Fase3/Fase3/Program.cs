using System;
using System.Linq;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] ciutats = {"Barcelona", "Madrid", "Valencia", "Malaga", "Cadis", "Santander"};

            string[] ArrayCiutatsModificades = new string[ciutats.Length];

            ArrayCiutatsModificades = ciutats.Select(s => s.Replace("a", "4")).ToArray();

            Array.Sort(ArrayCiutatsModificades);

            Console.WriteLine("Las ciudades introducidas son las siguientes: ");
            for (int i = 0; i < ArrayCiutatsModificades.Length; i++)
            {
                Console.Write(ArrayCiutatsModificades[i] + " ");
            }
            Console.ReadKey();



        }
    }
}
