using System;
using System.Collections.Generic;
using System.Linq;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Inicio Fase 1*/
            int bitllet_5;
            int bitllet_10;
            int bitllet_20;
            int bitllet_50;
            int bitllet_100;
            int bitllet_200;
            int bitllet_500;
            int preu_total = 0 ;

            int[] preu = new int[5];
            string[] menu = new string[5];
            /*Fin Fase 1*/

            /*Inicio Fase 2*/
            List<string> Menu_Comparatiu = new List<string>();
            int i;
            for (i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"Introdueix nombre del plat {i+1}:");
                menu[i] = Console.ReadLine();
                Console.WriteLine($"Introdueix preu de {menu[i]}:");
                preu[i] = Int32.Parse(Console.ReadLine());
                Menu_Comparatiu.Add($"{menu[i]} {preu[i]} ");

            }

            for (i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"El plat de {menu[i]} te un preu de {preu[i]}.");
            }

            Console.WriteLine("**************** \n");

            List<string> Menu_Preu = new List<string>();
            bool check = true;
            while (check)
            {
                
                Console.WriteLine("Quin menu vols escollir?");
                Console.WriteLine($"1. {menu[0]} {preu[0]}:C");
                Console.WriteLine($"2. {menu[1]} {preu[1]}");
                Console.WriteLine($"3. {menu[2]} {preu[2]}");
                Console.WriteLine($"4. {menu[3]} {preu[3]}");
                Console.WriteLine($"5. {menu[4]} {preu[4]}");

                Menu_Preu.Add(Console.ReadLine());

                Console.WriteLine("Vols seguir demanant? 0:No 1:Si");
                int confirmacio = Int32.Parse(Console.ReadLine());

                if (confirmacio == 0)
                {
                    check = false;
                }
                 
            }

            Console.WriteLine("El menu escollit es: ");
            Console.WriteLine("************************* ");
            Menu_Preu.ForEach(Console.WriteLine);
            /*Fin Fase 2 */

            /*Inicio Fase 3*/

            bool check1 = true;

            foreach(var comparador in Menu_Preu)
            {
                for (i = 0; i < preu.Length; i++)
                {
                    if(comparador == menu[i])
                    {
                        preu_total += preu[i];
                        check1 = true;
                    }
                    
                }
                if (check1 != true)
                {
                    Console.WriteLine($"El producte demanat no existeix: {comparador}");
                }
            }

            Console.WriteLine("**********************");
            Console.WriteLine($"PREU TOTAL: {preu_total} ");

            /*Fin Fase 3*/

            Console.ReadKey();
        }
    }
}
