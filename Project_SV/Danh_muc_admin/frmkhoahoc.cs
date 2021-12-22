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
    public partial class frmkhoahoc : Form
    {
        public frmkhoahoc()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void loadgr()
        {
            try
            {
                string sql = "select * from khoahoc";
                grkhoahoc.DataSource = kn.taobang(sql);
                int r = grkhoahoc.CurrentCell.RowIndex;
                string ma = grkhoahoc.Rows[r].Cells[0].Value.ToString();

                for (int i = 0; i < grkhoahoc.Rows.Count - 1; i++)
                {
                    if (grkhoahoc.Rows[i].Cells[0].Value.ToString() == ma)
                    {
                        grkhoahoc.CurrentCell = grkhoahoc.Rows[i].Cells[0];
                        grkhoahoc.Rows[i].Selected = true;
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
                if (grkhoahoc.Rows.Count > 1)
                {
                    int dong = grkhoahoc.CurrentCell.RowIndex;
                    txttenkhoahoc.Text = grkhoahoc.Rows[dong].Cells[1].Value.ToString();
                    return;
                }
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
            catch (Exception)
            {
                return;
                //throw;
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
            //txtmasv.Enabled = true;
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
            //txtmasv.Enabled = false;
        }
        private void resettext()
        {
            
        }
        private void frmkhoahoc_Load(object sender, EventArgs e)
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
        private void timkiem()
        {
            string sqltimkiem = "select * from khoahoc where ma_khoa_hoc like '%" + txttimkiem.Text.Trim() + "%' or ten_khoa_hoc like '%"+txttimkiem.Text.Trim()+"%' ";
            kn.sqlquery(sqltimkiem);
            grkhoahoc.DataSource = kn.taobang(sqltimkiem);
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resettext();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {
                try
                {
                string sql2 = "insert into khoahoc(ten_khoa_hoc)values('"+txttenkhoahoc.Text.Trim()+"')";
                kn.sqlquery(sql2);
                loadgr();
                loaddata();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu");
                }

            }

            else //ghi nút sửa
            {
                if (txttenkhoahoc.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txttenkhoahoc.Focus();
                    return;
                }
                int r = grkhoahoc.CurrentCell.RowIndex;
                string ma = grkhoahoc.Rows[r].Cells[0].Value.ToString();
                string sql3 = "update khoahoc set ten_khoa_hoc = '"+txttenkhoahoc.Text.Trim()+"' where ma_khoa_hoc ='"+ma+"'";
                kn.sqlquery(sql3);
                loadgr();
                loaddata();
            }
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
            txttenkhoahoc.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grkhoahoc.CurrentCell.RowIndex;
                string makhoa = grkhoahoc.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete khoa_hoc where ma_khoa_hoc='" + makhoa + "'";
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

        private void grkhoahoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kn.myclose();
            this.Close();
        }

        private void frmkhoahoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
