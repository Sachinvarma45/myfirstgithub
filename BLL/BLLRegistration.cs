using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using APPprops;

namespace BLL
{
    public class BLLRegistration
    {
        DALRegitraton Rdal = new DALRegitraton();

        public bool BinsertData(Registration_Details s)
        {
            return Rdal.insertData(s);
        }
        public bool Bupdatedata(Registration_Details s)
        {
            return Rdal.updateData(s);
        }
        public bool BdeleteData(Registration_Details s)
        {
            return Rdal.DeleteData(s);
        }
        public SqlDataReader BReadData(Registration_Details s)
        {
            return Rdal.ReadDAta(s);
        }
        public DataTable BReadAllData()
        {
            return Rdal.ReadAlldata();
        }

    }
}
