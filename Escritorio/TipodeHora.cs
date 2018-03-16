using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Escritorio
{
    public partial class TipodeHora : Form
    {
        String Operacion;
        public TipodeHora()
        {
            InitializeComponent();
            TipodeHora_Load();
        }

        void ListarTiposdeHoras()
        {
            DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
            dgv_TdH.DataSource = cc.tipodehoras;
        }

        void LimpiarCampo()
        {
            txt_name.Text = "";
        }

        void TipodeHora_Load()
        {
            this.ListarTiposdeHoras();
            grp_Datos.Enabled = false;
            grp_Listados.Enabled = true;
            dgv_TdH.AllowUserToAddRows = false;
            dgv_TdH.ReadOnly = true;
        }

        private bool ValidarNombre()
        {
            bool val = true;
            if (txt_name.Text.Trim() == "")
            {
                val = false;
                Validacion.SetError(txt_name, "Debe ingresar un tipo de hora.");
            }
            else if (!TextValidator.ValidarString(txt_name.Text))
            {
                val = false;
                Validacion.SetError(txt_name, "El tipo de hora solo debe contener letras");
            }

            return val;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Validacion.Clear();
            grp_Listados.Enabled = false;
            grp_Datos.Enabled = true;
            LimpiarCampo();
            Operacion = "agregar";
        }

        private void btn_updte_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de hora para poder realizar la modificacion");
                this.TipodeHora_Load();
            }
            else
            {
                Validacion.Clear();
                grp_Listados.Enabled = false;
                grp_Datos.Enabled = true;
                Operacion = "modificar";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tipo de hora para poder eliminarla");
                this.TipodeHora_Load();
            }
            else
            {
                try
                {
                    DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
                    int TdHId = Convert.ToInt32(dgv_TdH.CurrentRow.Cells[0].Value);
                    DataBase.tipodehora TdHDelete = cc.tipodehoras.Single(w => w.Id_TipodeHora == TdHId);
                    cc.tipodehoras.DeleteOnSubmit(TdHDelete);
                    MessageBox.Show("El tipo de hora seleccionado ha sido eliminado correctamente");
                    this.TipodeHora_Load();

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar el tipo de hora seleccionada");
                    this.TipodeHora_Load();
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Validacion.Clear();
            DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();

            if (ValidarNombre())
            {
                switch (Operacion)
                {
                    case "agregar":
                        try
                        {
                            DataBase.tipodehora newTdH = new DataBase.tipodehora();
                            newTdH.tipodehora_nom = txt_name.Text.Trim();
                            cc.tipodehoras.InsertOnSubmit(newTdH);
                            cc.SubmitChanges();
                            MessageBox.Show("Nuevo tipo de hora cargado");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("El tipo de hora no se ha podido cargar, por favor vuelva a intentar");
                            break;
                        }

                    case "modificar":
                        try
                        {
                            int TdHId = Convert.ToInt32(dgv_TdH.CurrentRow.Cells[0].Value);
                            var query = cc.tipodehoras.Where(w => w.Id_TipodeHora == TdHId).FirstOrDefault();
                            query.tipodehora_nom = txt_name.Text.Trim();
                            cc.SubmitChanges();
                            MessageBox.Show("El tipo de hora ha sido modificado");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("El tipo de hora no se ha podido actualizar, por favor vuelva a intentar");
                            break;
                        }
                }
                this.TipodeHora_Load();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Validacion.Clear();
            this.TipodeHora_Load();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Clear();
        }

        private void dgv_TdH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_TdH.CurrentRow.Cells[1].Value.ToString().Trim();
        }
    }
}
