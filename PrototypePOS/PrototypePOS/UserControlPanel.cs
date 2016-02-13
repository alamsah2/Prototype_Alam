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
    public partial class UserControlPanel : Form
    {
        private DBPOS db;
        private User user;

        //Properties
        public User CurrentUser
        {
            get { return user; }
            set { user = value; }
        }

        public UserControlPanel()
        {
            InitializeComponent();
        }

        public void CreateControls()
        {
            db = new DBPOS();

            switch(user.AccountType) {
                case "Administrator":
                case "Owner":
                    /*Administrator/Owner Control Panel*/
                    FlowLayoutPanel AdminPanel = new FlowLayoutPanel();
                    AdminPanel.AutoScroll = true;
                    AdminPanel.Size = new Size(581, 308);
                    AdminPanel.Location = new Point(10, 51);
                    AdminPanel.Padding = new Padding(5, 0, 5, 5);

                    Button viewPOSBtn = new Button();
                    viewPOSBtn.Size = new Size(124, 52);
                    viewPOSBtn.Text = "View Shop";
                    viewPOSBtn.Click += OpenPOS;

                    Button addVendorBtn = new Button();
                    addVendorBtn.Size = new Size(124, 52);
                    addVendorBtn.Text = "Add Vendor";
                    addVendorBtn.Click += OpenAddVendor;

                    Button addCategoryBtn = new Button();
                    addCategoryBtn.Size = new Size(124, 52);
                    addCategoryBtn.Text = "Add Category";

                    Button addProductBtn = new Button();
                    addProductBtn.Size = new Size(124, 52);
                    addProductBtn.Text = "Add Product";

                    Button viewVendorsBtn = new Button();
                    viewVendorsBtn.Size = new Size(124, 52);
                    viewVendorsBtn.Text = "View Vendors";
                    viewVendorsBtn.Click += OpenViewVendor;

                    Button viewProductsBtn = new Button();
                    viewProductsBtn.Size = new Size(124, 52);
                    viewProductsBtn.Text = "View Products";

                    Button salesReportBtn = new Button();
                    salesReportBtn.Size = new Size(124, 52);
                    salesReportBtn.Text = "Sales Report";

                    Button changeAccountDetailsBtn = new Button();
                    changeAccountDetailsBtn.Size = new Size(124, 52);
                    changeAccountDetailsBtn.Text = "Change Account Password";

                    this.Controls.Add(AdminPanel);
                    AdminPanel.Controls.Add(viewPOSBtn);
                    AdminPanel.Controls.Add(addVendorBtn);
                    AdminPanel.Controls.Add(addCategoryBtn);
                    AdminPanel.Controls.Add(addProductBtn);
                    AdminPanel.Controls.Add(viewVendorsBtn);
                    AdminPanel.Controls.Add(viewProductsBtn);
                    AdminPanel.Controls.Add(salesReportBtn);
                    AdminPanel.Controls.Add(changeAccountDetailsBtn);
                    break;

                case "Vendor":
                    /*Vendor Controls*/
                    FlowLayoutPanel VendorPanel = new FlowLayoutPanel();
                    VendorPanel.AutoScroll = true;
                    VendorPanel.Size = new Size(581, 308);
                    VendorPanel.Location = new Point(10, 71);
                    VendorPanel.Padding = new Padding(5, 5, 5, 5);

                    this.Controls.Add(VendorPanel);
                    break;

                case "Customer":
                    /*Customer Controls*/
                    FlowLayoutPanel CustomerPanel = new FlowLayoutPanel();
                    CustomerPanel.AutoScroll = true;
                    CustomerPanel.Size = new Size(581, 308);
                    CustomerPanel.Location = new Point(10, 71);
                    CustomerPanel.Padding = new Padding(5, 5, 5, 5);

                    viewPOSBtn = new Button();
                    viewPOSBtn.Size = new Size(124, 52);
                    viewPOSBtn.Text = "&Shop";
                    viewPOSBtn.Click += OpenPOS;

                    changeAccountDetailsBtn = new Button();
                    changeAccountDetailsBtn.Size = new Size(124, 52);
                    changeAccountDetailsBtn.Text = "Change Account Details";

                    this.Controls.Add(CustomerPanel);
                    CustomerPanel.Controls.Add(viewPOSBtn);
                    break;

                default:
                    FlowLayoutPanel DefaultPanel = new FlowLayoutPanel();
                    DefaultPanel.AutoScroll = true;
                    DefaultPanel.Size = new Size(581, 308);
                    DefaultPanel.Location = new Point(10, 71);
                    DefaultPanel.Padding = new Padding(5, 5, 5, 5);

                    Label l = new Label();
                    l.Text = "Default Panel";

                    this.Controls.Add(DefaultPanel);
                    DefaultPanel.Controls.Add(l); 
                    break;
            }
        }

        private void UserControlPanel_Load(object sender, EventArgs e)
        {
            CreateControls();

            string info = "";
            info = string.Format("Welcome {0}, choose what you wish to do below.", user.Username);
            lblAccountDetails.Text = info;
        }

        private void LogOut(object sender, EventArgs e)
        {
            //UserLogin login = new UserLogin();
            //login.ShowDialog();
            this.Close();
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to log out?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void OpenPOS(object sender, EventArgs e) {
            POS pos = new POS();
            pos.Store = new Store();
            pos.ShowDialog();
        }

        private void OpenAddVendor(object sender, EventArgs e)
        {
            VendorSignUp vsu = new VendorSignUp();
            vsu.ShowDialog();
        }

        private void OpenViewVendor(object sender,EventArgs e)
        {
            LoadVendor lv = new LoadVendor();
            lv.ShowDialog();
        }
    }
}
