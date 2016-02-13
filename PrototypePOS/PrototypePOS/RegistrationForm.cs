using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace PrototypePOS
{
    public partial class RegistrationForm : Form
    {
        private List<User> users;
        private int current = 0;

        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            txtBxCVC.MaxLength = 3;
            txtBxCreditCardNo.MaxLength = 16;
            txtBxMobileNo.MaxLength = 8;
            txtBxSixDigitPIN.MaxLength = 6;
            txtBxCreditCardNo.MaxLength = 16;

            lblErrorRegistration.Text = "";
            txtBxPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtBxPassword.PasswordChar = '\u2022';
            panelPg2.Visible = false;
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            DBPOS dbp = new DBPOS();
         
            //start of validation
            if (String.IsNullOrEmpty(txtBxUsername.Text) || String.IsNullOrEmpty(txtBxPassword.Text) ||
                   String.IsNullOrEmpty(txtBxFirstName.Text) || String.IsNullOrEmpty(txtBxLastName.Text) ||
                     String.IsNullOrEmpty(txtBxEmail.Text) || String.IsNullOrEmpty(txtBxAddress.Text) ||
                      String.IsNullOrEmpty(txtBxMobileNo.Text))


            {
                lblErrorRegistration.Text = "Please ensure all fields are entered";
                lblErrorRegistration.Visible = true;


            }
            else if (dbp.ValidateUsername(txtBxUsername.Text) == false)
            {
                lblErrorRegistration.Text = string.Format("Username \'{0}\' already exists!",txtBxUsername.Text);
                lblErrorRegistration.Visible = true;
            }
            else if (!Regex.Match(txtBxMobileNo.Text, @"^+\d{0,9}$").Success)
            {
                lblErrorRegistration.Text = "Please enter a valid Mobile Number";
                lblErrorRegistration.Visible = true;
            }
            else if (!Regex.Match(txtBxEmail.Text, @"(@)(.+)$").Success)
            {
                lblErrorRegistration.Text = "Please enter a valid Email";
                lblErrorRegistration.Visible = true;
            }
            else {
                lblErrorRegistration.Text = "";
                panelPg1.Visible = false;
                panelPg2.Visible = true;
            } //end of validation
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            panelPg1.Visible = false;
            panelPg2.Visible = true;
            DialogResult dr;

            DBPOS dbp = new DBPOS();
            string cardType = "";
            if (radioMasterVisa.Checked)
            {
                cardType = radioMasterVisa.Text;
            }

            else if (radioAmericanExp.Checked)
            {
                cardType = radioAmericanExp.Text;
            }

            

            if (String.IsNullOrEmpty(txtBxCreditCardName.Text) || String.IsNullOrEmpty(txtBxCreditCardNo.Text) ||
                   String.IsNullOrEmpty(txtBxCVC.Text) || String.IsNullOrEmpty(txtBxSixDigitPIN.Text) ||
                    !radioAmericanExp.Checked && !radioMasterVisa.Checked)
            {
                dr = MessageBox.Show("Are you sure you want to skip Entering Credit Card Details? (Can be entered later)",
                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.No)
                {
                    MessageBox.Show(
                           "Please ensure that you have fill in all your credit card credentials to complete your payment.",
                           "Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Exclamation);
                }
                else {
                    dbp.InsertAccount(txtBxEmail.Text, txtBxUsername.Text, txtBxPassword.Text, "GETDATE()", 1);
                    dbp.InsertCustomer(dbp.GetAccountID(txtBxUsername.Text), txtBxFirstName.Text, txtBxLastName.Text, txtBxMobileNo.Text, dtpDOB.Value.Date);
                    MessageBox.Show("Your account has been created, without payment");
                    this.Close();
                }

            }

            else
            {
                dbp.InsertAccount(txtBxEmail.Text, txtBxUsername.Text, txtBxPassword.Text, "GETDATE()", 1);
                dbp.InsertCustomer(dbp.GetAccountID(txtBxUsername.Text), txtBxFirstName.Text, txtBxLastName.Text, txtBxMobileNo.Text, dtpDOB.Value.Date);
                dbp.InsertCreditCard(dbp.GetAccountID(txtBxUsername.Text), txtBxCreditCardName.Text, long.Parse(txtBxCreditCardNo.Text), dtpExpiryDate.Value,int.Parse(txtBxCVC.Text), int.Parse(txtBxSixDigitPIN.Text), cardType);
                MessageBox.Show("Your account has been created, with payment");
                this.Close();
            }
        }
    }
}