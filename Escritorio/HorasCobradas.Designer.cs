namespace Escritorio
{
    partial class HorasCobradas
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
            this.grp_date = new System.Windows.Forms.GroupBox();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_hrs = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cobrado = new System.Windows.Forms.TextBox();
            this.btn_chrg = new System.Windows.Forms.Button();
            this.btn_chgd = new System.Windows.Forms.Button();
            this.dgv_HrsCob = new System.Windows.Forms.DataGridView();
            this.listarHorasTrabajadasPagasResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobradaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grp_date.SuspendLayout();
            this.grb_hrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HrsCob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarHorasTrabajadasPagasResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_date
            // 
            this.grp_date.Controls.Add(this.cmb_year);
            this.grp_date.Controls.Add(this.cmb_month);
            this.grp_date.Controls.Add(this.label1);
            this.grp_date.Location = new System.Drawing.Point(13, 13);
            this.grp_date.Name = "grp_date";
            this.grp_date.Size = new System.Drawing.Size(775, 84);
            this.grp_date.TabIndex = 0;
            this.grp_date.TabStop = false;
            this.grp_date.Text = "Seleccionar Fecha";
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(469, 32);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(121, 21);
            this.cmb_year.TabIndex = 2;
            this.cmb_year.SelectionChangeCommitted += new System.EventHandler(this.cmb_year_SelectionChangeCommitted);
            // 
            // cmb_month
            // 
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(330, 32);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(121, 21);
            this.cmb_month.TabIndex = 1;
            this.cmb_month.SelectionChangeCommitted += new System.EventHandler(this.cmb_month_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Mes y Año";
            // 
            // grb_hrs
            // 
            this.grb_hrs.Controls.Add(this.label2);
            this.grb_hrs.Controls.Add(this.txt_cobrado);
            this.grb_hrs.Controls.Add(this.btn_chrg);
            this.grb_hrs.Controls.Add(this.btn_chgd);
            this.grb_hrs.Controls.Add(this.dgv_HrsCob);
            this.grb_hrs.Location = new System.Drawing.Point(13, 97);
            this.grb_hrs.Name = "grb_hrs";
            this.grb_hrs.Size = new System.Drawing.Size(775, 446);
            this.grb_hrs.TabIndex = 1;
            this.grb_hrs.TabStop = false;
            this.grb_hrs.Text = "Horas Cobradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Abonado";
            // 
            // txt_cobrado
            // 
            this.txt_cobrado.Location = new System.Drawing.Point(653, 363);
            this.txt_cobrado.Name = "txt_cobrado";
            this.txt_cobrado.Size = new System.Drawing.Size(100, 20);
            this.txt_cobrado.TabIndex = 6;
            // 
            // btn_chrg
            // 
            this.btn_chrg.Location = new System.Drawing.Point(469, 406);
            this.btn_chrg.Name = "btn_chrg";
            this.btn_chrg.Size = new System.Drawing.Size(100, 30);
            this.btn_chrg.TabIndex = 5;
            this.btn_chrg.Text = "Exportar";
            this.btn_chrg.UseVisualStyleBackColor = true;
            this.btn_chrg.Click += new System.EventHandler(this.btn_chrg_Click);
            // 
            // btn_chgd
            // 
            this.btn_chgd.Location = new System.Drawing.Point(267, 406);
            this.btn_chgd.Name = "btn_chgd";
            this.btn_chgd.Size = new System.Drawing.Size(100, 30);
            this.btn_chgd.TabIndex = 4;
            this.btn_chgd.Text = "Cambiar Fecha";
            this.btn_chgd.UseVisualStyleBackColor = true;
            this.btn_chgd.Click += new System.EventHandler(this.btn_chgd_Click);
            // 
            // dgv_HrsCob
            // 
            this.dgv_HrsCob.AutoGenerateColumns = false;
            this.dgv_HrsCob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HrsCob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.nombrePacienteDataGridViewTextBoxColumn,
            this.tipoHoraDataGridViewTextBoxColumn,
            this.lugarDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.horasDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.cobradaDataGridViewCheckBoxColumn});
            this.dgv_HrsCob.DataSource = this.listarHorasTrabajadasPagasResultBindingSource;
            this.dgv_HrsCob.Location = new System.Drawing.Point(15, 20);
            this.dgv_HrsCob.Name = "dgv_HrsCob";
            this.dgv_HrsCob.Size = new System.Drawing.Size(745, 337);
            this.dgv_HrsCob.TabIndex = 0;
            // 
            // listarHorasTrabajadasPagasResultBindingSource
            // 
            this.listarHorasTrabajadasPagasResultBindingSource.DataSource = typeof(DataBase.ListarHorasTrabajadasPagasResult);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PacienteApellido";
            this.dataGridViewTextBoxColumn1.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            this.horasDataGridViewTextBoxColumn.HeaderText = "Total Horas";
            this.horasDataGridViewTextBoxColumn.Name = "horasDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // cobradaDataGridViewCheckBoxColumn
            // 
            this.cobradaDataGridViewCheckBoxColumn.DataPropertyName = "Cobrada";
            this.cobradaDataGridViewCheckBoxColumn.HeaderText = "Cobrada";
            this.cobradaDataGridViewCheckBoxColumn.Name = "cobradaDataGridViewCheckBoxColumn";
            this.cobradaDataGridViewCheckBoxColumn.Visible = false;
            // 
            // HorasCobradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.grb_hrs);
            this.Controls.Add(this.grp_date);
            this.Name = "HorasCobradas";
            this.Text = "HorasCobradas";
            this.grp_date.ResumeLayout(false);
            this.grp_date.PerformLayout();
            this.grb_hrs.ResumeLayout(false);
            this.grb_hrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HrsCob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listarHorasTrabajadasPagasResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_date;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_hrs;
        private System.Windows.Forms.DataGridView dgv_HrsCob;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_chgd;
        private System.Windows.Forms.Button btn_chrg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoTerapeutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTerapeutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cobradaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource listarHorasTrabajadasPagasResultBindingSource;
    }
}