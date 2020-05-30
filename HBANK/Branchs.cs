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
    public partial class Branchs : Form
    {
        public Branchs()
        {
            InitializeComponent();
        }
        public User user;
        List<Bank> banks = new List<Bank>();
        bool isNew;

        private void Branchs_Load(object sender, EventArgs e)
        {
            //Sayfa açılışında gride şubeleri getir.
            getBranchs();
            GetBanks();
            setNull();
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
                banks.Add(bank);
            }
        }

        public void getBranchs()
        {
            string query = @"SELECT  BR.*,B.DESCRIPTION AS BANKNAME from BRANCHS BR
                                JOIN BANKS AS B ON B.BANKCODE=BR.BANKCODE";
            SqlDataAdapter adapter = new SqlDataAdapter(query, BaseMethods.ConnectionString());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            grdBranch.DataSource = dt;
        }

        private void grdBranch_SelectionChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(grdBranch.CurrentRow.Cells["BRANCHCODE"].Value.ToString()))
            {
                txtEmail.Text = grdBranch.CurrentRow.Cells["EMAIL"].Value.ToString();
                txtDesc.Text = grdBranch.CurrentRow.Cells["DESCRIPTION"].Value.ToString();
                txtBankNumber.Text = grdBranch.CurrentRow.Cells["BANKNUMBER"].Value.ToString();

                foreach (var item in banks)
                {
                    if (item.BANKCODE == grdBranch.CurrentRow.Cells["BANKCODE"].Value.ToString())
                        cmbBank.SelectedItem = item;
                }
                //cmbBank.SelectedItem = grdBranch.CurrentRow.Cells["BANKNAME"].Value.ToString();
                cmbCurrency.Text = grdBranch.CurrentRow.Cells["CURRENCYCODE"].Value.ToString();
                cmbBankCity.Text = grdBranch.CurrentRow.Cells["BANKCITY"].Value.ToString();
                chkPassive.Checked = Convert.ToBoolean(grdBranch.CurrentRow.Cells["PASSIVEFLG"].Value);
                chkBlok.Checked = Convert.ToBoolean(grdBranch.CurrentRow.Cells["BLOCKEDFLG"].Value);
                chkAbroad.Checked = Convert.ToBoolean(grdBranch.CurrentRow.Cells["ABROADFLG"].Value);
                isNew = false;
            }
            else
            {
                setNull();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DBConnection connection = new DBConnection();

            if (grdBranch.CurrentRow != null)
            {
                var connectionDb = connection.ConnectionOpen();
                var command = connection.getQuery("SaveOrUpdateBranch");
                command.CommandType = CommandType.StoredProcedure;
                DataGridViewRow row = grdBranch.CurrentRow;
                command.Parameters.AddWithValue("@BRANCHCODE",!isNew? row.Cells["BRANCHCODE"].Value:0);
                var bank = cmbBank.SelectedItem as Bank; //as ve is kullanımları 
                command.Parameters.AddWithValue("@BANKCODE", bank.BANKCODE);
                command.Parameters.AddWithValue("@CURRENCYCODE", cmbCurrency.SelectedItem);
                command.Parameters.AddWithValue("@DESCRIPTION", txtDesc.Text);
                command.Parameters.AddWithValue("@BANKCITY", cmbBankCity.SelectedItem);
                command.Parameters.AddWithValue("@PASSIVE_FLG", chkPassive.Checked);
                command.Parameters.AddWithValue("@ABROAD_FLG", chkAbroad.Checked);
                command.Parameters.AddWithValue("@BLOCKED_FLG", chkBlok.Checked);
                command.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                command.Parameters.AddWithValue("@BANKNUMBER", txtBankNumber.Text);
                command.Parameters.AddWithValue("@CREDATE", !isNew ? row.Cells["CREDATE"].Value : DateTime.Now);
                command.Parameters.AddWithValue("@CREUSER", !isNew ? row.Cells["CREUSER"].Value : user.FULL_NAME);
                command.Parameters.AddWithValue("@MODUSER", user.FULL_NAME);
                command.Parameters.AddWithValue("@MODDATE", DateTime.Now);
                command.ExecuteNonQuery();
                connectionDb.Close();
                getBranchs();
            }
        }


        public void setNull()
        {
            cmbBank.SelectedItem = null;
            cmbCurrency.SelectedItem = null;
            txtDesc.Text = null;
            cmbBankCity.SelectedItem = null;
            txtBankNumber.Text = null;
            txtEmail.Text = null;
            chkAbroad.Checked = false;
            chkBlok.Checked = false;
            chkPassive.Checked = false;
            isNew = true;
        }
    }
}
