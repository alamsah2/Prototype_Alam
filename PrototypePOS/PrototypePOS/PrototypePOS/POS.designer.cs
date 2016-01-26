namespace PrototypePOS
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.lstCartItems = new System.Windows.Forms.ListBox();
            this.MCatalogue = new System.Windows.Forms.TabControl();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteFromCart = new System.Windows.Forms.Button();
            this.makePaymentbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.FCatalogue = new System.Windows.Forms.TabControl();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbxFemale = new System.Windows.Forms.GroupBox();
            this.grpbxMale = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radiobtnMaleCat = new System.Windows.Forms.RadioButton();
            this.radiobtnFemaleCat = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grpbxFemale.SuspendLayout();
            this.grpbxMale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCartItems
            // 
            this.lstCartItems.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCartItems.FormattingEnabled = true;
            this.lstCartItems.ItemHeight = 20;
            this.lstCartItems.Location = new System.Drawing.Point(12, 410);
            this.lstCartItems.Name = "lstCartItems";
            this.lstCartItems.Size = new System.Drawing.Size(521, 224);
            this.lstCartItems.TabIndex = 0;
            // 
            // MCatalogue
            // 
            this.MCatalogue.Location = new System.Drawing.Point(10, 42);
            this.MCatalogue.Name = "MCatalogue";
            this.MCatalogue.SelectedIndex = 0;
            this.MCatalogue.Size = new System.Drawing.Size(934, 263);
            this.MCatalogue.TabIndex = 1;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(725, 9);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(227, 38);
            this.lblStoreName.TabIndex = 2;
            this.lblStoreName.Text = "lblStoreName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Men\'s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cart";
            // 
            // btnDeleteFromCart
            // 
            this.btnDeleteFromCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteFromCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFromCart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFromCart.Location = new System.Drawing.Point(552, 472);
            this.btnDeleteFromCart.Name = "btnDeleteFromCart";
            this.btnDeleteFromCart.Size = new System.Drawing.Size(133, 50);
            this.btnDeleteFromCart.TabIndex = 5;
            this.btnDeleteFromCart.Text = "&Delete Item";
            this.btnDeleteFromCart.UseVisualStyleBackColor = false;
            this.btnDeleteFromCart.Click += new System.EventHandler(this.DeleteItemFromCart);
            // 
            // makePaymentbtn
            // 
            this.makePaymentbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.makePaymentbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makePaymentbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePaymentbtn.Location = new System.Drawing.Point(552, 554);
            this.makePaymentbtn.Name = "makePaymentbtn";
            this.makePaymentbtn.Size = new System.Drawing.Size(379, 80);
            this.makePaymentbtn.TabIndex = 6;
            this.makePaymentbtn.Text = "&Proceed to Payment";
            this.makePaymentbtn.UseVisualStyleBackColor = false;
            this.makePaymentbtn.Click += new System.EventHandler(this.MakePayment);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(708, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total :";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.BackColor = System.Drawing.Color.Black;
            this.lblTotalAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmt.Location = new System.Drawing.Point(764, 472);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(154, 26);
            this.lblTotalAmt.TabIndex = 8;
            this.lblTotalAmt.Text = "lblTotalAmount";
            // 
            // FCatalogue
            // 
            this.FCatalogue.Location = new System.Drawing.Point(10, 42);
            this.FCatalogue.Name = "FCatalogue";
            this.FCatalogue.SelectedIndex = 0;
            this.FCatalogue.Size = new System.Drawing.Size(934, 263);
            this.FCatalogue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Women\'s";
            // 
            // grpbxFemale
            // 
            this.grpbxFemale.BackColor = System.Drawing.Color.Transparent;
            this.grpbxFemale.Controls.Add(this.label5);
            this.grpbxFemale.Controls.Add(this.FCatalogue);
            this.grpbxFemale.Location = new System.Drawing.Point(12, 61);
            this.grpbxFemale.Name = "grpbxFemale";
            this.grpbxFemale.Size = new System.Drawing.Size(950, 319);
            this.grpbxFemale.TabIndex = 11;
            this.grpbxFemale.TabStop = false;
            this.grpbxFemale.Visible = false;
            // 
            // grpbxMale
            // 
            this.grpbxMale.Controls.Add(this.label2);
            this.grpbxMale.Controls.Add(this.MCatalogue);
            this.grpbxMale.Location = new System.Drawing.Point(12, 61);
            this.grpbxMale.Name = "grpbxMale";
            this.grpbxMale.Size = new System.Drawing.Size(950, 319);
            this.grpbxMale.TabIndex = 12;
            this.grpbxMale.TabStop = false;
            this.grpbxMale.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "Choose one of the gender to start shopping!";
            // 
            // radiobtnMaleCat
            // 
            this.radiobtnMaleCat.AutoSize = true;
            this.radiobtnMaleCat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.radiobtnMaleCat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnMaleCat.Location = new System.Drawing.Point(276, 9);
            this.radiobtnMaleCat.Name = "radiobtnMaleCat";
            this.radiobtnMaleCat.Size = new System.Drawing.Size(64, 23);
            this.radiobtnMaleCat.TabIndex = 14;
            this.radiobtnMaleCat.TabStop = true;
            this.radiobtnMaleCat.Text = "Male";
            this.radiobtnMaleCat.UseVisualStyleBackColor = false;
            this.radiobtnMaleCat.Click += new System.EventHandler(this.DisplayMaleProducts);
            // 
            // radiobtnFemaleCat
            // 
            this.radiobtnFemaleCat.AutoSize = true;
            this.radiobtnFemaleCat.BackColor = System.Drawing.Color.LightPink;
            this.radiobtnFemaleCat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnFemaleCat.Location = new System.Drawing.Point(276, 34);
            this.radiobtnFemaleCat.Name = "radiobtnFemaleCat";
            this.radiobtnFemaleCat.Size = new System.Drawing.Size(83, 23);
            this.radiobtnFemaleCat.TabIndex = 15;
            this.radiobtnFemaleCat.TabStop = true;
            this.radiobtnFemaleCat.Text = "Female";
            this.radiobtnFemaleCat.UseVisualStyleBackColor = false;
            this.radiobtnFemaleCat.Click += new System.EventHandler(this.DisplayFemaleProducts);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(548, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 48);
            this.label7.TabIndex = 16;
            this.label7.Text = "If you wish to edit your cart item, please delete the item from the cart first.";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(974, 640);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radiobtnFemaleCat);
            this.Controls.Add(this.radiobtnMaleCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTotalAmt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.makePaymentbtn);
            this.Controls.Add(this.btnDeleteFromCart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.lstCartItems);
            this.Controls.Add(this.grpbxMale);
            this.Controls.Add(this.grpbxFemale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(992, 687);
            this.MinimumSize = new System.Drawing.Size(992, 687);
            this.Name = "POS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Prototype Apparels";
            this.Load += new System.EventHandler(this.MainPOS_Load);
            this.grpbxFemale.ResumeLayout(false);
            this.grpbxFemale.PerformLayout();
            this.grpbxMale.ResumeLayout(false);
            this.grpbxMale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCartItems;
        private System.Windows.Forms.TabControl MCatalogue;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteFromCart;
        private System.Windows.Forms.Button makePaymentbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.TabControl FCatalogue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpbxFemale;
        private System.Windows.Forms.GroupBox grpbxMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radiobtnMaleCat;
        private System.Windows.Forms.RadioButton radiobtnFemaleCat;
        private System.Windows.Forms.Label label7;
    }
}