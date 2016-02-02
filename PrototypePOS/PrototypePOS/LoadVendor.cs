using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public partial class LoadVendor : Form
    {
      
        private List<Vendor> vendors;


        public LoadVendor()
        {
            InitializeComponent();
        }

        private void LoadVendors(object sender, EventArgs e)
        {
            DBPOS dbp = new DBPOS();
            vendors = dbp.LoadVendorAccounts();
            DataTable vendor = new DataTable();
            vendor.Columns.Add("VendorID");
            vendor.Columns.Add("AccountID");
            vendor.Columns.Add("Name");
            vendor.Columns.Add("ContactPerson");
            vendor.Columns.Add("ContactNo");

            lvLoadVendor.View = View.Details;
            foreach (Vendor v in vendors) {
                vendor.Rows.Add(v.VendorID,v.AccountID,v.Name,v.ContactPerson,v.ContactNo);
            }
            lvLoadVendor.Items.Clear();//Clear the ListView control first before adding ListViewItems
            foreach (DataRow dr in vendor.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr["VendorID"].ToString();
                item.SubItems.Add(dr["AccountID"].ToString());
                item.SubItems.Add(dr["Name"].ToString());
                item.SubItems.Add(dr["ContactPerson"].ToString());
                item.SubItems.Add(dr["ContactNo"].ToString());

                lvLoadVendor.Items.Add(item);
            }

        

    }

    }
}
