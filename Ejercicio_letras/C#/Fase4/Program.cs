using System;
using System.Collections.Generic;
using System.Linq;


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
            nom.Add(',');
            surname.Add('N');
            surname.Add('A');
            surname.Add('V');
            surname.Add('A');
            surname.Add('R');
            surname.Add('R');
            surname.Add('O');


            List<char> fullname = nom.Concat(surname).ToList();
            fullname.ForEach(item => System.Console.WriteLine(item));

        }
    }
}
