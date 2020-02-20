using _3.Paso3_4;
using Alumni;
using System;
using System.Collections.Generic;
using System.Text;
using Test;
using Topic;

namespace Database
{
    public class DbContext
    {
        /* Dictionary Section */
        public static Dictionary<ID, Students> _dicc_students { get; set; } = new Dictionary<ID, Students>();
        public static Dictionary<ID, Exam> _dicc_exams { get; set; } = new Dictionary<ID, Exam>();
        public static Dictionary<ID, Subject> _dicc_theme { get; set; } = new Dictionary<ID, Subject>();
        public static Dictionary<string, ID> _dicc_master { get; set; } = new Dictionary<string, ID>();

        /* Methods Section */
        public static bool AddnameStudent(Students name, ID id)
        {
            if(id.Id == null)
            {
                return false;
            }
            _dicc_students.Add(id, name);
            

            return true;
        }
        public static bool AddnameExams(Exam topic, ID id)
        {
            if (id.Id == null)
            {
                return false;
            }
            _dicc_exams.Add(id, topic);


            return true;
        }
        public static bool AddnameSubject(Subject number, ID id)
        {
            if (id.Id == null)
            {
                return false;
            }

            _dicc_theme.Add(id, number);

            return true;
        }
        public static bool AddID (string i, ID id)
        {
            if (id.Id == null)
            {
                return false;
            }

            _dicc_master.Add(i, id);

            return true;
        }
        public static bool ModifyValueStudent(Students name, ID id)
        {
            if(name.Id == null)
            {
                return false;
            }

            _dicc_students[id] = name;

            return true;
        }
        public static bool ModifyValueExams(Exam topic, ID id)
        {
            if (id.Id == null)
            {
                return false;
            }

            _dicc_exams[id] = topic;

            return true;
        }
        public static bool ModifyValueTheme(Subject number, ID id)
        {
            if (id.Id == null)
            {
                return false;
            }

            _dicc_theme[id] = number;

            return true;
        }
        public static bool ModifyValueID(string i, ID id)
        {
            if (id.Id == null)
            {
                return false;
            }

            _dicc_master[i] = id;

            return true;
        }
        public void ExterminateStudents(ID id) 
        {
            Console.WriteLine("Elige el alumno a eliminar, sera un accidente: ");
            id.Id = Console.ReadLine();
            _dicc_students.Remove(id);
        } //era necesario
        public void ExterminateExams(ID id)
        {
            Console.WriteLine("Elige el examen a eliminar, sera un accidente: ");
            id.Id = Console.ReadLine();
            _dicc_exams.Remove(id);
        }
        public void ExterminateTheme(ID id)
        {
            Console.WriteLine("Elige asignatura a eliminar, sera un accidente: ");
            id.Id = Console.ReadLine();
            _dicc_theme.Remove(id);
        }
        public void ExterminateID(string i)
        {
            Console.WriteLine("Elige DNI a eliminar, sera un accidente: ");
            i = Console.ReadLine();
            _dicc_master.Remove(i);
        }
        public void DestroyAllStudents()
        {
            _dicc_students.Clear();
        } // and humanity
        public void DestroyAllExams()
        {
            _dicc_exams.Clear();
        }
        public void DestroyAllTheme()
        {
            _dicc_theme.Clear();
        }
        public void DestroyAllId()
        {
            _dicc_master.Clear();
        }

    }
}
