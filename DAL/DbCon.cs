using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    class DbCon
    {
        SqlConnection con;

        public DbCon(string connectionStrings)
        {
            con = new SqlConnection(connectionStrings);
        }
        public bool UDI(string query) 
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            bool check = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return check;

        }
        public DataTable search(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dar = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dar.Fill(dt);
            con.Close();
            return dt;
        }
        public SqlDataReader SerchSingalData(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dar = cmd.ExecuteReader();
            return dar;
        }
    }
}
