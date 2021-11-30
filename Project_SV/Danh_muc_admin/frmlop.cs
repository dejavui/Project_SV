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
            this.lopTableAdapter.Fill(this.qLSVDataSet1.lop);

            string strmalop = "select * from lop";
            cmbtenkhoa.DataSource = kn.taobang(strmalop);
            cmbtenkhoa.DisplayMember = "Mã lớp";
            cmbtenkhoa.ValueMember = "ma_lop";

            string strmakhoahoc = "select * from khoahoc";
            cmbmakhoahoc.DataSource = kn.taobang(strmakhoahoc);
            cmbmakhoahoc.DisplayMember = "Mã khóa học";
            cmbmakhoahoc.ValueMember = "ma_khoa_hoc";

            //string strmakhoa = "select * from khoa";
            //cmbmakhoa.DataSource = kn.taobang(strmakhoa);
            //cmbmakhoa.DisplayMember = "Mã khoa";
            //cmbmakhoa.ValueMember = "ma_khoa";

            string strmachuongtrinh = "select * from chuongtrinh";
            cmbmachuongtrinh.DataSource = kn.taobang(strmachuongtrinh);
            cmbmachuongtrinh.DisplayMember = "Mã Chương trình";
            cmbmachuongtrinh.ValueMember = "ma_ct";

            string strkhoa = "select * from khoa";
            (grlop.Columns[2] as DataGridViewComboBoxColumn).DataSource = kn.taobang(strkhoa);
            (grlop.Columns[2] as DataGridViewComboBoxColumn).DisplayMember = "ten_khoa";
            (grlop.Columns[2] as DataGridViewComboBoxColumn).ValueMember = "ma_khoa";

            cmbtenkhoa.DataSource = kn.taobang(strkhoa);
            cmbtenkhoa.DisplayMember = "ten_khoa";
            cmbtenkhoa.ValueMember = "ma_khoa";

            for (int i = 0; i < grlop.Rows.Count - 1; i++)
            {
                if (grlop.Rows[i].Cells[0].Value.ToString() == txtmalop.Text)
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
                    txtmalop.Text = grlop.Rows[dong].Cells[0].Value.ToString();
                    cmbmakhoahoc.Text = grlop.Rows[dong].Cells[1].Value.ToString();
                    //cmbmakhoa.Text = grlop.Rows[dong].Cells[2].Value.ToString();
                    cmbtenkhoa.SelectedValue = grlop.Rows[dong].Cells[2].Value.ToString();
                    cmbmachuongtrinh.Text = grlop.Rows[dong].Cells[3].Value.ToString();
                    txtstt.Text = grlop.Rows[dong].Cells[4].Value.ToString();
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
            txtmalop.ResetText();
            cmbmakhoahoc.ResetText();
            cmbtenkhoa.ResetText();
            cmbmachuongtrinh.ResetText();
            txtstt.ResetText();
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

                string sql1 = "select * from lop where ma_lop ='" + txtmalop.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, kn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mã lớp đã có trong CSDL");
                    dr.Close();
                    return;
                }
                dr.Close();
                string sql2 = ("insert into lop(ma_lop,ma_khoa_hoc,ma_khoa,ma_ct,STT)values('"+txtmalop.Text.Trim()+"', '"+cmbmakhoahoc.SelectedValue.ToString()+"', '"+cmbtenkhoa.SelectedValue.ToString() +"', '"+cmbmachuongtrinh.SelectedValue.ToString() +"', '"+txtstt.Text.Trim()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();

            }

            else //ghi nút sửa
            {
                if (txtmalop.Text.Trim() == "" || txtstt.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txtmalop.Focus();
                    return;
                }

                string sql3 = "update lop set ma_khoa_hoc='"+cmbmakhoahoc.SelectedValue.ToString()+"', ma_khoa='"+cmbtenkhoa.SelectedValue.ToString()+"', ma_ct='"+cmbmachuongtrinh.SelectedValue.ToString()+"',STT='"+txtstt.Text.Trim()+"' where ma_lop= '"+txtmalop.Text.Trim()+"'";
                kn.sqlquery(sql3);
                loadgr();
                loaddata();
            }
        }

        private void timkiem()
        {
            string timkiem = "select * from lop where ma_lop like '%" + txttimkiem.Text.Trim() + "%";
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
    }
}
