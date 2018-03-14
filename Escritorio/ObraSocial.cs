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
    public partial class ObraSocial : Form
    {
        string Operacion;
        public ObraSocial()
        {
            InitializeComponent();
            ObraSocial_Load();
        }

        void ListarObrasSociales()
        {
            DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
            dgv_ObraSocial.DataSource = cc.obrasocials;
        }

        void LimpiarCampos()
        {
            txt_name.Text = "";
        }

        void ObraSocial_Load()
        {
            this.ListarObrasSociales();
            grp_Datos.Enabled = false;
            grp_Listado.Enabled = true;
            dgv_ObraSocial.AllowUserToAddRows = false;
            dgv_ObraSocial.ReadOnly = true;

        }

        private bool ValidarNombre()
        {
            bool val = true;
            if(txt_name.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_name, "El nombre de la obra social es obligatorio");
            }
            else if (!TextValidator.ValidarString(txt_name.Text))
            {
                val = false;
                Validaciones.SetError(txt_name, "El nombre de la obra social solo debe contener letras");
            }

            return val;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            grp_Listado.Enabled = false;
            grp_Datos.Enabled = true;
            LimpiarCampos();
            Operacion = "agregar";
        }

        private void btn_upda_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar una obra social para poder modificarla");
                this.ObraSocial_Load();
            }
            else
            {
                Validaciones.Clear();
                grp_Listado.Enabled = false;
                grp_Datos.Enabled = true;
                Operacion = "modificar";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar una obra social para poder eliminarla");
                this.ObraSocial_Load();
            }
            else
            {
                try
                {
                    DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
                    int OSId = Convert.ToInt32(dgv_ObraSocial.CurrentRow.Cells[0].Value);
                    DataBase.obrasocial OSDelete = cc.obrasocials.Single(w => w.Id_ObraSocial == OSId);
                    cc.obrasocials.DeleteOnSubmit(OSDelete);
                    MessageBox.Show("La obra social seleccionada ha sido eliminada correctamente");
                    this.ObraSocial_Load();
                
                }
                catch(Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar la obra social seleccionada");
                    this.ObraSocial_Load();
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();

            if (ValidarNombre())
            {
                switch (Operacion)
                {
                    case "agregar":
                        try
                        {
                            DataBase.obrasocial newOS = new DataBase.obrasocial();
                            newOS.obrasocial_nom = txt_name.Text.Trim();
                            cc.obrasocials.InsertOnSubmit(newOS);
                            cc.SubmitChanges();
                            MessageBox.Show("Nueva Obra Social cargada");
                            break;
                        }
                        catch(Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("La obra social no se ha podido cargar, por favor vuelva a intentar");
                            break;
                        }

                    case "modificar":
                        try
                        {
                            int OSId = Convert.ToInt32(dgv_ObraSocial.CurrentRow.Cells[0].Value);
                            var query = cc.obrasocials.Where(w => w.Id_ObraSocial == OSId).FirstOrDefault();
                            query.obrasocial_nom = txt_name.Text.Trim();
                            cc.SubmitChanges();
                            MessageBox.Show("La Obra Social ha sido modificada");
                            break;
                        }
                        catch(Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("La obra social no se ha podido actualizar, por favor vuelva a intentar");
                            break;
                        }
                }
                this.ObraSocial_Load();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            this.ObraSocial_Load();
        }

        
        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void dgv_ObraSocial_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_ObraSocial.CurrentRow.Cells[1].Value.ToString().Trim();
        }
    }
}
