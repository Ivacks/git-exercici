using System;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciutat1 = "Barcelona";
            string[] barcelona = new string[ciutat1.Length];   
            barcelona[0] = "B";
            barcelona[1] = "a";
            barcelona[2] = "r";
            barcelona[3] = "c";
            barcelona[4] = "e";
            barcelona[5] = "l";
            barcelona[6] = "o";
            barcelona[7] = "n";
            barcelona[8] = "a";

            Array.Reverse(barcelona);

            Console.WriteLine("La ciudad 1: ");
            for (int i = 0; i < barcelona.Length; i++)
            {
                Console.Write(barcelona[i]);
            }

            string ciutat2 = "Madrid";
            string[] madrid = new string[ciutat2.Length];
            madrid[0] = "M";
            madrid[1] = "a";
            madrid[2] = "d";
            madrid[3] = "r";
            madrid[4] = "i";
            madrid[5] = "d";
            

            Array.Reverse(madrid);

            Console.WriteLine("\nLa ciudad 2: ");
            for (int i = 0; i < madrid.Length; i++)
            {
                Console.Write(madrid[i]);
            }

            string ciutat3 = "Valencia";
            string[] valencia = new string[ciutat3.Length];
            valencia[0] = "V";
            valencia[1] = "a";
            valencia[2] = "l";
            valencia[3] = "e";
            valencia[4] = "n";
            valencia[5] = "c";
            valencia[6] = "i";
            valencia[7] = "a";

            Array.Reverse(valencia);

            Console.WriteLine("\nLa ciudad 3: ");
            for (int i = 0; i < valencia.Length; i++)
            {
                Console.Write(valencia[i]);
            }

            string ciutat4 = "Malaga";
            string[] malaga = new string[ciutat4.Length];
            malaga[0] = "M";
            malaga[1] = "a";
            malaga[2] = "l";
            malaga[3] = "a";
            malaga[4] = "g";
            malaga[5] = "a";
            

            Array.Reverse(malaga);

            Console.WriteLine("\nLa ciudad 4: ");
            for (int i = 0; i < malaga.Length; i++)
            {
                Console.Write(malaga[i]);
            }

            string ciutat5 = "Cadis";
            string[] cadis = new string[ciutat5.Length];
            cadis[0] = "C";
            cadis[1] = "a";
            cadis[2] = "d";
            cadis[3] = "i";
            cadis[4] = "s";
            

            Array.Reverse(cadis);

            Console.WriteLine("\nLa ciudad 5: ");
            for (int i = 0; i < cadis.Length; i++)
            {
                Console.Write(cadis[i]);
            }

            string ciutat6 = "Santander";
            string[] santander = new string[ciutat6.Length];
            santander[0] = "S";
            santander[1] = "a";
            santander[2] = "n";
            santander[3] = "t";
            santander[4] = "a";
            santander[5] = "n";
            santander[6] = "d";
            santander[7] = "e";
            santander[8] = "r";

            Array.Reverse(santander);

            Console.WriteLine("\nLa ciudad 6: ");
            for (int i = 0; i < santander.Length; i++)
            {
                Console.Write(santander[i]);
            }


            Console.ReadKey();

        }
    }
}
