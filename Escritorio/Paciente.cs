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
    public partial class Paciente : Form
    {
        String Operacion;
        private DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();

        public Paciente()
        {
            InitializeComponent();
            LlenarComboBox();
            Pacientes_Load();
        }

        private void LlenarComboBox()
        {
            // Sentencia para completar combobox de profesion.
            var ObrasSociales =
                from c in cc.obrasocials
                select new { OSId = c.Id_ObraSocial, OSNom = c.obrasocial_nom };

            cmb_OS.DataSource = ObrasSociales.ToList();
            cmb_OS.DisplayMember = "OSNom";
            cmb_OS.ValueMember = "OSId";

        }

        void ListarPacientes()
        {
            //DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
            dgv_Pac.DataSource = cc.ListarPacientes();
        }

        void LimpiarCampos()
        {
            txt_name.Text = "";
            txt_ape.Text = "";
            txt_doc.Text = "";
            txt_dom.Text = "";
            txt_tel.Text = "";
          
        }

        void Pacientes_Load()
        {
            this.ListarPacientes();
            this.LimpiarCampos();
            grp_Datos.Enabled = false;
            grp_Listados.Enabled = true;
            dgv_Pac.AllowUserToAddRows = false;
            dgv_Pac.ReadOnly = true;
            dtp_fecnac.Value = DateTime.Today;
        }

        private bool ValidarCampos()
        {
            bool val = true;
            if (txt_name.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_name, "Debe Ingresar un Nombre!");
            }
            else if (!TextValidator.ValidarString(txt_name.Text))
            {
                val = false;
                Validaciones.SetError(txt_name, "El nombre debe contener unicamente letras!");
            }


            if (txt_ape.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_ape, "Debe Ingresar un Apellido!");
            }
            else if (!TextValidator.ValidarString(txt_ape.Text))
            {
                val = false;
                Validaciones.SetError(txt_ape, "El Apellido debe contener unicamente letras!");
            }

            if (txt_tel.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_tel, "Debe Ingresar un Telefono!");
            }
            else if (!TextValidator.ValidarTelefono(txt_tel.Text))
            {
                val = false;
                Validaciones.SetError(txt_tel, "Ingrese un telefono valido!");
            }


            if (txt_dom.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_dom, "Debe Ingresar un Domicilio!");
            }
            else if (!TextValidator.ValidarStringEntero(txt_dom.Text))
            {
                val = false;
                Validaciones.SetError(txt_dom, "Debe ingresar un domicilio valido!");
            }

            if (txt_doc.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_doc, "Debe Ingresar un documento!");
            }
            else if (!TextValidator.ValidarEntero(txt_doc.Text))
            {
                val = false;
                Validaciones.SetError(txt_doc, "Debe ingresar un documento valido!");
            }

            return val;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            grp_Listados.Enabled = false;
            grp_Datos.Enabled = true;
            LimpiarCampos();
            Operacion = "agregar";
        }

        private void btn_updte_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar un paciente para poder realizar la modificacion");
                this.Pacientes_Load();
            }
            else
            {
                Validaciones.Clear();
                grp_Listados.Enabled = false;
                grp_Datos.Enabled = true;
                Operacion = "modificar";
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Debe seleccionar un paciente para poder eliminarlo");
                this.Pacientes_Load();
            }
            else
            {
                try
                {
                    //DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
                    int PacId = Convert.ToInt32(dgv_Pac.CurrentRow.Cells[0].Value);
                    DataBase.paciente PacDelete = cc.pacientes.Single(w => w.Id_paciente == PacId);
                    cc.pacientes.DeleteOnSubmit(PacDelete);
                    MessageBox.Show("El paciente seleccionada ha sido eliminada correctamente");
                    this.Pacientes_Load();

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar el paciente seleccionado");
                    this.Pacientes_Load();
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();

            if (ValidarCampos())
            {
                switch (Operacion)
                {
                    case "agregar":
                        try
                        {
                            DataBase.paciente newPac = new DataBase.paciente
                            {
                                paciente_nom = txt_name.Text.Trim(),
                                paciente_ape = txt_ape.Text.Trim(),
                                paciente_doc = txt_doc.Text.Trim(),
                                paciente_dom = txt_dom.Text.Trim(),
                                paciente_tel = txt_tel.Text.Trim(),
                                paciente_idobrasocial = (Int32)cmb_OS.SelectedValue,
                                paciente_fecnac = dtp_fecnac.Value.Date


                            };
                            cc.pacientes.InsertOnSubmit(newPac);
                            cc.SubmitChanges();
                            MessageBox.Show("Se ha cargado un nuevo paciente");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("El paciente no se ha podido cargar, por favor vuelva a intentar");
                            break;
                        }

                    case "modificar":
                        try
                        {
                            int PacId = Convert.ToInt32(dgv_Pac.CurrentRow.Cells[0].Value);
                            DataBase.paciente paciente = cc.pacientes.Where(w => w.Id_paciente == PacId).FirstOrDefault();
                            paciente.paciente_nom = txt_name.Text.Trim();
                            paciente.paciente_ape = txt_ape.Text.Trim();
                            paciente.paciente_doc = txt_doc.Text.Trim();
                            paciente.paciente_dom = txt_dom.Text.Trim();
                            paciente.paciente_tel = txt_tel.Text.Trim();
                            paciente.paciente_idobrasocial = (Int32)cmb_OS.SelectedValue;
                            paciente.paciente_fecnac = dtp_fecnac.Value.Date;
                            cc.SubmitChanges();
                            MessageBox.Show("el paciente ha sido modificado");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("El paciente no se ha podido actualizar, por favor vuelva a intentar");
                            break;
                        }
                }
                this.Pacientes_Load();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            this.Pacientes_Load();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_ape_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_doc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_dom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void dgv_Pac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_Pac.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_ape.Text = dgv_Pac.CurrentRow.Cells[2].Value.ToString().Trim();
            txt_dom.Text = dgv_Pac.CurrentRow.Cells[6].Value.ToString().Trim();
            txt_tel.Text = dgv_Pac.CurrentRow.Cells[5].Value.ToString().Trim();
            txt_doc.Text = dgv_Pac.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}
