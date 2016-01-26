using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePOS
{
    public class Apparel : Product
    {
        private string size;
        private char gender;

        //Properties
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        public override string DisplayProductInfo
        {
            get { return string.Format("{0}\t{1}\t{2}\t{3} ", Description, size, Quantity, (Price * Quantity).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); }
        }
    }
}
