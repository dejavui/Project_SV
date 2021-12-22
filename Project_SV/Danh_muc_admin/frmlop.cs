using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Project_SV
{
    public partial class frmlop : Form
    {
        public frmlop()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void btnfrmmain_Click(object sender, EventArgs e)
        {
            Form frm = new frmmain();
            frm.Show();
            this.Hide();
        }
        private void loadgr()
        {
            string sql = "select lop.ma_lop, lop.ten_lop, khoa.ten_khoa, khoahoc.ten_khoa_hoc, chuongtrinh.ten_ct,lop.STT from lop inner join khoa on khoa.ma_khoa = lop.ma_khoa inner join khoahoc on khoahoc.ma_khoa_hoc = lop.ma_khoa_hoc inner join chuongtrinh on chuongtrinh.ma_ct = lop.ma_ct";
            grlop.DataSource = kn.taobang(sql);

            string strmalop = "select * from lop";
            cmbtenkhoa.DataSource = kn.taobang(strmalop);
            cmbtenkhoa.DisplayMember = "ten_lop";
            cmbtenkhoa.ValueMember = "ma_lop";

            string strmakhoahoc = "select * from khoahoc";
            cmbmakhoahoc.DataSource = kn.taobang(strmakhoahoc);
            cmbmakhoahoc.DisplayMember = "ten_khoa_hoc";
            cmbmakhoahoc.ValueMember = "ma_khoa_hoc";

            string strmachuongtrinh = "select * from chuongtrinh";
            cmbtenchuongtrinh.DataSource = kn.taobang(strmachuongtrinh);
            cmbtenchuongtrinh.DisplayMember = "ten_ct";
            cmbtenchuongtrinh.ValueMember = "ma_ct";

            string strkhoa = "select * from khoa";
            cmbtenkhoa.DataSource = kn.taobang(strkhoa);
            cmbtenkhoa.DisplayMember = "ten_khoa";
            cmbtenkhoa.ValueMember = "ma_khoa";

            for (int i = 0; i < grlop.Rows.Count - 1; i++)
            {
                if (grlop.Rows[i].Cells[0].Value.ToString() == txttenlop.Text)
                {
                    grlop.CurrentCell = grlop.Rows[i].Cells[0];
                    grlop.Rows[i].Selected = true;
                }
            }
        }
        private void loaddata()
        {
            try
            {
                if (grlop.Rows.Count > 1)
                {
                    int dong = grlop.CurrentCell.RowIndex;
                    txttenlop.Text = grlop.Rows[dong].Cells[1].Value.ToString();
                    cmbtenkhoa.Text = grlop.Rows[dong].Cells[2].Value.ToString();
                    cmbmakhoahoc.Text = grlop.Rows[dong].Cells[3].Value.ToString();
                    cmbtenchuongtrinh.Text = grlop.Rows[dong].Cells[4].Value.ToString();
                    return;
                }
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
            catch (Exception)
            {
                return;
            }
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
        private void resetdata()
        {
            txttenlop.ResetText();
            cmbmakhoahoc.ResetText();
            cmbtenkhoa.ResetText();
            cmbtenchuongtrinh.ResetText();
        }
        private void frmlop_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
                //throw;
            }
            loadgr();
            loaddata();
            lockcontrol();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grlop.CurrentCell.RowIndex;
                string ma = grlop.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete lop where ma_lop='" + ma + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }

        private void grlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            resetdata();
            unlockcontrol();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            loaddata();
            flag = false;
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {
                try
                {

                string sql2 = ("insert into lop(ten_lop,ma_khoa_hoc,ma_khoa,ma_ct)values('"+txttenlop.Text.Trim()+"', '"+cmbmakhoahoc.SelectedValue.ToString()+"', '"+cmbtenkhoa.SelectedValue.ToString() +"', '"+cmbtenchuongtrinh.SelectedValue.ToString() +"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu","Thông báo");
                }


            }

            else //ghi nút sửa
            {
                //if (txttenlop.Text.Trim() == "" || txtstt.Text.Trim() == "")
                //{
                //    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                //    txttenlop.Focus();
                //    return;
                //}
                try
                {
                int r = grlop.CurrentCell.RowIndex;
                string ma = grlop.Rows[r].Cells[0].Value.ToString();
                string sql3 = "update lop set ten_lop = '"+txttenlop.Text.Trim()+"' ma_khoa_hoc='"+cmbmakhoahoc.SelectedValue.ToString()+"', ma_khoa='"+cmbtenkhoa.SelectedValue.ToString()+"', ma_ct='"+cmbtenchuongtrinh.SelectedValue.ToString()+"', where ma_lop= '"+txttenlop.Text.Trim()+"'";
                kn.sqlquery(sql3);
                loadgr();
                loaddata();

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi sửa","Thông báo");
                }
            }
        }

        private void timkiem()
        {
            string timkiem = "select lop.ma_lop, lop.ten_lop, khoa.ten_khoa, khoahoc.ten_khoa_hoc, chuongtrinh.ten_ct,lop.STT from lop inner join khoa on khoa.ma_khoa = lop.ma_khoa inner join khoahoc on khoahoc.ma_khoa_hoc = lop.ma_khoa_hoc inner join chuongtrinh on chuongtrinh.ma_ct = lop.ma_ct where lop.ma_lop like '%" + txttimkiem.Text.Trim() + "% or khoa.ten_khoa like '%"+txttimkiem.Text.Trim()+"%'";
            kn.sqlquery(timkiem);
            grlop.DataSource = kn.taobang(timkiem);
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmlop_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
