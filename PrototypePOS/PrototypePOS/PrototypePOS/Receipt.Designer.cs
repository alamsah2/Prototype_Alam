namespace PrototypePOS
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.txtbxRecipt = new System.Windows.Forms.TextBox();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnCloseTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxRecipt
            // 
            this.txtbxRecipt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxRecipt.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxRecipt.Location = new System.Drawing.Point(0, 0);
            this.txtbxRecipt.Multiline = true;
            this.txtbxRecipt.Name = "txtbxRecipt";
            this.txtbxRecipt.Size = new System.Drawing.Size(413, 556);
            this.txtbxRecipt.TabIndex = 0;
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(108, 562);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(57, 32);
            this.btnPrintReceipt.TabIndex = 1;
            this.btnPrintReceipt.Text = "&Print";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.PrintReceipt);
            // 
            // btnCloseTransaction
            // 
            this.btnCloseTransaction.Location = new System.Drawing.Point(221, 562);
            this.btnCloseTransaction.Name = "btnCloseTransaction";
            this.btnCloseTransaction.Size = new System.Drawing.Size(57, 32);
            this.btnCloseTransaction.TabIndex = 2;
            this.btnCloseTransaction.Text = "&OK";
            this.btnCloseTransaction.UseVisualStyleBackColor = true;
            this.btnCloseTransaction.Click += new System.EventHandler(this.CloseReceipt);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 601);
            this.Controls.Add(this.btnCloseTransaction);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.txtbxRecipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptGUI";
            this.Load += new System.EventHandler(this.ReceiptGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxRecipt;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnCloseTransaction;
    }
}