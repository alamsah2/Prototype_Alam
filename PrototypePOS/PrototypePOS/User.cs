using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePOS
{
    public class User
    {
        private string username, password,accountType,email,firstName,lastName;

        private int accountID,mobileNo;
   

        //Properties
        public string AccountType {
            get { return accountType; }
            set { accountType = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int AccountID
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

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public int MobileNo
        {
            get
            {
                return mobileNo;
            }

            set
            {
                mobileNo = value;
            }
        }

        //Constructor
        public User ()
        {
            username = "";
            password = "";
            accountType = "";
        }

        public User(string u, string p, string a, string e, int id)
        {
            username = u;
            password = p;
            accountType = a;
            email = e;
            accountID = id;
        }
        public User(string u, string p, string a, string e, int id,string fn,string ln, int n)
        {
            username = u;
            password = p;
            accountType = a;
            email = e;
            accountID = id;
            firstName = fn;
            lastName = ln;
            mobileNo = n;
        }

    }
}
