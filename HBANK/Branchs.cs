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
            
        }


        

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBank_Click(object sender, EventArgs e)
        {
            cmbBank.Items.Clear();
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
                Bank bank = new Bank();
                bank.BANKCODE = dataReader.GetString(0);
                bank.DESCRIPTION = dataReader.GetString(1);
                cmbBank.Items.Add(bank);
            }
        }
    }
}
