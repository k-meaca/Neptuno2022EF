namespace Neptuno2022EF.Windows
{
    partial class frmPayAccount
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
            this.lblAccountFrom = new System.Windows.Forms.Label();
            this.lblClientFullName = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblClientBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDolar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAccountFrom
            // 
            this.lblAccountFrom.AutoSize = true;
            this.lblAccountFrom.Location = new System.Drawing.Point(50, 26);
            this.lblAccountFrom.Name = "lblAccountFrom";
            this.lblAccountFrom.Size = new System.Drawing.Size(65, 13);
            this.lblAccountFrom.TabIndex = 0;
            this.lblAccountFrom.Text = "Account of :";
            // 
            // lblClientFullName
            // 
            this.lblClientFullName.AutoSize = true;
            this.lblClientFullName.Location = new System.Drawing.Point(121, 26);
            this.lblClientFullName.Name = "lblClientFullName";
            this.lblClientFullName.Size = new System.Drawing.Size(90, 13);
            this.lblClientFullName.TabIndex = 1;
            this.lblClientFullName.Text = "Client\'s Full Name";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(50, 60);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 13);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance     :";
            // 
            // lblClientBalance
            // 
            this.lblClientBalance.AutoSize = true;
            this.lblClientBalance.Location = new System.Drawing.Point(121, 60);
            this.lblClientBalance.Name = "lblClientBalance";
            this.lblClientBalance.Size = new System.Drawing.Size(37, 13);
            this.lblClientBalance.TabIndex = 1;
            this.lblClientBalance.Text = "$$$$$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make payment    :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(140, 87);
            this.txtAmount.MaxLength = 100;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAmount.Size = new System.Drawing.Size(86, 20);
            this.txtAmount.TabIndex = 2;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(232, 82);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(38, 29);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "$$";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(26, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(244, 28);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "C a n c e l";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(121, 90);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(13, 13);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "$";
            // 
            // frmPayAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 182);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblClientBalance);
            this.Controls.Add(this.lblClientFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccountFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPayAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountFrom;
        private System.Windows.Forms.Label lblClientFullName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblClientBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDolar;
    }
}