﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace Form2
{
    internal static class Funciones
    {


        // Validación que no haya ningun dato vacio
        public static bool ValidarIngresante(Ingresante ingr)
        {

            if (string.IsNullOrEmpty(ingr.Genero) || string.IsNullOrEmpty(ingr.Pais) || string.IsNullOrEmpty(ingr.Nombre) || string.IsNullOrEmpty(Convert.ToString(ingr.Edad)) || string.IsNullOrEmpty(ingr.Direccion))
            {
                return false;

            }

            for (int i = 0; i < ingr.Curso.Length; i++)
            {
                int contVacio = 0;
                
                if (ingr.Curso[i].IsNullOrEmpty())
                {
                    contVacio++;
                }
                
                if(contVacio == ingr.Curso.Length)
                {
                    return false;
                }
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

        //Validar dígito verificador
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

        //Verifica que el CUIL ingresado sea valido en cuanto al estandar
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
                else
                {
                    int calculado = CalcularDigito(cuit);  // Se almacena el código de verificación
                    int digito = int.Parse(cuit.Substring(10)); // Se almacena la subcadena que comienza en la posición 10
                    if(calculado != digito)
                    {
                        CustomException ex = new CustomException("El CUIT/CUIL ingresado es incorrecto.");
                        throw ex;
                    }
                    else
                    {
                        return calculado == digito; // Si se verifica que el código de verificación es igual al dígito del CUIT, se retorna true
                    }
                        
                }               
                
                
            }
            catch (CustomException ex)
            {
                MessageBox.Show("Aviso: " + ex.Message);
                return false;
            }
        }

        //Verifica si el cuil del ingresante ya  se encuentra en la lista
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

        // Método para guardar los datos de un ingresante en la lista correspondiente.
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

        //Los carga en cada archivo de cada curso con la "|" separadora
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

            Datos.InsertarDatosDB(persona);

        }

        //Lee el archivo y lo carga en las listas estaticas. Lo utilizamos en el evento LOAD de Menu.cs (principal)
        public static void LeerArchivos()
        {

            try
            {
                string[] lineas = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\CursoCSharp.txt");

                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        // Eliminar los caracteres de borde y dividir por '|'
                        var atributos = linea.Trim('|').Split('|');
                        if (atributos.Length == 6)  // Verificar si hay 6 atributos
                        {
                            var persona = new Ingresante
                            {
                                Cuit = atributos[0].Trim(),
                                Nombre = atributos[1].Trim(),
                                Direccion = atributos[2].Trim(),
                                Edad = int.Parse(atributos[3].Trim()),
                                Pais = atributos[4].Trim(),
                                Genero = atributos[5].Trim(),

                            };
                            Cursos.AgregarCSharp(persona);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            try
            {
                string[] lineas = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\CursoCplusplus.txt");

                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        // Eliminar los caracteres de borde y dividir por '|'
                        var atributos = linea.Trim('|').Split('|');
                        if (atributos.Length == 6)  // Verificar si hay 6 atributos
                        {
                            var persona = new Ingresante
                            {
                                Cuit = atributos[0].Trim(),
                                Nombre = atributos[1].Trim(),
                                Direccion = atributos[2].Trim(),
                                Edad = int.Parse(atributos[3].Trim()),
                                Pais = atributos[4].Trim(),
                                Genero = atributos[5].Trim(),

                            };
                            Cursos.AgregarCPlusPlus(persona);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            try
            {
                string[] lineas = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\CursoJavaScript.txt");

                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        // Eliminar los caracteres de borde y dividir por '|'
                        var atributos = linea.Trim('|').Split('|');
                        if (atributos.Length == 6)  // Verificar si hay 6 atributos
                        {
                            var persona = new Ingresante
                            {
                                Cuit = atributos[0].Trim(),
                                Nombre = atributos[1].Trim(),
                                Direccion = atributos[2].Trim(),
                                Edad = int.Parse(atributos[3].Trim()),
                                Pais = atributos[4].Trim(),
                                Genero = atributos[5].Trim(),

                            };
                            Cursos.AgregarJavaScript(persona);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

        }


    }
}
