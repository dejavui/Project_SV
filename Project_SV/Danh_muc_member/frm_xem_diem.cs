using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Project_SV;
namespace Project_SV
{
    public partial class frm_xem_diem : Form
    {
        private string message;
        public frm_xem_diem()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        public frm_xem_diem(string Messege): this()
        {
            message = Messege;
            txtnhap.Text = message;
        }
        private void btnxemdiem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "ua inner join sinhvien on ketqua.ma_sv=sinhvien.ma_sv inner join monhoc on monhoc.ma_mh=ketqua.ma_mh inner join khung_chuong_trinh on khung_chuong_trinh.ma_mh=monhoc.ma_mh where ketqua.ma_sv= '" + txtnhap.Text.Trim() + "'";
                kn.taobang(sql1);
                grketqua.DataSource = kn.taobang(sql1);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy Mã sinh viên này!!!");
            }
        }

        private void frm_xem_diem_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
                try
                {
                    string sql1 = "select ketqua.ma_sv,sinhvien.ho_ten,ngay_thang_nam_sinh,gioi_tinh,ketqua.ma_lop,monhoc.ten_mh,ketqua.lan_thi,diem,khung_chuong_trinh.nam_hoc from ketqua inner join sinhvien on ketqua.ma_sv=sinhvien.ma_sv inner join monhoc on monhoc.ma_mh=ketqua.ma_mh inner join khung_chuong_trinh on khung_chuong_trinh.ma_mh=monhoc.ma_mh where ketqua.ma_sv= '" + txtnhap.Text.Trim() + "'";
                    kn.taobang(sql1);
                    grketqua.DataSource = kn.taobang(sql1);
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy Mã sinh viên này!!!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }


        private void frm_xem_diem_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain_sinhvien(txtnhap.Text);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain_sinhvien(txtnhap.Text);
            this.Hide();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            Form frm = new frmReportKetQua(txtnhap.Text);
            this.Hide();
            frm.ShowDialog();
        }

        private void txtnhap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
