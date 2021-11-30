
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
            this.components = new System.ComponentModel.Container();
            this.grkhoahoc = new System.Windows.Forms.DataGridView();
            this.makhoahocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nambatdauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namketthucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet1 = new Project_SV.QLSVDataSet1();
            this.khoahocTableAdapter = new Project_SV.QLSVDataSet1TableAdapters.khoahocTableAdapter();
            this.btnkhongghi = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.txtmakhoahoc = new System.Windows.Forms.TextBox();
            this.txtnambatdau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnamketthuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnfrmmain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grkhoahoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoahocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grkhoahoc
            // 
            this.grkhoahoc.AutoGenerateColumns = false;
            this.grkhoahoc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grkhoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grkhoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoahocDataGridViewTextBoxColumn,
            this.nambatdauDataGridViewTextBoxColumn,
            this.namketthucDataGridViewTextBoxColumn});
            this.grkhoahoc.DataSource = this.khoahocBindingSource;
            this.grkhoahoc.Location = new System.Drawing.Point(20, 20);
            this.grkhoahoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grkhoahoc.Name = "grkhoahoc";
            this.grkhoahoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grkhoahoc.Size = new System.Drawing.Size(475, 518);
            this.grkhoahoc.TabIndex = 0;
            this.grkhoahoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grkhoahoc_CellClick);
            // 
            // makhoahocDataGridViewTextBoxColumn
            // 
            this.makhoahocDataGridViewTextBoxColumn.DataPropertyName = "ma_khoa_hoc";
            this.makhoahocDataGridViewTextBoxColumn.HeaderText = "Mã khóa học";
            this.makhoahocDataGridViewTextBoxColumn.Name = "makhoahocDataGridViewTextBoxColumn";
            this.makhoahocDataGridViewTextBoxColumn.Width = 130;
            // 
            // nambatdauDataGridViewTextBoxColumn
            // 
            this.nambatdauDataGridViewTextBoxColumn.DataPropertyName = "nam_bat_dau";
            this.nambatdauDataGridViewTextBoxColumn.HeaderText = "Năm bắt đầu khóa";
            this.nambatdauDataGridViewTextBoxColumn.Name = "nambatdauDataGridViewTextBoxColumn";
            this.nambatdauDataGridViewTextBoxColumn.Width = 150;
            // 
            // namketthucDataGridViewTextBoxColumn
            // 
            this.namketthucDataGridViewTextBoxColumn.DataPropertyName = "nam_ket_thuc";
            this.namketthucDataGridViewTextBoxColumn.HeaderText = "Năm kết thúc khóa";
            this.namketthucDataGridViewTextBoxColumn.Name = "namketthucDataGridViewTextBoxColumn";
            this.namketthucDataGridViewTextBoxColumn.Width = 150;
            // 
            // khoahocBindingSource
            // 
            this.khoahocBindingSource.DataMember = "khoahoc";
            this.khoahocBindingSource.DataSource = this.qLSVDataSet1;
            // 
            // qLSVDataSet1
            // 
            this.qLSVDataSet1.DataSetName = "QLSVDataSet1";
            this.qLSVDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // khoahocTableAdapter
            // 
            this.khoahocTableAdapter.ClearBeforeFill = true;
            // 
            // btnkhongghi
            // 
            this.btnkhongghi.Image = global::Project_SV.Properties.Resources.koghi;
            this.btnkhongghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhongghi.Location = new System.Drawing.Point(10, 94);
            this.btnkhongghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkhongghi.Name = "btnkhongghi";
            this.btnkhongghi.Size = new System.Drawing.Size(168, 54);
            this.btnkhongghi.TabIndex = 12;
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
            this.btnghi.Location = new System.Drawing.Point(10, 27);
            this.btnghi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(168, 54);
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
            this.btnxoa.Location = new System.Drawing.Point(10, 161);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(168, 54);
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
            this.btnsua.Location = new System.Drawing.Point(10, 94);
            this.btnsua.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(168, 54);
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
            this.btnthem.Location = new System.Drawing.Point(10, 27);
            this.btnthem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(168, 54);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
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
            // txtmakhoahoc
            // 
            this.txtmakhoahoc.Location = new System.Drawing.Point(114, 24);
            this.txtmakhoahoc.Name = "txtmakhoahoc";
            this.txtmakhoahoc.Size = new System.Drawing.Size(187, 26);
            this.txtmakhoahoc.TabIndex = 16;
            // 
            // txtnambatdau
            // 
            this.txtnambatdau.Location = new System.Drawing.Point(152, 59);
            this.txtnambatdau.Name = "txtnambatdau";
            this.txtnambatdau.Size = new System.Drawing.Size(149, 26);
            this.txtnambatdau.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã Khóa học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Năm bắt đầu khóa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnamketthuc
            // 
            this.txtnamketthuc.Location = new System.Drawing.Point(152, 91);
            this.txtnamketthuc.Name = "txtnamketthuc";
            this.txtnamketthuc.Size = new System.Drawing.Size(149, 26);
            this.txtnamketthuc.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Năm kết thúc khóa";
            // 
            // btnfrmmain
            // 
            this.btnfrmmain.Image = global::Project_SV.Properties.Resources.out2;
            this.btnfrmmain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfrmmain.Location = new System.Drawing.Point(10, 226);
            this.btnfrmmain.Name = "btnfrmmain";
            this.btnfrmmain.Size = new System.Drawing.Size(168, 54);
            this.btnfrmmain.TabIndex = 18;
            this.btnfrmmain.Text = "Form main";
            this.btnfrmmain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfrmmain.UseVisualStyleBackColor = true;
            this.btnfrmmain.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnfrmmain);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnkhongghi);
            this.groupBox1.Location = new System.Drawing.Point(507, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 300);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtmakhoahoc);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtnambatdau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtnamketthuc);
            this.groupBox2.Location = new System.Drawing.Point(507, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 138);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Location = new System.Drawing.Point(507, 164);
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
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.khoahocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grkhoahoc;
        private QLSVDataSet1 qLSVDataSet1;
        private QLSVDataSet1TableAdapters.khoahocTableAdapter khoahocTableAdapter;
        private System.Windows.Forms.Button btnkhongghi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.TextBox txtmakhoahoc;
        private System.Windows.Forms.TextBox txtnambatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnamketthuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoahocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nambatdauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namketthucDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource khoahocBindingSource;
        private System.Windows.Forms.Button btnfrmmain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}