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
        public User user;
        private void Home_Load(object sender, EventArgs e)
        {
            GetMenuItem();
            lbl_fullName.Text = user.FULL_NAME;
            lbl_fullName.Visible = true;
        }

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
            banks.user = user;
            banks.Show();
            this.Hide();
        }
    }
}
