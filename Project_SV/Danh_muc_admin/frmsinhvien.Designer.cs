
namespace Project_SV
{
    partial class frmsinhvien
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
            this.grsinhvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txt_dia_chi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmalop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_ngay_thang_nam_sinh = new System.Windows.Forms.DateTimePicker();
            this.cmb_gioi_tinh = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rd_toantruong = new System.Windows.Forms.RadioButton();
            this.rdkhoa_NGONNGU = new System.Windows.Forms.RadioButton();
            this.rdkhoa_KINHTE = new System.Windows.Forms.RadioButton();
            this.rdkhoaCN_OTO = new System.Windows.Forms.RadioButton();
            this.rdkhoaDL = new System.Windows.Forms.RadioButton();
            this.rdkhoa_CNTT = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grsinhvien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grsinhvien
            // 
            this.grsinhvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.grsinhvien.Location = new System.Drawing.Point(13, 18);
            this.grsinhvien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grsinhvien.Name = "grsinhvien";
            this.grsinhvien.RowTemplate.Height = 30;
            this.grsinhvien.RowTemplate.ReadOnly = true;
            this.grsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grsinhvien.Size = new System.Drawing.Size(892, 628);
            this.grsinhvien.TabIndex = 0;
            this.grsinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grsinhvien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_sv";
            this.Column1.HeaderText = "Mã sv";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ho_ten";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "gioi_tinh";
            this.Column3.HeaderText = "Giới tính";
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngay_thang_nam_sinh";
            this.Column4.HeaderText = "Ngày sinh";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "dia_chi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ten_lop";
            this.Column6.HeaderText = "Lớp";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ten_khoa";
            this.Column7.HeaderText = "Khoa";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(14, 25);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(287, 26);
            this.txttimkiem.TabIndex = 31;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(104, 33);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(207, 26);
            this.txtmasv.TabIndex = 1;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(104, 65);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(207, 26);
            this.txthoten.TabIndex = 2;
            // 
            // txt_dia_chi
            // 
            this.txt_dia_chi.Location = new System.Drawing.Point(104, 163);
            this.txt_dia_chi.Name = "txt_dia_chi";
            this.txt_dia_chi.Size = new System.Drawing.Size(207, 26);
            this.txt_dia_chi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày, tháng, năm sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giới tính";
            // 
            // cmbmalop
            // 
            this.cmbmalop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbmalop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbmalop.FormattingEnabled = true;
            this.cmbmalop.Location = new System.Drawing.Point(104, 195);
            this.cmbmalop.Name = "cmbmalop";
            this.cmbmalop.Size = new System.Drawing.Size(207, 28);
            this.cmbmalop.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mã lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_ngay_thang_nam_sinh);
            this.groupBox1.Controls.Add(this.cmb_gioi_tinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.cmbmalop);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_dia_chi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(912, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 242);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Địa chỉ";
            // 
            // dtp_ngay_thang_nam_sinh
            // 
            this.dtp_ngay_thang_nam_sinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngay_thang_nam_sinh.Location = new System.Drawing.Point(178, 131);
            this.dtp_ngay_thang_nam_sinh.Name = "dtp_ngay_thang_nam_sinh";
            this.dtp_ngay_thang_nam_sinh.Size = new System.Drawing.Size(133, 26);
            this.dtp_ngay_thang_nam_sinh.TabIndex = 4;
            this.dtp_ngay_thang_nam_sinh.Value = new System.DateTime(2021, 11, 21, 15, 48, 53, 0);
            this.dtp_ngay_thang_nam_sinh.ValueChanged += new System.EventHandler(this.dtp_ngay_thang_nam_sinh_ValueChanged);
            // 
            // cmb_gioi_tinh
            // 
            this.cmb_gioi_tinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_gioi_tinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_gioi_tinh.FormattingEnabled = true;
            this.cmb_gioi_tinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmb_gioi_tinh.Location = new System.Drawing.Point(104, 97);
            this.cmb_gioi_tinh.Name = "cmb_gioi_tinh";
            this.cmb_gioi_tinh.Size = new System.Drawing.Size(207, 28);
            this.cmb_gioi_tinh.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Location = new System.Drawing.Point(912, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 71);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsua);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Controls.Add(this.btnfrmmain);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnkhongghi);
            this.groupBox3.Controls.Add(this.btnghi);
            this.groupBox3.Location = new System.Drawing.Point(1072, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 309);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(9, 27);
            this.btnghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(132, 54);
            this.btnghi.TabIndex = 29;
            this.btnghi.Text = "Ghi";
            this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Project_SV.Properties.Resources.sửa1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(9, 91);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(132, 54);
            this.btnsua.TabIndex = 26;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(9, 27);
            this.btnthem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(132, 54);
            this.btnthem.TabIndex = 25;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(9, 220);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(132, 54);
            this.btnfrmmain.TabIndex = 30;
            this.btnfrmmain.Text = "Form Main";
            this.btnfrmmain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmmain.UseVisualStyleBackColor = true;
            this.btnfrmmain.Click += new System.EventHandler(this.btnfrmmain_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(9, 155);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(132, 54);
            this.btnxoa.TabIndex = 27;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(9, 91);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(132, 54);
            this.btnkhongghi.TabIndex = 28;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rd_toantruong);
            this.groupBox4.Controls.Add(this.rdkhoa_NGONNGU);
            this.groupBox4.Controls.Add(this.rdkhoa_KINHTE);
            this.groupBox4.Controls.Add(this.rdkhoaCN_OTO);
            this.groupBox4.Controls.Add(this.rdkhoaDL);
            this.groupBox4.Controls.Add(this.rdkhoa_CNTT);
            this.groupBox4.Location = new System.Drawing.Point(912, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 309);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lọc sinh viên";
            // 
            // rd_toantruong
            // 
            this.rd_toantruong.AutoSize = true;
            this.rd_toantruong.Location = new System.Drawing.Point(14, 27);
            this.rd_toantruong.Name = "rd_toantruong";
            this.rd_toantruong.Size = new System.Drawing.Size(113, 24);
            this.rd_toantruong.TabIndex = 2;
            this.rd_toantruong.TabStop = true;
            this.rd_toantruong.Text = "Toàn trường";
            this.rd_toantruong.UseVisualStyleBackColor = true;
            this.rd_toantruong.CheckedChanged += new System.EventHandler(this.rd_toantruong_CheckedChanged);
            // 
            // rdkhoa_NGONNGU
            // 
            this.rdkhoa_NGONNGU.AutoSize = true;
            this.rdkhoa_NGONNGU.Location = new System.Drawing.Point(14, 177);
            this.rdkhoa_NGONNGU.Name = "rdkhoa_NGONNGU";
            this.rdkhoa_NGONNGU.Size = new System.Drawing.Size(96, 24);
            this.rdkhoa_NGONNGU.TabIndex = 1;
            this.rdkhoa_NGONNGU.TabStop = true;
            this.rdkhoa_NGONNGU.Text = "Ngôn ngữ";
            this.rdkhoa_NGONNGU.UseVisualStyleBackColor = true;
            this.rdkhoa_NGONNGU.CheckedChanged += new System.EventHandler(this.rdkhoa_NGONNGU_CheckedChanged);
            // 
            // rdkhoa_KINHTE
            // 
            this.rdkhoa_KINHTE.AutoSize = true;
            this.rdkhoa_KINHTE.Location = new System.Drawing.Point(14, 147);
            this.rdkhoa_KINHTE.Name = "rdkhoa_KINHTE";
            this.rdkhoa_KINHTE.Size = new System.Drawing.Size(76, 24);
            this.rdkhoa_KINHTE.TabIndex = 0;
            this.rdkhoa_KINHTE.TabStop = true;
            this.rdkhoa_KINHTE.Text = "Kinh tế";
            this.rdkhoa_KINHTE.UseVisualStyleBackColor = true;
            this.rdkhoa_KINHTE.CheckedChanged += new System.EventHandler(this.rdkhoa_KINHTE_CheckedChanged);
            // 
            // rdkhoaCN_OTO
            // 
            this.rdkhoaCN_OTO.AutoSize = true;
            this.rdkhoaCN_OTO.Location = new System.Drawing.Point(14, 117);
            this.rdkhoaCN_OTO.Name = "rdkhoaCN_OTO";
            this.rdkhoaCN_OTO.Size = new System.Drawing.Size(86, 24);
            this.rdkhoaCN_OTO.TabIndex = 0;
            this.rdkhoaCN_OTO.TabStop = true;
            this.rdkhoaCN_OTO.Text = "CN ÔTÔ";
            this.rdkhoaCN_OTO.UseVisualStyleBackColor = true;
            this.rdkhoaCN_OTO.CheckedChanged += new System.EventHandler(this.rdkhoaCN_OTO_CheckedChanged);
            // 
            // rdkhoaDL
            // 
            this.rdkhoaDL.AutoSize = true;
            this.rdkhoaDL.Location = new System.Drawing.Point(14, 87);
            this.rdkhoaDL.Name = "rdkhoaDL";
            this.rdkhoaDL.Size = new System.Drawing.Size(94, 24);
            this.rdkhoaDL.TabIndex = 0;
            this.rdkhoaDL.TabStop = true;
            this.rdkhoaDL.Text = "Điện lạnh";
            this.rdkhoaDL.UseVisualStyleBackColor = true;
            this.rdkhoaDL.CheckedChanged += new System.EventHandler(this.rdkhoaDL_CheckedChanged);
            // 
            // rdkhoa_CNTT
            // 
            this.rdkhoa_CNTT.AutoSize = true;
            this.rdkhoa_CNTT.Location = new System.Drawing.Point(14, 57);
            this.rdkhoa_CNTT.Name = "rdkhoa_CNTT";
            this.rdkhoa_CNTT.Size = new System.Drawing.Size(67, 24);
            this.rdkhoa_CNTT.TabIndex = 0;
            this.rdkhoa_CNTT.TabStop = true;
            this.rdkhoa_CNTT.Text = "CNTT";
            this.rdkhoa_CNTT.UseVisualStyleBackColor = true;
            this.rdkhoa_CNTT.CheckedChanged += new System.EventHandler(this.rdkhoa_CNTT_CheckedChanged);
            // 
            // frmsinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1255, 692);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grsinhvien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmsinhvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmsinhvien_FormClosed);
            this.Load += new System.EventHandler(this.frmsinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grsinhvien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grsinhvien;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txt_dia_chi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmalop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtp_ngay_thang_nam_sinh;
        private System.Windows.Forms.ComboBox cmb_gioi_tinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdkhoa_KINHTE;
        private System.Windows.Forms.RadioButton rdkhoaCN_OTO;
        private System.Windows.Forms.RadioButton rdkhoaDL;
        private System.Windows.Forms.RadioButton rdkhoa_CNTT;
        private System.Windows.Forms.RadioButton rdkhoa_NGONNGU;
        private System.Windows.Forms.RadioButton rd_toantruong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}