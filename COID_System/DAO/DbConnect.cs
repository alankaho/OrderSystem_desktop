using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace COID_System.dao
{
    class DbConnect
    {
        public SqlConnection CreateConnection()
        {
            string connString =
                @"server=(local);Initial Catalog=OrderSystem;Integrated Security=SSPI;";

            SqlConnection sql = new SqlConnection(connString);


            return sql;
        }
    }
}
