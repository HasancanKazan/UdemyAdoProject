using HBANK.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBANK
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = "SELECT USER_ID FROM USERS where USER_NAME=@USERNAME and PASSWORD=@PASSWORD and ISACTIVE=1";
            SqlDataAdapter dap = new SqlDataAdapter(user,BaseMethods.ConnectionString());
            dap.SelectCommand.Parameters.AddWithValue("@USERNAME", txtUserName.Text);
            dap.SelectCommand.Parameters.AddWithValue("@PASSWORD", txtPassword.Text);
            dap.SelectCommand.Connection.Open();
            var userId = dap.SelectCommand.ExecuteScalar();
            dap.SelectCommand.Connection.Close();

            if (String.IsNullOrEmpty(userId?.ToString() ?? ""))
            {
                MessageBox.Show("Kullanıcı Bulunamadı.", "Login Hata", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Home home = new Home();
                //home.UserId = userId.ToString();

                BaseMethods baseMethods = new BaseMethods();
                home.user = baseMethods.getUser(userId.ToString());

                home.Show();
                this.Hide();
            }

        }
    }
}
