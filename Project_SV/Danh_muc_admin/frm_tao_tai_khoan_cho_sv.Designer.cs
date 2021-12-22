
namespace Project_SV
{
    partial class frm_tao_tai_khoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tao = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.grlogins = new System.Windows.Forms.DataGridView();
            this.tenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grlogins)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(141, 13);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(250, 29);
            this.txtmasv.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(141, 57);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(250, 29);
            this.txthoten.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sinh viên";
            // 
            // btn_tao
            // 
            this.btn_tao.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btn_tao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tao.Location = new System.Drawing.Point(397, 13);
            this.btn_tao.Name = "btn_tao";
            this.btn_tao.Size = new System.Drawing.Size(87, 43);
            this.btn_tao.TabIndex = 6;
            this.btn_tao.Text = "Tạo";
            this.btn_tao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_tao.UseVisualStyleBackColor = true;
            this.btn_tao.Click += new System.EventHandler(this.btn_tao_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(397, 62);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 43);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // grlogins
            // 
            this.grlogins.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grlogins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlogins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDN,
            this.hoten});
            this.grlogins.Location = new System.Drawing.Point(15, 92);
            this.grlogins.Name = "grlogins";
            this.grlogins.ReadOnly = true;
            this.grlogins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grlogins.Size = new System.Drawing.Size(376, 150);
            this.grlogins.TabIndex = 8;
            // 
            // tenDN
            // 
            this.tenDN.DataPropertyName = "tenDN";
            this.tenDN.HeaderText = "Tài khoản";
            this.tenDN.Name = "tenDN";
            this.tenDN.ReadOnly = true;
            this.tenDN.Width = 130;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên sinh viên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 200;
            // 
            // frm_tao_tai_khoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(539, 317);
            this.Controls.Add(this.grlogins);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btn_tao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_tao_tai_khoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo và Xóa tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_tao_tai_khoan_FormClosed);
            this.Load += new System.EventHandler(this.frm_tao_tai_khoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlogins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tao;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView grlogins;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
    }
}