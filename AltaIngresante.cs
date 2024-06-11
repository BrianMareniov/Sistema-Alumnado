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
    public partial class AltaIngresante : Form
    {
        public AltaIngresante()
        {
            InitializeComponent();
        }

        private void btoIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            int edad = (int)nudEdad.Value;
            string cuit = mtbCuit.Text.Trim();
            if (Funciones.ValidarCuit(cuit))
            {
                string genero = "";
                if (rbFemenino.Checked)
                {
                    genero = rbFemenino.Text.Trim();
                }
                else if (rbMasculino.Checked)
                {
                    genero = rbMasculino.Text.Trim();
                }
                else if (rbNoBinario.Checked)
                {
                    genero = rbNoBinario.Text.Trim();
                }

                string check1 = chkC.Checked ? chkC.Text.Trim() : "";
                string check2 = chkCplus.Checked ? chkCplus.Text.Trim() : "";
                string check3 = chkJavascript.Checked ? chkJavascript.Text.Trim() : "";

                string[] curso = new string[3];
                if (check1 == "" && check2 == "" && check3 == "")
                {
                    MessageBox.Show("Selecciona una opción para 'Curso'");
                }
                else
                {
                    curso[0] = check1;
                    curso[1] = check2;
                    curso[2] = check3;
                }

                string pais = lbPais.Text.Trim();


                Ingresante ingr = new Ingresante(nombre, direccion, edad, cuit, genero, curso, pais);

                if (Funciones.ValidarIngresante(ingr))
                {
                    MessageBox.Show(ingr.Mostrar(), "Datos ingresados: ", MessageBoxButtons.OKCancel);
                    //ingr.Guardar();
                    this.Vaciar();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, verifique.");
                }

            }
            else
            {
                MessageBox.Show("CUIT/CUIL incorrecto. Verifique.");
            }
        }

        internal void Vaciar()
        {
            txtDireccion.Text = "";
            txtNombre.Text = "";
            nudEdad.Value = 18;
            mtbCuit.Text = "";
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbNoBinario.Checked = false;
            chkC.Checked = false;
            chkCplus.Checked = false;
            chkJavascript.Checked = false;
            lbPais.Text = "";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
