using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CosmaticProject.Database_Layer
{
    class DataAccess
    {
        private static SqlConnection conn;

        public static SqlConnection ConnOpen()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-V6DB7O3\SQLEXPRESS;Initial Catalog=CosmaticShopDb;Integrated Security=True");
            }
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            return conn;
        }

        public static bool Crud(string query)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, ConnOpen());
                int noOfRecord = cmd.ExecuteNonQuery();
                if (noOfRecord > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {

                throw;
            }
        }
        public static DataTable Retrive(string query)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(query, ConnOpen());
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    return null;
                }
                return dt;
            }
            catch 
            {

                return null;
            }
        }


    }
}
