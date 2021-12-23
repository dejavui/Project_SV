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
namespace Project_SV
{
    public partial class frm_thong_tin : Form
    {
        private string message;
        public frm_thong_tin()
        {
            InitializeComponent();
        }
        public frm_thong_tin(string MaSV): this()
        {
            message = MaSV;
        }
        ketnoidulieu kn = new ketnoidulieu();
        private void frm_thong_tin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = new frmmain_sinhvien(message);
            this.Hide();
            frm.ShowDialog();
        }
        private void loadgr()
        {
            string sql1 = "select sinhvien.ma_sv,ho_ten,gioi_tinh,ngay_thang_nam_sinh,dia_chi,lop.ten_lop,khoa.ten_khoa from sinhvien inner join lop on sinhvien.ma_lop = lop.ma_lop  inner join khoa on lop.ma_khoa = khoa.ma_khoa where ma_sv = '" + message+"'";
            kn.taobang(sql1);
            grsinhvien.DataSource = kn.taobang(sql1);

        }
        private void frm_thong_tin_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            loadgr();
        }
    }
}
