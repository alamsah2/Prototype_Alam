namespace PrototypePOS
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custNameTxtbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.creditCardNumTxtbx = new System.Windows.Forms.TextBox();
            this.CvcTxtbx = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbxDiscountCode = new System.Windows.Forms.TextBox();
            this.paymentConfirmbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentlbl = new System.Windows.Forms.Label();
            this.btnApplyDiscountCode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.creditCardPaymentGrpbx = new System.Windows.Forms.GroupBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.radioAmericanExp = new System.Windows.Forms.RadioButton();
            this.radioMasterVisa = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cashPaymentGrpbx = new System.Windows.Forms.GroupBox();
            this.txtbxCashPayment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cashPaymentRadio = new System.Windows.Forms.RadioButton();
            this.creditCardRadio = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.discountAppliedStatuslbl = new System.Windows.Forms.Label();
            this.btnResetDiscount = new System.Windows.Forms.Button();
            this.btnCancelPayment = new System.Windows.Forms.Button();
            this.creditCardPaymentGrpbx.SuspendLayout();
            this.cashPaymentGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose your mode of payment below, to complete your purchase!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card Holder Name :";
            // 
            // custNameTxtbx
            // 
            this.custNameTxtbx.Location = new System.Drawing.Point(180, 56);
            this.custNameTxtbx.Name = "custNameTxtbx";
            this.custNameTxtbx.Size = new System.Drawing.Size(290, 23);
            this.custNameTxtbx.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CVC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expiry Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Card Number :";
            // 
            // creditCardNumTxtbx
            // 
            this.creditCardNumTxtbx.Location = new System.Drawing.Point(180, 92);
            this.creditCardNumTxtbx.Name = "creditCardNumTxtbx";
            this.creditCardNumTxtbx.Size = new System.Drawing.Size(178, 23);
            this.creditCardNumTxtbx.TabIndex = 6;
            // 
            // CvcTxtbx
            // 
            this.CvcTxtbx.Location = new System.Drawing.Point(180, 166);
            this.CvcTxtbx.Name = "CvcTxtbx";
            this.CvcTxtbx.Size = new System.Drawing.Size(115, 23);
            this.CvcTxtbx.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "&?";
            this.toolTip1.SetToolTip(this.label6, "Month/Year e.g. 05/19");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "&?";
            this.toolTip1.SetToolTip(this.label8, "The last 3 digit at the back of your credit card");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Discount Code :";
            // 
            // txtbxDiscountCode
            // 
            this.txtbxDiscountCode.Location = new System.Drawing.Point(146, 335);
            this.txtbxDiscountCode.Name = "txtbxDiscountCode";
            this.txtbxDiscountCode.Size = new System.Drawing.Size(223, 23);
            this.txtbxDiscountCode.TabIndex = 11;
            // 
            // paymentConfirmbtn
            // 
            this.paymentConfirmbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.paymentConfirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentConfirmbtn.Location = new System.Drawing.Point(20, 411);
            this.paymentConfirmbtn.Name = "paymentConfirmbtn";
            this.paymentConfirmbtn.Size = new System.Drawing.Size(243, 56);
            this.paymentConfirmbtn.TabIndex = 13;
            this.paymentConfirmbtn.Text = "&Confirm";
            this.paymentConfirmbtn.UseVisualStyleBackColor = false;
            this.paymentConfirmbtn.Click += new System.EventHandler(this.MakePayment);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 33);
            this.label9.TabIndex = 14;
            this.label9.Text = "Total Amount to Pay :";
            // 
            // paymentlbl
            // 
            this.paymentlbl.AutoSize = true;
            this.paymentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentlbl.Location = new System.Drawing.Point(248, 72);
            this.paymentlbl.Name = "paymentlbl";
            this.paymentlbl.Size = new System.Drawing.Size(54, 20);
            this.paymentlbl.TabIndex = 15;
            this.paymentlbl.Text = "$0.00";
            // 
            // btnApplyDiscountCode
            // 
            this.btnApplyDiscountCode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApplyDiscountCode.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyDiscountCode.Location = new System.Drawing.Point(382, 335);
            this.btnApplyDiscountCode.Name = "btnApplyDiscountCode";
            this.btnApplyDiscountCode.Size = new System.Drawing.Size(61, 27);
            this.btnApplyDiscountCode.TabIndex = 16;
            this.btnApplyDiscountCode.Text = "&Apply";
            this.btnApplyDiscountCode.UseVisualStyleBackColor = true;
            this.btnApplyDiscountCode.Click += new System.EventHandler(this.ValidateDiscountCode);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Back to shop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackToStore);
            // 
            // creditCardPaymentGrpbx
            // 
            this.creditCardPaymentGrpbx.Controls.Add(this.dtpExpiryDate);
            this.creditCardPaymentGrpbx.Controls.Add(this.radioAmericanExp);
            this.creditCardPaymentGrpbx.Controls.Add(this.radioMasterVisa);
            this.creditCardPaymentGrpbx.Controls.Add(this.label12);
            this.creditCardPaymentGrpbx.Controls.Add(this.label2);
            this.creditCardPaymentGrpbx.Controls.Add(this.label3);
            this.creditCardPaymentGrpbx.Controls.Add(this.label4);
            this.creditCardPaymentGrpbx.Controls.Add(this.label5);
            this.creditCardPaymentGrpbx.Controls.Add(this.custNameTxtbx);
            this.creditCardPaymentGrpbx.Controls.Add(this.label8);
            this.creditCardPaymentGrpbx.Controls.Add(this.creditCardNumTxtbx);
            this.creditCardPaymentGrpbx.Controls.Add(this.CvcTxtbx);
            this.creditCardPaymentGrpbx.Controls.Add(this.label6);
            this.creditCardPaymentGrpbx.Location = new System.Drawing.Point(20, 128);
            this.creditCardPaymentGrpbx.Name = "creditCardPaymentGrpbx";
            this.creditCardPaymentGrpbx.Size = new System.Drawing.Size(501, 201);
            this.creditCardPaymentGrpbx.TabIndex = 18;
            this.creditCardPaymentGrpbx.TabStop = false;
            this.creditCardPaymentGrpbx.Visible = false;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.CustomFormat = "MM/yy";
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpiryDate.Location = new System.Drawing.Point(180, 128);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.ShowUpDown = true;
            this.dtpExpiryDate.Size = new System.Drawing.Size(89, 23);
            this.dtpExpiryDate.TabIndex = 16;
            // 
            // radioAmericanExp
            // 
            this.radioAmericanExp.AutoSize = true;
            this.radioAmericanExp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAmericanExp.Location = new System.Drawing.Point(271, 23);
            this.radioAmericanExp.Name = "radioAmericanExp";
            this.radioAmericanExp.Size = new System.Drawing.Size(139, 20);
            this.radioAmericanExp.TabIndex = 15;
            this.radioAmericanExp.TabStop = true;
            this.radioAmericanExp.Text = "American Express";
            this.radioAmericanExp.UseVisualStyleBackColor = true;
            // 
            // radioMasterVisa
            // 
            this.radioMasterVisa.AutoSize = true;
            this.radioMasterVisa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMasterVisa.Location = new System.Drawing.Point(112, 23);
            this.radioMasterVisa.Name = "radioMasterVisa";
            this.radioMasterVisa.Size = new System.Drawing.Size(128, 20);
            this.radioMasterVisa.TabIndex = 14;
            this.radioMasterVisa.TabStop = true;
            this.radioMasterVisa.Text = "Mastercard/Visa";
            this.radioMasterVisa.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Card Type :";
            // 
            // cashPaymentGrpbx
            // 
            this.cashPaymentGrpbx.Controls.Add(this.txtbxCashPayment);
            this.cashPaymentGrpbx.Controls.Add(this.label10);
            this.cashPaymentGrpbx.Location = new System.Drawing.Point(28, 159);
            this.cashPaymentGrpbx.Name = "cashPaymentGrpbx";
            this.cashPaymentGrpbx.Size = new System.Drawing.Size(501, 130);
            this.cashPaymentGrpbx.TabIndex = 19;
            this.cashPaymentGrpbx.TabStop = false;
            this.cashPaymentGrpbx.Visible = false;
            // 
            // txtbxCashPayment
            // 
            this.txtbxCashPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxCashPayment.Location = new System.Drawing.Point(149, 50);
            this.txtbxCashPayment.Name = "txtbxCashPayment";
            this.txtbxCashPayment.Size = new System.Drawing.Size(178, 23);
            this.txtbxCashPayment.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Your payment :";
            // 
            // cashPaymentRadio
            // 
            this.cashPaymentRadio.AutoSize = true;
            this.cashPaymentRadio.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPaymentRadio.Location = new System.Drawing.Point(171, 110);
            this.cashPaymentRadio.Name = "cashPaymentRadio";
            this.cashPaymentRadio.Size = new System.Drawing.Size(54, 21);
            this.cashPaymentRadio.TabIndex = 20;
            this.cashPaymentRadio.TabStop = true;
            this.cashPaymentRadio.Text = "Cash";
            this.cashPaymentRadio.UseVisualStyleBackColor = true;
            this.cashPaymentRadio.Click += new System.EventHandler(this.choseCashPayment);
            // 
            // creditCardRadio
            // 
            this.creditCardRadio.AutoSize = true;
            this.creditCardRadio.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditCardRadio.Location = new System.Drawing.Point(253, 110);
            this.creditCardRadio.Name = "creditCardRadio";
            this.creditCardRadio.Size = new System.Drawing.Size(88, 21);
            this.creditCardRadio.TabIndex = 21;
            this.creditCardRadio.TabStop = true;
            this.creditCardRadio.Text = "Credit Card";
            this.creditCardRadio.UseVisualStyleBackColor = true;
            this.creditCardRadio.Click += new System.EventHandler(this.choseCreditCardPayment);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mode of payment :";
            // 
            // discountAppliedStatuslbl
            // 
            this.discountAppliedStatuslbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountAppliedStatuslbl.ForeColor = System.Drawing.Color.Black;
            this.discountAppliedStatuslbl.Location = new System.Drawing.Point(28, 365);
            this.discountAppliedStatuslbl.Name = "discountAppliedStatuslbl";
            this.discountAppliedStatuslbl.Size = new System.Drawing.Size(496, 43);
            this.discountAppliedStatuslbl.TabIndex = 23;
            this.discountAppliedStatuslbl.Text = "Label";
            // 
            // btnResetDiscount
            // 
            this.btnResetDiscount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResetDiscount.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDiscount.Location = new System.Drawing.Point(456, 335);
            this.btnResetDiscount.Name = "btnResetDiscount";
            this.btnResetDiscount.Size = new System.Drawing.Size(61, 27);
            this.btnResetDiscount.TabIndex = 25;
            this.btnResetDiscount.Text = "&Reset";
            this.btnResetDiscount.UseVisualStyleBackColor = true;
            this.btnResetDiscount.Click += new System.EventHandler(this.ResetDiscountApplied);
            // 
            // btnCancelPayment
            // 
            this.btnCancelPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelPayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPayment.Location = new System.Drawing.Point(282, 411);
            this.btnCancelPayment.Name = "btnCancelPayment";
            this.btnCancelPayment.Size = new System.Drawing.Size(242, 56);
            this.btnCancelPayment.TabIndex = 26;
            this.btnCancelPayment.Text = "&Cancel Transaction";
            this.btnCancelPayment.UseVisualStyleBackColor = false;
            this.btnCancelPayment.Click += new System.EventHandler(this.CancelTransaction);
            // 
            // Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 440);
            this.Controls.Add(this.btnCancelPayment);
            this.Controls.Add(this.btnResetDiscount);
            this.Controls.Add(this.discountAppliedStatuslbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.creditCardRadio);
            this.Controls.Add(this.cashPaymentRadio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnApplyDiscountCode);
            this.Controls.Add(this.paymentlbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paymentConfirmbtn);
            this.Controls.Add(this.txtbxDiscountCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.creditCardPaymentGrpbx);
            this.Controls.Add(this.cashPaymentGrpbx);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(541, 479);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.creditCardPaymentGrpbx.ResumeLayout(false);
            this.creditCardPaymentGrpbx.PerformLayout();
            this.cashPaymentGrpbx.ResumeLayout(false);
            this.cashPaymentGrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custNameTxtbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox creditCardNumTxtbx;
        private System.Windows.Forms.TextBox CvcTxtbx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbxDiscountCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button paymentConfirmbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label paymentlbl;
        private System.Windows.Forms.Button btnApplyDiscountCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox creditCardPaymentGrpbx;
        private System.Windows.Forms.GroupBox cashPaymentGrpbx;
        private System.Windows.Forms.TextBox txtbxCashPayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton cashPaymentRadio;
        private System.Windows.Forms.RadioButton creditCardRadio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioAmericanExp;
        private System.Windows.Forms.RadioButton radioMasterVisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Label discountAppliedStatuslbl;
        private System.Windows.Forms.Button btnResetDiscount;
        private System.Windows.Forms.Button btnCancelPayment;
    }
}

