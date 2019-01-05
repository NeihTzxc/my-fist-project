namespace QLBH._forms
{
    partial class frm_report
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
            this.ReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.ActiveViewIndex = -1;
            this.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportViewer1.DisplayGroupTree = false;
            this.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer1";
            this.ReportViewer1.SelectionFormula = "";
            this.ReportViewer1.Size = new System.Drawing.Size(571, 427);
            this.ReportViewer1.TabIndex = 0;
            this.ReportViewer1.ViewTimeSelectionFormula = "";
            this.ReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 427);
            this.Controls.Add(this.ReportViewer1);
            this.Name = "frm_report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_report_nv_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer ReportViewer1;
    }
}