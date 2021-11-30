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
            this.khoahocTableAdapter.Fill(this.qLSVDataSet1.khoahoc);
                for (int i = 0; i < grkhoahoc.Rows.Count - 1; i++)
                {
                    if (grkhoahoc.Rows[i].Cells[0].Value.ToString() == txtmakhoahoc.Text)
                    {
                        grkhoahoc.CurrentCell = grkhoahoc.Rows[i].Cells[0];
                        grkhoahoc.Rows[i].Selected = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không có dữ liệu");
                throw;
            }

        }
        private void loaddata()
        {
            try
            {
                if (grkhoahoc.Rows.Count > 1)
                {
                    int dong = grkhoahoc.CurrentCell.RowIndex;
                    txtmakhoahoc.Text = grkhoahoc.Rows[dong].Cells[0].Value.ToString();
                    txtnambatdau.Text = grkhoahoc.Rows[dong].Cells[1].Value.ToString();
                    txtnamketthuc.Text = grkhoahoc.Rows[dong].Cells[2].Value.ToString();
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
            txtmakhoahoc.ResetText();
            txtnambatdau.ResetText();
            txtnamketthuc.ResetText();
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
                //throw;
            }
            loadgr();
            loaddata();
            lockcontrol();
        }
        private void timkiem()
        {
            string sqltimkiem = "select * from khoahoc where ma_khoa_hoc like '%" + txttimkiem.Text.Trim() + "%' or nam_bat_dau like '%" + txttimkiem.Text.Trim() + "%' or nam_ket_thuc like'%" + txttimkiem.Text.Trim() + "%'";
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

                string sql1 = "select * from khoa where khoa_hoc = '" + txtmakhoahoc.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, kn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mã Khóa học đã có trong CSDL");
                    dr.Close();
                    return;
                }
                dr.Close();
                string sql2 = ("insert into khoahoc(ma_khoa_hoc,nam_bat_dau,nam_ket_thuc)values('"+txtmakhoahoc.Text.Trim()+"', '"+txtnambatdau.Text.Trim()+"', '"+txtnamketthuc.Text.Trim()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();

            }

            else //ghi nút sửa
            {
                if (txtmakhoahoc.Text.Trim() == "" || txtnambatdau.Text.Trim() == ""|| txtnamketthuc.Text.Trim() =="")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txtmakhoahoc.Focus();
                    return;
                }

                string sql3 = "select * from khoa_hoc where ma_khoa_hoc ='" + txtmakhoahoc.Text.Trim() + "'";
                kn.sqlquery(sql3);
                string sql4 = "update khoa_hoc set ma_khoa_hoc='" + txtmakhoahoc.Text.Trim() + "' where ma_khoa_hoc='" + txtmakhoahoc.Text.Trim() + "'";
                kn.sqlquery(sql4);
                string sql5 = "update khoa_hoc set nam_bat_dau='" + txtnambatdau.Text.Trim() + "' where ma_khoa_hoc='" + txtmakhoahoc.Text.Trim() + "'";
                kn.sqlquery(sql5);
                string sql6 = "update khoa_hoc set nam_ket_thuc ='" + txtnamketthuc.Text.Trim() + "' where ma_khoa_hoc ='"+txtmakhoahoc.Text.Trim()+ "'";
                kn.sqlquery(sql6);
                loadgr();
                loaddata();
            }
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
            txtmakhoahoc.Focus();
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
            Form frm = new frmmain();
            frm.Show();
            this.Hide();
        }

        private void frmkhoahoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
