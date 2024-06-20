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


        public static void AgregarCSharp(Ingresante persona)
        {
            CursoCSharp.Add(persona);
        }
        public static void AgregarCPlusPlus(Ingresante persona)
        {
            CursoCplusplus.Add(persona);
        }
        public static void AgregarJavaScript(Ingresante persona)
        {
            CursoJavaScript.Add(persona);
        }

        public static void ImprimirLista()
        {
            for(int i = 0; i < CursoCSharp.Count; i++)
            {
                MessageBox.Show(CursoCSharp[i].ToString());
            }
            
        }

    }
}
