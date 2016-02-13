using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public partial class ChangeAccountSettings : Form
    {
        private DBPOS dbp;
        private int current = 0;
        private List<User> users;
        public ChangeAccountSettings()
        {
            InitializeComponent();
        }

        public void ChangeAccountSettings_Load(object sender, EventArgs e)
        {
            txtBxCVC.MaxLength = 3;
            txtBxCreditCardNo.MaxLength = 16;
            txtBxMobileNo.MaxLength = 8;
            txtBxSixDigitPIN.MaxLength = 6;
            txtBxCreditCardNo.MaxLength = 16;
            lblLoginErrorStatus.Text = "";
            panelPg1.Visible = true;
            panelPg2.Visible = false;
            panelPg3.Visible = false;
        }

        private void btnCreditCardDetails_Click(object sender, EventArgs e)
        {
            panelPg2.Visible = false;
            panelPg3.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbp = new DBPOS();
            dbp.UpdateAccount(txtBxPasswordNew.Text,txtBxEmailNew.Text,txtBxUsernameOld.Text);
            dbp.UpdateCustomer(txtBxFirstNameNew.Text, txtBxLastNameNew.Text, txtBxMobileNoNew.Text,txtBxUsernameOld.Text);
            MessageBox.Show("Your account has been updated, without payment changes");
            this.Close();
        }
        private void btnUpdateCreditCard_Click(object sender, EventArgs e)
        {
            string cardType = "";
            if (radioMasterVisa.Checked)
            {
                cardType = radioMasterVisa.Text;
            }

            else if (radioAmericanExp.Checked)
            {
                cardType = radioAmericanExp.Text;
            }

            dbp = new DBPOS();
            dbp.UpdateAccount(txtBxEmailNew.Text, txtBxPasswordNew.Text, txtBxUsernameOld.Text);
            dbp.UpdateCustomer(txtBxFirstNameNew.Text, txtBxLastNameNew.Text, txtBxMobileNoNew.Text, txtBxUsernameOld.Text);
            dbp.InsertCreditCard(dbp.GetAccountID(txtBxUsernameOld.Text), txtBxCreditCardName.Text, long.Parse(txtBxCreditCardNo.Text), dtpExpiryDate.Value, int.Parse(txtBxCVC.Text), int.Parse(txtBxSixDigitPIN.Text), cardType);

            MessageBox.Show("Your account has been updated, with payment changes");
            this.Close();

        }

        private void btnLoginVerification_Click(object sender, EventArgs e)
        {
            dbp = new DBPOS();
            users = dbp.GetUserAccounts();
            current = 0;

            if (String.IsNullOrEmpty(txtBxUsernameOld.Text) && String.IsNullOrEmpty(txtBxPasswordOld.Text))
            {
                lblLoginErrorStatus.Text = "Please ensure all fields are entered";
                txtBxUsernameOld.ResetText();
                txtBxPasswordOld.ResetText();
            }
            else if (users.Exists(u => u.Username.Equals(txtBxUsernameOld.Text)))
            {
                current = users.FindIndex(u => u.Username.Equals(txtBxUsernameOld.Text));
                if (users[current].Username.Equals(txtBxUsernameOld.Text) && users[current].Password.Equals(txtBxPasswordOld.Text))
                {
                    lblLoginErrorStatus.Text = "";
                    txtBxUsernameOld.ResetText();
                    txtBxPasswordOld.ResetText();
                    panelPg1.Visible = false;
                    panelPg2.Visible = true;
                }
            }
            else {
                txtBxUsernameOld.ResetText();
                txtBxPasswordOld.ResetText();
                lblLoginErrorStatus.Text = "Either the username or password was incorrect.";
            }
        }

        private void btnCancelpanel3_Click(object sender, EventArgs e)
        {
            panelPg3.Visible = false;
            panelPg2.Visible = true;
        }

        private void btnCancelpanel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
