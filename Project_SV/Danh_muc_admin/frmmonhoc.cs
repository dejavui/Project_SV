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
            string sql = "select monhoc.ma_mh, monhoc.ten_mh, khoa.ten_khoa,chuongtrinh.ten_ct,monhoc.chu_thich from monhoc inner join khoa on khoa.ma_khoa = monhoc.ma_khoa inner join chuongtrinh on chuongtrinh.ma_ct = monhoc.ma_ct";
            kn.taobang(sql);
            grmonhoc.DataSource = kn.taobang(sql);

            string sqlkhoa = "select * from khoa";
            cmbtenkhoa.DataSource = kn.taobang(sqlkhoa);
            cmbtenkhoa.DisplayMember = "ten_khoa";
            cmbtenkhoa.ValueMember = "ma_khoa";

            string strmachuongtrinh = "select * from chuongtrinh";
            cmbtenchuongtrinh.DataSource = kn.taobang(strmachuongtrinh);
            cmbtenchuongtrinh.DisplayMember = "ten_ct";
            cmbtenchuongtrinh.ValueMember = "ma_ct";

            int r = grmonhoc.CurrentCell.RowIndex;
            string ma = grmonhoc.Rows[r].Cells[0].Value.ToString();

            for (int i = 0; i < grmonhoc.Rows.Count - 1; i++)
            {
                if (grmonhoc.Rows[i].Cells[0].Value.ToString() == ma)
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
                    txttenmonhoc.Text = grmonhoc.Rows[dong].Cells[1].Value.ToString();
                    cmbtenkhoa.Text = grmonhoc.Rows[dong].Cells[2].Value.ToString();
                    cmbtenchuongtrinh.Text = grmonhoc.Rows[dong].Cells[3].Value.ToString();
                    txtchuthich.Text = grmonhoc.Rows[dong].Cells[4].Value.ToString();
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
            kn.myclose();
            this.Close();
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
            lockcontrol();
            loadgr();
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            unlockcontrol();
            flag = false;
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (flag == true) // nút thêm
            {

                try
                {
                string sql2 = ("insert into monhoc(ten_mh,ma_khoa,ma_ct,chu_thich)values('"+txttenmonhoc.Text.Trim()+"','"+cmbtenkhoa.SelectedValue.ToString()+"','"+cmbtenchuongtrinh.SelectedValue.ToString()+"','"+txtchuthich.Text.Trim()+"')");
                kn.sqlquery(sql2);
                loadgr();
                loaddata();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi thêm dữ liệu","Thông báo");
                }

            }

            else //ghi nút sửa
            {
                try
                {
                    int r = grmonhoc.CurrentCell.RowIndex;
                    string ma = grmonhoc.Rows[r].Cells[0].Value.ToString();
                    string sql3 = "update monhoc set ten_mh = '"+txttenmonhoc.Text.Trim()+"', ma_khoa = '"+cmbtenkhoa.SelectedValue.ToString()+"',ma_ct='"+cmbtenchuongtrinh.SelectedValue.ToString()+"',chu_thich='"+txtchuthich.Text.Trim()+"' where ma_mh = '"+ma+"'";
                    kn.sqlquery(sql3);
                    loadgr();
                    loaddata();
                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi sửa dữ liệu");
                }
            }
        }
        private void timkiem()
        {
            string timkiem = "select monhoc.ma_mh, monhoc.ten_mh, khoa.ten_khoa,chuongtrinh.ten_ct,monhoc.chu_thich from monhoc inner join khoa on khoa.ma_khoa = monhoc.ma_khoa inner join chuongtrinh on chuongtrinh.ma_ct = monhoc.ma_ct where ma_mh like '%"+txttimkiem.Text.Trim()+"%' or ten_mh like '%"+txttimkiem.Text.Trim()+"%' or ten_khoa like '%"+txttimkiem.Text.Trim()+"%'";
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
        }

        private void cmbtenkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
