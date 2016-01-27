namespace PrototypePOS
{
    partial class LoadVendor
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
            this.lblLoadVendorTitle = new System.Windows.Forms.Label();
            this.lblLoadVendorDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoadVendorTitle
            // 
            this.lblLoadVendorTitle.AutoSize = true;
            this.lblLoadVendorTitle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadVendorTitle.Location = new System.Drawing.Point(24, 24);
            this.lblLoadVendorTitle.Name = "lblLoadVendorTitle";
            this.lblLoadVendorTitle.Size = new System.Drawing.Size(233, 22);
            this.lblLoadVendorTitle.TabIndex = 0;
            this.lblLoadVendorTitle.Text = "Available Vendor Details";
            // 
            // lblLoadVendorDetails
            // 
            this.lblLoadVendorDetails.Location = new System.Drawing.Point(12, 71);
            this.lblLoadVendorDetails.Name = "lblLoadVendorDetails";
            this.lblLoadVendorDetails.Size = new System.Drawing.Size(260, 181);
            this.lblLoadVendorDetails.TabIndex = 1;
            this.lblLoadVendorDetails.Click += new System.EventHandler(this.lblLoadVendorDetails_Click);
            // 
            // LoadVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblLoadVendorDetails);
            this.Controls.Add(this.lblLoadVendorTitle);
            this.Name = "LoadVendor";
            this.Text = "LoadVendor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadVendorTitle;
        private System.Windows.Forms.Label lblLoadVendorDetails;
    }
}