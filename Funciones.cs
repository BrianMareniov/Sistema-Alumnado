using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    internal static class Funciones
    {


        public static int CalcularDigito(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;

            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }

            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }


        //Método para verificar si el CUIT ingresado es correcto.
        //public static bool ValidarCuit(string cuit)
        //{


        //    if (cuit == null)  // Verifica si no se ingresa nada.
        //    {
        //        return false;
        //    }

        //    cuit = cuit.Replace("-", string.Empty); // Los guiones son reemplazados por espacios vacíos.

        //    if (cuit.Length != 11)  // Verifica que la cantidad de dígitos sea igual a 11
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        int calculado = CalcularDigito(cuit);  // Se almacena el código de verificación
        //        int digito = int.Parse(cuit.Substring(10)); // Se almacena la subcadena que comienza en la posición 10
        //        return calculado == digito;     // Si se verifica que el código de verificación es igual al dígito del CUIT, se retorna true
        //    }
        //}


        public static bool ValidarIngresante(Ingresante ingr)
        {

            if (string.IsNullOrEmpty(ingr.Genero) || string.IsNullOrEmpty(ingr.Pais) || string.IsNullOrEmpty(ingr.Nombre) || string.IsNullOrEmpty(Convert.ToString(ingr.Edad)) || string.IsNullOrEmpty(ingr.Direccion))
            {
                return false;

            }
            if (!(Funciones.ValidarEdad(ingr.Edad)))
            {
                return false;
            }

            return true;
        }

        // Validación de la edad del ingresante: Debe ser mayor a 18 años.
        public static bool ValidarEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Método para guardar datos del ingresante.
        public static void CargarIngresante(Ingresante persona)
        {
            if (VerificarIngreso(persona) == false)
            {
                for (int i = 0; i < persona.Curso.Length; i++)
                {
                    if (persona.Curso[i].Contains("C#"))
                    {
                        Cursos.AgregarCSharp(persona);
                    }
                    if (persona.Curso[i].Contains("C++"))
                    {
                        Cursos.AgregarCPlusPlus(persona);

                    }
                    if (persona.Curso[i].Contains("JavaScript"))
                    {
                        Cursos.AgregarJavaScript(persona);
                    }

                }
                ArchivarEstudiante(persona);
            }
            else
            {
                MessageBox.Show("Ya estas inscripto en uno o mas cursos de los que elegiste.");
            }


        }


        public static bool ValidarCuit(string cuit)
        {
            try
            {
                cuit = cuit.Replace("-", string.Empty); // Los guiones son reemplazados por espacios vacíos.
                if (string.IsNullOrEmpty(cuit.Trim()))  // Verifica si no se ingresa nada. De ser así, lanza una excepción
                {
                    CustomException ex = new CustomException("Debe indicar CUIT/CUIL.");
                    throw ex;
                }
                else if (cuit.Length != 11)  // Verifica que la cantidad de dígitos sea igual a 11
                {
                    CustomException ex = new CustomException("El CUIT/CUIL está incompleto.");
                    throw ex;
                }

                return true;
            }
            catch (CustomException ex)
            {
                MessageBox.Show("Aviso: " + ex.Message);
                return false;
            }
        }

        public static bool VerificarIngreso(Ingresante persona)
        {

            if (persona.Curso.Contains("C#"))
            {
                for (int i = 0; i < Cursos.CursoCSharp1.Count; i++)
                {
                    if (persona.Cuit == Cursos.CursoCSharp1[i].Cuit)
                    {
                        return true;
                    }
                }
            }
            if (persona.Curso.Contains("C++"))
            {
                for (int i = 0; i < Cursos.CursoCplusplus1.Count; i++)
                {
                    if (persona.Cuit == Cursos.CursoCplusplus1[i].Cuit)
                    {
                        return true;
                    }
                }

            }
            if (persona.Curso.Contains("JavaScript"))
            {
                for (int i = 0; i < Cursos.CursoJavaScript1.Count; i++)
                {
                    if (persona.Cuit == Cursos.CursoJavaScript1[i].Cuit)
                    {
                        return true;
                    }
                }

            }
            return false;

        }



        public static void ArchivarEstudiante(Ingresante persona)
        {
            StreamWriter sw = null;

            // Obtener el directorio actual del proyecto
            string path_CursoCSharp = Directory.GetCurrentDirectory() + "\\CursoCSharp.txt";
            string path_CursoCplusplus = Directory.GetCurrentDirectory() + "\\CursoCplusplus.txt";
            string path_CursoJavaScript = Directory.GetCurrentDirectory() + "\\CursoJavaScript.txt";



            if (persona.Curso.Contains("C#"))
            {
                try
                {
                    sw = new StreamWriter(path_CursoCSharp, true);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("|");
                    sb.Append(persona.Cuit);
                    sb.Append("|");
                    sb.Append(persona.Nombre);
                    sb.Append("|");
                    sb.Append(persona.Direccion);
                    sb.Append("|");
                    sb.Append(Convert.ToString(persona.Edad));
                    sb.Append("|");
                    sb.Append(persona.Pais);
                    sb.Append("|");
                    sb.Append(persona.Genero);
                    sb.Append("|");
                    sw.WriteLine(sb);
                    sw.Close();
                    sw.Dispose();

                }
                finally
                {

                    if (sw != null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                }

            }
            if (persona.Curso.Contains("C++"))
            {
                try
                {
                    sw = new StreamWriter(path_CursoCplusplus, true);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("|");
                    sb.Append(persona.Cuit);
                    sb.Append("|");
                    sb.Append(persona.Nombre);
                    sb.Append("|");
                    sb.Append(persona.Direccion);
                    sb.Append("|");
                    sb.Append(Convert.ToString(persona.Edad));
                    sb.Append("|");
                    sb.Append(persona.Pais);
                    sb.Append("|");
                    sb.Append(persona.Genero);
                    sb.Append("|");
                    sw.WriteLine(sb);
                    sw.Close();
                    sw.Dispose();

                }
                finally
                {

                    if (sw != null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                }

            }
            if (persona.Curso.Contains("JavaScript"))
            {
                try
                {
                    sw = new StreamWriter(path_CursoJavaScript, true);
                    StringBuilder sb = new StringBuilder();
                    sb.Append("|");
                    sb.Append(persona.Cuit);
                    sb.Append("|");
                    sb.Append(persona.Nombre);
                    sb.Append("|");
                    sb.Append(persona.Direccion);
                    sb.Append("|");
                    sb.Append(Convert.ToString(persona.Edad));
                    sb.Append("|");
                    sb.Append(persona.Pais);
                    sb.Append("|");
                    sb.Append(persona.Genero);
                    sb.Append("|");
                    sw.WriteLine(sb);
                    sw.Close();
                    sw.Dispose();

                }
                finally
                {

                    if (sw != null)
                    {
                        sw.Close();
                        sw.Dispose();
                    }
                }

            }



        }



    }
}
