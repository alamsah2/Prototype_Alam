using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PrototypePOS
{
    public partial class UserLogin : Form
    {
        private DBPOS db;
        private int current = 0;
        private List<User> users;

        public UserLogin()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(1000);
            t.Abort();
            InitializeComponent();
        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db = new DBPOS();
            users = db.GetUserAccounts();
            current = 0;

            if (String.IsNullOrEmpty(txtBxUserName.Text) && String.IsNullOrEmpty(txtBxPassword.Text))
            {
                lblLoginErrorMsg.Text = "Please ensure all fields are entered";
                txtBxUserName.ResetText();
                txtBxPassword.ResetText();
            }
            else if (users.Exists(u => u.Username.Equals(txtBxUserName.Text)))
            {
                current = users.FindIndex(u => u.Username.Equals(txtBxUserName.Text));
                if (users[current].Username.Equals(txtBxUserName.Text) && users[current].Password.Equals(txtBxPassword.Text))
                {
                    lblLoginErrorMsg.Text = "";
                    txtBxUserName.ResetText();
                    txtBxPassword.ResetText();
                    MessageBox.Show(string.Format("Welcome {0}! Your AccountType is {1}.", users[current].Username, users[current].AccountType));
                    UserControlPanel cp = new UserControlPanel();
                    cp.CurrentUser = users[current];
                    cp.ShowDialog();
                }
            }

            else
            {
                txtBxUserName.ResetText();
                txtBxPassword.ResetText();
                lblLoginErrorMsg.Text = "Either the username or password was incorrect.";
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            //txtBxPassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLoginErrorMsg.Text = "";
            txtBxPassword.PasswordChar = '\u2022';
        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}