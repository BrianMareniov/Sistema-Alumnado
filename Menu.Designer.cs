namespace Form2
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeIngresantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarIngresanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarIngresanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeIngresantesToolStripMenuItem,
            this.actualizarIngresanteToolStripMenuItem,
            this.eliminarIngresanteToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // altaDeIngresantesToolStripMenuItem
            // 
            this.altaDeIngresantesToolStripMenuItem.Name = "altaDeIngresantesToolStripMenuItem";
            this.altaDeIngresantesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.altaDeIngresantesToolStripMenuItem.Text = "Alta de Ingresantes";
            this.altaDeIngresantesToolStripMenuItem.Click += new System.EventHandler(this.altaDeIngresantesToolStripMenuItem_Click);
            // 
            // actualizarIngresanteToolStripMenuItem
            // 
            this.actualizarIngresanteToolStripMenuItem.Name = "actualizarIngresanteToolStripMenuItem";
            this.actualizarIngresanteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.actualizarIngresanteToolStripMenuItem.Text = "Baja Ingresante";
            // 
            // eliminarIngresanteToolStripMenuItem
            // 
            this.eliminarIngresanteToolStripMenuItem.Name = "eliminarIngresanteToolStripMenuItem";
            this.eliminarIngresanteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.eliminarIngresanteToolStripMenuItem.Text = "Modificar Ingresante";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Alumnado";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeIngresantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarIngresanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarIngresanteToolStripMenuItem;
    }
}