
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
            this.components = new System.ComponentModel.Container();
            this.grlop = new System.Windows.Forms.DataGridView();
            this.malopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoahocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.mactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet1 = new Project_SV.QLSVDataSet1();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.lopTableAdapter = new Project_SV.QLSVDataSet1TableAdapters.lopTableAdapter();
            this.txtstt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmakhoahoc = new System.Windows.Forms.ComboBox();
            this.cmbmachuongtrinh = new System.Windows.Forms.ComboBox();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtenkhoa = new System.Windows.Forms.ComboBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.gbtt = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).BeginInit();
            this.gbtt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grlop
            // 
            this.grlop.AutoGenerateColumns = false;
            this.grlop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malopDataGridViewTextBoxColumn,
            this.makhoahocDataGridViewTextBoxColumn,
            this.makhoaDataGridViewTextBoxColumn,
            this.mactDataGridViewTextBoxColumn,
            this.sTTDataGridViewTextBoxColumn});
            this.grlop.DataSource = this.lopBindingSource;
            this.grlop.Location = new System.Drawing.Point(20, 20);
            this.grlop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grlop.Name = "grlop";
            this.grlop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grlop.Size = new System.Drawing.Size(707, 379);
            this.grlop.TabIndex = 0;
            this.grlop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grlop_CellClick);
            // 
            // malopDataGridViewTextBoxColumn
            // 
            this.malopDataGridViewTextBoxColumn.DataPropertyName = "ma_lop";
            this.malopDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.malopDataGridViewTextBoxColumn.Name = "malopDataGridViewTextBoxColumn";
            // 
            // makhoahocDataGridViewTextBoxColumn
            // 
            this.makhoahocDataGridViewTextBoxColumn.DataPropertyName = "ma_khoa_hoc";
            this.makhoahocDataGridViewTextBoxColumn.HeaderText = "Mã Khóa Học";
            this.makhoahocDataGridViewTextBoxColumn.Name = "makhoahocDataGridViewTextBoxColumn";
            this.makhoahocDataGridViewTextBoxColumn.Width = 150;
            // 
            // makhoaDataGridViewTextBoxColumn
            // 
            this.makhoaDataGridViewTextBoxColumn.DataPropertyName = "ma_khoa";
            this.makhoaDataGridViewTextBoxColumn.HeaderText = "Tên khoa";
            this.makhoaDataGridViewTextBoxColumn.Name = "makhoaDataGridViewTextBoxColumn";
            this.makhoaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.makhoaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.makhoaDataGridViewTextBoxColumn.Width = 120;
            // 
            // mactDataGridViewTextBoxColumn
            // 
            this.mactDataGridViewTextBoxColumn.DataPropertyName = "ma_ct";
            this.mactDataGridViewTextBoxColumn.HeaderText = "Mã Chương Trình";
            this.mactDataGridViewTextBoxColumn.Name = "mactDataGridViewTextBoxColumn";
            this.mactDataGridViewTextBoxColumn.Width = 190;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "Số thứ tự";
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "lop";
            this.lopBindingSource.DataSource = this.qLSVDataSet1;
            // 
            // qLSVDataSet1
            // 
            this.qLSVDataSet1.DataSetName = "QLSVDataSet1";
            this.qLSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // txtstt
            // 
            this.txtstt.Location = new System.Drawing.Point(400, 61);
            this.txtstt.Name = "txtstt";
            this.txtstt.Size = new System.Drawing.Size(117, 26);
            this.txtstt.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã Khóa Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mã Chương Trình";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số thứ tự";
            // 
            // cmbmakhoahoc
            // 
            this.cmbmakhoahoc.FormattingEnabled = true;
            this.cmbmakhoahoc.Location = new System.Drawing.Point(400, 24);
            this.cmbmakhoahoc.Name = "cmbmakhoahoc";
            this.cmbmakhoahoc.Size = new System.Drawing.Size(118, 28);
            this.cmbmakhoahoc.TabIndex = 23;
            // 
            // cmbmachuongtrinh
            // 
            this.cmbmachuongtrinh.FormattingEnabled = true;
            this.cmbmachuongtrinh.Location = new System.Drawing.Point(164, 64);
            this.cmbmachuongtrinh.Name = "cmbmachuongtrinh";
            this.cmbmachuongtrinh.Size = new System.Drawing.Size(121, 28);
            this.cmbmachuongtrinh.TabIndex = 25;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(166, 27);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(118, 26);
            this.txtmalop.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nhập Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên khoa";
            // 
            // cmbtenkhoa
            // 
            this.cmbtenkhoa.FormattingEnabled = true;
            this.cmbtenkhoa.Location = new System.Drawing.Point(620, 22);
            this.cmbtenkhoa.Name = "cmbtenkhoa";
            this.cmbtenkhoa.Size = new System.Drawing.Size(118, 28);
            this.cmbtenkhoa.TabIndex = 22;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(7, 25);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(278, 26);
            this.txttimkiem.TabIndex = 28;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // gbtt
            // 
            this.gbtt.Controls.Add(this.label6);
            this.gbtt.Controls.Add(this.label5);
            this.gbtt.Controls.Add(this.txtstt);
            this.gbtt.Controls.Add(this.label1);
            this.gbtt.Controls.Add(this.txtmalop);
            this.gbtt.Controls.Add(this.label2);
            this.gbtt.Controls.Add(this.cmbmachuongtrinh);
            this.gbtt.Controls.Add(this.label4);
            this.gbtt.Controls.Add(this.cmbmakhoahoc);
            this.gbtt.Controls.Add(this.cmbtenkhoa);
            this.gbtt.Location = new System.Drawing.Point(20, 407);
            this.gbtt.Name = "gbtt";
            this.gbtt.Size = new System.Drawing.Size(858, 110);
            this.gbtt.TabIndex = 29;
            this.gbtt.TabStop = false;
            this.gbtt.Text = "Phần nhập Thông tin";
            this.gbtt.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Location = new System.Drawing.Point(734, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 379);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Location = new System.Drawing.Point(20, 523);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 68);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // frmlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(918, 607);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).EndInit();
            this.gbtt.ResumeLayout(false);
            this.gbtt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private QLSVDataSet1 qLSVDataSet1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLSVDataSet1TableAdapters.lopTableAdapter lopTableAdapter;
        private System.Windows.Forms.TextBox txtstt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmakhoahoc;
        private System.Windows.Forms.ComboBox cmbmachuongtrinh;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbtenkhoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox gbtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn malopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoahocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn makhoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}