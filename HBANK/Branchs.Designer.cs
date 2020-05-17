namespace HBANK
{
    partial class Branchs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBankCity = new System.Windows.Forms.ComboBox();
            this.chkPassive = new System.Windows.Forms.CheckBox();
            this.chkAbroad = new System.Windows.Forms.CheckBox();
            this.chkBlok = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBankNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdBranch = new System.Windows.Forms.DataGridView();
            this.BRANCHCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANKCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANKNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENCYCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANKCITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSIVEFLG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ABROADFLG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BLOCKEDFLG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BANKNUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBranch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank";
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(93, 20);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(208, 21);
            this.cmbBank.TabIndex = 1;
            this.cmbBank.SelectedIndexChanged += new System.EventHandler(this.cmbBank_SelectedIndexChanged);
            this.cmbBank.Click += new System.EventHandler(this.cmbBank_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Currency";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Items.AddRange(new object[] {
            "TL",
            "EUR",
            "USD",
            "AUD",
            "CAD",
            "NZD",
            "JPY",
            "GBP"});
            this.cmbCurrency.Location = new System.Drawing.Point(93, 50);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(208, 21);
            this.cmbCurrency.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(93, 80);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(208, 20);
            this.txtDesc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bank City";
            // 
            // cmbBankCity
            // 
            this.cmbBankCity.FormattingEnabled = true;
            this.cmbBankCity.Items.AddRange(new object[] {
            "İSTANBUL",
            "BALIKESİR",
            "ARTVİN",
            "MARDİN",
            "BURSA",
            "NEVŞEHİR",
            "ANTALYA",
            "DİYARBAKIR",
            "YOZGAT",
            "ANKARA",
            "MUŞ",
            "İZMİT",
            "İZMİR"});
            this.cmbBankCity.Location = new System.Drawing.Point(406, 20);
            this.cmbBankCity.Name = "cmbBankCity";
            this.cmbBankCity.Size = new System.Drawing.Size(208, 21);
            this.cmbBankCity.TabIndex = 7;
            // 
            // chkPassive
            // 
            this.chkPassive.AutoSize = true;
            this.chkPassive.Location = new System.Drawing.Point(635, 24);
            this.chkPassive.Name = "chkPassive";
            this.chkPassive.Size = new System.Drawing.Size(63, 17);
            this.chkPassive.TabIndex = 8;
            this.chkPassive.Text = "Passive";
            this.chkPassive.UseVisualStyleBackColor = true;
            // 
            // chkAbroad
            // 
            this.chkAbroad.AutoSize = true;
            this.chkAbroad.Location = new System.Drawing.Point(635, 52);
            this.chkAbroad.Name = "chkAbroad";
            this.chkAbroad.Size = new System.Drawing.Size(60, 17);
            this.chkAbroad.TabIndex = 9;
            this.chkAbroad.Text = "Abroad";
            this.chkAbroad.UseVisualStyleBackColor = true;
            // 
            // chkBlok
            // 
            this.chkBlok.AutoSize = true;
            this.chkBlok.Location = new System.Drawing.Point(635, 81);
            this.chkBlok.Name = "chkBlok";
            this.chkBlok.Size = new System.Drawing.Size(65, 17);
            this.chkBlok.TabIndex = 10;
            this.chkBlok.Text = "Blocked";
            this.chkBlok.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(406, 50);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(208, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-Mail";
            // 
            // txtBankNumber
            // 
            this.txtBankNumber.Location = new System.Drawing.Point(406, 78);
            this.txtBankNumber.Name = "txtBankNumber";
            this.txtBankNumber.Size = new System.Drawing.Size(208, 20);
            this.txtBankNumber.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bank Number";
            // 
            // grdBranch
            // 
            this.grdBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BRANCHCODE,
            this.BANKCODE,
            this.BANKNAME,
            this.CURRENCYCODE,
            this.DESCRIPTION,
            this.BANKCITY,
            this.PASSIVEFLG,
            this.ABROADFLG,
            this.BLOCKEDFLG,
            this.EMAIL,
            this.BANKNUMBER,
            this.CREUSER,
            this.CREDATE,
            this.MODDATE,
            this.MODUSER});
            this.grdBranch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdBranch.Location = new System.Drawing.Point(0, 146);
            this.grdBranch.Name = "grdBranch";
            this.grdBranch.Size = new System.Drawing.Size(870, 160);
            this.grdBranch.TabIndex = 15;
            this.grdBranch.SelectionChanged += new System.EventHandler(this.grdBranch_SelectionChanged);
            // 
            // BRANCHCODE
            // 
            this.BRANCHCODE.DataPropertyName = "BRANCHCODE";
            this.BRANCHCODE.HeaderText = "BranchCode";
            this.BRANCHCODE.Name = "BRANCHCODE";
            // 
            // BANKCODE
            // 
            this.BANKCODE.DataPropertyName = "BANKCODE";
            this.BANKCODE.HeaderText = "BankCode";
            this.BANKCODE.Name = "BANKCODE";
            // 
            // BANKNAME
            // 
            this.BANKNAME.DataPropertyName = "BANKNAME";
            this.BANKNAME.HeaderText = "BankName";
            this.BANKNAME.Name = "BANKNAME";
            // 
            // CURRENCYCODE
            // 
            this.CURRENCYCODE.DataPropertyName = "CURRENCYCODE";
            this.CURRENCYCODE.HeaderText = "CurrencyCode";
            this.CURRENCYCODE.Name = "CURRENCYCODE";
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.DataPropertyName = "DESCRIPTION";
            this.DESCRIPTION.HeaderText = "Description";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // BANKCITY
            // 
            this.BANKCITY.DataPropertyName = "BANKCITY";
            this.BANKCITY.HeaderText = "BankCity";
            this.BANKCITY.Name = "BANKCITY";
            // 
            // PASSIVEFLG
            // 
            this.PASSIVEFLG.DataPropertyName = "PASSIVE_FLG";
            this.PASSIVEFLG.HeaderText = "Passive";
            this.PASSIVEFLG.Name = "PASSIVEFLG";
            // 
            // ABROADFLG
            // 
            this.ABROADFLG.DataPropertyName = "ABROAD_FLG";
            this.ABROADFLG.HeaderText = "Abroad";
            this.ABROADFLG.Name = "ABROADFLG";
            // 
            // BLOCKEDFLG
            // 
            this.BLOCKEDFLG.DataPropertyName = "BLOCKED_FLG";
            this.BLOCKEDFLG.HeaderText = "Blocked";
            this.BLOCKEDFLG.Name = "BLOCKEDFLG";
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMail";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EMAIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BANKNUMBER
            // 
            this.BANKNUMBER.DataPropertyName = "BANKNUMBER";
            this.BANKNUMBER.HeaderText = "BankNumber";
            this.BANKNUMBER.Name = "BANKNUMBER";
            // 
            // CREUSER
            // 
            this.CREUSER.DataPropertyName = "CREUSER";
            this.CREUSER.HeaderText = "CreUser";
            this.CREUSER.Name = "CREUSER";
            // 
            // CREDATE
            // 
            this.CREDATE.DataPropertyName = "CREDATE";
            this.CREDATE.HeaderText = "CreDate";
            this.CREDATE.Name = "CREDATE";
            // 
            // MODDATE
            // 
            this.MODDATE.DataPropertyName = "MODDATE";
            this.MODDATE.HeaderText = "ModDate";
            this.MODDATE.Name = "MODDATE";
            // 
            // MODUSER
            // 
            this.MODUSER.DataPropertyName = "MODUSER";
            this.MODUSER.HeaderText = "ModUser";
            this.MODUSER.Name = "MODUSER";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(757, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(757, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Branchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 306);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grdBranch);
            this.Controls.Add(this.txtBankNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkBlok);
            this.Controls.Add(this.chkAbroad);
            this.Controls.Add(this.chkPassive);
            this.Controls.Add(this.cmbBankCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.label1);
            this.Name = "Branchs";
            this.Text = "Branchs";
            this.Load += new System.EventHandler(this.Branchs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBankCity;
        private System.Windows.Forms.CheckBox chkPassive;
        private System.Windows.Forms.CheckBox chkAbroad;
        private System.Windows.Forms.CheckBox chkBlok;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBankNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdBranch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRANCHCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANKCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANKNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENCYCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANKCITY;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PASSIVEFLG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ABROADFLG;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BLOCKEDFLG;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BANKNUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODUSER;
    }
}