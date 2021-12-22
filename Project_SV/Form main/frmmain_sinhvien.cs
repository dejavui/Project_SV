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
    public partial class frmmain_sinhvien : Form
    {
        private string message;
        public frmmain_sinhvien()
        {
            InitializeComponent();
        }
        public frmmain_sinhvien(string Message) : this()
        {
            message = Message;
            //txtnhan.Text = message;
            lbnhan.Text = message;
        }
        ketnoidulieu kn = new ketnoidulieu();
        string UID = frmlogin.ID_USERS_sinhvien;
        List<string> listper = null;

        private void id_per()
        {
            string id = "";
            try
            {
                string sql1 = "select * from select * from logins where quyen ='" + UID + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql1, kn.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["quyen"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối truy vấn");
            }
            finally
            {
                kn.myclose();
            }
        }
        private void btnxemthongtin_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frm_thong_tin(lbnhan.Text);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnxemdiem_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frm_xem_diem(lbnhan.Text);
            this.Hide();
            frm.ShowDialog();
        }

        private void frmmain_member_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmlogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmmain_member_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmlogin();
            this.Hide();
            frm.Show();
        }
    }
}
