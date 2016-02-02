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
            this.btnLoadVendor = new System.Windows.Forms.Button();
            this.lvLoadVendor = new System.Windows.Forms.ListView();
            this.VendorID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VendorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContactNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblLoadVendorTitle
            // 
            this.lblLoadVendorTitle.AutoSize = true;
            this.lblLoadVendorTitle.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadVendorTitle.Location = new System.Drawing.Point(266, 9);
            this.lblLoadVendorTitle.Name = "lblLoadVendorTitle";
            this.lblLoadVendorTitle.Size = new System.Drawing.Size(145, 22);
            this.lblLoadVendorTitle.TabIndex = 0;
            this.lblLoadVendorTitle.Text = "Vendor Details";
            // 
            // btnLoadVendor
            // 
            this.btnLoadVendor.Location = new System.Drawing.Point(303, 41);
            this.btnLoadVendor.Name = "btnLoadVendor";
            this.btnLoadVendor.Size = new System.Drawing.Size(75, 23);
            this.btnLoadVendor.TabIndex = 2;
            this.btnLoadVendor.Text = "Load";
            this.btnLoadVendor.UseVisualStyleBackColor = true;
            this.btnLoadVendor.Click += new System.EventHandler(this.LoadVendors);
            // 
            // lvLoadVendor
            // 
            this.lvLoadVendor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VendorID,
            this.AccountID,
            this.VendorName,
            this.columnHeader1,
            this.ContactNumber});
            this.lvLoadVendor.Location = new System.Drawing.Point(12, 72);
            this.lvLoadVendor.Name = "lvLoadVendor";
            this.lvLoadVendor.Size = new System.Drawing.Size(654, 285);
            this.lvLoadVendor.TabIndex = 3;
            this.lvLoadVendor.UseCompatibleStateImageBehavior = false;
            this.lvLoadVendor.View = System.Windows.Forms.View.Details;
            // 
            // VendorID
            // 
            this.VendorID.Text = "VendorID";
            this.VendorID.Width = 62;
            // 
            // AccountID
            // 
            this.AccountID.Text = "AccountID";
            this.AccountID.Width = 71;
            // 
            // VendorName
            // 
            this.VendorName.Text = "Name";
            this.VendorName.Width = 201;
            // 
            // ContactNumber
            // 
            this.ContactNumber.Text = "Contact Number";
            this.ContactNumber.Width = 116;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 4;
            this.columnHeader1.Text = "ContactPerson";
            this.columnHeader1.Width = 173;
            // 
            // LoadVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 369);
            this.Controls.Add(this.lvLoadVendor);
            this.Controls.Add(this.btnLoadVendor);
            this.Controls.Add(this.lblLoadVendorTitle);
            this.Name = "LoadVendor";
            this.Text = "LoadVendor1111";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoadVendorTitle;
        private System.Windows.Forms.Button btnLoadVendor;
        private System.Windows.Forms.ListView lvLoadVendor;
        private System.Windows.Forms.ColumnHeader VendorID;
        private System.Windows.Forms.ColumnHeader AccountID;
        private System.Windows.Forms.ColumnHeader VendorName;
        private System.Windows.Forms.ColumnHeader ContactNumber;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}