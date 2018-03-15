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
    public partial class Profesion : Form
    {
        String Operacion;
        public Profesion()
        {
            InitializeComponent();
            Profesion_Load();
        }

        void ListarProfesiones()
        {
            DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
            dgv_Profesion.DataSource = cc.profesions;
        }

        void LimpiarCampo()
        {
            txt_name.Text = "";
        }

        void Profesion_Load()
        {
            this.ListarProfesiones();
            grp_datos.Enabled = false;
            grp_Listado.Enabled = true;
            dgv_Profesion.AllowUserToAddRows = false;
            dgv_Profesion.ReadOnly = true;
        }

        private bool ValidarNombre()
        {
            bool val = true;
            if (txt_name.Text.Trim() == "")
            {
                val = false;
                Validacion.SetError(txt_name, "Debe ingresar una profesion.");
            }
            else if (!TextValidator.ValidarString(txt_name.Text))
            {
                val = false;
                Validacion.SetError(txt_name, "El nombre de la profesion solo debe contener letras");
            }

            return val;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Validacion.Clear();
            grp_Listado.Enabled = false;
            grp_datos.Enabled = true;
            LimpiarCampo();
            Operacion = "agregar";
        }

        private void btn_updte_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar una profesion para poder realizar la modificacion");
                this.Profesion_Load();
            }
            else
            {
                Validacion.Clear();
                grp_Listado.Enabled = false;
                grp_datos.Enabled = true;
                Operacion = "modificar";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar una profesion para poder eliminarla");
                this.Profesion_Load();
            }
            else
            {
                try
                {
                    DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
                    int ProId = Convert.ToInt32(dgv_Profesion.CurrentRow.Cells[0].Value);
                    DataBase.profesion ProDelete = cc.profesions.Single(w => w.Id_Profesion == ProId);
                    cc.profesions.DeleteOnSubmit(ProDelete);
                    MessageBox.Show("La profesion seleccionada ha sido eliminada correctamente");
                    this.Profesion_Load();

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar la obra social seleccionada");
                    this.Profesion_Load();
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
                            DataBase.profesion newPro = new DataBase.profesion();
                            newPro.pofesion_nom = txt_name.Text.Trim();
                            cc.profesions.InsertOnSubmit(newPro);
                            cc.SubmitChanges();
                            MessageBox.Show("Nueva profesion cargada");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("La profesion no se ha podido cargar, por favor vuelva a intentar");
                            break;
                        }

                    case "modificar":
                        try
                        {
                            int ProId = Convert.ToInt32(dgv_Profesion.CurrentRow.Cells[0].Value);
                            var query = cc.profesions.Where(w => w.Id_Profesion == ProId).FirstOrDefault();
                            query.pofesion_nom = txt_name.Text.Trim();
                            cc.SubmitChanges();
                            MessageBox.Show("La profesion ha sido modificada");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("La profesion no se ha podido actualizar, por favor vuelva a intentar");
                            break;
                        }
                }
                this.Profesion_Load();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Validacion.Clear();
            this.Profesion_Load();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.Clear();
        }

        private void dgv_Profesion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_Profesion.CurrentRow.Cells[1].Value.ToString().Trim();
        }
    }
}
