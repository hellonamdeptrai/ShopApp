using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShopApp.Code
{
    class Functions
    {
        public static SqlConnection con;       

        public static void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.DBShop;

            //Kiểm tra kết nối
            if (con.State != ConnectionState.Open) 
            {
                con.Open();
            }
            else 
            {
                MessageBox.Show("Không thể kết nối với dữ liệu");
            }

        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }

        public static DataSet GetData(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = name;
            cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();

            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            dap.Fill(ds);

            return ds;
        }

        public static SqlCommand RunProcedure(string text)
        {
            SqlCommand cmd = new SqlCommand();
            
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = text;

            return cmd;
        }
    }
}
