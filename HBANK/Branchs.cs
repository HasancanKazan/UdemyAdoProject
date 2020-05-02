using HBANK.Base;
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
            //Sayfa açılışında gride şubeleri getir.
            getBranchs();
        }


        

        private void cmbBank_SelectedIndexChanged(object sender, EventArgs e)
        {

            var bank = cmbBank.SelectedItem as Bank;
            var v = bank.BANKCODE;

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

        public void getBranchs()
        {
            string query = @"SELECT  BR.BRANCHCODE,BR.BANKCODE,B.DESCRIPTION AS BANKNAME,BR.CURRENCYCODE,
                            BR.DESCRIPTION,BR.BANKCITY,BR.PASSIVE_FLG,BR.ABROAD_FLG,BR.BLOCKED_FLG,
                            BR.EMAIL,BR.BANKNUMBER,BR.CREDATE,BR.CREUSER,BR.MODDATE,BR.MODUSER from BRANCHS BR
                            JOIN BANKS AS B ON B.BANKCODE = BR.BANKCODE";
            SqlDataAdapter adapter = new SqlDataAdapter(query, BaseMethods.ConnectionString());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grdBranch.DataSource = dt;

        }

        private void grdBranch_SelectionChanged(object sender, EventArgs e)
        {
            txtEmail.Text = grdBranch.CurrentRow.Cells["EMAIL"].Value.ToString();
            txtDesc.Text= grdBranch.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
            txtBankNumber.Text = grdBranch.CurrentRow.Cells["BANKNUMBER"].Value.ToString();
            cmbBank.Text= grdBranch.CurrentRow.Cells["BANKNAME"].Value.ToString();
            cmbCurrency.Text = grdBranch.CurrentRow.Cells["CURRENCYCODE"].Value.ToString();
            cmbBankCity.Text = grdBranch.CurrentRow.Cells["BANKCITY"].Value.ToString();
            chkPassive.Checked = Convert.ToBoolean(grdBranch.CurrentRow.Cells["PASSIVEFLG"].Value);
            chkBlok.Checked = Convert.ToBoolean(grdBranch.CurrentRow.Cells["BLOCKEDFLG"].Value);
            chkAbroad.Checked = Convert.ToBoolean(grdBranch.CurrentRow.Cells["ABROADFLG"].Value);
        }


    }
}
