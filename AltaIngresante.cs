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

                string[] cursos = new string[3];
                if (check1 == "" && check2 == "" && check3 == "")
                {
                    MessageBox.Show("Selecciona una opción para 'Curso'");
                }
                else
                {
                    cursos[0] = check1;
                    cursos[1] = check2;
                    cursos[2] = check3;
                }

                string pais = lbPais.Text.Trim();


                Ingresante ingr = new Ingresante(nombre, direccion, edad, cuit, genero, cursos, pais);

                if (Funciones.ValidarIngresante(ingr))
                {
                    MessageBox.Show(ingr.Mostrar(), "Datos ingresados: ", MessageBoxButtons.OKCancel);

                    Funciones.CargarIngresante(ingr);
                    
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
            nudEdad.Value = 0;
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras y controla las teclas de retroceso y espacio
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Cancela el evento si no es una letra
            }
        }

        private void AltaIngresante_Load(object sender, EventArgs e)
        {
            
        }
    }
}
