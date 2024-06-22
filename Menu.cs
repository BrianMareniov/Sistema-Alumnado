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
            SerializaciónCurso(Cursos.CursoCSharp1, path_CursoCSharp, "CursoCSharp");

            string path_CursoCplusplus = Directory.GetCurrentDirectory() + "\\CursoCplusplus.xml";
            SerializaciónCurso(Cursos.CursoCplusplus1, path_CursoCplusplus, "CursoCplusplus");

            string path_CursoJavaScript = Directory.GetCurrentDirectory() + "\\CursoJavaScript.xml";
            SerializaciónCurso(Cursos.CursoJavaScript1, path_CursoJavaScript, "CursoJavaScript");

        }

        private void SerializaciónCurso(List<Ingresante> curso, string filePath, string rootElementName)
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", ""); // Eliminar cualquier espacio de nombres

            // Crear un XmlSerializer para la lista de ingresantes con el nombre del elemento raíz especificado
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Ingresante>), new XmlRootAttribute(rootElementName));

            // Usa StreamWriter para escribir el archivo XML
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(sw, curso, namespaces);
            }
        }

        private void serializaciónJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Funciones.LeerArchivos();
        }
    }
}
