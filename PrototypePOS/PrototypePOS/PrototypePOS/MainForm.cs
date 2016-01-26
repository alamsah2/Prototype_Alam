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
    public partial class MainForm : Form
    {
        private Store store;

        //Constructors
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(1000);
            t.Abort();
            store = new Store();
            InitializeComponent();
        }

        //Methods & Event Handlers
        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void btnOpenPOS_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            pos.Store = store;
            pos.ShowDialog();
        }

        private void GenerateSalesReport(object sender, EventArgs e)
        {
            PasswordInput passwordInput = new PasswordInput();
            passwordInput.Store = store;
            passwordInput.ShowDialog();
        }
    }
}
