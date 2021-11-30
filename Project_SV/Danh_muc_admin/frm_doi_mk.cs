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
    public partial class frm_doi_mk : Form
    {
        public frm_doi_mk()
        {
            InitializeComponent();
        }
        ketnoidulieu kn = new ketnoidulieu();
        private void loadgr()
        {
            string sql = "select tenDN,matkhau,hoten from logins where quyen = 'member'";
            grtaikhoan.DataSource = kn.taobang(sql);
            
        }
        private void frm_doi_mk_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frmmain();
            this.Hide();
            frm.ShowDialog();
        }

        private void frm_doi_mk_Load(object sender, EventArgs e)
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
        private void loaddata()
        {
            try
            {
                if (grtaikhoan.RowCount > 1)
                {
                    int r = grtaikhoan.CurrentCell.RowIndex;
                    txtmasv.Text = grtaikhoan.Rows[r].Cells[0].Value.ToString();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void btndoimk_Click(object sender, EventArgs e)
        {
                int r = grtaikhoan.CurrentCell.RowIndex;
                string tk = grtaikhoan.Rows[r].Cells[0].Value.ToString();
                string sql5 = "update logins set matkhau = '"+txtmk.Text.Trim()+"' where tenDN = '" + tk + "'";
                kn.sqlquery(sql5);
                loadgr();
        }

        private void timkiem()
        {
            string sqltimkiem = "select tenDN,matkhau,hoten from logins where quyen = 'member' and tenDN like '%"+txttimkiem.Text.Trim()+"%'";
            grtaikhoan.DataSource = kn.taobang(sqltimkiem);
            loaddata();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiem();
        }

        private void grtaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }
    }
}
