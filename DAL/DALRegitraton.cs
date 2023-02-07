using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using APPprops;

namespace DAL
{
    public class DALRegitraton
    {
        DbCon con;
        public DALRegitraton()
        {
            con = new DbCon("Data Source=DESKTOP-NR4JUEC\\SQLEXPRESS;Initial Catalog=Manage;Integrated Security=True");
        }

        public bool insertData(Registration_Details s)
        {
            string query = "insert into Registration_form values('"+s.firstname+"','"+s.lastname+"', '"+s.Contact+"','"+s.Email+"','"+s.Gender+ "','"+s.Address+"','"+s.Designation+"')";
            return con.UDI(query);
        }
        public bool updateData(Registration_Details s)
        {
            string query = "update Registration_form set firstname = '" + s.firstname + "',lastname = '"+s.lastname+"',contact='"+s.Contact+"' ,Email ='"+s.Email+"', Gender = '"+s.Gender+"',Address = '"+s.Address+"',Designation='"+s.Designation+"' where id = '"+s.id+"'";
            return con.UDI(query);
        }
        public bool DeleteData(Registration_Details s)
        {
            string query = "Delete from Registration_form where id = '" + s.id + "'";
            return con.UDI(query);
        }
        public SqlDataReader ReadDAta(Registration_Details s)
        {
            string query = "Select * from Registration_form where id = '" + s.id + "'";
            return con.SerchSingalData(query);
        }
        public DataTable ReadAlldata()
        {
            string query = "select * from Registration_form";
            return con.search(query);
        }


    }
}

