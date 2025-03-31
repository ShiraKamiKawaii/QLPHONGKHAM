using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace BasicDev
{
    public class MyClass
    {
        static SqlConnection con = new SqlConnection();

        //Hàm kết nối
        public static void Connect()
        {
            con.ConnectionString = "Data Source=CT-FUBUKI;Initial Catalog=qlPhongKhamDongY; User ID= sa; Password=123;";
            try
            {
                con.Open();
            }catch(Exception)
            {
                throw;
            }
        }
        //Hàm đóng kết nối
        public static void Disconnect()
        {
            con.Close();
        }
        //Hàm đổ dữ liệu vào datatable
        public static DataTable GetData(String sql)
        {
            Connect();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(table);
            Disconnect();
            return table;
        }
        //Hàm lấy dữ liệu bằng DataSet
        public static DataSet GetDataSet(string sql)
        {
            Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(sql,con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
        //Hàm thực thi Insert/Update/Delete
        public static void RunSQL(String sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.ExecuteNonQuery();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Disconnect();
        }
    }
}
