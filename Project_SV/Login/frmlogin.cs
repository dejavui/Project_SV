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
                using (SqlCommand cmd = new SqlCommand("select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='member'", connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                                Form frm = new frmmain_member();
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
        public string getID_member()
        {
            string id = "";
            try
            {
                string sql1 = "select * from logins where tendn='" + txtTenDN.Text.Trim() + "' and matkhau='" + txtMatKhau.Text.Trim() + "' and quyen='member'";
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
        public static string ID_USERS_member = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            ID_USERS_admin = getID_admin();
            //loginadmin();
            //loginmember();
            if (ID_USERS_admin != "")
            {
                kn.myconn();
                MessageBox.Show("Đăng nhập thành công với quyền là: " + ID_USERS_admin);
                Form frm = new frmmain();
                this.Hide();
                frm.ShowDialog();
                return;
            }
            ID_USERS_member = getID_member();
            if(ID_USERS_member != "")
            {
                kn.myconn();
                MessageBox.Show("Đăng nhập thành công với quyền là: " + ID_USERS_member);
                Form frm = new frmmain_member(txtTenDN.Text.ToUpper());
                this.Hide();
                frm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng!!!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
    }
}
