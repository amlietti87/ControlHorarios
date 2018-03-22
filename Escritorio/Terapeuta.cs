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
    public partial class Terapeuta : Form
    {
        String Operacion;
        private DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
        public Terapeuta()
        {
            InitializeComponent();
            LlenarComboBox();
            Terapeuta_Load();
            

        }

        private void LlenarComboBox()
        {
            // Sentencia para completar combobox de profesion.
            var Profesiones =
                from c in cc.profesions
                select new { ProfId = c.Id_Profesion, ProfNom = c.profesion_nom };

            cmb_prof.DataSource = Profesiones.ToList();
            cmb_prof.DisplayMember = "ProfNom";
            cmb_prof.ValueMember = "ProfId";
            
        }

        void ListarTerapeutas()
        {
            //DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
            dgv_Ter.DataSource = cc.ListarTerapeutas();
        }

        void LimpiarCampos()
        {
            txt_name.Text = "";
            txt_ape.Text = "";
            txt_doc.Text = "";
            txt_dom.Text = "";
            txt_mail.Text = "";
            txt_mat.Text = "";
            txt_tel.Text = "";
        }

        void Terapeuta_Load()
        {
            this.ListarTerapeutas();
            this.LimpiarCampos();
            grp_Datos.Enabled = false;
            grp_Listados.Enabled = true;
            dgv_Ter.AllowUserToAddRows = false;
            dgv_Ter.ReadOnly = true;
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

            if (txt_mat.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_mat, "Debe Ingresar una matricula!");
            }
            else if (!TextValidator.ValidarEntero(txt_mat.Text))
            {
                val = false;
                Validaciones.SetError(txt_mat, "Debe ingresar una matricula valida!");
            }

            if (txt_mail.Text.Trim() == "")
            {
                val = false;
                Validaciones.SetError(txt_mail, "Debe Ingresar un mail!");
            }
            else if (!TextValidator.ValidarMail(txt_mail.Text))
            {
                val = false;
                Validaciones.SetError(txt_mail, "Debe ingresar un mail valido!");
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
                MessageBox.Show("Debe seleccionar un terapeuta para poder realizar la modificacion");
                this.Terapeuta_Load();
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
                MessageBox.Show("Debe seleccionar una profesion para poder eliminarla");
                this.Terapeuta_Load();
            }
            else
            {
                try
                {
                    DataBase.DataClasses1DataContext cc = new DataBase.DataClasses1DataContext();
                    int TerId = Convert.ToInt32(dgv_Ter.CurrentRow.Cells[0].Value);
                    DataBase.terapeuta TerDelete = cc.terapeutas.Single(w => w.Id_terapeuta == TerId);
                    cc.terapeutas.DeleteOnSubmit(TerDelete);
                    MessageBox.Show("El terapeuta seleccionada ha sido eliminada correctamente");
                    this.Terapeuta_Load();

                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    MessageBox.Show("No se ha podido eliminar el terapeuta seleccionado");
                    this.Terapeuta_Load();
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
                            DataBase.terapeuta newTer = new DataBase.terapeuta
                            {
                                terapeuta_nom = txt_name.Text.Trim(),
                                terapeuta_ape = txt_ape.Text.Trim(),
                                terapeuta_doc = txt_doc.Text.Trim(),
                                terapeuta_dom = txt_dom.Text.Trim(),
                                terapeuta_mail = txt_mail.Text.Trim(),
                                terapeuta_matricula = txt_mat.Text.Trim(),
                                terapeuta_tel = txt_tel.Text.Trim(),
                                terapeuta_idprofesion = (Int32)cmb_prof.SelectedValue

                            };
                            cc.terapeutas.InsertOnSubmit(newTer);
                            cc.SubmitChanges();
                            MessageBox.Show("Se ha cargado un nuevo terapeuta");
                            break;
                        }
                        catch (Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                            MessageBox.Show("El terapeuta no se ha podido cargar, por favor vuelva a intentar");
                            break;
                        }

                    case "modificar":
                        try
                        {
                            int TerId = Convert.ToInt32(dgv_Ter.CurrentRow.Cells[0].Value);
                            DataBase.terapeuta terapeuta = cc.terapeutas.Where(w => w.Id_terapeuta == TerId).FirstOrDefault();
                            terapeuta.terapeuta_nom = txt_name.Text.Trim();
                            terapeuta.terapeuta_ape = txt_ape.Text.Trim();
                            terapeuta.terapeuta_doc = txt_doc.Text.Trim();
                            terapeuta.terapeuta_dom = txt_dom.Text.Trim();
                            terapeuta.terapeuta_mail = txt_mail.Text.Trim();
                            terapeuta.terapeuta_matricula = txt_mat.Text.Trim();
                            terapeuta.terapeuta_tel = txt_tel.Text.Trim();
                            terapeuta.terapeuta_idprofesion = (Int32)cmb_prof.SelectedValue;
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
                this.Terapeuta_Load();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Validaciones.Clear();
            this.Terapeuta_Load();
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

        private void txt_mat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_dom_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.Clear();
        }

        private void dgv_Ter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = dgv_Ter.CurrentRow.Cells[1].Value.ToString().Trim();
            txt_ape.Text = dgv_Ter.CurrentRow.Cells[2].Value.ToString().Trim();
            txt_dom.Text = dgv_Ter.CurrentRow.Cells[7].Value.ToString().Trim();
            txt_mail.Text = dgv_Ter.CurrentRow.Cells[6].Value.ToString().Trim();
            txt_mat.Text = dgv_Ter.CurrentRow.Cells[5].Value.ToString().Trim();
            txt_tel.Text = dgv_Ter.CurrentRow.Cells[4].Value.ToString().Trim();
            txt_doc.Text = dgv_Ter.CurrentRow.Cells[3].Value.ToString().Trim();
        }
    }
}
