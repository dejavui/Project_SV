
namespace Project_SV
{
    partial class frm_quan_ly_tk_he_thong
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
            this.btnthem = new System.Windows.Forms.Button();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gr_tk = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ho_ten = new System.Windows.Forms.TextBox();
            this.cmb_per = new System.Windows.Forms.ComboBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.PicAn = new System.Windows.Forms.PictureBox();
            this.PicHien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gr_tk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(13, 311);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(112, 47);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txt_tk
            // 
            this.txt_tk.Location = new System.Drawing.Point(96, 168);
            this.txt_tk.Multiline = true;
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(267, 30);
            this.txt_tk.TabIndex = 1;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(96, 205);
            this.txt_mk.Multiline = true;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(267, 30);
            this.txt_mk.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quyền";
            // 
            // gr_tk
            // 
            this.gr_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gr_tk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gr_tk.Location = new System.Drawing.Point(16, 12);
            this.gr_tk.Name = "gr_tk";
            this.gr_tk.ReadOnly = true;
            this.gr_tk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gr_tk.Size = new System.Drawing.Size(465, 150);
            this.gr_tk.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenDN";
            this.Column1.HeaderText = "Tài khoản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "matkhau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hoten";
            this.Column3.HeaderText = "Tên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "quyen";
            this.Column4.HeaderText = "Quyền";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txt_ho_ten
            // 
            this.txt_ho_ten.Location = new System.Drawing.Point(96, 241);
            this.txt_ho_ten.Multiline = true;
            this.txt_ho_ten.Name = "txt_ho_ten";
            this.txt_ho_ten.Size = new System.Drawing.Size(267, 30);
            this.txt_ho_ten.TabIndex = 5;
            // 
            // cmb_per
            // 
            this.cmb_per.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_per.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_per.FormattingEnabled = true;
            this.cmb_per.Items.AddRange(new object[] {
            "thuky",
            "giaovien",
            "ketoan",
            "truongphong",
            "nhanvien"});
            this.cmb_per.Location = new System.Drawing.Point(96, 275);
            this.cmb_per.Name = "cmb_per";
            this.cmb_per.Size = new System.Drawing.Size(121, 28);
            this.cmb_per.TabIndex = 6;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(133, 311);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(112, 47);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // PicAn
            // 
            this.PicAn.BackColor = System.Drawing.Color.White;
            this.PicAn.Image = global::Project_SV.Properties.Resources.visibility;
            this.PicAn.Location = new System.Drawing.Point(326, 210);
            this.PicAn.Margin = new System.Windows.Forms.Padding(2);
            this.PicAn.Name = "PicAn";
            this.PicAn.Size = new System.Drawing.Size(35, 20);
            this.PicAn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicAn.TabIndex = 9;
            this.PicAn.TabStop = false;
            this.PicAn.Click += new System.EventHandler(this.PicAn_Click);
            // 
            // PicHien
            // 
            this.PicHien.BackColor = System.Drawing.Color.White;
            this.PicHien.Image = global::Project_SV.Properties.Resources.eye;
            this.PicHien.Location = new System.Drawing.Point(326, 210);
            this.PicHien.Margin = new System.Windows.Forms.Padding(2);
            this.PicHien.Name = "PicHien";
            this.PicHien.Size = new System.Drawing.Size(35, 20);
            this.PicHien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicHien.TabIndex = 8;
            this.PicHien.TabStop = false;
            this.PicHien.Click += new System.EventHandler(this.PicHien_Click);
            // 
            // frm_quan_ly_tk_he_thong
            // 
            this.AcceptButton = this.btnthem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(496, 467);
            this.Controls.Add(this.PicAn);
            this.Controls.Add(this.PicHien);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.cmb_per);
            this.Controls.Add(this.txt_ho_ten);
            this.Controls.Add(this.gr_tk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.btnthem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_quan_ly_tk_he_thong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản hệ thống";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_quan_ly_tk_he_thong_FormClosed);
            this.Load += new System.EventHandler(this.frm_quan_ly_tk_he_thong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gr_tk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gr_tk;
        private System.Windows.Forms.TextBox txt_ho_ten;
        private System.Windows.Forms.ComboBox cmb_per;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.PictureBox PicAn;
        private System.Windows.Forms.PictureBox PicHien;
    }
}