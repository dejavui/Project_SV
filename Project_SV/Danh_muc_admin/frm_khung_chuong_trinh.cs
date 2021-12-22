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
    public partial class frm_khung_chuong_trinh : Form
    {
        public frm_khung_chuong_trinh()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        bool flag;
        private void frmgiangkhoa_Load(object sender, EventArgs e)
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
            txtid.Enabled = false;
        }
        private void loadgr()
        {
            string giangkhoa = "select khung_chuong_trinh.ID, chuongtrinh.ten_ct, khoa.ten_khoa,monhoc.ten_mh, khung_chuong_trinh.nam_hoc,khung_chuong_trinh.hoc_ky,khung_chuong_trinh.so_tiet_ly_thuyet,khung_chuong_trinh.so_tiet_thuc_hanh,khung_chuong_trinh.so_tin_chi from chuongtrinh inner join khung_chuong_trinh on chuongtrinh.ma_ct = khung_chuong_trinh.ma_ct inner join khoa on khoa.ma_khoa = khung_chuong_trinh.ma_khoa inner join monhoc on monhoc.ma_mh = khung_chuong_trinh.ma_mh";
            kn.taobang(giangkhoa);
            grGiangKhoa.DataSource = kn.taobang(giangkhoa);

            string strct = "select * from chuongtrinh";
            cbchuongtrinh.DataSource = kn.taobang(strct);
            cbchuongtrinh.DisplayMember = "ten_ct";
            cbchuongtrinh.ValueMember = "ma_ct";

            string strkh = "select * from khoa";
            cbkhoa.DataSource = kn.taobang(strkh);
            cbkhoa.DisplayMember = "ten_khoa";
            cbkhoa.ValueMember = "ma_khoa";

            string strmh = "select * from monhoc";
            cbmonhoc.DataSource = kn.taobang(strmh);
            cbmonhoc.DisplayMember = "ten_mh";
            cbmonhoc.ValueMember = "ma_mh";

        }
        private void lockcontrol()
        {
            btnthem.Visible = true;
            btnxoa.Visible = true;
            btnluu.Visible = false;
            btnkhongluu.Visible = false;
        }
        private void unlockcontrol()
        {
            btnthem.Visible = false;
            btnxoa.Visible = false;
            btnluu.Visible = true;
            btnkhongluu.Visible = true;
        }
        private void resetdata()
        {
            cbchuongtrinh.Text = "";
            cbkhoa.Text = "";
            cbmonhoc.Text = "";
            txtnamhoc.Text = "";
            txthocky.Text = "";
            txtlyhtuyet.Text = "";
            txtthuchanh.Text = "";
            txttinchi.Text = "";
        }
        private void loaddata()
        {
            try
            {
                if (grGiangKhoa.Rows.Count > 1)
                {
                    int r = grGiangKhoa.CurrentCell.RowIndex;
                    txtid.Text = grGiangKhoa.Rows[r].Cells[0].Value.ToString();
                    cbchuongtrinh.Text = grGiangKhoa.Rows[r].Cells[1].Value.ToString();
                    cbkhoa.Text = grGiangKhoa.Rows[r].Cells[2].Value.ToString();
                    cbmonhoc.Text = grGiangKhoa.Rows[r].Cells[3].Value.ToString();
                    txtnamhoc.Text = grGiangKhoa.Rows[r].Cells[4].Value.ToString();
                    txthocky.Text = grGiangKhoa.Rows[r].Cells[5].Value.ToString();
                    txtlyhtuyet.Text = grGiangKhoa.Rows[r].Cells[6].Value.ToString();
                    txtthuchanh.Text = grGiangKhoa.Rows[r].Cells[7].Value.ToString();
                    txttinchi.Text = grGiangKhoa.Rows[r].Cells[8].Value.ToString();
                    return;
                }
                MessageBox.Show("Không tìm thấy dữ liệu");
            }
            catch (Exception)
            {
                return;
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            flag = false;
            cbchuongtrinh.Enabled = false;
            cbkhoa.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (txtnamhoc.Text.Trim() == "" || txthocky.Text.Trim() == "" || txtlyhtuyet.Text.Trim() == "" || txtthuchanh.Text.Trim() == "" || txttinchi.Text.Trim() == ""|| cbchuongtrinh.SelectedValue== null || cbkhoa.SelectedValue == null || cbmonhoc.SelectedValue == null)
            {
                MessageBox.Show("Bạn nhập thiếu rồi !!");
                return;
            }

            if (flag == true)
            {
                try
                {
                string sqlthem = "insert into khung_chuong_trinh(ma_ct,ma_khoa,ma_mh,nam_hoc,hoc_ky,so_tiet_ly_thuyet,so_tiet_thuc_hanh,so_tin_chi) values('"+cbchuongtrinh.SelectedValue.ToString()+"', '"+cbkhoa.SelectedValue.ToString()+"', '"+cbmonhoc.SelectedValue.ToString()+"', '"+txtnamhoc.Text.Trim()+"', '"+txthocky.Text.Trim()+"', '"+txtlyhtuyet.Text.Trim()+"', '"+txtthuchanh.Text.Trim()+"', '"+txttinchi.Text.Trim()+"')";
                kn.sqlquery(sqlthem);
                loadgr();
                loaddata();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi khi thêm");
                }

            }

            //else
            //{
            //string sql1 = "update giangkhoa set nam_hoc='"+txtnamhoc.Text.Trim()+"', hoc_ky='"+txthocky.Text.Trim()+"',so_tiet_ly_thuyet='"+txtlyhtuyet.Text.Trim()+"',so_tiet_thuc_hanh='"+txtthuchanh.Text.Trim()+"',so_tin_chi='"+txttinchi.Text.Trim()+"' where ma_mh=N'"+cbmonhoc.SelectedValue.ToString()+"'";
            //kn.sqlquery(sql1);
            //loadgr();
            //loaddata();
            //}

        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            
            loadgr();
            loaddata();
            cbchuongtrinh.Enabled = true;
            cbkhoa.Enabled = true;
        }

        private void btnmain_Click(object sender, EventArgs e)
        {
            kn.myclose();
            this.Close();
        }

        private void grGiangKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void timkiem()
        {
            if(txttimkiem.Text == "")
            {
                loadgr();
            }
            else
            {
            string timkiem = "select khung_chuong_trinh.ID, chuongtrinh.ten_ct, khoa.ten_khoa,monhoc.ten_mh, khung_chuong_trinh.nam_hoc,khung_chuong_trinh.hoc_ky,khung_chuong_trinh.so_tiet_ly_thuyet,khung_chuong_trinh.so_tiet_thuc_hanh,khung_chuong_trinh.so_tin_chi from chuongtrinh inner join khung_chuong_trinh on chuongtrinh.ma_ct = khung_chuong_trinh.ma_ct inner join khoa on khoa.ma_khoa = giangkhoa.ma_khoa inner join monhoc on monhoc.ma_mh = khung_chuong_trinh.ma_mh where ID like'%" + txttimkiem.Text.Trim()+"%' ,ten_ct like '%" + txttimkiem.Text.Trim()+"%' or ten_mh like '%"+txttimkiem.Text.Trim()+"%' or ten_khoa like '%"+txttimkiem.Text.Trim()+ "%' or chuongtrinh.ma_ct like '%"+txttimkiem.Text.Trim()+"%' or khoa.ma_khoa like '%"+txttimkiem.Text.Trim()+"%' or monhoc.ma_mh like '%"+txttimkiem.Text.Trim()+"%'";
            kn.sqlquery(timkiem);
            grGiangKhoa.DataSource = kn.taobang(timkiem);
            }
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            flag = true;
            unlockcontrol();
            resetdata();
        }

        private void btnkhongluu_Click(object sender, EventArgs e)
        {
            loadgr();   
            loaddata();
            lockcontrol();
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = grGiangKhoa.CurrentCell.RowIndex;
                string ma = grGiangKhoa.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete khung_chuong_trinh where ID ='" + ma + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
                loaddata();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            timkiem();
        }

        private void frmgiangkhoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
        }
    }
}
