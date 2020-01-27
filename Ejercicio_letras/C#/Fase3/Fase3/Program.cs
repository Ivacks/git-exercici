using System;
using System.Collections.Generic;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> nom = new Dictionary<char, int>();

            // Rellenar diccionario

            nom.Add('I', 1);
            nom.Add('V', 1);    
            nom.Add('A', 1);
            nom.Add('N', 1);

            foreach (char s  in nom.Keys)
            {
                Console.WriteLine("Lletra: " + s);
                foreach (int i in nom.Values)
                {
                    Console.WriteLine("Nombre d'intents: " + i);
                }
            }


        }
    }
}
