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
    public partial class PasswordInput : Form
    {
        private Store store;

        //Properties
        public Store Store
        {
            get { return store; }
            set { store = value; }
        }

        //Constructor
        public PasswordInput()
        {
            InitializeComponent();
        }

        //Methods & Event Handlers
        private void PasswordInput_Load(object sender, EventArgs e)
        {
            txtbxPassword.PasswordChar = '*';
        }

        private void ValidatePasswordAndCreateSalesReport(object sender, EventArgs e)
        {
            
            if(txtbxPassword.Text.Equals("ProtoType"))
            {
                store.GenerateSalesReport();
                MessageBox.Show("Sales Report has been generated. Please check the \'Sales Report\' folder.");
                DialogResult dialogResult = MessageBox.Show("Do you wish to print the sales report?", "Print Sales Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    store.PrintSalesReport();
                    this.Close();
                }

                else if(dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Have a nice day!");
                    this.Close();
                }

                else
                {
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("Invalid password!\r\nFailed to create sales report.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbxPassword.ResetText();
            }
        }

        private void CloseForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
