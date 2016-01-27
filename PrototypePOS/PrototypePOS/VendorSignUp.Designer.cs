namespace PrototypePOS
{
    partial class VendorSignUp
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
            this.btnCreateVendor = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPasswordVendor = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.lblAddVendorError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateVendor
            // 
            this.btnCreateVendor.Location = new System.Drawing.Point(97, 290);
            this.btnCreateVendor.Name = "btnCreateVendor";
            this.btnCreateVendor.Size = new System.Drawing.Size(75, 23);
            this.btnCreateVendor.TabIndex = 0;
            this.btnCreateVendor.Text = "Create";
            this.btnCreateVendor.UseVisualStyleBackColor = true;
            this.btnCreateVendor.Click += new System.EventHandler(this.btnCreateVendor_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(41, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 14);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username:";
            // 
            // lblPasswordVendor
            // 
            this.lblPasswordVendor.AutoSize = true;
            this.lblPasswordVendor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordVendor.Location = new System.Drawing.Point(36, 110);
            this.lblPasswordVendor.Name = "lblPasswordVendor";
            this.lblPasswordVendor.Size = new System.Drawing.Size(66, 14);
            this.lblPasswordVendor.TabIndex = 3;
            this.lblPasswordVendor.Text = "Password:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(36, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 14);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Create Vendor Account";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(142, 61);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(100, 20);
            this.txtBxUsername.TabIndex = 6;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(142, 103);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtBxPassword.TabIndex = 7;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(142, 157);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(100, 20);
            this.txtBxEmail.TabIndex = 8;
            // 
            // lblAddVendorError
            // 
            this.lblAddVendorError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddVendorError.ForeColor = System.Drawing.Color.Red;
            this.lblAddVendorError.Location = new System.Drawing.Point(36, 209);
            this.lblAddVendorError.Name = "lblAddVendorError";
            this.lblAddVendorError.Size = new System.Drawing.Size(206, 41);
            this.lblAddVendorError.TabIndex = 9;
            // 
            // VendorSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 340);
            this.Controls.Add(this.lblAddVendorError);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPasswordVendor);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnCreateVendor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendorSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VendorSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateVendor;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPasswordVendor;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label lblAddVendorError;
    }
}