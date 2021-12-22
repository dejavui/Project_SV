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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();

        private void frmlogin_Load(object sender, EventArgs e)
        {
            try
            {
                kn.myconn();
                cboName.Items.Add(SystemInformation.UserDomainName.ToString()); //+"\\SQLServer"
                cboName.Text = cboName.Items[0].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void loginadmin()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=FX-MASTER;Initial Catalog=QLSV;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='admin'", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("đăng nhập vào hệ thống !", "Thông báo !");
                                Form frm = new frmmain();
                                frm.Show();
                                this.Hide();
                                cmd.Dispose();
                                
                                //do something
                            }
                        }
                        reader.Dispose();
                        reader.Close();
                    }// reader closed and disposed up here
                    
                } // command disposed here
                connection.Close();
                connection.Dispose();
            } //connection closed and disposed here
        }
        private void loginmember()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=FX-MASTER;Initial Catalog=QLSV;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='sinhvien'", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                                Form frm = new frmmain_sinhvien();
                                frm.Show();
                                this.Hide();
                                cmd.Dispose();
                                //do something
                            }
                        }
                        reader.Dispose();
                        reader.Close();
                    }// reader closed and disposed up here

                } // command disposed here
                connection.Close();
                connection.Dispose();
            } //connection closed and disposed here
        }

        public string getID_admin()
        {
            string id = "";
            try
            {
                string sql1 = "select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='admin'";
                SqlDataAdapter da = new SqlDataAdapter(sql1, kn.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["quyen"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                kn.myclose();
            }
            return id;
        }
        public string getID_sinhvien()
        {
            string id = "";
            try
            {
                string sql1 = "select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='sinhvien'";
                SqlDataAdapter da = new SqlDataAdapter(sql1, kn.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["quyen"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                kn.myclose();
            }
            return id;
        }
        public string getID_thuky()
        {
            string id = "";
            try
            {
                string sql1 = "select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='thuky'";
                SqlDataAdapter da = new SqlDataAdapter(sql1, kn.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["quyen"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                kn.myclose();
            }
            return id;
        }

        public static string ID_USERS_admin = "";
        public static string ID_USERS_sinhvien = "";
        public static string ID_USERS_thuky = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ID_USERS_admin = getID_admin();
            //loginadmin();
            //loginmember();
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Không được để trống mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
            if (ID_USERS_admin != "")
            {
                kn.myconn();
                MessageBox.Show("Đăng nhập thành công với quyền là: " + ID_USERS_admin);
                Form frm = new frmmain(txtTenDN.Text.ToUpper());
                this.Hide();
                frm.ShowDialog();
                return;
            }
            ID_USERS_sinhvien = getID_sinhvien();
            if(ID_USERS_sinhvien != "")
            {
                kn.myconn();
                MessageBox.Show("Đăng nhập thành công với quyền là: " + ID_USERS_sinhvien);
                Form frm = new frmmain_sinhvien(txtTenDN.Text.ToUpper());
                this.Hide();
                frm.ShowDialog();
                return;
            }
            ID_USERS_thuky = getID_thuky();
            if (ID_USERS_thuky != "")
            {
                kn.myconn();
                MessageBox.Show("Đăng nhập thành công với quyền là: " + ID_USERS_thuky);
                Form frm = new frm_thu_ky();
                this.Hide();
                frm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMatKhau.Focus();
            }

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            Control.IsKeyLocked(Keys.CapsLock);
        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {
            Control.IsKeyLocked(Keys.CapsLock);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public static string taikhoan;
        public static string matkhau;
        private void cb_save_tt_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_save_tt.Checked == true)
            {

            }
            
        }
    }
}
