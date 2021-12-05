
namespace Project_SV
{
    partial class frmkhoa
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
            this.grkhoa = new System.Windows.Forms.DataGridView();
            this.ma_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grkhoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grkhoa
            // 
            this.grkhoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grkhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_khoa,
            this.ten_khoa});
            this.grkhoa.Location = new System.Drawing.Point(18, 18);
            this.grkhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grkhoa.Name = "grkhoa";
            this.grkhoa.ReadOnly = true;
            this.grkhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grkhoa.Size = new System.Drawing.Size(395, 445);
            this.grkhoa.TabIndex = 0;
            this.grkhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grkhoa_CellClick);
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
            // btnthem
            // 
            this.btnthem.Image = global::Project_SV.Properties.Resources.thêm1;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(6, 25);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(134, 50);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::Project_SV.Properties.Resources.sửa1;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(7, 83);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(134, 50);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::Project_SV.Properties.Resources.Trash_Full;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(7, 141);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(134, 50);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(7, 201);
            this.btnfrmmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(134, 50);
            this.btnfrmmain.TabIndex = 4;
            this.btnfrmmain.Text = "Form main";
            this.btnfrmmain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmmain.UseVisualStyleBackColor = true;
            this.btnfrmmain.Click += new System.EventHandler(this.btnchuyenform_Click);
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(87, 25);
            this.txtmakhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(148, 26);
            this.txtmakhoa.TabIndex = 5;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(87, 58);
            this.txttenkhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(148, 26);
            this.txttenkhoa.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Khoa";
            // 
            // btnghi
            // 
            this.btnghi.BackColor = System.Drawing.SystemColors.Control;
            this.btnghi.Image = global::Project_SV.Properties.Resources.thêm2;
            this.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnghi.Location = new System.Drawing.Point(6, 25);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(134, 50);
            this.btnghi.TabIndex = 8;
            this.btnghi.Text = "Ghi";
            this.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(6, 83);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(134, 50);
            this.btnkhongghi.TabIndex = 8;
            this.btnkhongghi.Text = "Không ghi";
            this.btnkhongghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhongghi.UseVisualStyleBackColor = true;
            this.btnkhongghi.Click += new System.EventHandler(this.btnkhongghi_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(11, 25);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(224, 26);
            this.txttimkiem.TabIndex = 10;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Location = new System.Drawing.Point(420, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 268);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmakhoa);
            this.groupBox2.Controls.Add(this.txttenkhoa);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(420, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 101);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập liệu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Location = new System.Drawing.Point(420, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 64);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // frmkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(701, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grkhoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmkhoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khoa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmkhoa_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grkhoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grkhoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_khoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

