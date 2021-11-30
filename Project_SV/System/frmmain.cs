using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Project_SV
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        string UID = frmlogin.ID_USERS_admin;
        List<string> listper = null;
        frmmain main;
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
        private void btnkhoa_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmkhoa();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnkhoahoc_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmkhoahoc();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnchuongtrinh_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmchuongtrinh();
            this.Hide();
            frm.ShowDialog();
        }


        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmsinhvien();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnlop_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmlop();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnkq_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmketqua();
            this.Hide();
            frm.ShowDialog();
        }


        private void btnmonhoc_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmmonhoc();
            this.Hide();
            frm.ShowDialog();
        }

        private void btngiangkhoa_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmgiangkhoa();
            this.Hide();
            frm.ShowDialog();
        }

        private void Frmmain_Load(object sender, EventArgs e)
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

        private void btn_tao_tai_khoan_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frm_tao_tai_khoan();
            this.Hide();
            frm.ShowDialog();
        }

        private void btn_doi_mk_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frm_doi_mk();
            this.Hide();
            frm.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMon_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmmonhoc();
            this.Hide();
            frm.ShowDialog();
        }

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmkhoa();
            this.Hide();
            frm.ShowDialog();
        }

        private void mnuLop_Click(object sender, EventArgs e)
        {
            kn.myconn();
            Form frm = new frmlop();
            this.Hide();
            frm.ShowDialog();
        }

        private void frmmain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmlogin();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
