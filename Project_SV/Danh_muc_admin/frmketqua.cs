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
            string sql = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa";
            kn.taobang(sql);
            grkq.DataSource = kn.taobang(sql);

            string strmh = "select * from monhoc";
            cmbmonhoc.DataSource = kn.taobang(strmh);
            cmbmonhoc.DisplayMember = "ten_mh";
            cmbmonhoc.ValueMember = "ma_mh";

            string strlop = "select * from lop";
            cmbtenlop.DataSource = kn.taobang(strlop);
            cmbtenlop.DisplayMember = "ten_lop";
            cmbtenlop.ValueMember = "ma_lop";

            string strsv = "select * from sinhvien";
            cmbma_sv.DataSource = kn.taobang(strsv);
            cmbma_sv.DisplayMember = "ma_sv";
            cmbma_sv.ValueMember = "ma_sv";

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
                cmbma_sv.Text = grkq.Rows[r].Cells[1].Value.ToString();
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
            txt_ma_kq.Enabled = false;
            rd_toantruong.Checked = true;
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
                string sql1 = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa where ketqua.ma_kq like '%" + txttimkiemmasv.Text.Trim()+"%' or ketqua.ma_sv like '%"+txttimkiemmasv.Text.Trim()+"%'";
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
                string sql2 = ("insert into ketqua(ma_sv,ma_mh,ma_lop,lan_thi,diem)values('" + cmbma_sv.SelectedValue.ToString()+"','"+cmbmonhoc.SelectedValue.ToString()+"','"+cmbtenlop.SelectedValue.ToString()+"','"+txtlanthi.Text.Trim()+"','"+txtdiemthi.Text.Trim()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Nhập điểm bị lỗi rồi");
            }
        }

        private void btnkhongghi_Click(object sender, EventArgs e)
        {
            
            lockcontrol();
            loadgr();
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resetdata();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.Show();
        }

        private void rdkhoa_CNTT_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoa_CNTT.Checked==true)
            {
                string sql = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa where khoa.ma_khoa = '1'";
                grkq.DataSource = kn.taobang(sql);
            }
        }

        private void rdkhoaDL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoaDL.Checked == true)
            {
                string sql = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa where khoa.ma_khoa = '2'";
                grkq.DataSource = kn.taobang(sql);
            }
        }

        private void rdkhoaCN_OTO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoaCN_OTO.Checked == true)
            {
                string sql = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa where khoa.ma_khoa = '3'";
                grkq.DataSource = kn.taobang(sql);
            }
        }

        private void rdkhoa_KINHTE_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoa_KINHTE.Checked == true)
            {
                string sql = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa where khoa.ma_khoa = '4'";
                grkq.DataSource = kn.taobang(sql);
            }
        }

        private void rdkhoa_NGONNGU_CheckedChanged(object sender, EventArgs e)
        {
            if (rdkhoa_NGONNGU.Checked == true)
            {
                string sql = "select ketqua.ma_kq, sinhvien.ma_sv, monhoc.ten_mh,lop.ten_lop,ketqua.lan_thi,ketqua.diem,khoa.ten_khoa from ketqua inner join sinhvien on ketqua.ma_sv = sinhvien.ma_sv inner join monhoc on ketqua.ma_mh = monhoc.ma_mh inner join lop on ketqua.ma_lop = lop.ma_lop inner join khoa on lop.ma_khoa = khoa.ma_khoa where khoa.ma_khoa = '5'";
                grkq.DataSource = kn.taobang(sql);
            }
        }

        private void rd_toantruong_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_toantruong.Checked==true)
            {
                loadgr();
            }
        }
    }
}
