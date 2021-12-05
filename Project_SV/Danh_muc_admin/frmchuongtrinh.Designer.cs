
namespace Project_SV
{
    partial class frmchuongtrinh
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
            this.grchuongtrinh = new System.Windows.Forms.DataGridView();
            this.ma_ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_ct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtmact = new System.Windows.Forms.TextBox();
            this.txttenct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grchuongtrinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grchuongtrinh
            // 
            this.grchuongtrinh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grchuongtrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grchuongtrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_ct,
            this.ten_ct});
            this.grchuongtrinh.Location = new System.Drawing.Point(13, 14);
            this.grchuongtrinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grchuongtrinh.Name = "grchuongtrinh";
            this.grchuongtrinh.ReadOnly = true;
            this.grchuongtrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grchuongtrinh.Size = new System.Drawing.Size(375, 475);
            this.grchuongtrinh.TabIndex = 0;
            this.grchuongtrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grchuongtrinh_CellClick);
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
            this.ten_ct.Width = 180;
            // 
            // txtmact
            // 
            this.txtmact.Location = new System.Drawing.Point(135, 25);
            this.txtmact.Name = "txtmact";
            this.txtmact.Size = new System.Drawing.Size(154, 26);
            this.txtmact.TabIndex = 7;
            // 
            // txttenct
            // 
            this.txttenct.Location = new System.Drawing.Point(136, 63);
            this.txttenct.Name = "txttenct";
            this.txttenct.Size = new System.Drawing.Size(154, 26);
            this.txttenct.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên chương trình";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã chương trình";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(12, 24);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(282, 26);
            this.txttimkiem.TabIndex = 6;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Location = new System.Drawing.Point(395, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 304);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(7, 27);
            this.btnghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(153, 54);
            this.btnghi.TabIndex = 4;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(6, 234);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(153, 54);
            this.btnfrmmain.TabIndex = 9;
            this.btnfrmmain.Text = "Form Main";
            this.btnfrmmain.UseVisualStyleBackColor = true;
            this.btnfrmmain.Click += new System.EventHandler(this.btnfrmmain_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(7, 27);
            this.btnthem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(153, 54);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Project_SV.Properties.Resources.sửa1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(7, 99);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(153, 54);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(6, 169);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(153, 54);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(7, 99);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(153, 54);
            this.btnkhongghi.TabIndex = 5;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmact);
            this.groupBox2.Controls.Add(this.txttenct);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(395, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 101);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Location = new System.Drawing.Point(395, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 60);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // frmchuongtrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(711, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grchuongtrinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmchuongtrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương Trình";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmchuongtrinh_FormClosed);
            this.Load += new System.EventHandler(this.frmchuongtrinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grchuongtrinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grchuongtrinh;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtmact;
        private System.Windows.Forms.TextBox txttenct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_ct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_ct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}