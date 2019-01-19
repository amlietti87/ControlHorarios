namespace Escritorio
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeHorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarYCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.obrasSocialesToolStripMenuItem,
            this.tiposDeHorasToolStripMenuItem,
            this.sesionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // obrasSocialesToolStripMenuItem
            // 
            this.obrasSocialesToolStripMenuItem.Name = "obrasSocialesToolStripMenuItem";
            this.obrasSocialesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.obrasSocialesToolStripMenuItem.Text = "Obras Sociales";
            this.obrasSocialesToolStripMenuItem.Click += new System.EventHandler(this.obrasSocialesToolStripMenuItem_Click);
            // 
            // tiposDeHorasToolStripMenuItem
            // 
            this.tiposDeHorasToolStripMenuItem.Name = "tiposDeHorasToolStripMenuItem";
            this.tiposDeHorasToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.tiposDeHorasToolStripMenuItem.Text = "Tipos de Horas";
            this.tiposDeHorasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeHorasToolStripMenuItem_Click);
            // 
            // sesionesToolStripMenuItem
            // 
            this.sesionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarYCobrarToolStripMenuItem,
            this.cobradasToolStripMenuItem});
            this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
            this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.sesionesToolStripMenuItem.Text = "Sesiones";
            // 
            // cargarYCobrarToolStripMenuItem
            // 
            this.cargarYCobrarToolStripMenuItem.Name = "cargarYCobrarToolStripMenuItem";
            this.cargarYCobrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarYCobrarToolStripMenuItem.Text = "Cargar y Cobrar";
            this.cargarYCobrarToolStripMenuItem.Click += new System.EventHandler(this.cargarYCobrarToolStripMenuItem_Click);
            // 
            // cobradasToolStripMenuItem
            // 
            this.cobradasToolStripMenuItem.Name = "cobradasToolStripMenuItem";
            this.cobradasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobradasToolStripMenuItem.Text = "Cobradas";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Location = new System.Drawing.Point(8, 27);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(779, 423);
            this.PanelContenedor.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposDeHorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarYCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel PanelContenedor;
    }
}