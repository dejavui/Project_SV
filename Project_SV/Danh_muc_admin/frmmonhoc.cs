using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project_SV
{
    public partial class frmmonhoc : Form
    {
        public frmmonhoc()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void loadgr()
        {
            string sql = "select monhoc.ma_mh,monhoc.ten_mh,khoa.ten_khoa from monhoc inner join khoa on monhoc.ma_khoa = khoa.ma_khoa";
            kn.taobang(sql);
            grmonhoc.DataSource = kn.taobang(sql);

            string sqlkhoa = "select * from khoa";
            cmbtenkhoa.DataSource = kn.taobang(sqlkhoa);
            cmbtenkhoa.DisplayMember = "ten_khoa";
            cmbtenkhoa.ValueMember = "ma_khoa";

            for (int i = 0; i < grmonhoc.Rows.Count - 1; i++)
            {
                if (grmonhoc.Rows[i].Cells[0].Value.ToString() == txtmamonhoc.Text.Trim())
                {
                    grmonhoc.CurrentCell = grmonhoc.Rows[i].Cells[0];
                    grmonhoc.Rows[i].Selected = true;
                }
            }

        }
        private void loaddata()
        {
            try
            {
                if (grmonhoc.Rows.Count > 1)
                {
                    int dong = grmonhoc.CurrentCell.RowIndex;
                    txtmamonhoc.Text = grmonhoc.Rows[dong].Cells[0].Value.ToString();
                    txttenmonhoc.Text = grmonhoc.Rows[dong].Cells[1].Value.ToString();
                    cmbtenkhoa.SelectedValue = grmonhoc.Rows[dong].Cells[2].Value.ToString();
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
        private void frmmonhoc_Load(object sender, EventArgs e)
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
                int r = grmonhoc.CurrentCell.RowIndex;
                string ma = grmonhoc.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete monhoc where ma_mh='" + ma + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }

        private void btnfrmmain_Click(object sender, EventArgs e)
        {
            Form frm = new frmmain();
            frm.Show();
            this.Hide();
        }

        private void grmonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            txtmamonhoc.Enabled = true;
            lockcontrol();
            loadgr();
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            txtmamonhoc.Enabled = false;
            unlockcontrol();
            flag = false;
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {

                string sql1 = "select * from monhoc where ma_mh ='" + txtmamonhoc.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, kn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mã lớp đã có trong CSDL");
                    dr.Close();
                    return;
                }
                dr.Close();
                string sql2 = ("insert into monhoc(ma_mh,ten_mh,ma_khoa)values('"+txtmamonhoc.Text.Trim()+"', '"+txttenmonhoc.Text.Trim()+"', '"+cmbtenkhoa.SelectedValue.ToString()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();

            }

            else //ghi nút sửa
            {
                if (txtmamonhoc.Text.Trim() == "" || txttenmonhoc.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txtmamonhoc.Focus();
                    return;
                }

                string sql3 = "update monhoc set ten_mh = '"+txttenmonhoc.Text.Trim()+"', ma_khoa = '"+cmbtenkhoa.SelectedValue.ToString()+"' where ma_mh = '"+txtmamonhoc.Text.Trim()+"'";
                kn.sqlquery(sql3);
                loadgr();
                loaddata();
            }
        }
        private void timkiem()
        {
            string timkiem = "select * from monhoc where ma_mh like '%"+txttimkiem.Text.Trim()+"%' or ten_mh like '%"+txttimkiem.Text.Trim()+"%'";
            kn.sqlquery(timkiem);
            grmonhoc.DataSource = kn.taobang(timkiem);
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void frmmonhoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
