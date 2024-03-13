using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanAn.DAO
{
    internal class DataProvider
    {
        //string i = "Data Source=HOANGS\\sqlexpress;Initial Catalog=QL_QuanAn;Integrated Security=True";
        public string conStr = "";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            set { DataProvider.Instance = value; }
        }

        //===================================================================================
        public int testConnect(string data, string tk, string mk)
        {
            conStr = "Data Source="+data+";Initial Catalog=QL_QuanAn;Persist Security Info=True;User ID="+tk+";Password="+mk+"";
            int value = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    connection.Open();
                    connection.Close();
                }
                value = 1;
            }
            catch { }
            return value;
        }
        public DataTable executeQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object executeScaler(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
