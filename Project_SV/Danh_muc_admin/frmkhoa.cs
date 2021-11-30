using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Project_SV
{
    public partial class frmkhoa : Form
    {
        public frmkhoa()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void loadgr()
        {
            try
            {
                string sql = "select * from khoa";
                kn.taobang(sql);
                grkhoa.DataSource = kn.taobang(sql);
                for (int i = 0; i < grkhoa.Rows.Count - 1; i++)
                {
                    if (grkhoa.Rows[i].Cells[0].Value.ToString() == txtmakhoa.Text.Trim())
                    {
                        grkhoa.CurrentCell = grkhoa.Rows[i].Cells[0];
                        grkhoa.Rows[i].Selected = true;
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
                if (grkhoa.Rows.Count > 1)
                {
                    int dong = grkhoa.CurrentCell.RowIndex;
                    txtmakhoa.Text = grkhoa.Rows[dong].Cells[0].Value.ToString();
                    txttenkhoa.Text = grkhoa.Rows[dong].Cells[1].Value.ToString();
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
        private void Form1_Load(object sender, EventArgs e)
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
        private void resettext()
        {
            txtmakhoa.ResetText();
            txttenkhoa.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resettext();
        }

        private void grkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {

                string sql1 = "select * from khoa where MA_KHOA='" + txtmakhoa.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, kn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mã Khoa đã có trong CSDL");
                    dr.Close();
                    return;
                }
                dr.Close();
                string sql2 = ("insert into khoa(ma_khoa,ten_khoa) values('"+txtmakhoa.Text.Trim()+"', '"+txttenkhoa.Text.Trim()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();

            }

            else //ghi nút sửa
            {
                if (txtmakhoa.Text.Trim() == "" || txttenkhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txtmakhoa.Focus();
                    return;
                }

                string sql3 = "select * from khoa where ma_khoa ='" + txtmakhoa.Text.Trim() + "'";
                kn.sqlquery(sql3);
                string sql4 = "update khoa set ma_khoa='" + txtmakhoa.Text.Trim() + "' where ma_khoa='" + txtmakhoa.Text.Trim() + "'";
                kn.sqlquery(sql4);
                string sql5 = "update khoa set ten_khoa='" + txttenkhoa.Text.Trim() + "' where ma_khoa='" + txtmakhoa.Text.Trim() + "'";
                kn.sqlquery(sql5);
                
                loadgr();
                loaddata();
            }
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
            txtmakhoa.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = false;
            unlockcontrol();
            //txtmakhoa.Enabled = false;
        }

        private void timkiem()
        {
            string sql6 = "select * from khoa where ma_khoa like '%" + txttimkiem.Text.Trim() + "%' or ten_khoa like '%" + txttimkiem.Text.Trim() + "%' ";
            kn.sqlquery(sql6);
            grkhoa.DataSource = kn.taobang(sql6);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grkhoa.CurrentCell.RowIndex;
                string makhoa = grkhoa.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete khoa where ma_khoa='" + makhoa + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }

        private void btnchuyenform_Click(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            frm.Show();
            this.Hide();
        }

        private void frmkhoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
