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
        private DataBase.BDHorariosDataContext ch = new DataBase.BDHorariosDataContext();
        string Operacion;
        public ObraSocial()
        {
            InitializeComponent();
            ObraSocial_Load();
        }

        void ListarObrasSociales()
        {
            
            dgv_ObraSocial.DataSource = ch.ListarObrasSociales();
        }

        void LimpiarCampos()
        {
            txt_name.Text = "";
        }

        void ObraSocial_Load()
        {
            this.ListarObrasSociales();
            this.LimpiarCampos();
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
                    
                    int OSId = Convert.ToInt32(dgv_ObraSocial.CurrentRow.Cells[0].Value);
                    DataBase.Obras_Sociale OSDelete = ch.Obras_Sociales.Single(w => w.ObSoc_Id == OSId);
                    ch.Obras_Sociales.DeleteOnSubmit(OSDelete);
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
            

            if (ValidarNombre())
            {
                switch (Operacion)
                {
                    case "agregar":
                        try
                        {
                            DataBase.Obras_Sociale newOS = new DataBase.Obras_Sociale();
                            newOS.ObSoc_Nom = txt_name.Text.Trim();
                            ch.Obras_Sociales.InsertOnSubmit(newOS);
                            ch.SubmitChanges();
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
                            var query = ch.Obras_Sociales.Where(w => w.ObSoc_Id == OSId).FirstOrDefault();
                            query.ObSoc_Nom = txt_name.Text.Trim();
                            ch.SubmitChanges();
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

        public void LoadOS()
        {
            this.ObraSocial_Load();
        }
    }
}
