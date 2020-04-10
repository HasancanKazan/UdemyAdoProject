using HBANK.Base;
using HBANK.Models;
using HBANK.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBANK
{
    public partial class Banks : Form
    {
        public Banks()
        {
            InitializeComponent();
        }

        private void Banks_Load(object sender, EventArgs e)
        {
            getBanks();
            getUser();
        }

        public string UserId { get; set; }
        User user = new User();
        private void grdBanks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DBConnection dBConnection = new DBConnection();

            if (grdBanks.CurrentRow != null)
            {
                dBConnection.ConnectionOpen();
                SqlCommand command = dBConnection.getQuery("BankInsertOrUpdate");
                command.CommandType = CommandType.StoredProcedure;
                DataGridViewRow row = grdBanks.CurrentRow;
                command.Parameters.AddWithValue("@BANKCODE", row.Cells["dataBANKCODE"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["dataBANKCODE"].Value));
                command.Parameters.AddWithValue("@DESCRIPTION", row.Cells["dataDescription"].Value);
                command.Parameters.AddWithValue("@KATILIM_FLG", row.Cells["dataKatilim"].Value);
                command.Parameters.AddWithValue("@ABROAD_FLG", row.Cells["dataAbroad"].Value);
                command.Parameters.AddWithValue("@BLOCKED_FLG", row.Cells["dataBlocked"].Value);
                command.Parameters.AddWithValue("@CRE_DATE", row.Cells["dataCreDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["dataCreDate"].Value));
                command.Parameters.AddWithValue("@CRE_USER", row.Cells["dataCreUser"].Value == DBNull.Value ? user.FULL_NAME : Convert.ToString(row.Cells["dataCreUser"].Value));
                command.Parameters.AddWithValue("@MOD_DATE", row.Cells["dataModDate"].Value == DBNull.Value ? DateTime.Now : Convert.ToDateTime(row.Cells["dataModDate"].Value));
                command.Parameters.AddWithValue("@MOD_USER", row.Cells["dataModUser"].Value == DBNull.Value ? user.FULL_NAME : Convert.ToString(row.Cells["dataModUser"].Value));
                command.ExecuteNonQuery();
                getBanks();

            }
        }

        public void getBanks()
        {
            string query = "SELECT * FROM BANKS;";
            SqlDataAdapter dap = new SqlDataAdapter(query, BaseMethods.ConnectionString());
            DataTable dt = new DataTable();
            dap.Fill(dt);
            grdBanks.DataSource = dt;
        }

        #region GetUser
        public void getUser()
        {
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata");
            }

        }
        #endregion

        private void grdBanks_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                DataGridViewRow row = grdBanks.CurrentRow;
                DBConnection dBConnection = new DBConnection();
                dBConnection.ConnectionOpen();
                string deleteQuery = "DELETE FROM BANKS WHERE BANKCODE=@BANKCODE";
                SqlCommand command = dBConnection.getQuery(deleteQuery);
                command.Parameters.AddWithValue("BANKCODE", row.Cells["dataBANKCODE"].Value);
                command.ExecuteNonQuery();
                getBanks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
