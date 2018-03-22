namespace Escritorio
{
    partial class Terapeuta
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
            this.dgv_Ter = new System.Windows.Forms.DataGridView();
            this.idterapeutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutanomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutaapeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutadocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutatelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutamatriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutamailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terapeutadomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesionnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listarTerapeutasResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updte = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.listarTerapeutasResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp_Datos = new System.Windows.Forms.GroupBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cmb_prof = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_doc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Validaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Listados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarTerapeutasResultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarTerapeutasResultBindingSource)).BeginInit();
            this.grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Listados
            // 
            this.grp_Listados.Controls.Add(this.dgv_Ter);
            this.grp_Listados.Controls.Add(this.btn_del);
            this.grp_Listados.Controls.Add(this.btn_updte);
            this.grp_Listados.Controls.Add(this.btn_new);
            this.grp_Listados.Location = new System.Drawing.Point(2, 13);
            this.grp_Listados.Name = "grp_Listados";
            this.grp_Listados.Size = new System.Drawing.Size(1047, 271);
            this.grp_Listados.TabIndex = 0;
            this.grp_Listados.TabStop = false;
            this.grp_Listados.Text = "Terapeutas";
            // 
            // dgv_Ter
            // 
            this.dgv_Ter.AutoGenerateColumns = false;
            this.dgv_Ter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idterapeutaDataGridViewTextBoxColumn,
            this.terapeutanomDataGridViewTextBoxColumn,
            this.terapeutaapeDataGridViewTextBoxColumn,
            this.terapeutadocDataGridViewTextBoxColumn,
            this.terapeutatelDataGridViewTextBoxColumn,
            this.terapeutamatriculaDataGridViewTextBoxColumn,
            this.terapeutamailDataGridViewTextBoxColumn,
            this.terapeutadomDataGridViewTextBoxColumn,
            this.profesionnomDataGridViewTextBoxColumn});
            this.dgv_Ter.DataSource = this.listarTerapeutasResultBindingSource1;
            this.dgv_Ter.Location = new System.Drawing.Point(16, 20);
            this.dgv_Ter.Name = "dgv_Ter";
            this.dgv_Ter.Size = new System.Drawing.Size(844, 230);
            this.dgv_Ter.TabIndex = 4;
            this.dgv_Ter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ter_CellClick);
            // 
            // idterapeutaDataGridViewTextBoxColumn
            // 
            this.idterapeutaDataGridViewTextBoxColumn.DataPropertyName = "Id_terapeuta";
            this.idterapeutaDataGridViewTextBoxColumn.HeaderText = "Id_terapeuta";
            this.idterapeutaDataGridViewTextBoxColumn.Name = "idterapeutaDataGridViewTextBoxColumn";
            this.idterapeutaDataGridViewTextBoxColumn.Visible = false;
            // 
            // terapeutanomDataGridViewTextBoxColumn
            // 
            this.terapeutanomDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_nom";
            this.terapeutanomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.terapeutanomDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.terapeutanomDataGridViewTextBoxColumn.Name = "terapeutanomDataGridViewTextBoxColumn";
            // 
            // terapeutaapeDataGridViewTextBoxColumn
            // 
            this.terapeutaapeDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_ape";
            this.terapeutaapeDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.terapeutaapeDataGridViewTextBoxColumn.MaxInputLength = 30;
            this.terapeutaapeDataGridViewTextBoxColumn.Name = "terapeutaapeDataGridViewTextBoxColumn";
            // 
            // terapeutadocDataGridViewTextBoxColumn
            // 
            this.terapeutadocDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_doc";
            this.terapeutadocDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.terapeutadocDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.terapeutadocDataGridViewTextBoxColumn.Name = "terapeutadocDataGridViewTextBoxColumn";
            // 
            // terapeutatelDataGridViewTextBoxColumn
            // 
            this.terapeutatelDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_tel";
            this.terapeutatelDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.terapeutatelDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.terapeutatelDataGridViewTextBoxColumn.Name = "terapeutatelDataGridViewTextBoxColumn";
            // 
            // terapeutamatriculaDataGridViewTextBoxColumn
            // 
            this.terapeutamatriculaDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_matricula";
            this.terapeutamatriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.terapeutamatriculaDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.terapeutamatriculaDataGridViewTextBoxColumn.Name = "terapeutamatriculaDataGridViewTextBoxColumn";
            // 
            // terapeutamailDataGridViewTextBoxColumn
            // 
            this.terapeutamailDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_mail";
            this.terapeutamailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.terapeutamailDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.terapeutamailDataGridViewTextBoxColumn.Name = "terapeutamailDataGridViewTextBoxColumn";
            // 
            // terapeutadomDataGridViewTextBoxColumn
            // 
            this.terapeutadomDataGridViewTextBoxColumn.DataPropertyName = "terapeuta_dom";
            this.terapeutadomDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            this.terapeutadomDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.terapeutadomDataGridViewTextBoxColumn.Name = "terapeutadomDataGridViewTextBoxColumn";
            // 
            // profesionnomDataGridViewTextBoxColumn
            // 
            this.profesionnomDataGridViewTextBoxColumn.DataPropertyName = "profesion_nom";
            this.profesionnomDataGridViewTextBoxColumn.HeaderText = "Profesion";
            this.profesionnomDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.profesionnomDataGridViewTextBoxColumn.Name = "profesionnomDataGridViewTextBoxColumn";
            // 
            // listarTerapeutasResultBindingSource1
            // 
            this.listarTerapeutasResultBindingSource1.DataSource = typeof(DataBase.ListarTerapeutasResult);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(922, 188);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(80, 30);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_updte
            // 
            this.btn_updte.Location = new System.Drawing.Point(922, 116);
            this.btn_updte.Name = "btn_updte";
            this.btn_updte.Size = new System.Drawing.Size(80, 30);
            this.btn_updte.TabIndex = 2;
            this.btn_updte.Text = "Modificar";
            this.btn_updte.UseVisualStyleBackColor = true;
            this.btn_updte.Click += new System.EventHandler(this.btn_updte_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(922, 40);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 30);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Agregar";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // listarTerapeutasResultBindingSource
            // 
            this.listarTerapeutasResultBindingSource.DataSource = typeof(DataBase.ListarTerapeutasResult);
            // 
            // grp_Datos
            // 
            this.grp_Datos.Controls.Add(this.txt_tel);
            this.grp_Datos.Controls.Add(this.label8);
            this.grp_Datos.Controls.Add(this.btn_cancel);
            this.grp_Datos.Controls.Add(this.btn_confirm);
            this.grp_Datos.Controls.Add(this.cmb_prof);
            this.grp_Datos.Controls.Add(this.label7);
            this.grp_Datos.Controls.Add(this.txt_mail);
            this.grp_Datos.Controls.Add(this.label6);
            this.grp_Datos.Controls.Add(this.txt_dom);
            this.grp_Datos.Controls.Add(this.label5);
            this.grp_Datos.Controls.Add(this.txt_mat);
            this.grp_Datos.Controls.Add(this.label4);
            this.grp_Datos.Controls.Add(this.txt_doc);
            this.grp_Datos.Controls.Add(this.label3);
            this.grp_Datos.Controls.Add(this.txt_ape);
            this.grp_Datos.Controls.Add(this.label2);
            this.grp_Datos.Controls.Add(this.txt_name);
            this.grp_Datos.Controls.Add(this.label1);
            this.grp_Datos.Location = new System.Drawing.Point(8, 290);
            this.grp_Datos.Name = "grp_Datos";
            this.grp_Datos.Size = new System.Drawing.Size(1041, 239);
            this.grp_Datos.TabIndex = 1;
            this.grp_Datos.TabStop = false;
            this.grp_Datos.Text = "Datos Terapeuta";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(622, 33);
            this.txt_tel.MaxLength = 50;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 17;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(526, 196);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(273, 196);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(80, 30);
            this.btn_confirm.TabIndex = 14;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // cmb_prof
            // 
            this.cmb_prof.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_prof.FormattingEnabled = true;
            this.cmb_prof.Location = new System.Drawing.Point(622, 86);
            this.cmb_prof.Name = "cmb_prof";
            this.cmb_prof.Size = new System.Drawing.Size(121, 21);
            this.cmb_prof.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Profesion";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(362, 141);
            this.txt_mail.MaxLength = 50;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 11;
            this.txt_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mail_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mail";
            // 
            // txt_dom
            // 
            this.txt_dom.Location = new System.Drawing.Point(362, 86);
            this.txt_dom.MaxLength = 50;
            this.txt_dom.Name = "txt_dom";
            this.txt_dom.Size = new System.Drawing.Size(100, 20);
            this.txt_dom.TabIndex = 9;
            this.txt_dom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dom_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Domicilio";
            // 
            // txt_mat
            // 
            this.txt_mat.Location = new System.Drawing.Point(362, 33);
            this.txt_mat.MaxLength = 30;
            this.txt_mat.Name = "txt_mat";
            this.txt_mat.Size = new System.Drawing.Size(100, 20);
            this.txt_mat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Matricula";
            // 
            // txt_doc
            // 
            this.txt_doc.Location = new System.Drawing.Point(79, 141);
            this.txt_doc.MaxLength = 50;
            this.txt_doc.Name = "txt_doc";
            this.txt_doc.Size = new System.Drawing.Size(100, 20);
            this.txt_doc.TabIndex = 5;
            this.txt_doc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_doc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Documento";
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(79, 86);
            this.txt_ape.MaxLength = 30;
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(100, 20);
            this.txt_ape.TabIndex = 3;
            this.txt_ape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ape_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(79, 33);
            this.txt_name.MaxLength = 30;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Validaciones
            // 
            this.Validaciones.ContainerControl = this;
            // 
            // Terapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 533);
            this.Controls.Add(this.grp_Datos);
            this.Controls.Add(this.grp_Listados);
            this.Name = "Terapeuta";
            this.Text = "Terapeuta";
            this.grp_Listados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarTerapeutasResultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarTerapeutasResultBindingSource)).EndInit();
            this.grp_Datos.ResumeLayout(false);
            this.grp_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Listados;
        private System.Windows.Forms.BindingSource listarTerapeutasResultBindingSource;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updte;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox grp_Datos;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.ComboBox cmb_prof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ErrorProvider Validaciones;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_Ter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idterapeutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutanomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutaapeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutadocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutatelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutamatriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutamailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terapeutadomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesionnomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listarTerapeutasResultBindingSource1;
    }
}