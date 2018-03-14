namespace Escritorio
{
    partial class ObraSocial
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
            this.obrasocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_upda = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.grp_Listado = new System.Windows.Forms.GroupBox();
            this.grp_Datos = new System.Windows.Forms.GroupBox();
            this.Validaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv_ObraSocial = new System.Windows.Forms.DataGridView();
            this.idObraSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obrasocialnomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.obrasocialBindingSource)).BeginInit();
            this.grp_Listado.SuspendLayout();
            this.grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObraSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // obrasocialBindingSource
            // 
            this.obrasocialBindingSource.DataSource = typeof(DataBase.obrasocial);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(728, 90);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(130, 50);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "Agregar";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_upda
            // 
            this.btn_upda.Location = new System.Drawing.Point(728, 184);
            this.btn_upda.Name = "btn_upda";
            this.btn_upda.Size = new System.Drawing.Size(130, 50);
            this.btn_upda.TabIndex = 2;
            this.btn_upda.Text = "Modificar";
            this.btn_upda.UseVisualStyleBackColor = true;
            this.btn_upda.Click += new System.EventHandler(this.btn_upda_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(728, 272);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(130, 50);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre Obra Social";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(313, 87);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(150, 31);
            this.txt_name.TabIndex = 5;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(209, 175);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(130, 50);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(447, 175);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 50);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // grp_Listado
            // 
            this.grp_Listado.Controls.Add(this.dgv_ObraSocial);
            this.grp_Listado.Controls.Add(this.btn_new);
            this.grp_Listado.Controls.Add(this.btn_upda);
            this.grp_Listado.Controls.Add(this.btn_del);
            this.grp_Listado.Location = new System.Drawing.Point(12, 12);
            this.grp_Listado.Name = "grp_Listado";
            this.grp_Listado.Size = new System.Drawing.Size(940, 388);
            this.grp_Listado.TabIndex = 8;
            this.grp_Listado.TabStop = false;
            this.grp_Listado.Text = "Obras Sociales";
            // 
            // grp_Datos
            // 
            this.grp_Datos.Controls.Add(this.label1);
            this.grp_Datos.Controls.Add(this.txt_name);
            this.grp_Datos.Controls.Add(this.btn_confirm);
            this.grp_Datos.Controls.Add(this.btn_cancel);
            this.grp_Datos.Location = new System.Drawing.Point(12, 415);
            this.grp_Datos.Name = "grp_Datos";
            this.grp_Datos.Size = new System.Drawing.Size(940, 249);
            this.grp_Datos.TabIndex = 9;
            this.grp_Datos.TabStop = false;
            this.grp_Datos.Text = "Dato Obra Social";
            // 
            // Validaciones
            // 
            this.Validaciones.ContainerControl = this;
            // 
            // dgv_ObraSocial
            // 
            this.dgv_ObraSocial.AutoGenerateColumns = false;
            this.dgv_ObraSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ObraSocial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObraSocialDataGridViewTextBoxColumn,
            this.obrasocialnomDataGridViewTextBoxColumn});
            this.dgv_ObraSocial.DataSource = this.obrasocialBindingSource;
            this.dgv_ObraSocial.Location = new System.Drawing.Point(93, 62);
            this.dgv_ObraSocial.Name = "dgv_ObraSocial";
            this.dgv_ObraSocial.RowTemplate.Height = 33;
            this.dgv_ObraSocial.Size = new System.Drawing.Size(490, 297);
            this.dgv_ObraSocial.TabIndex = 4;
            // 
            // idObraSocialDataGridViewTextBoxColumn
            // 
            this.idObraSocialDataGridViewTextBoxColumn.DataPropertyName = "Id_ObraSocial";
            this.idObraSocialDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idObraSocialDataGridViewTextBoxColumn.Name = "idObraSocialDataGridViewTextBoxColumn";
            // 
            // obrasocialnomDataGridViewTextBoxColumn
            // 
            this.obrasocialnomDataGridViewTextBoxColumn.DataPropertyName = "obrasocial_nom";
            this.obrasocialnomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.obrasocialnomDataGridViewTextBoxColumn.Name = "obrasocialnomDataGridViewTextBoxColumn";
            // 
            // ObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 676);
            this.Controls.Add(this.grp_Datos);
            this.Controls.Add(this.grp_Listado);
            this.Name = "ObraSocial";
            this.Text = "Obras Sociales";
            ((System.ComponentModel.ISupportInitialize)(this.obrasocialBindingSource)).EndInit();
            this.grp_Listado.ResumeLayout(false);
            this.grp_Datos.ResumeLayout(false);
            this.grp_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ObraSocial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource obrasocialBindingSource;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_upda;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox grp_Listado;
        private System.Windows.Forms.GroupBox grp_Datos;
        private System.Windows.Forms.ErrorProvider Validaciones;
        private System.Windows.Forms.DataGridView dgv_ObraSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObraSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obrasocialnomDataGridViewTextBoxColumn;
    }
}

