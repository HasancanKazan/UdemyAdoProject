using HBANK.Users;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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


        #region GetUser
        public User getUser(string UserId)
        {
            User user = new User();
            string getUser = "SELECT * FROM USERS WHERE USER_ID=@USERID";
            SqlDataAdapter dap = new SqlDataAdapter(getUser, BaseMethods.ConnectionString());
            dap.SelectCommand.Parameters.AddWithValue("@USERID", UserId);
            DataTable dt = new DataTable();
            dap.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                user.USER_ID = row["USER_ID"].ToString();
                user.FIRST_NAME = row["FIRST_NAME"].ToString();
                user.USER_NAME = row["USER_NAME"].ToString();
                user.LAST_NAME = row["LAST_NAME"].ToString();
                user.USER_TYPE = Convert.ToInt32(row["USER_TYPE"]);
                user.CRE_USER = row["CRE_USER"].ToString();
                user.CRE_DATE = Convert.ToDateTime(row["CRE_DATE"]);
                user.MOD_USER = row["MOD_USER"].ToString();
                user.MOD_DATE = Convert.ToDateTime(row["MOD_DATE"]);
                user.ISACTIVE = Convert.ToBoolean(row["ISACTIVE"]);
                user.PHONE_NUMBER = row["PHONE_NUMBER"].ToString();
                user.EMAIL = row["EMAIL"].ToString();
            }
            return user;
        }
        #endregion
    }
}
