using HBANK.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBANK.Models
{
    class DBConnection
    {

        public SqlConnection ConnectionOpen()
        {
            SqlConnection connection = new SqlConnection(BaseMethods.ConnectionString());
            connection.Open();
            return connection;
        }


        public SqlCommand getQuery(string query)
        {
            SqlCommand command = new SqlCommand(query,ConnectionOpen());
            return command;
        }

    }
}
