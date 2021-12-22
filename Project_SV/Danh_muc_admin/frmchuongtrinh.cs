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
    public partial class frmchuongtrinh : Form
    {
        public frmchuongtrinh()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void loadgr()
        {
            try
            {
                string sql = "select * from chuongtrinh";
                kn.taobang(sql);
                grchuongtrinh.DataSource = kn.taobang(sql);
                int r = grchuongtrinh.CurrentCell.RowIndex;
                string ma = grchuongtrinh.Rows[r].Cells[0].Value.ToString();
                for (int i = 0; i < grchuongtrinh.Rows.Count - 1; i++)
                {
                    if (grchuongtrinh.Rows[i].Cells[0].Value.ToString() == ma)
                    {
                        grchuongtrinh.CurrentCell = grchuongtrinh.Rows[i].Cells[0];
                        grchuongtrinh.Rows[i].Selected = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }
        private void loaddata()
        {
            try
            {
                if (grchuongtrinh.Rows.Count > 1)
                {
                    int dong = grchuongtrinh.CurrentCell.RowIndex;
                    txttenct.Text = grchuongtrinh.Rows[dong].Cells[1].Value.ToString();
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
            //txtmact.Enabled = true;
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
            //txtmact.Enabled = false;
        }
        private void frmchuongtrinh_Load(object sender, EventArgs e)
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
            loaddata();
            lockcontrol();
        }
        private void resetdata()
        {
            txttenct.ResetText();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
            txttenct.Focus();
        }

        private void btnfrmmain_Click(object sender, EventArgs e)
        {
            Form frm = new frmmain();
            this.Hide();
            frm.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resetdata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grchuongtrinh.CurrentCell.RowIndex;
                string makhoa = grchuongtrinh.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete chuongtrinh where ma_ct='" + makhoa + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = false;
            unlockcontrol();
        }

        private void grchuongtrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }
        private void timkiem()
        {
            string sqltimkiem = "select * from chuongtrinh where ma_ct like'%"+txttimkiem.Text.Trim()+"%' or ten_ct like'%"+txttimkiem.Text.Trim()+"%'";
            kn.sqlquery(sqltimkiem);
            grchuongtrinh.DataSource = kn.taobang(sqltimkiem);
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void frmchuongtrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnghi_Click_1(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {
                string sql2 = ("insert into chuongtrinh(ten_ct)values('" + txttenct.Text.Trim() + "')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();

            }

            else //ghi nút sửa
            {
                if (txttenct.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txttenct.Focus();
                    return;
                }
                int r = grchuongtrinh.CurrentCell.RowIndex;
                string ma = grchuongtrinh.Rows[r].Cells[0].Value.ToString();
                string sql5 = "update chuongtrinh set ten_ct='" + txttenct.Text.Trim() + "' where ma_ct='" + ma + "'";
                kn.sqlquery(sql5);
                loadgr();
                loaddata();
            }
        }
    }
}
