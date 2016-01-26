using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public partial class Payment : Form
    {
        private decimal total = 0, beforeDiscount = 0, cashPaymentInput = 0, changeDue = 0, discountedAmount = 0;
        private bool hasDiscount;
        private BindingList<Apparel> transactionItems;
        private BindingList<Discount> discountCodes;

        //Constuctor
        public Payment()
        {
            InitializeComponent();

            discountCodes = new BindingList<Discount>();
        }

        //Properties
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public BindingList<Apparel> TransactionItems
        {
            get { return transactionItems; }
            set { transactionItems = value; }
        }

        public BindingList<Discount> DiscountCodes
        {
            get { return discountCodes; }
            set { discountCodes = value; }
        }

        //Methods & Event Handlers
        public delegate void PaymentMadeEvent(object sender, PaymentMadeEventArgs e);

        public event PaymentMadeEvent PaymentMade;

        private void Payment_Load(object sender, EventArgs e)
        {
            ScaleApplication();

            paymentlbl.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            creditCardNumTxtbx.MaxLength = 12;
            CvcTxtbx.MaxLength = 3;

            txtbxDiscountCode.CharacterCasing = CharacterCasing.Upper;
            discountAppliedStatuslbl.Visible = false;

            if (String.IsNullOrEmpty(txtbxDiscountCode.Text))
            {
                btnResetDiscount.Visible = false;
                btnResetDiscount.Enabled = false;
            }
        }

        private void ScaleApplication()
        {
            float width_ratio = (Screen.PrimaryScreen.Bounds.Width / 1280);
            float heigh_ratio = (Screen.PrimaryScreen.Bounds.Height / 800);

            SizeF scale = new SizeF(width_ratio, heigh_ratio);
            Scale(scale);
        }

        private void ValidateDiscountCode(object sender, EventArgs e)
        {
            string currentCode = txtbxDiscountCode.Text;
            beforeDiscount = total;

            //Empty/Null Discount Code
            if (String.IsNullOrEmpty(txtbxDiscountCode.Text))
            {
                btnResetDiscount.Visible = false;
                btnResetDiscount.Enabled = false;
            }

            //Foreach loop to check if discount code input existed
            foreach (Discount discountCode in discountCodes)
            {
                //If discount code exist
                if (discountCode.Code.Equals(currentCode.ToUpper()))
                {
                    txtbxDiscountCode.Enabled = false;
                    btnResetDiscount.Visible = true;
                    btnResetDiscount.Enabled = true;
                    btnApplyDiscountCode.Enabled = false;

                    discountedAmount = (beforeDiscount * (decimal)discountCode.Rate);
                    discountAppliedStatuslbl.Visible = true;
                    discountAppliedStatuslbl.ForeColor = Color.Green;
                    discountAppliedStatuslbl.Text = string.Format(
                        "The discount code \'{0}\' applied eligible you for {1}% discount! \r\nYour net total has been updated.",
                        discountCode.Code, discountCode.Rate * 100);

                    total = beforeDiscount * (decimal)(1 - discountCode.Rate);
                    paymentlbl.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    hasDiscount = true;
                    break;
                }

                //If discount code do not exist at all
                discountAppliedStatuslbl.Visible = true;
                discountAppliedStatuslbl.ForeColor = Color.Red;
                discountAppliedStatuslbl.Text = string.Format(
                    "The discount code \'{0}\' does not exist, hence no discount was given.",
                    currentCode.ToUpper());
            }//End of foreach loop
            txtbxDiscountCode.ResetText();
        }

        private void ResetDiscountApplied(object sender, EventArgs e)
        {
            txtbxDiscountCode.ResetText();
            txtbxDiscountCode.Enabled = true;

            discountAppliedStatuslbl.Visible = true;
            discountAppliedStatuslbl.ForeColor = Color.Gray;
            discountAppliedStatuslbl.Text = "Discount has been removed, your net notal has been updated.";

            hasDiscount = false;
            total = beforeDiscount;
            paymentlbl.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            btnResetDiscount.Visible = false;
            btnResetDiscount.Enabled = false;

            btnApplyDiscountCode.Enabled = true;
        }

        private void CancelTransaction(object sender, EventArgs e)
        {
            PaymentMade(this, new PaymentMadeEventArgs() { SuccessfulPayment = false });
            this.Close();
        }

        //When confirm button is pressed (Print receipt upon successful payment input)
        private void MakePayment(object sender, EventArgs e)
        {
            if (!cashPaymentRadio.Checked || !creditCardRadio.Checked) //First conditon checking if a mode of payment was selected
            {
                //Payment mode: Credit Card
                if (creditCardRadio.Checked) 
                {
                    //All credentials not filled in
                    if (String.IsNullOrEmpty(custNameTxtbx.Text) || String.IsNullOrEmpty(creditCardNumTxtbx.Text) ||
                        String.IsNullOrEmpty(CvcTxtbx.Text) || !radioAmericanExp.Checked && !radioMasterVisa.Checked)
                    {
                        MessageBox.Show(
                        "Please ensure that you have fill in all your credit card credentials to complete your payment.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    }

                    //All credentials were filled in with valid input
                    else
                    {
                        string cardType = "";
                        if (radioMasterVisa.Checked) {
                            cardType = radioMasterVisa.Text;
                        }

                        if (radioAmericanExp.Checked)
                        {
                            cardType = radioAmericanExp.Text;
                        }
                            /*When a successful payment is made, the PaymentMadeEvent will be invoked and send a boolean value of true to the POS*/
                            PaymentMade(
                                this,
                                new PaymentMadeEventArgs()
                                {
                                    SuccessfulPayment = true,
                                    IsCreditCardPayment = true,
                                    IsCashPayment = false,
                                    HasDiscount = hasDiscount,
                                    BeforeDiscountTotalAmount = beforeDiscount,
                                    DiscountedValue = discountedAmount,
                                    Total = total,
                                    CardType = cardType,
                                    CreditCardHolderName = custNameTxtbx.Text,
                                    CreditCardNumber = creditCardNumTxtbx.Text,
                                    TransactionItems = transactionItems
                                });
                            this.Close();
                    }
                }
                
                //Payment mode: CASH
                else if (cashPaymentRadio.Checked) 
                {
                    //Checks for valid & correct payment amount
                    if (String.IsNullOrEmpty(txtbxCashPayment.Text) ||
                        decimal.TryParse(txtbxCashPayment.Text, out cashPaymentInput) == false ||
                        cashPaymentInput <= 0) 
                    {
                        MessageBox.Show(
                        "Please ensure you have entered a valid & correct payment value for your purchase.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    }

                    //Checks for input amount > total amount user suppose to pay
                    else if (cashPaymentInput < total)
                    { 
                        MessageBox.Show(
                        "Please ensure you have entered at least " + total.ToString("C", CultureInfo.CreateSpecificCulture("en-US")),
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    }
                    
                    //If valid and correct payment amount was input, shows receipt
                    else
                    {
                        cashPaymentInput = decimal.Parse(txtbxCashPayment.Text);
                        changeDue = cashPaymentInput - total;

                        //Display Change if the change amount is > 0
                        if (changeDue > 0)
                        {
                            MessageBox.Show("Your change is " + changeDue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")), "Change Due", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        
                        PaymentMade(
                            this,
                            new PaymentMadeEventArgs()
                            { SuccessfulPayment = true,
                              IsCashPayment = true,
                              HasDiscount = hasDiscount,
                              BeforeDiscountTotalAmount = beforeDiscount,
                              DiscountedValue = discountedAmount,
                              Total = total,
                              CashPaymentInput = cashPaymentInput,
                              ChangeDue = changeDue,
                              TransactionItems = transactionItems
                            });
                        this.Close();
                    }
                }
                
                //Checks if no payment mode was selected
                else
                { 
                    MessageBox.Show(
                    "Please ensure that you have chose your preferred mode of payment.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }
                //PaymentMade(this, new PaymentMadeEventArgs() { PaymentSuccess = true });
            } //Ends of no payment mode selected if conditional check
        }

        private void BackToStore(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choseCashPayment(object sender, EventArgs e)
        {
            cashPaymentGrpbx.Visible = true;
            creditCardPaymentGrpbx.Visible = false;
        }

        private void choseCreditCardPayment(object sender, EventArgs e)
        {
            creditCardPaymentGrpbx.Visible = true;
            cashPaymentGrpbx.Visible = false;
        }
    }

    //Inner class for the EventsArgs for PaymentMade
        public class PaymentMadeEventArgs : EventArgs
    {
        private bool successfulPayment, isCreditCardPayment, isCashPayment, hasDiscount;
        private string creditCardHolderName, cardType, creditCardNumber;
        private decimal total, cashPaymentInput, changeDue, discountedValue, beforeDiscountTotalAmount;
        private BindingList<Apparel> transactionItems;

        //Properties
        public string CreditCardHolderName
        {
            get { return creditCardHolderName; }
            set { creditCardHolderName = value; }
        }

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        public string CreditCardNumber
        {
            get { return creditCardNumber; }
            set { creditCardNumber = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public decimal CashPaymentInput
        {
            get { return cashPaymentInput; }
            set {  cashPaymentInput = value; }
        }

        public decimal ChangeDue
        {
            get { return changeDue; }
            set { changeDue = value; }
        }

        public decimal DiscountedValue
        {
            get { return discountedValue; }

            set { discountedValue = value; }
        }

        public decimal BeforeDiscountTotalAmount
        {
            get { return beforeDiscountTotalAmount; }

            set { beforeDiscountTotalAmount = value; }
        }

        public bool SuccessfulPayment
        {
            get { return successfulPayment; }
            set { successfulPayment = value; }
        }

        public bool IsCashPayment
        {
            get { return isCashPayment; }
            set { isCashPayment = value; }
        }

        public bool IsCreditCardPayment
        {
            get { return isCreditCardPayment; }
            set { isCreditCardPayment = value; }
        }

        public bool HasDiscount
        {
            get { return hasDiscount; }
            set { hasDiscount = value; }
        }

        public BindingList<Apparel> TransactionItems
        {
            get { return transactionItems; }
            set { transactionItems = value; }
        }
    }
}
