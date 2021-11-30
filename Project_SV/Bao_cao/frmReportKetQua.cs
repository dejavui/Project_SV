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
using Microsoft.Reporting.WinForms;
using Project_SV;
namespace Project_SV
{
    public partial class frmReportKetQua : Form
    {
        private string message;
        public frmReportKetQua()
        {
            InitializeComponent();
        }
        public frmReportKetQua(string Message):this()
        {
            message = Message;
        }
        ketnoidulieu kn = new ketnoidulieu();

        private void frmReportKetQua_Load(object sender, EventArgs e)
        {
            this.rpketqua.RefreshReport();
            kn.myconn();
            string sql = "select ketqua.ma_sv,sinhvien.ho_ten,ngay_thang_nam_sinh,gioi_tinh,ketqua.ma_lop,monhoc.ten_mh,ketqua.lan_thi,diem,giangkhoa.nam_hoc from ketqua inner join sinhvien on ketqua.ma_sv=sinhvien.ma_sv inner join monhoc on monhoc.ma_mh=ketqua.ma_mh inner join giangkhoa on giangkhoa.ma_mh=monhoc.ma_mh where ketqua.ma_sv= '" + message+"' ";
            SqlDataAdapter da = new SqlDataAdapter(sql, kn.conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "ketqua inner join sinhvien on ketqua.ma_sv=sinhvien.ma_sv inner join monhoc on monhoc.ma_mh=ketqua.ma_mh inner join giangkhoa on giangkhoa.ma_mh=monhoc.ma_mh");
            this.rpketqua.LocalReport.ReportEmbeddedResource = "Project_SV.ReportKetQua.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetKetQua";
            rds.Value = ds.Tables[0];
            this.rpketqua.LocalReport.DataSources.Add(rds);
            this.rpketqua.RefreshReport();
            
        }
        
        
        private void rpketqua_Load(object sender, EventArgs e)
        {

        }

        private void btnnut_Click(object sender, EventArgs e)
        {

        }

        private void frmReportKetQua_FormClosed(object sender, FormClosedEventArgs e)
        {
            kn.myclose();
            Form frm = new frm_xem_diem(message);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
