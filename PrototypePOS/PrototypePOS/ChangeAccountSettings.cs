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
        private User user;

        public User CurrentUser
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public ChangeAccountSettings()
        {
            InitializeComponent();
        }

        public void ChangeAccountSettings_Load(object sender, EventArgs e)
        {
            txtBxPasswordNew.PasswordChar = '\u2022';
            txtBxCVC.MaxLength = 3;
            txtBxCreditCardNo.MaxLength = 16;
            txtBxMobileNoNew.MaxLength = 8;
            txtBxSixDigitPIN.MaxLength = 6;
            txtBxCreditCardNo.MaxLength = 16;
            if (user.AccountType == "Administrator" || user.AccountType == "Vendor")
            {
                dbp = new DBPOS();
                users = dbp.GetUserAccounts();
                panelPg2.Visible = true;
                CustPanel.Visible = false;
                PassEmailPanel.Visible = true;
                panelPg3.Visible = false;
                PassEmailPanel.Location = new Point(37, 31);
                txtBxPasswordNew.Text = users[0].Password;
                txtBxEmailNew.Text = users[0].Email;
            }
            else {
                dbp = new DBPOS();
                users = dbp.GetUserInfo(user.AccountID);
                txtBxFirstNameNew.Text = users[0].FirstName;
                txtBxLastNameNew.Text = users[0].LastName;
                txtBxMobileNoNew.Text = users[0].MobileNo.ToString();
                txtBxPasswordNew.Text = users[0].Password;
                txtBxEmailNew.Text = users[0].Email;

                panelPg2.Visible = true;
                panelPg3.Visible = false;
            }
            }


        private void btnCreditCardDetails_Click(object sender, EventArgs e)
        {
            panelPg2.Visible = false;
            panelPg3.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dbp = new DBPOS();
            dbp.UpdateAccount(txtBxPasswordNew.Text,txtBxEmailNew.Text,user.Username);
            dbp.UpdateCustomer(txtBxFirstNameNew.Text, txtBxLastNameNew.Text, txtBxMobileNoNew.Text,user.Username);
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
            dbp.UpdateAccount(txtBxEmailNew.Text, txtBxPasswordNew.Text, user.Username);
            dbp.UpdateCustomer(txtBxFirstNameNew.Text, txtBxLastNameNew.Text, txtBxMobileNoNew.Text, user.Username);
            dbp.InsertCreditCard(dbp.GetAccountID(user.Username), txtBxCreditCardName.Text, long.Parse(txtBxCreditCardNo.Text), dtpExpiryDate.Value, int.Parse(txtBxCVC.Text), int.Parse(txtBxSixDigitPIN.Text), cardType);

            MessageBox.Show("Your account has been updated, with payment changes");
            this.Close();

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

        
    }
}
