using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Informes
{
    public partial class Informes : Form
    {
        TablaReporte _datosReporte;
        String TituloInforme;
        String TotalInnforme;

        public Informes()
        {
            InitializeComponent();
        }

        public Informes(TablaReporte datos, string Titulo, string Total) : this()
        {
            _datosReporte = datos;
            TituloInforme = Titulo;
            TotalInnforme = Total;
            this.Informes_Load();
        }

        private void Informes_Load()
        {
            InformeHoras _deuda = new InformeHoras();
            _deuda.SetDataSource(_datosReporte);
            _deuda.SummaryInfo.ReportTitle = TituloInforme;
            _deuda.SummaryInfo.ReportComments = TotalInnforme;

            crm_informes.ReportSource = _deuda;
        }
    }
}
