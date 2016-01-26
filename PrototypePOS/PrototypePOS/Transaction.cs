using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.ComponentModel;

namespace PrototypePOS
{
    public class Transaction
    {
        private int id, numberOfTransactionItems;
        private decimal totalAmount;
        private string transactionDateTime;
        private BindingList<Apparel> transactionItems;

        //Properties
        public int TransactionID
        {
            get { return id; }
            set { id = value; }
        }

        public int NumberOfTransactionItems
        {
            get { return numberOfTransactionItems; }
            set { numberOfTransactionItems = value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string TransactionDateTime
        {
            get { return transactionDateTime; }
            set { transactionDateTime = value; }
        }

        public BindingList<Apparel> TransactionItems
        {
            get { return transactionItems; }
            set { transactionItems = value; }
        }

        //Constructor
        public Transaction()
        {
            totalAmount = 0;
            transactionItems = new BindingList<Apparel>();
        }

        //Methods
        public int GenerateID()
        {
            return int.Parse(
                DateTime.Now.Day.ToString() + //Get current Day from current instance's datetime
                DateTime.Now.Month.ToString() + //Get current Month (numeric) from current instance's datetime
                DateTime.Now.Millisecond.ToString() //Get current Millisecond from current instance's datetime
                );
        }
    }
}
