﻿namespace Escritorio
{
    partial class TipodeHora
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
            this.grp_Datos = new System.Windows.Forms.GroupBox();
            this.dgv_TdH = new System.Windows.Forms.DataGridView();
            this.tipodehoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTipodeHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodehoranomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_updte = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.Validacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_Listados.SuspendLayout();
            this.grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TdH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodehoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Listados
            // 
            this.grp_Listados.Controls.Add(this.btn_del);
            this.grp_Listados.Controls.Add(this.btn_updte);
            this.grp_Listados.Controls.Add(this.btn_new);
            this.grp_Listados.Controls.Add(this.dgv_TdH);
            this.grp_Listados.Location = new System.Drawing.Point(6, 6);
            this.grp_Listados.Name = "grp_Listados";
            this.grp_Listados.Size = new System.Drawing.Size(470, 202);
            this.grp_Listados.TabIndex = 0;
            this.grp_Listados.TabStop = false;
            this.grp_Listados.Text = "Tipos de Hora";
            // 
            // grp_Datos
            // 
            this.grp_Datos.Controls.Add(this.btn_cancel);
            this.grp_Datos.Controls.Add(this.btn_confirm);
            this.grp_Datos.Controls.Add(this.txt_name);
            this.grp_Datos.Controls.Add(this.label1);
            this.grp_Datos.Location = new System.Drawing.Point(6, 216);
            this.grp_Datos.Name = "grp_Datos";
            this.grp_Datos.Size = new System.Drawing.Size(470, 129);
            this.grp_Datos.TabIndex = 1;
            this.grp_Datos.TabStop = false;
            this.grp_Datos.Text = "Datos Tipo de Hora";
            // 
            // dgv_TdH
            // 
            this.dgv_TdH.AutoGenerateColumns = false;
            this.dgv_TdH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TdH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipodeHoraDataGridViewTextBoxColumn,
            this.tipodehoranomDataGridViewTextBoxColumn});
            this.dgv_TdH.DataSource = this.tipodehoraBindingSource;
            this.dgv_TdH.Location = new System.Drawing.Point(46, 32);
            this.dgv_TdH.Name = "dgv_TdH";
            this.dgv_TdH.Size = new System.Drawing.Size(244, 150);
            this.dgv_TdH.TabIndex = 0;
            this.dgv_TdH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TdH_CellClick);
            // 
            // tipodehoraBindingSource
            // 
            this.tipodehoraBindingSource.DataSource = typeof(DataBase.tipodehora);
            // 
            // idTipodeHoraDataGridViewTextBoxColumn
            // 
            this.idTipodeHoraDataGridViewTextBoxColumn.DataPropertyName = "Id_TipodeHora";
            this.idTipodeHoraDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idTipodeHoraDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.idTipodeHoraDataGridViewTextBoxColumn.Name = "idTipodeHoraDataGridViewTextBoxColumn";
            // 
            // tipodehoranomDataGridViewTextBoxColumn
            // 
            this.tipodehoranomDataGridViewTextBoxColumn.DataPropertyName = "tipodehora_nom";
            this.tipodehoranomDataGridViewTextBoxColumn.HeaderText = "Tipo de Hora";
            this.tipodehoranomDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.tipodehoranomDataGridViewTextBoxColumn.Name = "tipodehoranomDataGridViewTextBoxColumn";
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
            // btn_updte
            // 
            this.btn_updte.Location = new System.Drawing.Point(364, 96);
            this.btn_updte.Name = "btn_updte";
            this.btn_updte.Size = new System.Drawing.Size(65, 26);
            this.btn_updte.TabIndex = 2;
            this.btn_updte.Text = "Modificar";
            this.btn_updte.UseVisualStyleBackColor = true;
            this.btn_updte.Click += new System.EventHandler(this.btn_updte_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Hora";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(156, 45);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
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
            // Validacion
            // 
            this.Validacion.ContainerControl = this;
            // 
            // TipodeHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 352);
            this.Controls.Add(this.grp_Datos);
            this.Controls.Add(this.grp_Listados);
            this.Name = "TipodeHora";
            this.Text = "TipodeHora";
            this.grp_Listados.ResumeLayout(false);
            this.grp_Datos.ResumeLayout(false);
            this.grp_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TdH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodehoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Validacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Listados;
        private System.Windows.Forms.GroupBox grp_Datos;
        private System.Windows.Forms.DataGridView dgv_TdH;
        private System.Windows.Forms.BindingSource tipodehoraBindingSource;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_updte;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipodeHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodehoranomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ErrorProvider Validacion;
    }
}