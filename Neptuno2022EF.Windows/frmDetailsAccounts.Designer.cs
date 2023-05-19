namespace Neptuno2022EF.Windows
{
    partial class frmDetailsAccounts
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
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblClientFullName = new System.Windows.Forms.Label();
            this.lblAccountFrom = new System.Windows.Forms.Label();
            this.pnlDivision1 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnClose);
            this.pnlInfo.Controls.Add(this.lblClientFullName);
            this.pnlInfo.Controls.Add(this.lblAccountFrom);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(504, 37);
            this.pnlInfo.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Neptuno2022EF.Windows.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(471, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblClientFullName
            // 
            this.lblClientFullName.AutoSize = true;
            this.lblClientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFullName.Location = new System.Drawing.Point(104, 8);
            this.lblClientFullName.Name = "lblClientFullName";
            this.lblClientFullName.Size = new System.Drawing.Size(138, 17);
            this.lblClientFullName.TabIndex = 3;
            this.lblClientFullName.Text = "Client\'s Full Name";
            // 
            // lblAccountFrom
            // 
            this.lblAccountFrom.AutoSize = true;
            this.lblAccountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountFrom.Location = new System.Drawing.Point(3, 8);
            this.lblAccountFrom.Name = "lblAccountFrom";
            this.lblAccountFrom.Size = new System.Drawing.Size(95, 17);
            this.lblAccountFrom.TabIndex = 2;
            this.lblAccountFrom.Text = "Account of :";
            // 
            // pnlDivision1
            // 
            this.pnlDivision1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDivision1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivision1.Location = new System.Drawing.Point(0, 37);
            this.pnlDivision1.Name = "pnlDivision1";
            this.pnlDivision1.Size = new System.Drawing.Size(504, 5);
            this.pnlDivision1.TabIndex = 3;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblAmount);
            this.pnlBottom.Controls.Add(this.lblBalance);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 405);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(504, 45);
            this.pnlBottom.TabIndex = 4;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colMovement,
            this.colDebt,
            this.colCredit});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 42);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(504, 363);
            this.dgvData.TabIndex = 5;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMovement
            // 
            this.colMovement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMovement.HeaderText = "Movement";
            this.colMovement.Name = "colMovement";
            this.colMovement.ReadOnly = true;
            this.colMovement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDebt
            // 
            this.colDebt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDebt.HeaderText = "Debt";
            this.colDebt.Name = "colDebt";
            this.colDebt.ReadOnly = true;
            this.colDebt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCredit
            // 
            this.colCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCredit.HeaderText = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.ReadOnly = true;
            this.colCredit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(354, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(62, 17);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "$$$$$$";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(269, 19);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(76, 17);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance :";
            // 
            // frmDetailsAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlDivision1);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetailsAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Details";
            this.Load += new System.EventHandler(this.frmDetailsAccounts_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblClientFullName;
        private System.Windows.Forms.Label lblAccountFrom;
        private System.Windows.Forms.Panel pnlDivision1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCredit;
    }
}