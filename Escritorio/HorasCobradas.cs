using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class HorasCobradas : Form
    {
        decimal cobrado = 0;
        private DataBase.BDHorariosDataContext ch = new DataBase.BDHorariosDataContext();
        Boolean Mes = true;
        Boolean Horas = false;
        String MesCobrado;

        public HorasCobradas()
        {
            InitializeComponent();
            this.cmb_month.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
            this.cmb_year.DataSource = Enumerable.Range(2010, DateTime.Now.Year - 2010 + 1).ToList();
            this.cmb_year.SelectedIndex = DateTime.Now.Year - 2010;
            this.cmb_month.SelectedIndex = DateTime.Now.Month - 1;
            this.ListarHorasTrabajadas(Mes, Horas);
        }

        void ListarHorasTrabajadas(Boolean Mes, Boolean Horas)
        {

            dgv_HrsCob.AllowUserToAddRows = false;
            dgv_HrsCob.ReadOnly = true;
            txt_cobrado.ReadOnly = true;
            grb_hrs.Enabled = Horas;
            grp_date.Enabled = Mes;
            this.cmb_year.Enabled = false;
            if (Horas)
            {
                dgv_HrsCob.DataSource = ch.ListarHorasTrabajadasPagas(MesCobrado);
                txt_cobrado.Text = this.SumarCobro().ToString();
            }
        }

        decimal SumarCobro()
        {
            cobrado = 0;
            foreach (DataGridViewRow row in dgv_HrsCob.Rows)
            {
                cobrado += Convert.ToDecimal(row.Cells[9].Value);
            }

            return cobrado;
        }

        public void LoadHoras()
        {
            this.ListarHorasTrabajadas(true, false);

        }

        private void cmb_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cmb_month.Enabled = false;
            this.cmb_year.Enabled = true;
        }

        private void cmb_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MesCobrado = cmb_month.SelectedValue.ToString() + " " + cmb_year.SelectedValue.ToString();
            this.ListarHorasTrabajadas(false, true);
        }

        private void btn_chgd_Click(object sender, EventArgs e)
        {
            dgv_HrsCob.DataSource = null;
            this.ListarHorasTrabajadas(true, false);
        }

        private void btn_chrg_Click(object sender, EventArgs e)
        {
            Informes.TablaReporte Tr = new Informes.TablaReporte();
            string Titulo = "Detalle de pagos realizados del mes de " + cmb_month.SelectedValue.ToString() + " de " + cmb_year.SelectedValue.ToString();
            string Total = "Total cobrado $" + txt_cobrado.Text;

            foreach (DataGridViewRow row in dgv_HrsCob.Rows)
            {
                Informes.TablaReporte.DataTable1Row rowdeuda = Tr.DataTable1.NewDataTable1Row();
                rowdeuda.Apellido = Convert.ToString(row.Cells[3].Value);
                rowdeuda.Nombre = Convert.ToString(row.Cells[4].Value);
                rowdeuda.Tipo_Hora = Convert.ToString(row.Cells[5].Value);
                rowdeuda.Lugar = Convert.ToString(row.Cells[6].Value);
                rowdeuda.Fecha = Convert.ToString(row.Cells[7].Value);
                rowdeuda.Cantidad_de_Horas = Convert.ToString(row.Cells[8].Value);
                rowdeuda.Total = Convert.ToString(row.Cells[9].Value);

                Tr.DataTable1.AddDataTable1Row(rowdeuda);

            }

            Informes.Informes frm = new Informes.Informes(Tr, Titulo, Total);
            frm.Show();
        }
    }
}
