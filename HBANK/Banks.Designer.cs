namespace HBANK
{
    partial class Banks
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
            this.grdBanks = new System.Windows.Forms.DataGridView();
            this.dataBANKCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataKatilim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataAbroad = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataBlocked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataCreUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCreDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataModUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataModDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBanks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBanks
            // 
            this.grdBanks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBanks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataBANKCODE,
            this.dataDescription,
            this.dataKatilim,
            this.dataAbroad,
            this.dataBlocked,
            this.dataCreUser,
            this.dataCreDate,
            this.dataModUser,
            this.dataModDate});
            this.grdBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBanks.Location = new System.Drawing.Point(0, 0);
            this.grdBanks.Name = "grdBanks";
            this.grdBanks.Size = new System.Drawing.Size(820, 205);
            this.grdBanks.TabIndex = 0;
            this.grdBanks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBanks_CellValueChanged);
            this.grdBanks.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdBanks_UserDeletedRow);
            // 
            // dataBANKCODE
            // 
            this.dataBANKCODE.DataPropertyName = "BANKCODE";
            this.dataBANKCODE.HeaderText = "Bank Code";
            this.dataBANKCODE.Name = "dataBANKCODE";
            this.dataBANKCODE.Visible = false;
            // 
            // dataDescription
            // 
            this.dataDescription.DataPropertyName = "DESCRIPTION";
            this.dataDescription.HeaderText = "Description";
            this.dataDescription.Name = "dataDescription";
            // 
            // dataKatilim
            // 
            this.dataKatilim.DataPropertyName = "KATILIM_FLG";
            this.dataKatilim.HeaderText = "Katılım Status";
            this.dataKatilim.Name = "dataKatilim";
            // 
            // dataAbroad
            // 
            this.dataAbroad.DataPropertyName = "ABROAD_FLG";
            this.dataAbroad.HeaderText = "Abroad Status";
            this.dataAbroad.Name = "dataAbroad";
            // 
            // dataBlocked
            // 
            this.dataBlocked.DataPropertyName = "BLOCKED_FLG";
            this.dataBlocked.HeaderText = "Blocked Status";
            this.dataBlocked.Name = "dataBlocked";
            // 
            // dataCreUser
            // 
            this.dataCreUser.DataPropertyName = "CREUSER";
            this.dataCreUser.HeaderText = "Cre User";
            this.dataCreUser.Name = "dataCreUser";
            // 
            // dataCreDate
            // 
            this.dataCreDate.DataPropertyName = "CREDATE";
            this.dataCreDate.HeaderText = "Cre Date";
            this.dataCreDate.Name = "dataCreDate";
            // 
            // dataModUser
            // 
            this.dataModUser.DataPropertyName = "MODUSER";
            this.dataModUser.HeaderText = "Mod User";
            this.dataModUser.Name = "dataModUser";
            // 
            // dataModDate
            // 
            this.dataModDate.DataPropertyName = "MODDATE";
            this.dataModDate.HeaderText = "Mod Date";
            this.dataModDate.Name = "dataModDate";
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 205);
            this.Controls.Add(this.grdBanks);
            this.Name = "Banks";
            this.Text = "Banks";
            this.Load += new System.EventHandler(this.Banks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBanks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBanks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBANKCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataKatilim;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataAbroad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataBlocked;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCreUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCreDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModDate;
    }
}