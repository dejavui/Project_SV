
namespace Project_SV
{
    partial class frmlop
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
            this.grlop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbmakhoahoc = new System.Windows.Forms.ComboBox();
            this.cmbtenchuongtrinh = new System.Windows.Forms.ComboBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtenkhoa = new System.Windows.Forms.ComboBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.gbtt = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grlop)).BeginInit();
            this.gbtt.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlop
            // 
            this.grlop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grlop.Location = new System.Drawing.Point(20, 20);
            this.grlop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grlop.Name = "grlop";
            this.grlop.ReadOnly = true;
            this.grlop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grlop.Size = new System.Drawing.Size(823, 379);
            this.grlop.TabIndex = 0;
            this.grlop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grlop_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_lop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten_lop";
            this.Column2.HeaderText = "Tên lớp";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ten_khoa";
            this.Column3.HeaderText = "Tên khoa";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ten_khoa_hoc";
            this.Column4.HeaderText = "Tên khóa học";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ten_ct";
            this.Column5.HeaderText = "Tên CT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "STT";
            this.Column6.HeaderText = "STT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(9, 105);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(127, 54);
            this.btnkhongghi.TabIndex = 17;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(9, 35);
            this.btnghi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(127, 54);
            this.btnghi.TabIndex = 18;
            this.btnghi.Text = "Ghi";
            this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
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
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
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
            this.btnfrmmain.Click += new System.EventHandler(this.btnfrmmain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Khóa Học";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên chương trình";
            // 
            // cmbmakhoahoc
            // 
            this.cmbmakhoahoc.FormattingEnabled = true;
            this.cmbmakhoahoc.Location = new System.Drawing.Point(669, 25);
            this.cmbmakhoahoc.Name = "cmbmakhoahoc";
            this.cmbmakhoahoc.Size = new System.Drawing.Size(141, 28);
            this.cmbmakhoahoc.TabIndex = 23;
            // 
            // cmbtenchuongtrinh
            // 
            this.cmbtenchuongtrinh.FormattingEnabled = true;
            this.cmbtenchuongtrinh.Location = new System.Drawing.Point(164, 64);
            this.cmbtenchuongtrinh.Name = "cmbtenchuongtrinh";
            this.cmbtenchuongtrinh.Size = new System.Drawing.Size(141, 28);
            this.cmbtenchuongtrinh.TabIndex = 25;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(166, 27);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(141, 26);
            this.txttenlop.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhập tên lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên khoa";
            // 
            // cmbtenkhoa
            // 
            this.cmbtenkhoa.FormattingEnabled = true;
            this.cmbtenkhoa.Location = new System.Drawing.Point(400, 25);
            this.cmbtenkhoa.Name = "cmbtenkhoa";
            this.cmbtenkhoa.Size = new System.Drawing.Size(141, 28);
            this.cmbtenkhoa.TabIndex = 22;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 23);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(183, 26);
            this.txttimkiem.TabIndex = 28;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // gbtt
            // 
            this.gbtt.Controls.Add(this.groupBox2);
            this.gbtt.Controls.Add(this.label6);
            this.gbtt.Controls.Add(this.label1);
            this.gbtt.Controls.Add(this.txttenlop);
            this.gbtt.Controls.Add(this.label2);
            this.gbtt.Controls.Add(this.cmbtenchuongtrinh);
            this.gbtt.Controls.Add(this.label4);
            this.gbtt.Controls.Add(this.cmbmakhoahoc);
            this.gbtt.Controls.Add(this.cmbtenkhoa);
            this.gbtt.Location = new System.Drawing.Point(20, 407);
            this.gbtt.Name = "gbtt";
            this.gbtt.Size = new System.Drawing.Size(823, 135);
            this.gbtt.TabIndex = 29;
            this.gbtt.TabStop = false;
            this.gbtt.Text = "Phần nhập Thông tin";
            this.gbtt.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Location = new System.Drawing.Point(323, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 55);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Location = new System.Drawing.Point(850, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 379);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // frmlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1129, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbtt);
            this.Controls.Add(this.grlop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmlop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmlop_FormClosed);
            this.Load += new System.EventHandler(this.frmlop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlop)).EndInit();
            this.gbtt.ResumeLayout(false);
            this.gbtt.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grlop;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbmakhoahoc;
        private System.Windows.Forms.ComboBox cmbtenchuongtrinh;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtenkhoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox gbtt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}