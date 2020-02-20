using System;
using System.Collections.Generic;
using System.Linq;

namespace Paso1_2
{
    class Program
    {

        /*Declaración constantes y listas.*/
        static char EscapeCharacter = 'E';
        static string EscapeWord = "E";
        static List<string> nom_alumne = new List<string>();
        static List<double> nota_alumne = new List<double>();
        private int to_go;

        public int To_go
        {
            get { return to_go; }
            set { to_go = value; }
        }


        /*Declaración de funciones.*/
        static void ShowMainMenu()
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("*****************");
            Console.WriteLine("");
            Console.WriteLine("Menu de selección");
            Console.WriteLine("*****************");
            Console.WriteLine("1.Introducir datos alumnos.");
            Console.WriteLine("2.Datos de los alumnos.");
            Console.WriteLine("3.Centro de operaciones.");
            Console.WriteLine("*****************");
            Console.WriteLine("NOTA: para salir a este panel de control teclear E.");
            Console.WriteLine("*****************");
            Console.WriteLine("");

        } //Muestra el menu.
        static void ClearThePath()
        {
            Console.Clear();
        }//Borra el contenido presente en consola.
        static void FillTheAlumniData() 
        {
            double nota_double;
            bool check_alumni = true;
            Console.WriteLine("Bienvenidos al menu de los suspensos, digo de indicar notas");
            Console.WriteLine("*****************");
            Console.WriteLine("Para volver a menu principal escribir E en el apartado de nombre.");
            Console.WriteLine("*****************");
            Console.WriteLine("Ejemplo nota: 9.8 o 0.2");
            while (check_alumni) 
            { 
                Console.Write("Introduce nombre del alumno: ");
                string nom_move = Console.ReadLine();
                if (nom_move == "E")
                {
                    break;
                }
                Console.Write($"Introduce nota de {nom_move}: ");
                var nota_move = Console.ReadLine();
                double.TryParse(nota_move.Replace(".",","), out nota_double);


                nom_alumne.Add(nom_move);
                nota_alumne.Add(nota_double);

            }
            ClearThePath();
            ShowMainMenu();
        }//Llena los datos de la lista de los alumnos
        static void ZaWarudo()
        {
            Console.WriteLine("Muestra de alumnos:");
            foreach(var nom_mostra in nom_alumne)
            {
                Console.WriteLine($"{nom_mostra}");
            }
            Console.WriteLine("Muestra de notas");    
            foreach (double nota_mostra in nota_alumne)
            {
                Console.WriteLine($"{nota_mostra}");
            }
        }//Muestra los alumnos y sus notas.
        static void Wolololo()//Hace cosas con los numeros, cosas muy locas, algunos dicen es cosa de brujas.
        {
            Console.WriteLine("Bienvenido a donde se produce la magia");
            Console.WriteLine("***************");
            Console.WriteLine("1.Nota minima");
            Console.WriteLine("2.Nota maxima");
            Console.WriteLine("3.Nota media");
            string wolo = Console.ReadLine();


            if (wolo == "1")
            {
                Console.WriteLine("***************");
                LowValue();
            }
            else if (wolo == "2")
            {
                Console.WriteLine("***************");
                HighValue();
            }
            else if (wolo == "3")
            {
                Console.WriteLine("***************");
                AverageValue();
            }
            else
            {
                ClearThePath();
                ShowMainMenu();
            }

        }
        static void LowValue()
        {
            double nota_minima = nota_alumne.Min();
            Console.WriteLine($"La nota minima es: {nota_minima}");
            Console.ReadKey();
            ShowMainMenu();
        }//Muestra el número mas bajo
        static void HighValue()
        {
            double nota_maxima = nota_alumne.Max();
            Console.WriteLine($"La nota maxima es: {nota_maxima}");
            Console.ReadKey();
            ShowMainMenu();
        }//Muestra el número mas alto.
        static void AverageValue()
        {
            double nota_media = nota_alumne.Average();
            Console.WriteLine($"La nota mitjana es: {nota_media}");
            Console.ReadKey();
            ShowMainMenu();
        }//Muestra la media de todas las notas.
        
        /*MAIN*/
        static void Main(string[] args)
        {
            ShowMainMenu();

            bool check = true;
            while (check)
            {
                Console.Write("Elige tu opción (vigila con lo que haces, we are watching u): ");
                string erabe = Console.ReadLine();
              
                if (erabe == "1")
                {
                    ClearThePath();
                    FillTheAlumniData();
                }
                else if (erabe == "2")
                {
                    ClearThePath();
                    ZaWarudo();
                }
                else if (erabe == "3")
                {
                    ClearThePath();
                    Wolololo();
                }
                else
                {
                    ClearThePath();
                    ShowMainMenu();
                }

                if (EscapeWord == erabe)
                {
                    check = false;
                }
            }

            Console.ReadKey();

        }
        

        
    }
}


