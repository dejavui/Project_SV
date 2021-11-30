
namespace Project_SV
{
    partial class frmketqua
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
            this.txtdiemthi = new System.Windows.Forms.TextBox();
            this.txtlanthi = new System.Windows.Forms.TextBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txttimkiemmasv = new System.Windows.Forms.TextBox();
            this.grkq = new System.Windows.Forms.DataGridView();
            this.ma_kq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ma_kq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtenlop = new System.Windows.Forms.ComboBox();
            this.cmbmonhoc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grkq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdiemthi
            // 
            this.txtdiemthi.Location = new System.Drawing.Point(119, 200);
            this.txtdiemthi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiemthi.Name = "txtdiemthi";
            this.txtdiemthi.Size = new System.Drawing.Size(162, 26);
            this.txtdiemthi.TabIndex = 19;
            // 
            // txtlanthi
            // 
            this.txtlanthi.Location = new System.Drawing.Point(119, 164);
            this.txtlanthi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtlanthi.Name = "txtlanthi";
            this.txtlanthi.Size = new System.Drawing.Size(162, 26);
            this.txtlanthi.TabIndex = 17;
            // 
            // txttensv
            // 
            this.txttensv.Location = new System.Drawing.Point(119, 61);
            this.txttensv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttensv.Name = "txttensv";
            this.txttensv.Size = new System.Drawing.Size(162, 26);
            this.txttensv.TabIndex = 14;
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(-297, 555);
            this.txtmasv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(148, 26);
            this.txtmasv.TabIndex = 13;
            // 
            // txttimkiemmasv
            // 
            this.txttimkiemmasv.Location = new System.Drawing.Point(7, 27);
            this.txttimkiemmasv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiemmasv.Name = "txttimkiemmasv";
            this.txttimkiemmasv.Size = new System.Drawing.Size(274, 26);
            this.txttimkiemmasv.TabIndex = 7;
            this.txttimkiemmasv.TextChanged += new System.EventHandler(this.txttimkiemmasv_TextChanged);
            // 
            // grkq
            // 
            this.grkq.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grkq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grkq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_kq,
            this.Column1,
            this.Column2,
            this.ten_lop,
            this.Column3,
            this.Column4});
            this.grkq.Location = new System.Drawing.Point(12, 14);
            this.grkq.Name = "grkq";
            this.grkq.ReadOnly = true;
            this.grkq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grkq.Size = new System.Drawing.Size(643, 523);
            this.grkq.TabIndex = 22;
            this.grkq.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grkq_CellClick);
            // 
            // ma_kq
            // 
            this.ma_kq.DataPropertyName = "ma_kq";
            this.ma_kq.HeaderText = "Mã kết quả";
            this.ma_kq.Name = "ma_kq";
            this.ma_kq.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_sv";
            this.Column1.HeaderText = "Mã SV";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten_mh";
            this.Column2.HeaderText = "Tên môn học";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ten_lop
            // 
            this.ten_lop.DataPropertyName = "ma_lop";
            this.ten_lop.HeaderText = "Tên lớp";
            this.ten_lop.Name = "ten_lop";
            this.ten_lop.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lan_thi";
            this.Column3.HeaderText = "Lần thi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "diem";
            this.Column4.HeaderText = "Điểm";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tên môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tên lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Lần thi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Điểm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ma_kq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbtenlop);
            this.groupBox1.Controls.Add(this.cmbmonhoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdiemthi);
            this.groupBox1.Controls.Add(this.txtlanthi);
            this.groupBox1.Location = new System.Drawing.Point(667, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 241);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập liệu";
            // 
            // txt_ma_kq
            // 
            this.txt_ma_kq.Location = new System.Drawing.Point(119, 27);
            this.txt_ma_kq.Name = "txt_ma_kq";
            this.txt_ma_kq.Size = new System.Drawing.Size(162, 26);
            this.txt_ma_kq.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Mã KQ";
            // 
            // cmbtenlop
            // 
            this.cmbtenlop.FormattingEnabled = true;
            this.cmbtenlop.Location = new System.Drawing.Point(119, 128);
            this.cmbtenlop.Name = "cmbtenlop";
            this.cmbtenlop.Size = new System.Drawing.Size(162, 28);
            this.cmbtenlop.TabIndex = 36;
            // 
            // cmbmonhoc
            // 
            this.cmbmonhoc.FormattingEnabled = true;
            this.cmbmonhoc.Location = new System.Drawing.Point(119, 93);
            this.cmbmonhoc.Name = "cmbmonhoc";
            this.cmbmonhoc.Size = new System.Drawing.Size(162, 28);
            this.cmbmonhoc.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiemmasv);
            this.groupBox2.Location = new System.Drawing.Point(667, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 67);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnthoat
            // 
            this.btnthoat.Image = global::Project_SV.Properties.Resources.out2;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(6, 139);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(166, 51);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Form Main";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click_1);
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(6, 83);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(166, 51);
            this.btnkhongghi.TabIndex = 26;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // btnghi
            // 
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(6, 25);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(166, 51);
            this.btnghi.TabIndex = 25;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(6, 82);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(166, 51);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(6, 25);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(166, 51);
            this.btnthem.TabIndex = 23;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnthoat);
            this.groupBox3.Controls.Add(this.btnkhongghi);
            this.groupBox3.Controls.Add(this.btnghi);
            this.groupBox3.Location = new System.Drawing.Point(667, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 203);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // frmketqua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(978, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grkq);
            this.Controls.Add(this.txtmasv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmketqua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết quả";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmketqua_FormClosed);
            this.Load += new System.EventHandler(this.frmketqua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grkq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdiemthi;
        private System.Windows.Forms.TextBox txtlanthi;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txttimkiemmasv;
        private System.Windows.Forms.DataGridView grkq;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbmonhoc;
        private System.Windows.Forms.ComboBox cmbtenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_kq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txt_ma_kq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}