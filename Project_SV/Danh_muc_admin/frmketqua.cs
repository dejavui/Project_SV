using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Project_SV
{
    public partial class frmketqua : Form
    {
        public frmketqua()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void loadgr()
        {
            string sql = "select ketqua.ma_kq, ketqua.ma_sv,monhoc.ten_mh,ketqua.ma_lop,ketqua.lan_thi,ketqua.diem from ketqua inner join monhoc on ketqua.ma_mh = monhoc.ma_mh";
            kn.taobang(sql);
            grkq.DataSource = kn.taobang(sql);

            string strmh = "select * from monhoc";
            cmbmonhoc.DataSource = kn.taobang(strmh);
            cmbmonhoc.DisplayMember = "ten_mh";
            cmbmonhoc.ValueMember = "ma_mh";

            string strlop = "select * from lop";
            cmbtenlop.DataSource = kn.taobang(strlop);
            cmbtenlop.DisplayMember = "ten_khoa";
            cmbtenlop.ValueMember = "ma_lop";

            for (int i = 0; i < grkq.Rows.Count - 1; i++)
            {
                if (grkq.Rows[i].Cells[0].Value.ToString() == txt_ma_kq.Text.Trim())
                {
                    grkq.CurrentCell = grkq.Rows[i].Cells[0];
                    grkq.Rows[i].Selected = true;
                }
            }
        }
        private void loaddata()
        {
            try
            {
                if (grkq.RowCount > 1)
                {
                int r = grkq.CurrentCell.RowIndex;
                txt_ma_kq.Text = grkq.Rows[r].Cells[0].Value.ToString();
                txttensv.Text = grkq.Rows[r].Cells[1].Value.ToString();
                cmbmonhoc.Text = grkq.Rows[r].Cells[2].Value.ToString();
                cmbtenlop.Text = grkq.Rows[r].Cells[3].Value.ToString();
                txtlanthi.Text = grkq.Rows[r].Cells[4].Value.ToString();
                txtdiemthi.Text = grkq.Rows[r].Cells[5].Value.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void lockcontrol()
        {
            btnghi.Visible = false;
            btnkhongghi.Visible = false;

            btnthem.Visible = true;
            btnxoa.Visible = true;
        }
        private void unlockcontrol()
        {
            btnghi.Visible = true;
            btnkhongghi.Visible = true;

            btnthem.Visible = false;
            btnxoa.Visible = false;
        }
        private void resetdata()
        {
            txt_ma_kq.ResetText();
            txttensv.ResetText();
            txtlanthi.ResetText();
            txtdiemthi.ResetText();
        }
        private void frmketqua_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại");
            }
            loadgr();
            lockcontrol();
            loaddata();
    }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Form frm = new frmmain();
            frm.ShowDialog();
            this.Hide();
        }

        private void txttimkiemmasv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "select ketqua.ma_kq, ketqua.ma_sv,monhoc.ten_mh,ketqua.ma_lop,ketqua.lan_thi,ketqua.diem from ketqua inner join monhoc on ketqua.ma_mh = monhoc.ma_mh where ketqua.ma_kq like '%"+txttimkiemmasv.Text.Trim()+"%' or ketqua.ma_sv like '%"+txttimkiemmasv.Text.Trim()+"%'";
                grkq.DataSource = kn.taobang(sql1);
                loaddata();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy Mã sinh viên này!!!");
            }
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            loadgr();
            txttimkiemmasv.Clear();
            txttimkiemmasv.Focus();
        }

        private void grketqua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void frmketqua_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }

        private void grkq_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grkq.CurrentCell.RowIndex;
                string ma = grkq.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete ketqua where ma_kq = '" + ma + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            try
            {
            if (flag == true) // nút thêm
            {
                string sql2 = ("insert into ketqua(ma_kq,ma_sv,ma_mh,ma_lop,lan_thi,diem)values('"+txt_ma_kq.Text.Trim()+"','" + txttensv.Text.Trim()+"','"+cmbmonhoc.SelectedValue.ToString()+"','"+cmbtenlop.SelectedValue.ToString()+"','"+txtlanthi.Text.Trim()+"','"+txtdiemthi.Text.Trim()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lỗi rồi");
            }
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            lockcontrol();
            loadgr();
            loaddata();
            txttensv.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resetdata();
            txttensv.Focus();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.Show();
        }
    }
}
