using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Form frm_alta_Ingresante = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Frm_alta_Ingresante").SingleOrDefault();

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
                frm_alta_Ingresante.WindowState = FormWindowState.Normal;
                frm_alta_Ingresante.Show();
            }

        }
    }
}
