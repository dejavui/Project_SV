
namespace Project_SV
{
    partial class frm_xem_diem
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
            this.txtnhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grketqua = new System.Windows.Forms.DataGridView();
            this.ma_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_mh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lan_thi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nam_hoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxemdiem = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grketqua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnhap
            // 
            this.txtnhap.Location = new System.Drawing.Point(119, 144);
            this.txtnhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.ReadOnly = true;
            this.txtnhap.Size = new System.Drawing.Size(246, 26);
            this.txtnhap.TabIndex = 1;
            this.txtnhap.TextChanged += new System.EventHandler(this.txtnhap_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã sinh viên";
            // 
            // grketqua
            // 
            this.grketqua.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grketqua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sv,
            this.ho_ten,
            this.nam_sinh,
            this.gioi_tinh,
            this.ma_lop,
            this.ten_mh,
            this.lan_thi,
            this.diem,
            this.nam_hoc});
            this.grketqua.Location = new System.Drawing.Point(13, 4);
            this.grketqua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grketqua.Name = "grketqua";
            this.grketqua.ReadOnly = true;
            this.grketqua.RowTemplate.Height = 28;
            this.grketqua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grketqua.Size = new System.Drawing.Size(1100, 130);
            this.grketqua.TabIndex = 7;
            // 
            // ma_sv
            // 
            this.ma_sv.DataPropertyName = "ma_sv";
            this.ma_sv.HeaderText = "Mã sinh viên";
            this.ma_sv.Name = "ma_sv";
            this.ma_sv.ReadOnly = true;
            this.ma_sv.Width = 150;
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ tên sinh viên";
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.ReadOnly = true;
            this.ho_ten.Width = 150;
            // 
            // nam_sinh
            // 
            this.nam_sinh.DataPropertyName = "ngay_thang_nam_sinh";
            this.nam_sinh.HeaderText = "Năm sinh";
            this.nam_sinh.Name = "nam_sinh";
            this.nam_sinh.ReadOnly = true;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.ReadOnly = true;
            // 
            // ma_lop
            // 
            this.ma_lop.DataPropertyName = "ma_lop";
            this.ma_lop.HeaderText = "Mã lớp";
            this.ma_lop.Name = "ma_lop";
            this.ma_lop.ReadOnly = true;
            // 
            // ten_mh
            // 
            this.ten_mh.DataPropertyName = "ten_mh";
            this.ten_mh.HeaderText = "Tên môn học";
            this.ten_mh.Name = "ten_mh";
            this.ten_mh.ReadOnly = true;
            this.ten_mh.Width = 150;
            // 
            // lan_thi
            // 
            this.lan_thi.DataPropertyName = "lan_thi";
            this.lan_thi.HeaderText = "Lần thi";
            this.lan_thi.Name = "lan_thi";
            this.lan_thi.ReadOnly = true;
            // 
            // diem
            // 
            this.diem.DataPropertyName = "diem";
            this.diem.HeaderText = "Điểm thi";
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            // 
            // nam_hoc
            // 
            this.nam_hoc.DataPropertyName = "nam_hoc";
            this.nam_hoc.HeaderText = "Năm học";
            this.nam_hoc.Name = "nam_hoc";
            this.nam_hoc.ReadOnly = true;
            // 
            // btnxemdiem
            // 
            this.btnxemdiem.Image = global::Project_SV.Properties.Resources.colors;
            this.btnxemdiem.Location = new System.Drawing.Point(497, 144);
            this.btnxemdiem.Name = "btnxemdiem";
            this.btnxemdiem.Size = new System.Drawing.Size(121, 47);
            this.btnxemdiem.TabIndex = 8;
            this.btnxemdiem.Text = "Xem điểm";
            this.btnxemdiem.UseVisualStyleBackColor = true;
            this.btnxemdiem.Click += new System.EventHandler(this.btnxemdiem_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Image = global::Project_SV.Properties.Resources.out2;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(624, 144);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(160, 47);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Quay lại";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnbaocao
            // 
            this.btnbaocao.Image = global::Project_SV.Properties.Resources.print_50;
            this.btnbaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbaocao.Location = new System.Drawing.Point(791, 144);
            this.btnbaocao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(270, 47);
            this.btnbaocao.TabIndex = 11;
            this.btnbaocao.Text = "In Kết Quả Học Tập";
            this.btnbaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // frm_xem_diem
            // 
            this.AcceptButton = this.btnxemdiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnthoat;
            this.ClientSize = new System.Drawing.Size(1129, 232);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxemdiem);
            this.Controls.Add(this.grketqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_xem_diem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_xem_diem_FormClosed);
            this.Load += new System.EventHandler(this.frm_xem_diem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grketqua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grketqua;
        private System.Windows.Forms.Button btnxemdiem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnbaocao;
        public System.Windows.Forms.TextBox txtnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn lan_thi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nam_hoc;
    }
}