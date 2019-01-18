namespace Escritorio
{
    partial class Profesion
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
            this.dgv_Profesion = new System.Windows.Forms.DataGridView();
            this.grp_Listado = new System.Windows.Forms.GroupBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_updte = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Validacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.listarProfesionesResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesion_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profesion)).BeginInit();
            this.grp_Listado.SuspendLayout();
            this.grp_datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarProfesionesResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Profesion
            // 
            this.dgv_Profesion.AutoGenerateColumns = false;
            this.dgv_Profesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Profesion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profesion_nom,
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgv_Profesion.DataSource = this.listarProfesionesResultBindingSource;
            this.dgv_Profesion.Location = new System.Drawing.Point(46, 32);
            this.dgv_Profesion.Name = "dgv_Profesion";
            this.dgv_Profesion.Size = new System.Drawing.Size(244, 150);
            this.dgv_Profesion.TabIndex = 0;
            this.dgv_Profesion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Profesion_CellClick);
            // 
            // grp_Listado
            // 
            this.grp_Listado.Controls.Add(this.btn_del);
            this.grp_Listado.Controls.Add(this.btn_updte);
            this.grp_Listado.Controls.Add(this.btn_new);
            this.grp_Listado.Controls.Add(this.dgv_Profesion);
            this.grp_Listado.Location = new System.Drawing.Point(6, 6);
            this.grp_Listado.Name = "grp_Listado";
            this.grp_Listado.Size = new System.Drawing.Size(470, 202);
            this.grp_Listado.TabIndex = 1;
            this.grp_Listado.TabStop = false;
            this.grp_Listado.Text = "Profesiones";
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(364, 141);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(65, 26);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_updte
            // 
            this.btn_updte.Location = new System.Drawing.Point(364, 97);
            this.btn_updte.Name = "btn_updte";
            this.btn_updte.Size = new System.Drawing.Size(65, 26);
            this.btn_updte.TabIndex = 2;
            this.btn_updte.Text = "Modificar";
            this.btn_updte.UseVisualStyleBackColor = true;
            this.btn_updte.Click += new System.EventHandler(this.btn_updte_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(364, 47);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(65, 26);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Agregar";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.btn_cancel);
            this.grp_datos.Controls.Add(this.btn_confirm);
            this.grp_datos.Controls.Add(this.txt_name);
            this.grp_datos.Controls.Add(this.label1);
            this.grp_datos.Location = new System.Drawing.Point(6, 216);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(470, 129);
            this.grp_datos.TabIndex = 2;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Dato Profesion";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(224, 91);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(65, 26);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(104, 91);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(65, 26);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(156, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profesion";
            // 
            // Validacion
            // 
            this.Validacion.ContainerControl = this;
            // 
            // listarProfesionesResultBindingSource
            // 
            this.listarProfesionesResultBindingSource.DataSource = typeof(DataBase.ListarProfesionesResult);
            // 
            // profesion_nom
            // 
            this.profesion_nom.DataPropertyName = "profesion_nom";
            this.profesion_nom.HeaderText = "Profesion";
            this.profesion_nom.MaxInputLength = 30;
            this.profesion_nom.Name = "profesion_nom";
            this.profesion_nom.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Profesion";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // Profesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 352);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.grp_Listado);
            this.Name = "Profesion";
            this.Text = "Profesion";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Profesion)).EndInit();
            this.grp_Listado.ResumeLayout(false);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarProfesionesResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Profesion;
        private System.Windows.Forms.GroupBox grp_Listado;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updte;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ErrorProvider Validacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesion_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listarProfesionesResultBindingSource;
    }
}