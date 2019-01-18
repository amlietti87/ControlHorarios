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
        private DataBase.BDHorariosDataContext ch = new DataBase.BDHorariosDataContext();
        String Operacion;
        public Profesion()
        {
            InitializeComponent();
            Profesion_Load();
        }

        void ListarProfesiones()
        {
            
            dgv_Profesion.DataSource = ch.ListarProfesiones();
        }

        void LimpiarCampo()
        {
            txt_name.Text = "";
        }

        void Profesion_Load()
        {
            this.ListarProfesiones();
            this.LimpiarCampo();
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
                    
                    int ProId = Convert.ToInt32(dgv_Profesion.CurrentRow.Cells[0].Value);
                    DataBase.Profesione ProDelete = ch.Profesiones.Single(w => w.Profesion_Id == ProId);
                    ch.Profesiones.DeleteOnSubmit(ProDelete);
                    MessageBox.Show("La profesion seleccionada ha sido eliminada correctamente");
                    this.Profesion_Load();

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar la profesion seleccionada");
                    this.Profesion_Load();
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Validacion.Clear();
    
            if (ValidarNombre())
            {
                switch (Operacion)
                {
                    case "agregar":
                        try
                        {
                            DataBase.Profesione newPro = new DataBase.Profesione();
                            newPro.Profesion_Nom = txt_name.Text.Trim();
                            ch.Profesiones.InsertOnSubmit(newPro);
                            ch.SubmitChanges();
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
                            var query = ch.Profesiones.Where(w => w.Profesion_Id == ProId).FirstOrDefault();
                            query.Profesion_Nom = txt_name.Text.Trim();
                            ch.SubmitChanges();
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
