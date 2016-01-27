using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
    public partial class VendorSignUp : Form
    {
        private string datasource, database;
        public VendorSignUp()
        {
            InitializeComponent();
        }

        private void btnCreateVendor_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBxUsername.Text) || String.IsNullOrEmpty(txtBxPassword.Text) || String.IsNullOrEmpty(txtBxEmail.Text))
            {
                lblAddVendorError.Text = "Please ensure all fields are entered";

            }
            else {

                DBPOS dbp = new DBPOS();
                dbp.InsertVendorAccount(txtBxEmail.Text, txtBxUsername.Text, txtBxPassword.Text, "GETDATE()");
                MessageBox.Show("Vendor account has been created.");
                txtBxEmail.Text = "";
                txtBxUsername.Text = "";
                txtBxPassword.Text = "";
                txtBxEmail.Text= "";
            }
        }

        private void VendorSignUp_Load(object sender, EventArgs e)
        {
            lblAddVendorError.Text = "";
            txtBxPassword.PasswordChar = '*';
        }
    }
}
