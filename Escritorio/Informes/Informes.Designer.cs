namespace Escritorio.Informes
{
    partial class Informes
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
            this.crm_informes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crm_informes
            // 
            this.crm_informes.ActiveViewIndex = -1;
            this.crm_informes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crm_informes.Cursor = System.Windows.Forms.Cursors.Default;
            this.crm_informes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crm_informes.Location = new System.Drawing.Point(0, 0);
            this.crm_informes.Name = "crm_informes";
            this.crm_informes.Size = new System.Drawing.Size(800, 450);
            this.crm_informes.TabIndex = 0;
            this.crm_informes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crm_informes);
            this.Name = "Informes";
            this.Text = "Informes";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crm_informes;
    }
}