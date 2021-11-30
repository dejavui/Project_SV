
namespace Project_SV
{
    partial class frmReportKetQua
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
            this.rpketqua = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpketqua
            // 
            this.rpketqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpketqua.Location = new System.Drawing.Point(0, 0);
            this.rpketqua.Name = "rpketqua";
            this.rpketqua.ServerReport.BearerToken = null;
            this.rpketqua.Size = new System.Drawing.Size(800, 450);
            this.rpketqua.TabIndex = 0;
            this.rpketqua.Load += new System.EventHandler(this.rpketqua_Load);
            // 
            // frmReportKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpketqua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReportKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In kết quả học tập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmReportKetQua_FormClosed);
            this.Load += new System.EventHandler(this.frmReportKetQua_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpketqua;
    }
}