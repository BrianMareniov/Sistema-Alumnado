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
        static List<Ingresante> CursoCSharp = new List<Ingresante>();
        static List<Ingresante> CursoCplusplus = new List<Ingresante>();
        static List<Ingresante> CursoJavaScript = new List<Ingresante>();         //cada uno de los cursos

        internal static List<Ingresante> CursoCSharp1 { get => CursoCSharp; set => CursoCSharp = value; }
        internal static List<Ingresante> CursoCplusplus1 { get => CursoCplusplus; set => CursoCplusplus = value; }
        internal static List<Ingresante> CursoJavaScript1 { get => CursoJavaScript; set => CursoJavaScript = value; }

        public static void AgregarCSharp(Ingresante persona)
        {
            if(CursoCSharp1.Count < 40 )
            {
            CursoCSharp1.Add(persona); 
            }
            else
            {
                MessageBox.Show("No hay mas cupos disponibles.");
            }
            
        }
        public static void AgregarCPlusPlus(Ingresante persona)
        {
            if (CursoCplusplus1.Count < 40)
            {
                CursoCplusplus1.Add(persona);
            }
            else
            {
                MessageBox.Show("No hay mas cupos disponibles.");
            }
        }
        public static void AgregarJavaScript(Ingresante persona)
        {
            if (CursoJavaScript1.Count < 40)
            {
                CursoJavaScript1.Add(persona);
            }
            else
            {
                MessageBox.Show("No hay mas cupos disponibles.");
            }
        }

        public static void ImprimirLista()
        {
            for(int i = 0; i < CursoCSharp1.Count; i++)
            {
                MessageBox.Show(CursoCSharp1[i].ToString());
            }
            
        }

    }
}
