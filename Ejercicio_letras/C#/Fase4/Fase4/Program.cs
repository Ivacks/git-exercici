using System;
using System.Collections.Generic;
namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> nom = new List<char>();
            List<char> surname = new List<char>();

            nom.Add('I');
            nom.Add('V');
            nom.Add('A');
            nom.Add('N');
            surname.Add('N');
            surname.Add('A');
            surname.Add('V');
            surname.Add('A');
            surname.Add('R');
            surname.Add('R');
            surname.Add('O');

            nom.AddRange(surname);

            Console.WriteLine(nom[0] + ", " + nom[1] + ", " + nom[2] + ", " + nom[3] + ",  ," + nom[4] + ", " + 
                nom[5] + ", " + nom[6] + ", " + nom[7] + ", " + nom[8] + ", " + nom[9] + ", " + nom[10]);

        }
    }
}
