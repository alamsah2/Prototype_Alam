using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePOS
{
    class Vendor
    {
        private string accountID, contactNo, name, contactPerson,vendorID;

        public Vendor(string vendorID,string accountID, string name, string contactPerson, string contactNo)
        {
            this.vendorID = vendorID;
            this.AccountID = accountID;
            this.Name = name;
            this.ContactPerson = contactPerson;
            this.ContactNo = contactNo;
        }

        public string AccountID
        {
            get
            {
                return accountID;
            }

            set
            {
                accountID = value;
            }
        }

        public string ContactNo
        {
            get
            {
                return contactNo;
            }

            set
            {
                contactNo = value;
            }
        }

        public string ContactPerson
        {
            get
            {
                return contactPerson;
            }

            set
            {
                contactPerson = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string VendorID
        {
            get
            {
                return vendorID;
            }

            set
            {
                vendorID = value;
            }
        }
    }
}
