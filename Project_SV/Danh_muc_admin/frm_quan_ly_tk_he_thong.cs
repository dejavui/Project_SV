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
    public partial class frm_quan_ly_tk_he_thong : Form
    {
        public frm_quan_ly_tk_he_thong()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        private void loadgr()
        {
            string sql = "select * from logins where quyen NOT like 'admin' and quyen NOT like 'sinhvien'";
            gr_tk.DataSource = kn.taobang(sql);

        }
        private void frm_quan_ly_tk_he_thong_Load(object sender, EventArgs e)
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
            if (txt_mk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo");
            }
            if (txt_tk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo");
            }
            if (txt_ho_ten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo");
            }
            if (cmb_per.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa chọn quyền", "Thông báo");
            }
            else
            {
            string sql = "insert into logins(tenDN,matkhau,hoten,quyen) values ('"+txt_tk.Text.Trim()+"','"+txt_mk.Text.Trim()+"','"+txt_ho_ten.Text.Trim()+"','"+cmb_per.SelectedItem.ToString()+"')";
            kn.sqlquery(sql);
            loadgr();
            }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thêm tài khoản");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo);
            if (traloi == DialogResult.Yes)
            {
                int r = gr_tk.CurrentCell.RowIndex;
                string tk = gr_tk.Rows[r].Cells[0].Value.ToString();
                string sqlxoa = "delete logins where tenDN ='" + tk + "'";
                kn.sqlquery(sqlxoa);
                loadgr();
            }
        }

        private void PicHien_Click(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '\0')
            {
                // ngược lại nếu password char = rỗng thì sẽ mang ảnh hiện lên trước và biến password char về giá trị *
                PicAn.BringToFront();
                txt_mk.PasswordChar = '*';
            }
        }

        private void PicAn_Click(object sender, EventArgs e)
        {
            if (txt_mk.PasswordChar == '*')
            {
                // nếu password char = * thì sẽ mang ảnh hiện lên trước và biến password char về giá trị rỗng
                PicHien.BringToFront();
                txt_mk.PasswordChar = '\0';
            }
        }

        private void frm_quan_ly_tk_he_thong_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
        }
    }
}
