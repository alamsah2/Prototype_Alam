namespace PrototypePOS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnOpenPOS = new System.Windows.Forms.Button();
            this.btnGenerateSalesReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPOS
            // 
            this.btnOpenPOS.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenPOS.Location = new System.Drawing.Point(52, 129);
            this.btnOpenPOS.Name = "btnOpenPOS";
            this.btnOpenPOS.Size = new System.Drawing.Size(211, 99);
            this.btnOpenPOS.TabIndex = 0;
            this.btnOpenPOS.Text = "&Open POS";
            this.btnOpenPOS.UseVisualStyleBackColor = false;
            this.btnOpenPOS.Click += new System.EventHandler(this.btnOpenPOS_Click);
            // 
            // btnGenerateSalesReport
            // 
            this.btnGenerateSalesReport.Location = new System.Drawing.Point(338, 129);
            this.btnGenerateSalesReport.Name = "btnGenerateSalesReport";
            this.btnGenerateSalesReport.Size = new System.Drawing.Size(211, 99);
            this.btnGenerateSalesReport.TabIndex = 1;
            this.btnGenerateSalesReport.Text = "&Generate Sales Report";
            this.btnGenerateSalesReport.UseVisualStyleBackColor = true;
            this.btnGenerateSalesReport.Click += new System.EventHandler(this.GenerateSalesReport);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 364);
            this.Controls.Add(this.btnGenerateSalesReport);
            this.Controls.Add(this.btnOpenPOS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prototype Apparels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPOS;
        private System.Windows.Forms.Button btnGenerateSalesReport;
    }
}