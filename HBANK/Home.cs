using HBANK.Base;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public string UserId { get; set; }
        User user = new User();


        private void Home_Load(object sender, EventArgs e)
        {
            getUser();
            GetMenuItem();
            lbl_fullName.Text = user.FULL_NAME;
            lbl_fullName.Visible = true;
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
        #region GetMenuItem
        public void GetMenuItem()
        {
            switch (user.USER_TYPE)
            {
                case 1:
                    goToCreditToolStripMenuItem.Visible = false;
                    break;
                case 2:
                    banksToolStripMenuItem.Visible = false;
                    branchsToolStripMenuItem.Visible = false;
                    usersToolStripMenuItem.Visible = false;
                    break;
                default:
                    break;
            }
        } 
        #endregion

        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banks banks = new Banks();
            banks.UserId = UserId;
            banks.Show();
            this.Hide();
        }
    }
}
