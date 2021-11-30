using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Project_SV
{
    class ketnoidulieu
    {
        public SqlConnection conn = null;
        public string fxmaster = @"Data Source=FX-MASTER;Initial Catalog=QLSV;Integrated Security=True";
        public void myconn()
        {
            if (conn == null) conn = new SqlConnection(fxmaster);
            if (conn.State == ConnectionState.Closed) conn.Open();
            //System.Data.ConnectionState.Closed
        }
        public void myclose()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
        public DataTable taobang(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void kiemtra(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("Đã có trong CSDL");
                return;
            }
            dr.Close();
            dr.Dispose();
        }
        public void kt(string sql_kt)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=FX-MASTER;Initial Catalog=QLSV;Integrated Security=True"))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(sql_kt, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show("Đã có trong CSDL");
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
        public void sqlquery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
