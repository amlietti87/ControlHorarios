using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paciente paciente = Application.OpenForms.OfType<Paciente>().FirstOrDefault() ?? new Paciente();
            AddFormInPanel(paciente);
        }

        private void obrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObraSocial obraSocial = Application.OpenForms.OfType<ObraSocial>().FirstOrDefault() ?? new ObraSocial();
            AddFormInPanel(obraSocial);
        }

        private void tiposDeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipodeHora tipodeHora = Application.OpenForms.OfType<TipodeHora>().FirstOrDefault() ?? new TipodeHora();
            AddFormInPanel(tipodeHora);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
