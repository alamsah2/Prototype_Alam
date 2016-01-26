using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public class Discount
    {
        private string code;
        private double rate;

        //Properties
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}
