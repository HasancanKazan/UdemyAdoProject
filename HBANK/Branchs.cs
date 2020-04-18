using HBANK.Models;
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
    public partial class Branchs : Form
    {
        public Branchs()
        {
            InitializeComponent();
        }

        private void Branchs_Load(object sender, EventArgs e)
        {
            GetBanks();
        }


        public void GetBanks()
        {
            DBConnection dBConnection = new DBConnection();

            SqlConnection connection = dBConnection.ConnectionOpen();
            string query = "SELECT BANKCODE, DESCRIPTION FROM BANKS";
            SqlCommand sqlCommand = dBConnection.getQuery(query);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            while (dataReader.Read())
            {
                cmbBank.Items.Add(dataReader["DESCRIPTION"]);
            }

            cmbBank.SelectedIndex = 0;
        }
    }
}
