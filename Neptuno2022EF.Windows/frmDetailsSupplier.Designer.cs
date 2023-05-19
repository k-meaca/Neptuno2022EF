namespace Neptuno2022EF.Windows
{
    partial class frmDetailsSupplier
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
            this.fullNameBox = new System.Windows.Forms.GroupBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPostalCod = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.fullNameBox.SuspendLayout();
            this.locationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullNameBox
            // 
            this.fullNameBox.Controls.Add(this.txtFullName);
            this.fullNameBox.Controls.Add(this.lblFullName);
            this.fullNameBox.Location = new System.Drawing.Point(22, 13);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(423, 59);
            this.fullNameBox.TabIndex = 0;
            this.fullNameBox.TabStop = false;
            this.fullNameBox.Text = "Full Name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(30, 25);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name :";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFullName.Enabled = false;
            this.txtFullName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFullName.Location = new System.Drawing.Point(98, 22);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(295, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // locationBox
            // 
            this.locationBox.Controls.Add(this.txtAddress);
            this.locationBox.Controls.Add(this.txtCountry);
            this.locationBox.Controls.Add(this.txtPostalCod);
            this.locationBox.Controls.Add(this.label4);
            this.locationBox.Controls.Add(this.txtCity);
            this.locationBox.Controls.Add(this.label3);
            this.locationBox.Controls.Add(this.label1);
            this.locationBox.Controls.Add(this.label2);
            this.locationBox.Location = new System.Drawing.Point(22, 79);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(423, 140);
            this.locationBox.TabIndex = 1;
            this.locationBox.TabStop = false;
            this.locationBox.Text = "Location of Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Country :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "City :";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Info;
            this.txtCity.Enabled = false;
            this.txtCity.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCity.Location = new System.Drawing.Point(98, 52);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(295, 20);
            this.txtCity.TabIndex = 1;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Info;
            this.txtCountry.Enabled = false;
            this.txtCountry.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCountry.Location = new System.Drawing.Point(98, 24);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(295, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Postal Cod :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address :";
            // 
            // txtPostalCod
            // 
            this.txtPostalCod.BackColor = System.Drawing.SystemColors.Info;
            this.txtPostalCod.Enabled = false;
            this.txtPostalCod.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPostalCod.Location = new System.Drawing.Point(98, 108);
            this.txtPostalCod.Name = "txtPostalCod";
            this.txtPostalCod.Size = new System.Drawing.Size(295, 20);
            this.txtPostalCod.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Enabled = false;
            this.txtAddress.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddress.Location = new System.Drawing.Point(98, 80);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(295, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(22, 225);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(423, 36);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmDetailsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 268);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.fullNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetailsSupplier";
            this.ShowIcon = false;
            this.Text = "Details Supplier";
            this.fullNameBox.ResumeLayout(false);
            this.fullNameBox.PerformLayout();
            this.locationBox.ResumeLayout(false);
            this.locationBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox fullNameBox;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.GroupBox locationBox;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtPostalCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
    }
}