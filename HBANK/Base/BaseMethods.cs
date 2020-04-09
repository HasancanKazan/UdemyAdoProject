using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBANK.Base
{
    class BaseMethods
    {
        public static string ConnectionString()
        {
            string connectionString = ConfigurationManager.AppSettings["ConnectionDb"];
            return connectionString;
        }

    }
}
