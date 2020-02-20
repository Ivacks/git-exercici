using System;
using System.Collections.Generic;
using System.Linq;
using Test;
using Topic;
using Alumni;






namespace Paso2_3
{
    class Program
    {
        /*Declaración constantes y listas.*/
        static char EscapeCharacter = 'E';
        static string EscapeWord = "E";
        static IDictionary<int, string> studentdict = new Dictionary<int, string>();    
        static IDictionary<int, double> nota_alumne = new Dictionary<int, double>();
        static IDictionary<int, string> id_alumne = new Dictionary<int, string>();
        static IDictionary<int, string> tema = new Dictionary<int, string>();

        
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
            int i = 1;
            var estudiant = new Students();
            var nota_move = new Subject();
            var id = new Students();
            var asignatura = new Exam();
            bool check_alumni = true;
            Console.WriteLine("Bienvenidos al menu de los suspensos, digo de indicar notas");
            Console.WriteLine("*****************");
            Console.WriteLine("Para volver a menu principal escribir E en el apartado de nombre.");
            Console.WriteLine("*****************");
            Console.WriteLine("Ejemplo nota: 9,8 o 0,2. Importante utilizar comas.");
            while (check_alumni)
            {
                /*Introduce nombre alumno*/
                Console.Write("Introduce nombre del alumno: ");
                estudiant.name = Console.ReadLine() ;
                if (estudiant.name == "E")
                {
                    break;
                }
                /*Introduce DNI alumno*/
                Console.Write($"Introduce DNI de {estudiant.name}: ");
                id.DNI = Console.ReadLine();
                /*Introduce nota alumno*/
                Console.Write($"Introduce nota de {estudiant.name}: ");
                nota_move.notes = Convert.ToDouble(Console.ReadLine());
                string note_pass = Convert.ToString(nota_move.notes);
                double note_comme = Convert.ToDouble(note_pass);
                /*Introduce asignatura a puntuar*/
                Console.Write("Introduce asignatura: ");
                asignatura.theme = Console.ReadLine();
                
                /*Añadiendo a diccionarios*/
                studentdict.Add(i, estudiant.name);
                nota_alumne.Add(i , note_comme);
                id_alumne.Add(i, id.DNI);
                tema.Add(i, asignatura.theme);
                
                i++;
            }
            ClearThePath();
            ShowMainMenu();
        }//Llena los datos de la lista de los alumnos
        static void ZaWarudo()
        {
            Console.WriteLine("Bienvenidos al muro de las lamentaciones");
            Console.WriteLine("*****************");
            for (int i = 0; i < studentdict.Count; i++)
            {
                Console.WriteLine($"DNI : {id_alumne[i+1]} Alumno: {studentdict[i+1]} Asignatura: {tema[i+1]} Nota: {nota_alumne[i+1]}");
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
            var nota_minima = nota_alumne.Values.Min();
            Console.WriteLine($"La nota minima es: {nota_minima}");
            Console.ReadKey();
        }//Muestra el número mas bajo
        static void HighValue()
        {
            var nota_maxima = nota_alumne.Values.Max();
            Console.WriteLine($"La nota maxima es: {nota_maxima}");
            Console.ReadKey();
        }//Muestra el número mas alto.
        static void AverageValue()
        {
            double nota_media = nota_alumne.Values.Average();
            Console.WriteLine($"La nota mitjana es: {nota_media}");
            Console.ReadKey();
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