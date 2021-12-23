
namespace Project_SV
{
    partial class frmkhoahoc
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
            this.grkhoahoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttenkhoahoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grkhoahoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grkhoahoc
            // 
            this.grkhoahoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grkhoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grkhoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.grkhoahoc.Location = new System.Drawing.Point(20, 20);
            this.grkhoahoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grkhoahoc.Name = "grkhoahoc";
            this.grkhoahoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grkhoahoc.Size = new System.Drawing.Size(475, 518);
            this.grkhoahoc.TabIndex = 0;
            this.grkhoahoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grkhoahoc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ma_khoa_hoc";
            this.Column1.HeaderText = "Mã Khóa học";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ten_khoa_hoc";
            this.Column2.HeaderText = "Tên khóa học";
            this.Column2.Name = "Column2";
            this.Column2.Width = 230;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(10, 27);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(220, 26);
            this.txttimkiem.TabIndex = 14;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Location = new System.Drawing.Point(507, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 295);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(10, 27);
            this.btnghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(138, 54);
            this.btnghi.TabIndex = 13;
            this.btnghi.Text = "Ghi";
            this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(10, 226);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(138, 54);
            this.btnfrmmain.TabIndex = 18;
            this.btnfrmmain.Text = "Form main";
            this.btnfrmmain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmmain.UseVisualStyleBackColor = true;
            this.btnfrmmain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(10, 27);
            this.btnthem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 54);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Project_SV.Properties.Resources.sửa1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(10, 94);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(138, 54);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(10, 161);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(138, 54);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(10, 94);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(138, 54);
            this.btnkhongghi.TabIndex = 12;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttenkhoahoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(507, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 67);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập";
            // 
            // txttenkhoahoc
            // 
            this.txttenkhoahoc.Location = new System.Drawing.Point(114, 27);
            this.txttenkhoahoc.Name = "txttenkhoahoc";
            this.txttenkhoahoc.Size = new System.Drawing.Size(187, 26);
            this.txttenkhoahoc.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên khóa học";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Location = new System.Drawing.Point(507, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 68);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // frmkhoahoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(895, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grkhoahoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmkhoahoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khóa học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmkhoahoc_FormClosed);
            this.Load += new System.EventHandler(this.frmkhoahoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grkhoahoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grkhoahoc;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txttenkhoahoc;
        private System.Windows.Forms.Label label2;
    }
}