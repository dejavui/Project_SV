
namespace Project_SV
{
    partial class frm_thu_ky
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuItemHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdmonhoc = new System.Windows.Forms.RadioButton();
            this.rdkhoahoc = new System.Windows.Forms.RadioButton();
            this.rdchuongtrinh = new System.Windows.Forms.RadioButton();
            this.rdkhoa = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grkhoahoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grmonhoc = new System.Windows.Forms.DataGridView();
            this.ma_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grkhoa = new System.Windows.Forms.DataGridView();
            this.ma_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grchuongtrinh = new System.Windows.Forms.DataGridView();
            this.ma_ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grkhoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grmonhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grkhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grchuongtrinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHethong});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuItemHethong
            // 
            this.mnuItemHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.mnuDN,
            this.mnuDoiMK,
            this.mnuDX,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.mnuExit});
            this.mnuItemHethong.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuItemHethong.Name = "mnuItemHethong";
            this.mnuItemHethong.Size = new System.Drawing.Size(69, 20);
            this.mnuItemHethong.Text = "&Hệ thống";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuDN
            // 
            this.mnuDN.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(145, 22);
            this.mnuDN.Text = "Đăng nhập";
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(145, 22);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            // 
            // mnuDX
            // 
            this.mnuDX.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuDX.Name = "mnuDX";
            this.mnuDX.Size = new System.Drawing.Size(145, 22);
            this.mnuDX.Text = "Đăng xuất";
            this.mnuDX.Click += new System.EventHandler(this.mnuDX_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(142, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(142, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(145, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdmonhoc);
            this.groupBox2.Controls.Add(this.rdkhoahoc);
            this.groupBox2.Controls.Add(this.rdchuongtrinh);
            this.groupBox2.Controls.Add(this.rdkhoa);
            this.groupBox2.Location = new System.Drawing.Point(536, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 329);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý";
            // 
            // rdmonhoc
            // 
            this.rdmonhoc.AutoSize = true;
            this.rdmonhoc.Location = new System.Drawing.Point(6, 115);
            this.rdmonhoc.Name = "rdmonhoc";
            this.rdmonhoc.Size = new System.Drawing.Size(88, 24);
            this.rdmonhoc.TabIndex = 0;
            this.rdmonhoc.Text = "Môn học";
            this.rdmonhoc.UseVisualStyleBackColor = true;
            this.rdmonhoc.CheckedChanged += new System.EventHandler(this.rdmonhoc_CheckedChanged);
            // 
            // rdkhoahoc
            // 
            this.rdkhoahoc.AutoSize = true;
            this.rdkhoahoc.Location = new System.Drawing.Point(6, 85);
            this.rdkhoahoc.Name = "rdkhoahoc";
            this.rdkhoahoc.Size = new System.Drawing.Size(94, 24);
            this.rdkhoahoc.TabIndex = 0;
            this.rdkhoahoc.Text = "Khóa học";
            this.rdkhoahoc.UseVisualStyleBackColor = true;
            this.rdkhoahoc.CheckedChanged += new System.EventHandler(this.rdkhoahoc_CheckedChanged);
            // 
            // rdchuongtrinh
            // 
            this.rdchuongtrinh.AutoSize = true;
            this.rdchuongtrinh.Location = new System.Drawing.Point(6, 55);
            this.rdchuongtrinh.Name = "rdchuongtrinh";
            this.rdchuongtrinh.Size = new System.Drawing.Size(118, 24);
            this.rdchuongtrinh.TabIndex = 0;
            this.rdchuongtrinh.Text = "Chương trình";
            this.rdchuongtrinh.UseVisualStyleBackColor = true;
            this.rdchuongtrinh.CheckedChanged += new System.EventHandler(this.rdchuongtrinh_CheckedChanged);
            // 
            // rdkhoa
            // 
            this.rdkhoa.AutoSize = true;
            this.rdkhoa.Location = new System.Drawing.Point(6, 25);
            this.rdkhoa.Name = "rdkhoa";
            this.rdkhoa.Size = new System.Drawing.Size(64, 24);
            this.rdkhoa.TabIndex = 0;
            this.rdkhoa.Text = "Khoa";
            this.rdkhoa.UseVisualStyleBackColor = true;
            this.rdkhoa.CheckedChanged += new System.EventHandler(this.rdkhoa_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grkhoahoc);
            this.groupBox3.Controls.Add(this.grmonhoc);
            this.groupBox3.Controls.Add(this.grkhoa);
            this.groupBox3.Controls.Add(this.grchuongtrinh);
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 524);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tổng hợp";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // grkhoahoc
            // 
            this.grkhoahoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grkhoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grkhoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grkhoahoc.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grkhoahoc.Location = new System.Drawing.Point(7, 26);
            this.grkhoahoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grkhoahoc.Name = "grkhoahoc";
            this.grkhoahoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grkhoahoc.Size = new System.Drawing.Size(496, 474);
            this.grkhoahoc.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_khoa_hoc";
            this.Column1.HeaderText = "Mã khóa học";
            this.Column1.Name = "Column1";
            this.Column1.Width = 130;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nam_bat_dau";
            this.Column2.HeaderText = "Năm bắt đầu";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nam_ket_thuc";
            this.Column3.HeaderText = "Năm kết thúc";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // grmonhoc
            // 
            this.grmonhoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_mh,
            this.ten_mh,
            this.dataGridViewTextBoxColumn1});
            this.grmonhoc.Location = new System.Drawing.Point(7, 26);
            this.grmonhoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grmonhoc.Name = "grmonhoc";
            this.grmonhoc.ReadOnly = true;
            this.grmonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grmonhoc.Size = new System.Drawing.Size(496, 474);
            this.grmonhoc.TabIndex = 1;
            // 
            // ma_mh
            // 
            this.ma_mh.DataPropertyName = "ma_mh";
            this.ma_mh.HeaderText = "Mã môn học";
            this.ma_mh.Name = "ma_mh";
            this.ma_mh.ReadOnly = true;
            this.ma_mh.Width = 130;
            // 
            // ten_mh
            // 
            this.ten_mh.DataPropertyName = "ten_mh";
            this.ten_mh.HeaderText = "Tên môn học";
            this.ten_mh.Name = "ten_mh";
            this.ten_mh.ReadOnly = true;
            this.ten_mh.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ten_khoa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên khoa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // grkhoa
            // 
            this.grkhoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_khoa,
            this.ten_khoa});
            this.grkhoa.Location = new System.Drawing.Point(7, 26);
            this.grkhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grkhoa.Name = "grkhoa";
            this.grkhoa.ReadOnly = true;
            this.grkhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grkhoa.Size = new System.Drawing.Size(395, 474);
            this.grkhoa.TabIndex = 1;
            // 
            // ma_khoa
            // 
            this.ma_khoa.DataPropertyName = "ma_khoa";
            this.ma_khoa.HeaderText = "Mã_khoa";
            this.ma_khoa.Name = "ma_khoa";
            this.ma_khoa.ReadOnly = true;
            this.ma_khoa.Width = 150;
            // 
            // ten_khoa
            // 
            this.ten_khoa.DataPropertyName = "ten_khoa";
            this.ten_khoa.HeaderText = "Tên Khoa";
            this.ten_khoa.Name = "ten_khoa";
            this.ten_khoa.ReadOnly = true;
            this.ten_khoa.Width = 200;
            // 
            // grchuongtrinh
            // 
            this.grchuongtrinh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grchuongtrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grchuongtrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_ct,
            this.ten_ct});
            this.grchuongtrinh.Location = new System.Drawing.Point(7, 26);
            this.grchuongtrinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grchuongtrinh.Name = "grchuongtrinh";
            this.grchuongtrinh.ReadOnly = true;
            this.grchuongtrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grchuongtrinh.Size = new System.Drawing.Size(395, 474);
            this.grchuongtrinh.TabIndex = 1;
            // 
            // ma_ct
            // 
            this.ma_ct.DataPropertyName = "ma_ct";
            this.ma_ct.HeaderText = "Mã chương trình";
            this.ma_ct.Name = "ma_ct";
            this.ma_ct.ReadOnly = true;
            this.ma_ct.Width = 150;
            // 
            // ten_ct
            // 
            this.ten_ct.DataPropertyName = "ten_ct";
            this.ten_ct.HeaderText = "Tên chương trình";
            this.ten_ct.Name = "ten_ct";
            this.ten_ct.ReadOnly = true;
            this.ten_ct.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Location = new System.Drawing.Point(676, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 329);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(151, 35);
            this.btnghi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(127, 54);
            this.btnghi.TabIndex = 18;
            this.btnghi.Text = "Ghi";
            this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(9, 35);
            this.btnthem.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 54);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(9, 250);
            this.btnfrmmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(127, 54);
            this.btnfrmmain.TabIndex = 19;
            this.btnfrmmain.Text = "Form main";
            this.btnfrmmain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmmain.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Project_SV.Properties.Resources.sửa1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(9, 105);
            this.btnsua.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 54);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(151, 105);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(127, 54);
            this.btnkhongghi.TabIndex = 17;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(9, 179);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(127, 54);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // frm_thu_ky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1024, 790);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_thu_ky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thư ký";
            this.Load += new System.EventHandler(this.frm_thu_ky_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grkhoahoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grmonhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grkhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grchuongtrinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHethong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
        public System.Windows.Forms.ToolStripMenuItem mnuDX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdmonhoc;
        private System.Windows.Forms.RadioButton rdkhoahoc;
        private System.Windows.Forms.RadioButton rdchuongtrinh;
        private System.Windows.Forms.RadioButton rdkhoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_khoa;
        private System.Windows.Forms.DataGridView grchuongtrinh;
        private System.Windows.Forms.DataGridView grkhoahoc;
        private System.Windows.Forms.DataGridView grmonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_ct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}