
namespace Project_SV
{
    partial class frm_thong_tin
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
            this.grttsinhvien = new System.Windows.Forms.DataGridView();
            this.ma_sv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ho_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioi_tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay_thang_nam_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grttsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // grttsinhvien
            // 
            this.grttsinhvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grttsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grttsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sv,
            this.ho_ten,
            this.gioi_tinh,
            this.ngay_thang_nam_sinh,
            this.dia_chi,
            this.ma_lop});
            this.grttsinhvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grttsinhvien.Location = new System.Drawing.Point(0, 0);
            this.grttsinhvien.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.grttsinhvien.Name = "grttsinhvien";
            this.grttsinhvien.RowTemplate.ReadOnly = true;
            this.grttsinhvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grttsinhvien.Size = new System.Drawing.Size(1091, 605);
            this.grttsinhvien.TabIndex = 1;
            // 
            // ma_sv
            // 
            this.ma_sv.DataPropertyName = "ma_sv";
            this.ma_sv.HeaderText = "Mã SV";
            this.ma_sv.Name = "ma_sv";
            // 
            // ho_ten
            // 
            this.ho_ten.DataPropertyName = "ho_ten";
            this.ho_ten.HeaderText = "Họ và tên";
            this.ho_ten.Name = "ho_ten";
            this.ho_ten.Width = 200;
            // 
            // gioi_tinh
            // 
            this.gioi_tinh.DataPropertyName = "gioi_tinh";
            this.gioi_tinh.HeaderText = "Giới tính";
            this.gioi_tinh.Name = "gioi_tinh";
            this.gioi_tinh.Width = 150;
            // 
            // ngay_thang_nam_sinh
            // 
            this.ngay_thang_nam_sinh.DataPropertyName = "ngay_thang_nam_sinh";
            this.ngay_thang_nam_sinh.HeaderText = "Ngày tháng năm sinh";
            this.ngay_thang_nam_sinh.Name = "ngay_thang_nam_sinh";
            this.ngay_thang_nam_sinh.Width = 250;
            // 
            // dia_chi
            // 
            this.dia_chi.DataPropertyName = "dia_chi";
            this.dia_chi.HeaderText = "Địa chỉ";
            this.dia_chi.Name = "dia_chi";
            this.dia_chi.Width = 200;
            // 
            // ma_lop
            // 
            this.ma_lop.DataPropertyName = "ma_lop";
            this.ma_lop.HeaderText = "Tên lớp";
            this.ma_lop.Name = "ma_lop";
            this.ma_lop.Width = 145;
            // 
            // frm_thong_tin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 605);
            this.Controls.Add(this.grttsinhvien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_thong_tin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_thong_tin_FormClosed);
            this.Load += new System.EventHandler(this.frm_thong_tin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grttsinhvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grttsinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ho_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioi_tinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay_thang_nam_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_lop;
    }
}