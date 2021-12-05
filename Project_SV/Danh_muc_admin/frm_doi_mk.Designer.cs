
namespace Project_SV
{
    partial class frm_doi_mk
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
            this.btndoimk = new System.Windows.Forms.Button();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grtaikhoan = new System.Windows.Forms.DataGridView();
            this.tenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grtaikhoan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndoimk
            // 
            this.btndoimk.Location = new System.Drawing.Point(7, 27);
            this.btndoimk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndoimk.Name = "btndoimk";
            this.btndoimk.Size = new System.Drawing.Size(112, 35);
            this.btndoimk.TabIndex = 2;
            this.btndoimk.Text = "Đổi mật khẩu";
            this.btndoimk.UseVisualStyleBackColor = true;
            this.btndoimk.Click += new System.EventHandler(this.btndoimk_Click);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(192, 57);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(148, 26);
            this.txtmk.TabIndex = 1;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(78, 14);
            this.txtmasv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(262, 26);
            this.txtmasv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu cần thay đổi";
            // 
            // grtaikhoan
            // 
            this.grtaikhoan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grtaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grtaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDN,
            this.matkhau,
            this.hoten});
            this.grtaikhoan.Location = new System.Drawing.Point(12, 197);
            this.grtaikhoan.Name = "grtaikhoan";
            this.grtaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grtaikhoan.Size = new System.Drawing.Size(423, 150);
            this.grtaikhoan.TabIndex = 4;
            this.grtaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grtaikhoan_CellClick);
            // 
            // tenDN
            // 
            this.tenDN.DataPropertyName = "tenDN";
            this.tenDN.FillWeight = 130F;
            this.tenDN.HeaderText = "Tài khoản";
            this.tenDN.Name = "tenDN";
            this.tenDN.ReadOnly = true;
            this.tenDN.Width = 130;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.Name = "matkhau";
            this.matkhau.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ và tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 150;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 27);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(188, 26);
            this.txttimkiem.TabIndex = 3;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndoimk);
            this.groupBox2.Location = new System.Drawing.Point(218, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // frm_doi_mk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(450, 359);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grtaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmasv);
            this.Controls.Add(this.txtmk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_doi_mk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_doi_mk_FormClosed);
            this.Load += new System.EventHandler(this.frm_doi_mk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grtaikhoan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndoimk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grtaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}