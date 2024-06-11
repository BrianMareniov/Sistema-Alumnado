namespace Form2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDetalleUsuario = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.chkJavascript = new System.Windows.Forms.CheckBox();
            this.chkCplus = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.lbPais = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btoIngresar = new System.Windows.Forms.Button();
            this.mtbCuit = new System.Windows.Forms.MaskedTextBox();
            this.gbDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalleUsuario
            // 
            this.gbDetalleUsuario.Controls.Add(this.mtbCuit);
            this.gbDetalleUsuario.Controls.Add(this.label5);
            this.gbDetalleUsuario.Controls.Add(this.nudEdad);
            this.gbDetalleUsuario.Controls.Add(this.txtDireccion);
            this.gbDetalleUsuario.Controls.Add(this.txtNombre);
            this.gbDetalleUsuario.Controls.Add(this.label3);
            this.gbDetalleUsuario.Controls.Add(this.label2);
            this.gbDetalleUsuario.Controls.Add(this.label1);
            this.gbDetalleUsuario.Location = new System.Drawing.Point(51, 46);
            this.gbDetalleUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDetalleUsuario.Name = "gbDetalleUsuario";
            this.gbDetalleUsuario.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDetalleUsuario.Size = new System.Drawing.Size(243, 141);
            this.gbDetalleUsuario.TabIndex = 0;
            this.gbDetalleUsuario.TabStop = false;
            this.gbDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "CUIL/CUIT";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(79, 85);
            this.nudEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(55, 21);
            this.nudEdad.TabIndex = 3;
            this.nudEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(79, 57);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(136, 21);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(445, 46);
            this.gbGenero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbGenero.Size = new System.Drawing.Size(233, 115);
            this.gbGenero.TabIndex = 5;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(17, 80);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(83, 19);
            this.rbNoBinario.TabIndex = 8;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(17, 55);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(81, 19);
            this.rbFemenino.TabIndex = 7;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(17, 30);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(82, 19);
            this.rbMasculino.TabIndex = 6;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.chkJavascript);
            this.gbCurso.Controls.Add(this.chkCplus);
            this.gbCurso.Controls.Add(this.chkC);
            this.gbCurso.Location = new System.Drawing.Point(445, 199);
            this.gbCurso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCurso.Size = new System.Drawing.Size(233, 123);
            this.gbCurso.TabIndex = 10;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Curso";
            // 
            // chkJavascript
            // 
            this.chkJavascript.AutoSize = true;
            this.chkJavascript.Location = new System.Drawing.Point(15, 82);
            this.chkJavascript.Name = "chkJavascript";
            this.chkJavascript.Size = new System.Drawing.Size(82, 19);
            this.chkJavascript.TabIndex = 13;
            this.chkJavascript.Text = "JavaScript";
            this.chkJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCplus
            // 
            this.chkCplus.AutoSize = true;
            this.chkCplus.Location = new System.Drawing.Point(15, 57);
            this.chkCplus.Name = "chkCplus";
            this.chkCplus.Size = new System.Drawing.Size(48, 19);
            this.chkCplus.TabIndex = 12;
            this.chkCplus.Text = "C++";
            this.chkCplus.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(15, 32);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(41, 19);
            this.chkC.TabIndex = 11;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // lbPais
            // 
            this.lbPais.FormattingEnabled = true;
            this.lbPais.ItemHeight = 15;
            this.lbPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay",
            "Brasil",
            "Perú"});
            this.lbPais.Location = new System.Drawing.Point(151, 217);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(134, 79);
            this.lbPais.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "País:";
            // 
            // btoIngresar
            // 
            this.btoIngresar.BackColor = System.Drawing.SystemColors.Menu;
            this.btoIngresar.Location = new System.Drawing.Point(303, 326);
            this.btoIngresar.Name = "btoIngresar";
            this.btoIngresar.Size = new System.Drawing.Size(113, 38);
            this.btoIngresar.TabIndex = 14;
            this.btoIngresar.Text = "Ingresar";
            this.btoIngresar.UseVisualStyleBackColor = false;
            this.btoIngresar.Click += new System.EventHandler(this.btoIngresar_Click);
            // 
            // mtbCuit
            // 
            this.mtbCuit.Location = new System.Drawing.Point(78, 110);
            this.mtbCuit.Mask = "00-00000000-0";
            this.mtbCuit.Name = "mtbCuit";
            this.mtbCuit.Size = new System.Drawing.Size(137, 21);
            this.mtbCuit.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(780, 386);
            this.Controls.Add(this.btoIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbCurso);
            this.Controls.Add(this.gbDetalleUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Registro";
            this.gbDetalleUsuario.ResumeLayout(false);
            this.gbDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleUsuario;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkJavascript;
        private System.Windows.Forms.CheckBox chkCplus;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.ListBox lbPais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btoIngresar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbCuit;
    }
}

