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
    public partial class frm_tao_tai_khoan : Form
    {
        public frm_tao_tai_khoan()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        private void loadgr()
        {
            string sql = "select logins.tenDN,hoten from logins where quyen = 'sinhvien'";
            grlogins.DataSource = kn.taobang(sql);

            string strsv = "select * from sinhvien";
            cmbma_sv.DataSource = kn.taobang(strsv);
            cmbma_sv.DisplayMember = "ma_sv";
            cmbma_sv.ValueMember = "ma_sv";

            for (int i = 0; i < grlogins.Rows.Count - 1; i++)
            {
                if (grlogins.Rows[i].Cells[0].Value.ToString() == txthoten.Text.Trim())
                {
                    grlogins.CurrentCell = grlogins.Rows[i].Cells[0];
                    grlogins.Rows[i].Selected = true;
                }
            }
        }
        private void frm_tao_tai_khoan_Load(object sender, EventArgs e)
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
        }

        private void frm_tao_tai_khoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
        }

        private void btn_tao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txthoten.Text =="")
                {
                    MessageBox.Show("Bạn chưa nhập tên sinh viên","Thông báo");
                }
                if (cmbma_sv.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Chưa chọn mã sinh viên","Thông báo");
                }
            string sql = "insert into logins (tenDN,matkhau,hoten,quyen)values('"+cmbma_sv.SelectedValue.ToString().ToUpper()+"', '123', '"+txthoten.Text.Trim()+"', 'sinhvien')";
            kn.sqlquery(sql);
            loadgr();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi tạo tài khoản");
            }

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (traloi == DialogResult.Yes)
            {
                int r = grlogins.CurrentCell.RowIndex;
                string tk = grlogins.Rows[r].Cells[0].Value.ToString();
                string sql5 = "delete logins where tenDN='" + tk + "'";
                kn.sqlquery(sql5);
                loadgr();
            }
        }
    }
}
