
namespace Project_SV
{
    partial class frmmonhoc
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
            this.grmonhoc = new System.Windows.Forms.DataGridView();
            this.ma_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttenmonhoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbtenkhoa = new System.Windows.Forms.ComboBox();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchuthich = new System.Windows.Forms.TextBox();
            this.cmbtenchuongtrinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grmonhoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grmonhoc
            // 
            this.grmonhoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grmonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_mh,
            this.ten_mh,
            this.ten_khoa,
            this.Column2,
            this.Column3});
            this.grmonhoc.Location = new System.Drawing.Point(13, 14);
            this.grmonhoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grmonhoc.Name = "grmonhoc";
            this.grmonhoc.ReadOnly = true;
            this.grmonhoc.RowTemplate.Height = 30;
            this.grmonhoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grmonhoc.Size = new System.Drawing.Size(725, 532);
            this.grmonhoc.TabIndex = 0;
            this.grmonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grmonhoc_CellClick);
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
            this.ten_mh.Width = 150;
            // 
            // ten_khoa
            // 
            this.ten_khoa.DataPropertyName = "ten_khoa";
            this.ten_khoa.HeaderText = "Tên khoa";
            this.ten_khoa.Name = "ten_khoa";
            this.ten_khoa.ReadOnly = true;
            this.ten_khoa.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten_ct";
            this.Column2.HeaderText = "Tên chương trình";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "chu_thich";
            this.Column3.HeaderText = "Chú thích";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(149, 27);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(137, 54);
            this.btnkhongghi.TabIndex = 12;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhongghi.UseVisualStyleBackColor = false;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(7, 27);
            this.btnghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(137, 54);
            this.btnghi.TabIndex = 13;
            this.btnghi.Text = "Ghi";
            this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(7, 94);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(137, 54);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Project_SV.Properties.Resources.sửa1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(149, 27);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(137, 54);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(7, 27);
            this.btnthem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(137, 54);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttenmonhoc
            // 
            this.txttenmonhoc.Location = new System.Drawing.Point(144, 22);
            this.txttenmonhoc.Name = "txttenmonhoc";
            this.txttenmonhoc.Size = new System.Drawing.Size(168, 26);
            this.txttenmonhoc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên khoa";
            // 
            // cmbtenkhoa
            // 
            this.cmbtenkhoa.FormattingEnabled = true;
            this.cmbtenkhoa.Location = new System.Drawing.Point(144, 57);
            this.cmbtenkhoa.Name = "cmbtenkhoa";
            this.cmbtenkhoa.Size = new System.Drawing.Size(168, 28);
            this.cmbtenkhoa.TabIndex = 3;
            this.cmbtenkhoa.SelectedIndexChanged += new System.EventHandler(this.cmbtenkhoa_SelectedIndexChanged);
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(151, 94);
            this.btnfrmmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(137, 54);
            this.btnfrmmain.TabIndex = 20;
            this.btnfrmmain.Text = "Form main";
            this.btnfrmmain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmmain.UseVisualStyleBackColor = true;
            this.btnfrmmain.Click += new System.EventHandler(this.btnfrmmain_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(10, 25);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(275, 26);
            this.txttimkiem.TabIndex = 4;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Location = new System.Drawing.Point(763, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 172);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Location = new System.Drawing.Point(763, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 66);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtchuthich);
            this.groupBox3.Controls.Add(this.cmbtenchuongtrinh);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txttenmonhoc);
            this.groupBox3.Controls.Add(this.cmbtenkhoa);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(763, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 161);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chú thích";
            // 
            // txtchuthich
            // 
            this.txtchuthich.Location = new System.Drawing.Point(144, 127);
            this.txtchuthich.Name = "txtchuthich";
            this.txtchuthich.Size = new System.Drawing.Size(168, 26);
            this.txtchuthich.TabIndex = 20;
            // 
            // cmbtenchuongtrinh
            // 
            this.cmbtenchuongtrinh.FormattingEnabled = true;
            this.cmbtenchuongtrinh.Location = new System.Drawing.Point(144, 92);
            this.cmbtenchuongtrinh.Name = "cmbtenchuongtrinh";
            this.cmbtenchuongtrinh.Size = new System.Drawing.Size(168, 28);
            this.cmbtenchuongtrinh.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên chương trình";
            // 
            // frmmonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1114, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grmonhoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmmonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Môn học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmmonhoc_FormClosed);
            this.Load += new System.EventHandler(this.frmmonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grmonhoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grmonhoc;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttenmonhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbtenkhoa;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchuthich;
        private System.Windows.Forms.ComboBox cmbtenchuongtrinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}