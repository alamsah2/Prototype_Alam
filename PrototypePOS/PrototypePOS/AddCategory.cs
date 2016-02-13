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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string genderType = "";
            if (radioMale.Checked)
            {
                genderType = "M";
            }

            else if (radioFemale.Checked)
            {
                genderType = "F";
            }
            DBPOS dbp = new DBPOS();
            dbp.InsertCategory(txtBxDescription.Text, genderType);
            MessageBox.Show("The category has been added");
            this.Close();

        }
    }
}
