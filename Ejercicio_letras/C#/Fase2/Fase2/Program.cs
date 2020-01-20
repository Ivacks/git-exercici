using System;
using System.Collections;
using System.Collections.Generic;


namespace Fase2
{
    class Program   
    {
        static void Main(string[] args)
        {
            
            List<char> nom = new List<char>();

            nom.Add('I');
            nom.Add('V');
            nom.Add('A');
            nom.Add('N');

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(nom[i]);
                if((nom[i] == 'A') || (nom[i] == 'E') || (nom[i] == 'I') || (nom[i] == 'O') || (nom[i] == 'U'))
                {
                    Console.WriteLine("VOCAL");
                }
                else
                {
                    Console.WriteLine("CONSONANT");
                }

                if ((nom[i] == '0') || (nom[i] == '1') || (nom[i] == '2') || (nom[i] == '3') || (nom[i] == '4') || (nom[i] == '5') || (nom[i] == '6') || (nom[i] == '7') || (nom[i] == '8') || (nom[i] == '9'))
                {
                    Console.WriteLine("El nom de les persones no contenen números");
                }
                

            }
        }
    }
}
