using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    static class Cursos
    {
        // Definición de las listas de todos los cursos
        static List<Ingresante> CursoCSharp = new List<Ingresante>();
        static List<Ingresante> CursoCplusplus = new List<Ingresante>();
        static List<Ingresante> CursoJavaScript = new List<Ingresante>();

        internal static List<Ingresante> CursoCSharp1 { get => CursoCSharp; set => CursoCSharp = value; }
        internal static List<Ingresante> CursoCplusplus1 { get => CursoCplusplus; set => CursoCplusplus = value; }
        internal static List<Ingresante> CursoJavaScript1 { get => CursoJavaScript; set => CursoJavaScript = value; }

        //Función para agregar un ingresante al curso CSharp
        public static void AgregarCSharp(Ingresante persona)
        {
            //Verificación si el curso esta lleno
            if (CursoCSharp1.Count < 40)
            {
                CursoCSharp1.Add(persona);
            }
            else
            {
                MessageBox.Show("No hay mas cupos disponibles.");
            }

        }

        //Función para agregar un ingresante al curso CPlusPlus
        public static void AgregarCPlusPlus(Ingresante persona)
        {
            //Verificación si el curso esta lleno
            if (CursoCplusplus1.Count < 40)
            {
                CursoCplusplus1.Add(persona);
            }
            else
            {
                MessageBox.Show("No hay mas cupos disponibles.");
            }
        }

        //Función para agregar un ingresante al curso JavaScript
        public static void AgregarJavaScript(Ingresante persona)
        {
            //Verificación si el curso esta lleno
            if (CursoJavaScript1.Count < 40)
            {
                CursoJavaScript1.Add(persona);
            }
            else
            {
                MessageBox.Show("No hay mas cupos disponibles.");
            }
        }

     
    }
}
