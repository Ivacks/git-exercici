using System;
using System.Collections.Generic;
using System.Linq;
using Test;
using Topic;
using Alumni;
using Database;
using _3.Paso3_4;

namespace Paso2_3
{
    class Program
    {
        /*Declaración constantes y listas/diccionarios.*/
        static string EscapeWord = "E";

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
            bool check_alumni = true;

            while (check_alumni)
            {
                Console.WriteLine("Bienvenidos al menu de los suspensos, digo de indicar notas");
                Console.WriteLine("*****************");
                Console.WriteLine("");
                Console.WriteLine("Menu de selección");
                Console.WriteLine("*****************");
                Console.WriteLine("1.Introducir nombres alumnos.");
                Console.WriteLine("2.Introducir asignaturas que cursan los alumnos.");
                Console.WriteLine("3.Introducir notas de los alumnos.");
                Console.WriteLine("*****************");

                string erabe = Console.ReadLine();

                if (erabe == "1")
                {
                    ClearThePath();
                    FilltheNames();

                }
                else if (erabe == "2")
                {
                    ClearThePath();
                    FilltheExams();
                }
                else if (erabe == "3")
                {
                    ClearThePath();
                    FilltheNotes();
                }
                else
                {
                    break;
                }
            }
            ClearThePath();
            ShowMainMenu();

        }//Llena los datos de la lista de los alumnos
        static void ZaWarudo()
        {
            var id_alumne = new DbContext();
            var studentdict = new DbContext();
            var tema = new DbContext();
            var nota_alumne = new DbContext();

            Console.WriteLine("Bienvenidos al muro de las lamentaciones");
            Console.WriteLine("*****************");
            Console.WriteLine("Lista de alumnos:");
            foreach (KeyValuePair<ID, Students> student in DbContext._dicc_students)
            {
                Console.WriteLine($"DNI: {student.Key.Id} Nombre: {student.Value.name}.");
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Lista de examenes:");
            foreach (KeyValuePair<ID, Exam> exam in DbContext._dicc_exams)
            {
                Console.WriteLine($"DNI: {exam.Key.Id} Examen: {exam.Value.theme}");
            }
            Console.WriteLine("*****************");
            Console.WriteLine("Lista de notas:");
            foreach (KeyValuePair<ID, Subject> nota in DbContext._dicc_theme)
            {
                Console.WriteLine($"DNI: {nota.Key.Id} Nota: {nota.Value.notes}");
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
            var nota_minima = 0.00;
            foreach (KeyValuePair<ID, Subject> notas in DbContext._dicc_theme)
            {
                nota_minima = Math.Min(nota_minima, notas.Value.notes);
            }
            Console.WriteLine($"La nota minima es: {nota_minima}");
            Console.ReadKey();
        }//Muestra el número mas bajo
        static void HighValue()
        {
            var nota_maxima = 0.00;
            foreach (KeyValuePair<ID, Subject>notas in DbContext._dicc_theme)
            {
                nota_maxima = Math.Max(nota_maxima, notas.Value.notes);
            }
            Console.WriteLine($"La nota maxima es: {nota_maxima}");
            Console.ReadKey();
        }//Muestra el número mas alto.
        static void AverageValue()
        {
            var nota_media = 0.00;
            var nota_sumada = 0.00;
            foreach (KeyValuePair<ID, Subject> notas in DbContext._dicc_theme)
            {
                nota_sumada += notas.Value.notes;
            }
            nota_media = nota_sumada / Convert.ToDouble(DbContext._dicc_theme.Count);
            Console.WriteLine($"La nota mitjana es: {nota_media}");
            Console.ReadKey();
        }//Muestra la media de todas las notas.
        static void FilltheExams()
        {
            var id = new ID();
            var asignatura = new Exam();

            foreach (KeyValuePair<ID, Students> nom in DbContext._dicc_students)
            {
                Console.WriteLine($"DNI: {nom.Key.Id} Alumno: {nom.Value.name}");
            }

            /*Introduce DNI alumno*/
            Console.Write($"Introduce DNI: ");
            id.Id = Console.ReadLine();
            /*Introduce asignatura a puntuar*/
            Console.Write("Introduce asignatura: ");
            asignatura.theme = Console.ReadLine();

            DbContext.AddnameExams(asignatura, id);
        }//Rellena DNI con asignatura
        static void FilltheNames()
        {
            var estudiant = new Students();
            var id = new ID();

            /*Introduce DNI alumno*/
            Console.Write($"Introduce DNI: ");
            id.Id = Console.ReadLine();
            /*Introduce nombre alumno*/
            Console.Write("Introduce nombre del alumno: ");
            estudiant.name = Console.ReadLine();

            DbContext.AddnameStudent(estudiant, id);

        }//Rellena DNI con nombre
        static void FilltheNotes()
        {
            var nota_move = new Subject();
            var id = new ID();

            foreach (KeyValuePair<ID, Students> nom in DbContext._dicc_students)
            {
                Console.WriteLine($"DNI: {nom.Key.Id} Alumno: {nom.Value.name}");
            }

            Console.WriteLine("Ejemplo nota: 9,8 o 0,2. Importante utilizar comas.");
            Console.WriteLine("*****************");
            /*Introduce DNI alumno*/
            Console.Write($"Introduce DNI: ");
            id.Id = Console.ReadLine();
            /*Introduce nota alumno*/
            Console.Write($"Introduce nota: ");
            nota_move.notes = Convert.ToDouble(Console.ReadLine());

            DbContext.AddnameSubject(nota_move, id);

        }//Rellena DNI con notas

    }
}