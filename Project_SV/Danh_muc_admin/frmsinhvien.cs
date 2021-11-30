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
    public partial class frmsinhvien : Form
    {
        public frmsinhvien()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void loadgr()
        {
            this.sinhvienTableAdapter.Fill(this.qLSVDataSet.sinhvien);
            string strmalop = "select * from lop";
            cmbmalop.DataSource = kn.taobang(strmalop);
            cmbmalop.DisplayMember = "Ma_lop";
            cmbmalop.ValueMember = "ma_lop";

            grsinhvien.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < grsinhvien.Rows.Count - 1; i++)
            {
                if (grsinhvien.Rows[i].Cells[0].Value.ToString() == txtmasv.Text.Trim())
                {
                    grsinhvien.CurrentCell = grsinhvien.Rows[i].Cells[0];
                    grsinhvien.Rows[i].Selected = true;
                }
            }

        }
        private void loaddata()
        {
            try
            {
                if (grsinhvien.Rows.Count > 1)
                {
                    int dong = grsinhvien.CurrentCell.RowIndex;
                    txtmasv.Text = grsinhvien.Rows[dong].Cells[0].Value.ToString();
                    txthoten.Text = grsinhvien.Rows[dong].Cells[1].Value.ToString();
                    cmb_gioi_tinh.Text = grsinhvien.Rows[dong].Cells[2].Value.ToString();
                    dtp_ngay_thang_nam_sinh.Text = grsinhvien.Rows[dong].Cells[3].Value.ToString();
                    txt_dia_chi.Text = grsinhvien.Rows[dong].Cells[4].Value.ToString();
                    cmbmalop.Text = grsinhvien.Rows[dong].Cells[5].Value.ToString();
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
            
        }
        private void resetdata()
        {
            txtmasv.ResetText();
            txt_dia_chi.ResetText();
            txthoten.ResetText();
            cmb_gioi_tinh.ResetText();
            cmbmalop.ResetText();
            dtp_ngay_thang_nam_sinh.ResetText();
        }
        private void frmsinhvien_Load(object sender, EventArgs e)
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
            lockcontrol();
            loadgr();
            loaddata();
        }

        private void btnfrmmain_Click(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            frm.Show();
            this.Hide();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grsinhvien.CurrentCell.RowIndex;
                string ma = grsinhvien.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete sinhvien where ma_sv='" + ma + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }
        private void timkiem()
        {
            string timkiem = "select * from sinhvien where ma_sv like '%" + txttimkiem.Text.Trim() + "%' or ho_ten like '%" + txttimkiem.Text.Trim() + "%' or ma_lop like '%" + txttimkiem.Text.Trim() + "%'";
            kn.sqlquery(timkiem);
            grsinhvien.DataSource = kn.taobang(timkiem);
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void grsinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resetdata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            flag = false;
            unlockcontrol();
            txtmasv.Enabled = false;
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
            txtmasv.Focus();
            txtmasv.Enabled = true;
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {

                string sql1 = "select * from sinhvien where ma_sv=N'" + txtmasv.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, kn.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Mã chương trình đã có trong CSDL");
                    dr.Close();
                    return;
                }
                dr.Close();
                string sql2 = ("insert into sinhvien(ma_sv,ho_ten,ngay_thang_nam_sinh,dia_chi,gioi_tinh,ma_lop)values(N'" + txtmasv.Text.Trim()+"', N'"+txthoten.Text.Trim()+"','"+dtp_ngay_thang_nam_sinh.Value.ToString("yyyy-MM-dd")+"', N'"+txt_dia_chi.Text.Trim()+"','"+cmb_gioi_tinh.SelectedItem.ToString()+"', '"+cmbmalop.SelectedValue.ToString()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();
            }
            else //ghi nút sửa
            {
                if (txtmasv.Text.Trim() == "" || cmbmalop.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn không được để trống thông tin", "Thông báo");
                    txtmasv.Focus();
                    return;
                }

                string sql3 = "update sinhvien set ho_ten=N'"+txthoten.Text.Trim()+ "',ngay_thang_nam_sinh = '" + dtp_ngay_thang_nam_sinh.Value.ToString("yyyy-MM-dd") + "',gioi_tinh=N'"+cmb_gioi_tinh.SelectedValue.ToString()+"',ma_lop='"+cmbmalop.SelectedValue.ToString()+"',dia_chi='"+txt_dia_chi.Text.Trim()+"' where ma_sv= '"+txtmasv.Text.Trim()+"'";
                kn.sqlquery(sql3);
                //string sql4 = "update sinhvien set ma_sv =N'" + txtmasv.Text.Trim() + "' where ma_sv ='" + txtmasv.Text.Trim() + "'";
                //kn.sqlquery(sql4);
                //string sql5 = "update sinhvien set ho_ten =N'" + txthoten.Text.Trim() + "' where ma_sv ='" + txtmasv.Text.Trim() + "'";
                //kn.sqlquery(sql5);
                //string sql6 = "update sinhvien set nam_sinh = N'"+txtnamsinh.Text.Trim()+"' where ma_sv ='"+txtmasv.Text.Trim()+"' ";
                //kn.sqlquery(sql6);
                //string sql7 = "update sinhvien set gioi_tinh = N'"+txtgioitinh.Text.Trim()+"' where ma_sv = '"+txtmasv.Text.Trim()+"'";
                //kn.sqlquery(sql7); 
                //string sql8 = "update sinhvien set ma_lop = '"+cmbmalop.SelectedValue+"' where ma_sv = '"+txtmasv.Text.Trim()+"' ";
                //kn.sqlquery(sql8);
                loadgr();
                loaddata();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmsinhvien_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
