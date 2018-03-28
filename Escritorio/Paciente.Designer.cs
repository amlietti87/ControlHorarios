namespace Escritorio
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grp_Listados = new System.Windows.Forms.GroupBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updte = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dgv_Pac = new System.Windows.Forms.DataGridView();
            this.grp_Datos = new System.Windows.Forms.GroupBox();
            this.dtp_fecnac = new System.Windows.Forms.DateTimePicker();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cmb_OS = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dom = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Validaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.idpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientedocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientefecnacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientetelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacientedomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasocialnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarPacientesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp_Listados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pac)).BeginInit();
            this.grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarPacientesResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Listados
            // 
            this.grp_Listados.Controls.Add(this.btn_del);
            this.grp_Listados.Controls.Add(this.btn_updte);
            this.grp_Listados.Controls.Add(this.btn_new);
            this.grp_Listados.Controls.Add(this.dgv_Pac);
            this.grp_Listados.Location = new System.Drawing.Point(2, 13);
            this.grp_Listados.Name = "grp_Listados";
            this.grp_Listados.Size = new System.Drawing.Size(938, 271);
            this.grp_Listados.TabIndex = 0;
            this.grp_Listados.TabStop = false;
            this.grp_Listados.Text = "Pacientes";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(820, 192);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(80, 30);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_updte
            // 
            this.btn_updte.Location = new System.Drawing.Point(820, 120);
            this.btn_updte.Name = "btn_updte";
            this.btn_updte.Size = new System.Drawing.Size(80, 30);
            this.btn_updte.TabIndex = 2;
            this.btn_updte.Text = "Modificar";
            this.btn_updte.UseVisualStyleBackColor = true;
            this.btn_updte.Click += new System.EventHandler(this.btn_updte_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(820, 44);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 30);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Agregar";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgv_Pac
            // 
            this.dgv_Pac.AutoGenerateColumns = false;
            this.dgv_Pac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpacienteDataGridViewTextBoxColumn,
            this.pacientenomDataGridViewTextBoxColumn,
            this.pacienteapeDataGridViewTextBoxColumn,
            this.pacientedocDataGridViewTextBoxColumn,
            this.pacientefecnacDataGridViewTextBoxColumn,
            this.pacientetelDataGridViewTextBoxColumn,
            this.pacientedomDataGridViewTextBoxColumn,
            this.obrasocialnomDataGridViewTextBoxColumn});
            this.dgv_Pac.DataSource = this.listarPacientesResultBindingSource;
            this.dgv_Pac.Location = new System.Drawing.Point(16, 20);
            this.dgv_Pac.Name = "dgv_Pac";
            this.dgv_Pac.Size = new System.Drawing.Size(744, 230);
            this.dgv_Pac.TabIndex = 0;
            this.dgv_Pac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pac_CellClick);
            // 
            // grp_Datos
            // 
            this.grp_Datos.Controls.Add(this.dtp_fecnac);
            this.grp_Datos.Controls.Add(this.btn_cancel);
            this.grp_Datos.Controls.Add(this.btn_confirm);
            this.grp_Datos.Controls.Add(this.cmb_OS);
            this.grp_Datos.Controls.Add(this.label7);
            this.grp_Datos.Controls.Add(this.txt_dom);
            this.grp_Datos.Controls.Add(this.txt_tel);
            this.grp_Datos.Controls.Add(this.label4);
            this.grp_Datos.Controls.Add(this.label5);
            this.grp_Datos.Controls.Add(this.label6);
            this.grp_Datos.Controls.Add(this.txt_doc);
            this.grp_Datos.Controls.Add(this.txt_ape);
            this.grp_Datos.Controls.Add(this.txt_name);
            this.grp_Datos.Controls.Add(this.label3);
            this.grp_Datos.Controls.Add(this.label2);
            this.grp_Datos.Controls.Add(this.label1);
            this.grp_Datos.Location = new System.Drawing.Point(2, 290);
            this.grp_Datos.Name = "grp_Datos";
            this.grp_Datos.Size = new System.Drawing.Size(938, 231);
            this.grp_Datos.TabIndex = 1;
            this.grp_Datos.TabStop = false;
            this.grp_Datos.Text = "Datos Paciente";
            // 
            // dtp_fecnac
            // 
            this.dtp_fecnac.Location = new System.Drawing.Point(352, 35);
            this.dtp_fecnac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_fecnac.Name = "dtp_fecnac";
            this.dtp_fecnac.Size = new System.Drawing.Size(102, 20);
            this.dtp_fecnac.TabIndex = 16;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(546, 194);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(283, 194);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(80, 30);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cmb_OS
            // 
            this.cmb_OS.FormattingEnabled = true;
            this.cmb_OS.Location = new System.Drawing.Point(615, 35);
            this.cmb_OS.Name = "cmb_OS";
            this.cmb_OS.Size = new System.Drawing.Size(121, 21);
            this.cmb_OS.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Obra Social";
            // 
            // txt_dom
            // 
            this.txt_dom.Location = new System.Drawing.Point(352, 141);
            this.txt_dom.MaxLength = 30;
            this.txt_dom.Name = "txt_dom";
            this.txt_dom.Size = new System.Drawing.Size(100, 20);
            this.txt_dom.TabIndex = 11;
            this.txt_dom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dom_KeyPress);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(352, 88);
            this.txt_tel.MaxLength = 30;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 10;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domicilio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fec. Nac.";
            // 
            // txt_doc
            // 
            this.txt_doc.Location = new System.Drawing.Point(89, 141);
            this.txt_doc.MaxLength = 30;
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.Size = new System.Drawing.Size(100, 20);
            this.txt_doc.TabIndex = 5;
            this.txt_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_doc_KeyPress);
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(89, 88);
            this.txt_ape.MaxLength = 30;
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(100, 20);
            this.txt_ape.TabIndex = 4;
            this.txt_ape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ape_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(89, 35);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Validaciones
            // 
            this.Validaciones.ContainerControl = this;
            // 
            // idpacienteDataGridViewTextBoxColumn
            // 
            this.idpacienteDataGridViewTextBoxColumn.DataPropertyName = "Id_paciente";
            this.idpacienteDataGridViewTextBoxColumn.HeaderText = "Id_paciente";
            this.idpacienteDataGridViewTextBoxColumn.Name = "idpacienteDataGridViewTextBoxColumn";
            this.idpacienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacientenomDataGridViewTextBoxColumn
            // 
            this.pacientenomDataGridViewTextBoxColumn.DataPropertyName = "paciente_nom";
            this.pacientenomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.pacientenomDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.pacientenomDataGridViewTextBoxColumn.Name = "pacientenomDataGridViewTextBoxColumn";
            // 
            // pacienteapeDataGridViewTextBoxColumn
            // 
            this.pacienteapeDataGridViewTextBoxColumn.DataPropertyName = "paciente_ape";
            this.pacienteapeDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.pacienteapeDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.pacienteapeDataGridViewTextBoxColumn.Name = "pacienteapeDataGridViewTextBoxColumn";
            // 
            // pacientedocDataGridViewTextBoxColumn
            // 
            this.pacientedocDataGridViewTextBoxColumn.DataPropertyName = "paciente_doc";
            this.pacientedocDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.pacientedocDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.pacientedocDataGridViewTextBoxColumn.Name = "pacientedocDataGridViewTextBoxColumn";
            // 
            // pacientefecnacDataGridViewTextBoxColumn
            // 
            this.pacientefecnacDataGridViewTextBoxColumn.DataPropertyName = "paciente_fecnac";
            this.pacientefecnacDataGridViewTextBoxColumn.HeaderText = "F. Nac.";
            this.pacientefecnacDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.pacientefecnacDataGridViewTextBoxColumn.Name = "pacientefecnacDataGridViewTextBoxColumn";
            // 
            // pacientetelDataGridViewTextBoxColumn
            // 
            this.pacientetelDataGridViewTextBoxColumn.DataPropertyName = "paciente_tel";
            this.pacientetelDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.pacientetelDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.pacientetelDataGridViewTextBoxColumn.Name = "pacientetelDataGridViewTextBoxColumn";
            // 
            // pacientedomDataGridViewTextBoxColumn
            // 
            this.pacientedomDataGridViewTextBoxColumn.DataPropertyName = "paciente_dom";
            this.pacientedomDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.pacientedomDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.pacientedomDataGridViewTextBoxColumn.Name = "pacientedomDataGridViewTextBoxColumn";
            // 
            // obrasocialnomDataGridViewTextBoxColumn
            // 
            this.obrasocialnomDataGridViewTextBoxColumn.DataPropertyName = "obrasocial_nom";
            this.obrasocialnomDataGridViewTextBoxColumn.HeaderText = "Obra Social";
            this.obrasocialnomDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.obrasocialnomDataGridViewTextBoxColumn.Name = "obrasocialnomDataGridViewTextBoxColumn";
            // 
            // listarPacientesResultBindingSource
            // 
            this.listarPacientesResultBindingSource.DataSource = typeof(DataBase.ListarPacientesResult);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 525);
            this.Controls.Add(this.grp_Datos);
            this.Controls.Add(this.grp_Listados);
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.grp_Listados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pac)).EndInit();
            this.grp_Datos.ResumeLayout(false);
            this.grp_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarPacientesResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Listados;
        private System.Windows.Forms.DataGridView dgv_Pac;
        private System.Windows.Forms.BindingSource listarPacientesResultBindingSource;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updte;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteapeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientedocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientefecnacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientetelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacientedomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrasocialnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grp_Datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dom;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_doc;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cmb_OS;
        private System.Windows.Forms.ErrorProvider Validaciones;
        private System.Windows.Forms.DateTimePicker dtp_fecnac;
    }
}