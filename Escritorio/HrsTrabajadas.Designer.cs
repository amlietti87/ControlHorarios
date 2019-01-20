namespace Escritorio
{
    partial class HrsTrabajadas
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
            this.grp_mes = new System.Windows.Forms.GroupBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_Horas = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_chgm = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_chrg = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_deuda = new System.Windows.Forms.TextBox();
            this.dgv_Horas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoTerapeutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTerapeutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobradaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listarHorasTrabajadasResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp_Datos = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.txt_hrs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_month = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_place = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_TiposHrs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Pac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Validaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_mes.SuspendLayout();
            this.grp_Horas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarHorasTrabajadasResultBindingSource)).BeginInit();
            this.grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_mes
            // 
            this.grp_mes.Controls.Add(this.cmb_year);
            this.grp_mes.Controls.Add(this.cmb_month);
            this.grp_mes.Controls.Add(this.label1);
            this.grp_mes.Location = new System.Drawing.Point(12, 4);
            this.grp_mes.Name = "grp_mes";
            this.grp_mes.Size = new System.Drawing.Size(763, 68);
            this.grp_mes.TabIndex = 0;
            this.grp_mes.TabStop = false;
            this.grp_mes.Text = "Seleccion Fecha";
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(477, 27);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(121, 21);
            this.cmb_year.TabIndex = 2;
            this.cmb_year.SelectionChangeCommitted += new System.EventHandler(this.cmb_year_SelectionChangeCommitted);
            // 
            // cmb_month
            // 
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(338, 27);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(121, 21);
            this.cmb_month.TabIndex = 1;
            this.cmb_month.SelectionChangeCommitted += new System.EventHandler(this.cmb_month_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Mes y Año";
            // 
            // grp_Horas
            // 
            this.grp_Horas.Controls.Add(this.btn_export);
            this.grp_Horas.Controls.Add(this.btn_chgm);
            this.grp_Horas.Controls.Add(this.btn_del);
            this.grp_Horas.Controls.Add(this.btn_chrg);
            this.grp_Horas.Controls.Add(this.btn_new);
            this.grp_Horas.Controls.Add(this.label2);
            this.grp_Horas.Controls.Add(this.txt_deuda);
            this.grp_Horas.Controls.Add(this.dgv_Horas);
            this.grp_Horas.Location = new System.Drawing.Point(12, 78);
            this.grp_Horas.Name = "grp_Horas";
            this.grp_Horas.Size = new System.Drawing.Size(763, 307);
            this.grp_Horas.TabIndex = 1;
            this.grp_Horas.TabStop = false;
            this.grp_Horas.Text = "Horas Trabajadas";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(650, 278);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(100, 23);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "Exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_chgm
            // 
            this.btn_chgm.Location = new System.Drawing.Point(650, 247);
            this.btn_chgm.Name = "btn_chgm";
            this.btn_chgm.Size = new System.Drawing.Size(100, 23);
            this.btn_chgm.TabIndex = 6;
            this.btn_chgm.Text = "Cambiar Fecha";
            this.btn_chgm.UseVisualStyleBackColor = true;
            this.btn_chgm.Click += new System.EventHandler(this.btn_chgm_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(465, 262);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(80, 30);
            this.btn_del.TabIndex = 5;
            this.btn_del.Text = "Eliminar";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_chrg
            // 
            this.btn_chrg.Location = new System.Drawing.Point(345, 262);
            this.btn_chrg.Name = "btn_chrg";
            this.btn_chrg.Size = new System.Drawing.Size(80, 30);
            this.btn_chrg.TabIndex = 4;
            this.btn_chrg.Text = "Cobrar";
            this.btn_chrg.UseVisualStyleBackColor = true;
            this.btn_chrg.Click += new System.EventHandler(this.btn_chrg_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(220, 262);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(80, 30);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "Agregar";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Adeudado";
            // 
            // txt_deuda
            // 
            this.txt_deuda.Location = new System.Drawing.Point(650, 204);
            this.txt_deuda.Name = "txt_deuda";
            this.txt_deuda.Size = new System.Drawing.Size(100, 20);
            this.txt_deuda.TabIndex = 1;
            // 
            // dgv_Horas
            // 
            this.dgv_Horas.AutoGenerateColumns = false;
            this.dgv_Horas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.apellidoTerapeutaDataGridViewTextBoxColumn,
            this.nombreTerapeutaDataGridViewTextBoxColumn,
            this.pacienteApellidoDataGridViewTextBoxColumn,
            this.nombrePacienteDataGridViewTextBoxColumn,
            this.tipoHoraDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.cobradaDataGridViewCheckBoxColumn});
            this.dgv_Horas.DataSource = this.listarHorasTrabajadasResultBindingSource;
            this.dgv_Horas.Location = new System.Drawing.Point(7, 20);
            this.dgv_Horas.Name = "dgv_Horas";
            this.dgv_Horas.Size = new System.Drawing.Size(744, 150);
            this.dgv_Horas.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoTerapeutaDataGridViewTextBoxColumn
            // 
            this.apellidoTerapeutaDataGridViewTextBoxColumn.DataPropertyName = "ApellidoTerapeuta";
            this.apellidoTerapeutaDataGridViewTextBoxColumn.HeaderText = "ApellidoTerapeuta";
            this.apellidoTerapeutaDataGridViewTextBoxColumn.Name = "apellidoTerapeutaDataGridViewTextBoxColumn";
            this.apellidoTerapeutaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreTerapeutaDataGridViewTextBoxColumn
            // 
            this.nombreTerapeutaDataGridViewTextBoxColumn.DataPropertyName = "NombreTerapeuta";
            this.nombreTerapeutaDataGridViewTextBoxColumn.HeaderText = "NombreTerapeuta";
            this.nombreTerapeutaDataGridViewTextBoxColumn.Name = "nombreTerapeutaDataGridViewTextBoxColumn";
            this.nombreTerapeutaDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacienteApellidoDataGridViewTextBoxColumn
            // 
            this.pacienteApellidoDataGridViewTextBoxColumn.DataPropertyName = "PacienteApellido";
            this.pacienteApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.pacienteApellidoDataGridViewTextBoxColumn.Name = "pacienteApellidoDataGridViewTextBoxColumn";
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            this.nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "NombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            // 
            // tipoHoraDataGridViewTextBoxColumn
            // 
            this.tipoHoraDataGridViewTextBoxColumn.DataPropertyName = "TipoHora";
            this.tipoHoraDataGridViewTextBoxColumn.HeaderText = "TipoHora";
            this.tipoHoraDataGridViewTextBoxColumn.Name = "tipoHoraDataGridViewTextBoxColumn";
            // 
            // lugarDataGridViewTextBoxColumn
            // 
            this.lugarDataGridViewTextBoxColumn.DataPropertyName = "Lugar";
            this.lugarDataGridViewTextBoxColumn.HeaderText = "Lugar";
            this.lugarDataGridViewTextBoxColumn.Name = "lugarDataGridViewTextBoxColumn";
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            // 
            // horasDataGridViewTextBoxColumn
            // 
            this.horasDataGridViewTextBoxColumn.DataPropertyName = "Horas";
            this.horasDataGridViewTextBoxColumn.HeaderText = "Cant. Horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total a Cobrar";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // cobradaDataGridViewCheckBoxColumn
            // 
            this.cobradaDataGridViewCheckBoxColumn.DataPropertyName = "Cobrada";
            this.cobradaDataGridViewCheckBoxColumn.HeaderText = "Cobrada";
            this.cobradaDataGridViewCheckBoxColumn.Name = "cobradaDataGridViewCheckBoxColumn";
            this.cobradaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // listarHorasTrabajadasResultBindingSource
            // 
            this.listarHorasTrabajadasResultBindingSource.DataSource = typeof(DataBase.ListarHorasTrabajadasResult);
            // 
            // grp_Datos
            // 
            this.grp_Datos.Controls.Add(this.btn_cancel);
            this.grp_Datos.Controls.Add(this.btn_confirm);
            this.grp_Datos.Controls.Add(this.txt_hrs);
            this.grp_Datos.Controls.Add(this.label7);
            this.grp_Datos.Controls.Add(this.txt_month);
            this.grp_Datos.Controls.Add(this.label6);
            this.grp_Datos.Controls.Add(this.txt_place);
            this.grp_Datos.Controls.Add(this.label5);
            this.grp_Datos.Controls.Add(this.cmb_TiposHrs);
            this.grp_Datos.Controls.Add(this.label4);
            this.grp_Datos.Controls.Add(this.cmb_Pac);
            this.grp_Datos.Controls.Add(this.label3);
            this.grp_Datos.Location = new System.Drawing.Point(12, 392);
            this.grp_Datos.Name = "grp_Datos";
            this.grp_Datos.Size = new System.Drawing.Size(763, 212);
            this.grp_Datos.TabIndex = 2;
            this.grp_Datos.TabStop = false;
            this.grp_Datos.Text = "Carga de Horas";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(440, 166);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(252, 166);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(80, 30);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // txt_hrs
            // 
            this.txt_hrs.Location = new System.Drawing.Point(650, 46);
            this.txt_hrs.Name = "txt_hrs";
            this.txt_hrs.Size = new System.Drawing.Size(100, 20);
            this.txt_hrs.TabIndex = 9;
            this.txt_hrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hrs_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad Horas";
            // 
            // txt_month
            // 
            this.txt_month.Location = new System.Drawing.Point(384, 116);
            this.txt_month.Name = "txt_month";
            this.txt_month.Size = new System.Drawing.Size(100, 20);
            this.txt_month.TabIndex = 7;
            this.txt_month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_month_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha";
            // 
            // txt_place
            // 
            this.txt_place.Location = new System.Drawing.Point(384, 47);
            this.txt_place.Name = "txt_place";
            this.txt_place.Size = new System.Drawing.Size(100, 20);
            this.txt_place.TabIndex = 5;
            this.txt_place.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_place_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lugar";
            // 
            // cmb_TiposHrs
            // 
            this.cmb_TiposHrs.FormattingEnabled = true;
            this.cmb_TiposHrs.Location = new System.Drawing.Point(122, 116);
            this.cmb_TiposHrs.Name = "cmb_TiposHrs";
            this.cmb_TiposHrs.Size = new System.Drawing.Size(121, 21);
            this.cmb_TiposHrs.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Hora";
            // 
            // cmb_Pac
            // 
            this.cmb_Pac.FormattingEnabled = true;
            this.cmb_Pac.Location = new System.Drawing.Point(122, 46);
            this.cmb_Pac.Name = "cmb_Pac";
            this.cmb_Pac.Size = new System.Drawing.Size(121, 21);
            this.cmb_Pac.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Paciente";
            // 
            // Validaciones
            // 
            this.Validaciones.ContainerControl = this;
            // 
            // HrsTrabajadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 616);
            this.Controls.Add(this.grp_Datos);
            this.Controls.Add(this.grp_Horas);
            this.Controls.Add(this.grp_mes);
            this.Name = "HrsTrabajadas";
            this.Text = "HrsTrabajadas";
            this.grp_mes.ResumeLayout(false);
            this.grp_mes.PerformLayout();
            this.grp_Horas.ResumeLayout(false);
            this.grp_Horas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarHorasTrabajadasResultBindingSource)).EndInit();
            this.grp_Datos.ResumeLayout(false);
            this.grp_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Validaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_mes;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Horas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_deuda;
        private System.Windows.Forms.DataGridView dgv_Horas;
        private System.Windows.Forms.BindingSource listarHorasTrabajadasResultBindingSource;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_chrg;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoTerapeutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTerapeutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cobradaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox grp_Datos;
        private System.Windows.Forms.TextBox txt_hrs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_month;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_place;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_TiposHrs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Pac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ErrorProvider Validaciones;
        private System.Windows.Forms.Button btn_chgm;
        private System.Windows.Forms.Button btn_export;
    }
}