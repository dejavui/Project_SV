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
            string sql1 = "select * from sinhvien where ma_sv = '"+message+"'";
            kn.taobang(sql1);
            grttsinhvien.DataSource = kn.taobang(sql1);

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
