using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePOS
{
    public class User
    {
        private string username, password,accountType;
   

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
   
        //Constructor
        public User ()
        {
            username = "";
            password = "";
            accountType = "";
        }

        public User (string u, string p, string a)
        {
            username = u;
            password = p;
            accountType = a;
        }
    }
}
