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
using Utilities;

namespace Escritorio
{
    public partial class HrsTrabajadas : Form
    {

        String Operacion;
        String MesaCargar;
        Boolean Mes = true;
        Boolean Horas = false;
        decimal deuda = 0;
        private DataBase.BDHorariosDataContext ch = new DataBase.BDHorariosDataContext();

        public HrsTrabajadas()
        {
            InitializeComponent();
            this.cmb_month.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
            this.cmb_year.DataSource = Enumerable.Range(2010, DateTime.Now.Year - 2010 + 1).ToList();
            this.cmb_year.SelectedIndex = DateTime.Now.Year - 2010;
            this.cmb_month.SelectedIndex = DateTime.Now.Month - 1;
            this.HrsTrabajadas_Load(Mes, Horas);
        }

        void HrsTrabajadas_Load(Boolean Mes, Boolean Horas)
        {
            if (Horas)
            {
                this.ListarHorasTrabajadas();
                txt_deuda.Text = this.SumarDeuda().ToString();
                txt_month.Text = cmb_month.SelectedValue.ToString() + " " + cmb_year.SelectedValue.ToString();
            }

            this.LlenarComboBox();
            this.LimpiarCampos();
            this.cmb_year.Enabled = false;
            grp_mes.Enabled = Mes;
            grp_Horas.Enabled = Horas;
            grp_Datos.Enabled = false;
            dgv_Horas.AllowUserToAddRows = false;
            dgv_Horas.ReadOnly = true;
            txt_month.ReadOnly = true;
            txt_deuda.ReadOnly = true;


        }

        void ListarHorasTrabajadas()
        {
            dgv_Horas.DataSource = ch.ListarHorasTrabajadas(MesaCargar);
        }

        decimal SumarDeuda()
        {
            deuda = 0;
            foreach (DataGridViewRow row in dgv_Horas.Rows)
            {
                deuda += Convert.ToDecimal(row.Cells[7].Value);
            }

            return deuda;
        }

        private void LlenarComboBox()
        {

            // Sentencia para completar combobox de Pacientes.
            var Pacientes =
                from pac in ch.Pacientes
                select new { PacId = pac.Paciente_Id, PacNom = pac.Paciente_Ape + " " + pac.Paciente_Nom };
            cmb_Pac.DataSource = Pacientes.ToList();
            cmb_Pac.DisplayMember = "PacNom";
            cmb_Pac.ValueMember = "PacId";

            // Sentencia para completar combobox de tipos de hora.
            var TiposHoras =
                from th in ch.Tipos_Horas
                select new { TipoHrId = th.TipoHora_Id, TipoHrNom = th.TipoHora_Nom };
            cmb_TiposHrs.DataSource = TiposHoras.ToList();
            cmb_TiposHrs.DisplayMember = "TipoHrNom";
            cmb_TiposHrs.ValueMember = "TipoHrId";

        }

        void LimpiarCampos()
        {
            txt_place.Text = "";
            txt_hrs.Text = "";
        }

        private bool ValidarCampos()
        {
            bool val = true;
            if (txt_place.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_place, "Debe Ingresar un Lugar!");
            }
            else if ((!TextValidator.ValidarStringEntero(txt_place.Text) && !TextValidator.ValidarString(txt_place.Text)))
            {
                val = false;
                Validaciones.SetError(txt_place, "Debe ingresar un lugar valido!");
            }


            if (txt_hrs.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_hrs, "Debe ingresar las horas trabajadas!");
            }
            else if (!TextValidator.ValidarFloat(txt_hrs.Text))
            {
                val = false;
                Validaciones.SetError(txt_hrs, "Las hora pueden ser unicamente numeros!");
            }

            return val;
        }

        decimal TotalACobrar(int TPId, decimal cantidad)
        {
            DataBase.Tipos_Hora tipoHr = ch.Tipos_Horas.Where(w => w.TipoHora_Id == TPId).FirstOrDefault();
            decimal valor = (cantidad * tipoHr.TipoHora_Precio);
            return valor;
        }

        private void cmb_month_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cmb_month.Enabled = false;
            this.cmb_year.Enabled = true;
        }

        private void cmb_year_SelectionChangeCommitted(object sender, EventArgs e)
        {
            MesaCargar = cmb_month.SelectedValue.ToString() + " " + cmb_year.SelectedValue.ToString();
            this.HrsTrabajadas_Load(false, true);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            grp_Horas.Enabled = false;
            grp_Datos.Enabled = true;
            LimpiarCampos();
            Operacion = "agregar";

            int thid = Convert.ToInt32(cmb_TiposHrs.SelectedValue);
        }

        private void btn_chrg_Click(object sender, EventArgs e)
        {
            int HTId = Convert.ToInt32(dgv_Horas.CurrentRow.Cells[0].Value);

            if (HTId == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de hora para poder cobrarla");
                this.HrsTrabajadas_Load(false, true);
            }
            else
            {
                try
                {
                    DataBase.Horas_Trabajada HT = ch.Horas_Trabajadas.Where(w => w.HrTrab_Id == HTId).FirstOrDefault();
                    HT.HrTrab_Cob = true;
                    ch.SubmitChanges();
                    MessageBox.Show("La sesion seleccionada ha sido cobrada");
                    this.HrsTrabajadas_Load(false, true);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("La sesion seleccionada no hay podido ser cobrada");
                    this.HrsTrabajadas_Load(false, true);
                }

            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            int HTId = Convert.ToInt32(dgv_Horas.CurrentRow.Cells[0].Value);

            if (HTId == 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de hora para poder eliminar");
                this.HrsTrabajadas_Load(false, true);
            }
            else
            {
                try
                {
                    DataBase.Horas_Trabajada HTDelete = ch.Horas_Trabajadas.Single(w => w.HrTrab_Id == HTId);
                    ch.Horas_Trabajadas.DeleteOnSubmit(HTDelete);
                    MessageBox.Show("La sesion seleccionada ha sido eliminada correctamente");
                    this.HrsTrabajadas_Load(false, true);

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar la sesion seleccionada");
                    this.HrsTrabajadas_Load(false, true);
                }
            }
        }

        private void btn_chgm_Click(object sender, EventArgs e)
        {
            dgv_Horas.DataSource = null;
            this.cmb_month.Enabled = true;
            this.cmb_year.Enabled = false;
            this.HrsTrabajadas_Load(true, false);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Informes.TablaReporte Tr = new Informes.TablaReporte();
            string Titulo = "Detalle de pagos adeudados del mes de " + cmb_month.SelectedValue.ToString() + " de " + cmb_year.SelectedValue.ToString();
            string Total = "Total deuda $" + txt_deuda.Text;

            foreach (DataGridViewRow row in dgv_Horas.Rows)
            {
                Informes.TablaReporte.DataTable1Row rowdeuda = Tr.DataTable1.NewDataTable1Row();
                rowdeuda.Paciente = Convert.ToString(row.Cells[1].Value) + ", " + Convert.ToString(row.Cells[2].Value);
                rowdeuda.Tipo_Hora = Convert.ToString(row.Cells[3].Value);
                rowdeuda.Lugar = Convert.ToString(row.Cells[4].Value);
                rowdeuda.Fecha = Convert.ToString(row.Cells[5].Value);
                rowdeuda.Cantidad_de_Horas = Convert.ToString(row.Cells[6].Value);
                rowdeuda.Total = Convert.ToString(row.Cells[7].Value);

                Tr.DataTable1.AddDataTable1Row(rowdeuda);

            }

            Informes.Informes frm = new Informes.Informes(Tr, Titulo, Total);
            frm.Show();
        }

        private void txt_place_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_month_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_hrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();


            if (ValidarCampos())
            {
                switch (Operacion)
                {
                    case "agregar":
                        try
                        {
                            DataBase.Horas_Trabajada newHT = new DataBase.Horas_Trabajada
                            {
                                HrTrab_Cant = Convert.ToDecimal(txt_hrs.Text.Trim()),
                                HrTrab_Lugar = txt_place.Text.Trim(),
                                HrTrab_Pac = (Int32)cmb_Pac.SelectedValue,
                                HrTrab_TipoHr = (Int32)cmb_TiposHrs.SelectedValue,
                                HrTrab_Mes = txt_month.Text.Trim(),
                                HrTrab_Precio = this.TotalACobrar((Int32)cmb_TiposHrs.SelectedValue, Convert.ToDecimal(txt_hrs.Text.Trim())),
                                HrTrab_Cob = false
                            };
                            ch.Horas_Trabajadas.InsertOnSubmit(newHT);
                            ch.SubmitChanges();
                            MessageBox.Show("Se ha cargado una nueva sesion");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("La sesion no se ha podido cargar, por favor vuelva a intentar");
                            break;
                        }
                }
                MesaCargar = txt_month.Text.Trim();
                this.HrsTrabajadas_Load(false, true);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            this.cmb_month.Enabled = true;
            this.cmb_year.Enabled = false;
            this.HrsTrabajadas_Load(false, true);
        }

        public void LoadHoras()
        {
            this.HrsTrabajadas_Load(true, false);
            this.LlenarComboBox();
        }
    }
}
