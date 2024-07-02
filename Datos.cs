using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public class Datos
    {

        public static void InsertarDatosDB(Ingresante persona)
        {
            //String que tomará el valor de la key 'servidor' alojada en la app.config del proyecto
            string servidor = ConfigurationManager.AppSettings["servidor"];

            //String que tomará el valor de la key 'base' alojada en la app.config del proyecto
            string nombreBase = ConfigurationManager.AppSettings["base"];

            //String de conexión conformado por el servidor y el nombre de la base.
            string connectionString = "Data Source=" + servidor + ";Initial Catalog="
            + nombreBase + ";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    if (persona.Curso.Contains("C#"))
                    {
                        string sql = "INSERT INTO AlumnosCursos (Cuit, Nombre, Direccion, Edad, Pais, Genero, Curso) VALUES (@cuit, @nombre, @direccion, @edad, @pais, @genero, @curso)";

                        SqlCommand command = new SqlCommand(sql, conn);

                        command.Parameters.AddWithValue("@cuit", persona.Cuit);
                        command.Parameters.AddWithValue("@nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@direccion", persona.Direccion);
                        command.Parameters.AddWithValue("@edad", persona.Edad);
                        command.Parameters.AddWithValue("@pais", persona.Pais);
                        command.Parameters.AddWithValue("@genero", persona.Genero);
                        command.Parameters.AddWithValue("@curso", "C#");

                        int rowsAffected = command.ExecuteNonQuery();

                    }
                    if (persona.Curso.Contains("C++"))
                    {
                        string sql = "INSERT INTO AlumnosCursos (Cuit, Nombre, Direccion, Edad, Pais, Genero, Curso) VALUES (@cuit, @nombre, @direccion, @edad, @pais, @genero, @curso)";

                        SqlCommand command = new SqlCommand(sql, conn);

                        command.Parameters.AddWithValue("@cuit", persona.Cuit);
                        command.Parameters.AddWithValue("@nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@direccion", persona.Direccion);
                        command.Parameters.AddWithValue("@edad", persona.Edad);
                        command.Parameters.AddWithValue("@pais", persona.Pais);
                        command.Parameters.AddWithValue("@genero", persona.Genero);
                        command.Parameters.AddWithValue("@curso", "C++");

                        int rowsAffected = command.ExecuteNonQuery();

                    }
                    if (persona.Curso.Contains("JavaScript"))
                    {
                        string sql = "INSERT INTO AlumnosCursos (Cuit, Nombre, Direccion, Edad, Pais, Genero, Curso) VALUES (@cuit, @nombre, @direccion, @edad, @pais, @genero, @curso)";

                        SqlCommand command = new SqlCommand(sql, conn);

                        command.Parameters.AddWithValue("@cuit", persona.Cuit);
                        command.Parameters.AddWithValue("@nombre", persona.Nombre);
                        command.Parameters.AddWithValue("@direccion", persona.Direccion);
                        command.Parameters.AddWithValue("@edad", persona.Edad);
                        command.Parameters.AddWithValue("@pais", persona.Pais);
                        command.Parameters.AddWithValue("@genero", persona.Genero);
                        command.Parameters.AddWithValue("@curso", "JavaScript");

                        int rowsAffected = command.ExecuteNonQuery();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Error al conectar la base de datos!\n" + ex.ToString());
                }
                finally
                {
                    conn.Close(); // Cerrar la conexión de la Base de datos
                }
            }
        }
    }
}
