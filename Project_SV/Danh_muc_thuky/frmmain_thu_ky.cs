using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_SV
{
    public partial class frm_thu_ky : Form
    {
        public frm_thu_ky()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void mnuExit_Click(object sender, EventArgs e)
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
        private void hide_gr()
        {
            grchuongtrinh.Visible = false;
            grkhoa.Visible = false;
            grkhoahoc.Visible = false;
            grmonhoc.Visible = false;
            
        }
        private void lockcontrol()
        {
            btnthem.Visible = true;
            btnsua.Visible = true;
            btnxoa.Visible = true;
            //
            //btntrove.Visible = false;
            btnghi.Visible = false;
            btnkhongghi.Visible = false;
        }
        private void unlockcontrol()
        {
            btnthem.Visible = false;
            btnsua.Visible = false;
            btnxoa.Visible = false;
            //
            //btntrove.Visible = true;
            btnghi.Visible = true;
            btnkhongghi.Visible = true;
            //
        }
        private void frm_thu_ky_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            hide_gr();
            lockcontrol();
            rdkhoa.Checked = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void loadgr_khoa()
        {
            string sql = "select * from khoa";
            grkhoa.DataSource = kn.taobang(sql);
        }
        private void rdkhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoa.Checked == true)
            {
                string sql = "select * from khoa";
                grkhoa.DataSource = kn.taobang(sql);
                grkhoa.Visible = true;
                grchuongtrinh.Visible = false;
                grkhoahoc.Visible = false;
                grmonhoc.Visible = false;
            }
        }

        private void rdchuongtrinh_CheckedChanged(object sender, EventArgs e)
        {
            if (rdchuongtrinh.Checked==true)
            {
                string sql = "select * from chuongtrinh";
                grchuongtrinh.DataSource = kn.taobang(sql);
                grchuongtrinh.Visible = true;
                grkhoa.Visible = false;
                grkhoahoc.Visible = false;
                grmonhoc.Visible = false;
            }
        }

        private void rdkhoahoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoahoc.Checked==true)
            {
            string sql = "select * from khoahoc";
            grkhoahoc.DataSource = kn.taobang(sql);
            grkhoahoc.Visible = true;
            grchuongtrinh.Visible = false;
            grkhoa.Visible = false;
            grmonhoc.Visible = false;

            }
        }

        private void rdmonhoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdmonhoc.Checked==true)
            {
                string sql = "select monhoc.ma_mh,monhoc.ten_mh,khoa.ten_khoa from monhoc inner join khoa on monhoc.ma_khoa = khoa.ma_khoa";
                kn.taobang(sql);
                grmonhoc.DataSource = kn.taobang(sql);
                grmonhoc.Visible = true;
                grkhoahoc.Visible = false;
                grchuongtrinh.Visible = false;
                grkhoa.Visible = false;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            flag = false;
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag==true) // nút thêm
            {
                if (rdkhoa.Checked==true)
                {

                }
            }
            else
            {

            }
        }
    }
}
