using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace Form2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void altaDeIngresantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_alta_Ingresante = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "AltaIngresante").SingleOrDefault();

            // Verifica si el formulario ya está abierto
            if (frm_alta_Ingresante == null)
            {

                // Se instancia un formulario de AltaIngresante
                AltaIngresante altaIng = new AltaIngresante();

                //Setea al formulario MENU como el padre de AltaIngresante
                altaIng.MdiParent = this;

                //Lo mostramos
                altaIng.Show();
            }
            else
            {
                // El formulario ya está abierto, puedes traerlo al frente si lo deseas
                frm_alta_Ingresante.Select();
                frm_alta_Ingresante.WindowState = FormWindowState.Maximized;
                frm_alta_Ingresante.Show();
            }

        }

        private void serializaciónXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path_CursoCSharp = Directory.GetCurrentDirectory() + "\\CursoCSharp.xml";
            SerializaciónCursoXML(Cursos.CursoCSharp1, path_CursoCSharp, "CursoCSharp");

            string path_CursoCplusplus = Directory.GetCurrentDirectory() + "\\CursoCPlusPlus.xml";
            SerializaciónCursoXML(Cursos.CursoCplusplus1, path_CursoCplusplus, "CursoCPlusPlus");

            string path_CursoJavaScript = Directory.GetCurrentDirectory() + "\\CursoJavaScript.xml";
            SerializaciónCursoXML(Cursos.CursoJavaScript1, path_CursoJavaScript, "CursoJavaScript");

        }

        private void serializaciónJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path_CursoCSharp = Directory.GetCurrentDirectory() + "\\CursoCSharp.json";
            SerializarCursoJson(Cursos.CursoCSharp1, path_CursoCSharp, "CursoCSharp");

            // Serializar el curso de C++
            string path_CursoCplusplus = Directory.GetCurrentDirectory() + "\\CursoCPlusPlus.json";
            SerializarCursoJson(Cursos.CursoCplusplus1, path_CursoCplusplus, "CursoCPlusPlus");

            // Serializar el curso de JavaScript
            string path_CursoJavaScript = Directory.GetCurrentDirectory() + "\\CursoJavaScript.json";
            SerializarCursoJson(Cursos.CursoJavaScript1, path_CursoJavaScript, "CursoJavaScript");
        }

        //Serializa una lista de ingresantes en un archivo XML con un elemento raíz especificado.
        private void SerializaciónCursoXML(List<Ingresante> curso, string rutaArchivo, string nombreElementoRaiz)
        {
            try
            {
                // Crea un XmlSerializer sin espacios de nombres
                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", ""); // Eliminar cualquier espacio de nombres

                // Crear un XmlSerializer para la lista de ingresantes con el nombre del elemento raíz especificado
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Ingresante>), new XmlRootAttribute(nombreElementoRaiz));

                // Usa StreamWriter para escribir el archivo XML
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    xmlSerializer.Serialize(sw, curso, namespaces);
                }

                MessageBox.Show($"El archivo {nombreElementoRaiz} se creó con éxito.", "Serialización .xml exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrió un error al crear el archivo {rutaArchivo}: {ex.Message}", "Error de Serialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Serializa una lista de ingresantes en un archivo JSON y muestra un mensaje indicando el resultado de la operación.
        private void SerializarCursoJson(List<Ingresante> curso, string rutaArchivo, string nombreElementoRaiz)
        {
            try
            {
                // Serializar la lista de ingresantes a JSON
                string jsonString = JsonSerializer.Serialize(curso, new JsonSerializerOptions { WriteIndented = true });

                // Escribe el JSON a un archivo
                File.WriteAllText(rutaArchivo, jsonString);

                // Muestra mensaje de éxito
                MessageBox.Show($"El archivo {nombreElementoRaiz} se creó con éxito.", "Serialización .json exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Ocurrió un error al crear el archivo {rutaArchivo}: {ex.Message}", "Error de Serialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Funciones.LeerArchivos();
        }
    }
}
