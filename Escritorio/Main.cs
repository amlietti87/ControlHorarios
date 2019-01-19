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

            this.PanelContenedor.Width = fh.Width;
            this.PanelContenedor.Height = fh.Height;
            this.Height = this.PanelContenedor.Height;
            this.Width = this.PanelContenedor.Width;

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
            paciente.Height = 590;
            paciente.Width = 980;
            paciente.LoadPaciente();
            AddFormInPanel(paciente);
        }

        private void obrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObraSocial obraSocial = Application.OpenForms.OfType<ObraSocial>().FirstOrDefault() ?? new ObraSocial();
            obraSocial.Height = 415;
            obraSocial.Width = 515;
            obraSocial.LoadOS();
            AddFormInPanel(obraSocial);
        }

        private void tiposDeHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipodeHora tipodeHora = Application.OpenForms.OfType<TipodeHora>().FirstOrDefault() ?? new TipodeHora();
            tipodeHora.Height = 455;
            tipodeHora.Width = 515;
            tipodeHora.LoadTipoDeHora();
            AddFormInPanel(tipodeHora);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargarYCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HrsTrabajadas hrsTrabajadas = Application.OpenForms.OfType<HrsTrabajadas>().FirstOrDefault() ?? new HrsTrabajadas();
            hrsTrabajadas.Width = 805;
            hrsTrabajadas.Height = 670;
            hrsTrabajadas.LoadHoras();
            AddFormInPanel(hrsTrabajadas);
        }
    }
}
