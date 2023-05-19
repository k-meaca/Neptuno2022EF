namespace Neptuno2022EF.Windows
{
    partial class frmPayAccount2
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
            this.lblClientFullName = new System.Windows.Forms.Label();
            this.lblAccountFrom = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDivision1 = new System.Windows.Forms.Panel();
            this.dgvDataDebts = new System.Windows.Forms.DataGridView();
            this.lblDebts = new System.Windows.Forms.Label();
            this.dgvPartialPayment = new System.Windows.Forms.DataGridView();
            this.lblPartialPayment = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gboxTotalPayment = new System.Windows.Forms.GroupBox();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.gboxPartialPayment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPartialAmount = new System.Windows.Forms.Label();
            this.btnPartialPayment = new System.Windows.Forms.Button();
            this.btnFullPayment = new System.Windows.Forms.Button();
            this.lblTotalAmmount = new System.Windows.Forms.Label();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovementPartial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmountPartial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataDebts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartialPayment)).BeginInit();
            this.gboxTotalPayment.SuspendLayout();
            this.gboxPartialPayment.SuspendLayout();
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
            this.pnlInfo.Size = new System.Drawing.Size(840, 37);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblClientFullName
            // 
            this.lblClientFullName.AutoSize = true;
            this.lblClientFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientFullName.Location = new System.Drawing.Point(112, 8);
            this.lblClientFullName.Name = "lblClientFullName";
            this.lblClientFullName.Size = new System.Drawing.Size(138, 17);
            this.lblClientFullName.TabIndex = 3;
            this.lblClientFullName.Text = "Client\'s Full Name";
            // 
            // lblAccountFrom
            // 
            this.lblAccountFrom.AutoSize = true;
            this.lblAccountFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountFrom.Location = new System.Drawing.Point(11, 8);
            this.lblAccountFrom.Name = "lblAccountFrom";
            this.lblAccountFrom.Size = new System.Drawing.Size(95, 17);
            this.lblAccountFrom.TabIndex = 2;
            this.lblAccountFrom.Text = "Account of :";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Neptuno2022EF.Windows.Properties.Resources.close_window_32px;
            this.btnClose.Location = new System.Drawing.Point(807, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 27);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDivision1
            // 
            this.pnlDivision1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDivision1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDivision1.Location = new System.Drawing.Point(0, 37);
            this.pnlDivision1.Name = "pnlDivision1";
            this.pnlDivision1.Size = new System.Drawing.Size(840, 5);
            this.pnlDivision1.TabIndex = 1;
            // 
            // dgvDataDebts
            // 
            this.dgvDataDebts.AllowUserToAddRows = false;
            this.dgvDataDebts.AllowUserToDeleteRows = false;
            this.dgvDataDebts.AllowUserToResizeColumns = false;
            this.dgvDataDebts.AllowUserToResizeRows = false;
            this.dgvDataDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colMovement,
            this.colAmount});
            this.dgvDataDebts.Location = new System.Drawing.Point(12, 87);
            this.dgvDataDebts.Name = "dgvDataDebts";
            this.dgvDataDebts.ReadOnly = true;
            this.dgvDataDebts.RowHeadersVisible = false;
            this.dgvDataDebts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataDebts.Size = new System.Drawing.Size(371, 209);
            this.dgvDataDebts.TabIndex = 3;
            // 
            // lblDebts
            // 
            this.lblDebts.AutoSize = true;
            this.lblDebts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebts.Location = new System.Drawing.Point(13, 57);
            this.lblDebts.Name = "lblDebts";
            this.lblDebts.Size = new System.Drawing.Size(50, 17);
            this.lblDebts.TabIndex = 4;
            this.lblDebts.Text = "Debts";
            // 
            // dgvPartialPayment
            // 
            this.dgvPartialPayment.AllowUserToAddRows = false;
            this.dgvPartialPayment.AllowUserToDeleteRows = false;
            this.dgvPartialPayment.AllowUserToResizeColumns = false;
            this.dgvPartialPayment.AllowUserToResizeRows = false;
            this.dgvPartialPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartialPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colMovementPartial,
            this.colAmountPartial});
            this.dgvPartialPayment.Location = new System.Drawing.Point(458, 87);
            this.dgvPartialPayment.Name = "dgvPartialPayment";
            this.dgvPartialPayment.ReadOnly = true;
            this.dgvPartialPayment.RowHeadersVisible = false;
            this.dgvPartialPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartialPayment.Size = new System.Drawing.Size(371, 209);
            this.dgvPartialPayment.TabIndex = 3;
            // 
            // lblPartialPayment
            // 
            this.lblPartialPayment.AutoSize = true;
            this.lblPartialPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartialPayment.Location = new System.Drawing.Point(455, 57);
            this.lblPartialPayment.Name = "lblPartialPayment";
            this.lblPartialPayment.Size = new System.Drawing.Size(122, 17);
            this.lblPartialPayment.TabIndex = 4;
            this.lblPartialPayment.Text = "Partial Payment";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(103, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(564, 302);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(173, 43);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gboxTotalPayment
            // 
            this.gboxTotalPayment.Controls.Add(this.lblTotalAmmount);
            this.gboxTotalPayment.Controls.Add(this.label2);
            this.gboxTotalPayment.Controls.Add(this.btnFullPayment);
            this.gboxTotalPayment.Controls.Add(this.lblTotalDebt);
            this.gboxTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxTotalPayment.Location = new System.Drawing.Point(235, 506);
            this.gboxTotalPayment.Name = "gboxTotalPayment";
            this.gboxTotalPayment.Size = new System.Drawing.Size(370, 116);
            this.gboxTotalPayment.TabIndex = 6;
            this.gboxTotalPayment.TabStop = false;
            this.gboxTotalPayment.Text = "CANCEL ALL DEBTS";
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Location = new System.Drawing.Point(17, 57);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(94, 17);
            this.lblTotalDebt.TabIndex = 0;
            this.lblTotalDebt.Text = "Total Debt: ";
            // 
            // gboxPartialPayment
            // 
            this.gboxPartialPayment.Controls.Add(this.lblPartialAmount);
            this.gboxPartialPayment.Controls.Add(this.label1);
            this.gboxPartialPayment.Controls.Add(this.btnPartialPayment);
            this.gboxPartialPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPartialPayment.Location = new System.Drawing.Point(235, 351);
            this.gboxPartialPayment.Name = "gboxPartialPayment";
            this.gboxPartialPayment.Size = new System.Drawing.Size(370, 116);
            this.gboxPartialPayment.TabIndex = 6;
            this.gboxPartialPayment.TabStop = false;
            this.gboxPartialPayment.Text = "PARTIAL PAYMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, -117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount: ";
            // 
            // lblPartialAmount
            // 
            this.lblPartialAmount.AutoSize = true;
            this.lblPartialAmount.Location = new System.Drawing.Point(127, 50);
            this.lblPartialAmount.Name = "lblPartialAmount";
            this.lblPartialAmount.Size = new System.Drawing.Size(44, 17);
            this.lblPartialAmount.TabIndex = 0;
            this.lblPartialAmount.Text = "$$$$";
            // 
            // btnPartialPayment
            // 
            this.btnPartialPayment.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPartialPayment.Location = new System.Drawing.Point(227, 37);
            this.btnPartialPayment.Name = "btnPartialPayment";
            this.btnPartialPayment.Size = new System.Drawing.Size(106, 43);
            this.btnPartialPayment.TabIndex = 5;
            this.btnPartialPayment.Text = "PAY";
            this.btnPartialPayment.UseVisualStyleBackColor = false;
            this.btnPartialPayment.Click += new System.EventHandler(this.btnPartialPayment_Click);
            // 
            // btnFullPayment
            // 
            this.btnFullPayment.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFullPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFullPayment.Location = new System.Drawing.Point(227, 44);
            this.btnFullPayment.Name = "btnFullPayment";
            this.btnFullPayment.Size = new System.Drawing.Size(106, 43);
            this.btnFullPayment.TabIndex = 5;
            this.btnFullPayment.Text = "FULL PAYMENT";
            this.btnFullPayment.UseVisualStyleBackColor = false;
            this.btnFullPayment.Click += new System.EventHandler(this.btnFullPayment_Click);
            // 
            // lblTotalAmmount
            // 
            this.lblTotalAmmount.AutoSize = true;
            this.lblTotalAmmount.Location = new System.Drawing.Point(127, 57);
            this.lblTotalAmmount.Name = "lblTotalAmmount";
            this.lblTotalAmmount.Size = new System.Drawing.Size(44, 17);
            this.lblTotalAmmount.TabIndex = 0;
            this.lblTotalAmmount.Text = "$$$$";
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
            // colAmount
            // 
            this.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMovementPartial
            // 
            this.colMovementPartial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMovementPartial.HeaderText = "Movement";
            this.colMovementPartial.Name = "colMovementPartial";
            this.colMovementPartial.ReadOnly = true;
            this.colMovementPartial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmountPartial
            // 
            this.colAmountPartial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAmountPartial.HeaderText = "Amount";
            this.colAmountPartial.Name = "colAmountPartial";
            this.colAmountPartial.ReadOnly = true;
            this.colAmountPartial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmPayAccount2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 634);
            this.ControlBox = false;
            this.Controls.Add(this.gboxPartialPayment);
            this.Controls.Add(this.gboxTotalPayment);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPartialPayment);
            this.Controls.Add(this.lblDebts);
            this.Controls.Add(this.dgvPartialPayment);
            this.Controls.Add(this.dgvDataDebts);
            this.Controls.Add(this.pnlDivision1);
            this.Controls.Add(this.pnlInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPayAccount2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debts From Client";
            this.Load += new System.EventHandler(this.frmPayAccount2_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataDebts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartialPayment)).EndInit();
            this.gboxTotalPayment.ResumeLayout(false);
            this.gboxTotalPayment.PerformLayout();
            this.gboxPartialPayment.ResumeLayout(false);
            this.gboxPartialPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblClientFullName;
        private System.Windows.Forms.Label lblAccountFrom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDivision1;
        private System.Windows.Forms.DataGridView dgvDataDebts;
        private System.Windows.Forms.Label lblDebts;
        private System.Windows.Forms.DataGridView dgvPartialPayment;
        private System.Windows.Forms.Label lblPartialPayment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gboxTotalPayment;
        private System.Windows.Forms.Label lblTotalAmmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFullPayment;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.GroupBox gboxPartialPayment;
        private System.Windows.Forms.Label lblPartialAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPartialPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovementPartial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmountPartial;
    }
}