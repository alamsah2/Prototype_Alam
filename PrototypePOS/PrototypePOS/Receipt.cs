using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public partial class Receipt : Form
    {
        private decimal transactionAmount = 0, changeDue = 0, discountedValue = 0, beforeDiscountTotalAmount = 0, cashPaymentInput = 0;
        private bool isCreditCardPayment, hasDiscount;
        private string creditCardHolderName, cardType, creditCardNumber;
        private Transaction transaction;

        //Properties
        public bool IsCreditCardPayment
        {
            get
            {
                return isCreditCardPayment;
            }

            set
            {
                isCreditCardPayment = value;
            }
        }

        public bool HasDiscount
        {
            get
            {
                return hasDiscount;
            }

            set
            {
                hasDiscount = value;
            }
        }

        public string CreditCardHolderName
        {
            get
            {
                return creditCardHolderName;
            }

            set
            {
                creditCardHolderName = value;
            }
        }

        public string CardType
        {
            get { return cardType; }
            set { cardType = value; }
        }

        public string CreditCardNumber
        {
            get
            {
                return creditCardNumber;
            }

            set
            {
                creditCardNumber = value;
            }
        }

        public decimal TransactionAmount
        {
            get
            {
                return transactionAmount;
            }

            set
            {
                transactionAmount = value;
            }
        }

        public decimal ChangeDue
        {
            get
            {
                return changeDue;
            }

            set
            {
                changeDue = value;
            }
        }

        public decimal DiscountedValue
        {
            get
            {
                return discountedValue;
            }

            set
            {
                discountedValue = value;
            }
        }

        public decimal BeforeDiscountTotalAmount
        {
            get
            {
                return beforeDiscountTotalAmount;
            }

            set
            {
                beforeDiscountTotalAmount = value;
            }
        }

        public decimal CashPaymentInput
        {
            get
            {
                return cashPaymentInput;
            }

            set
            {
                cashPaymentInput = value;
            }
        }

        public Transaction Transaction
        {
            get
            {
                return transaction;
            }

            set
            {
                transaction = value;
            }
        }

        //Constructor
        public Receipt()
        {
            InitializeComponent();
            transaction = new Transaction();
            transaction.TransactionID = transaction.GenerateID();
            transaction.TransactionDateTime = DateTime.Now.ToString();
        }

        //Methods & Event Handlers
        private void ReceiptGUI_Load(object sender, EventArgs e)
        {
            DisplayReceipt();

            txtbxRecipt.ScrollBars = ScrollBars.Vertical;
            txtbxRecipt.SelectionStart = 0;
        }

        private void DisplayReceipt()
        {
            txtbxRecipt.Text = "\tPROTOTYPE Apparel Shop\r\n";
            txtbxRecipt.Text += "-----------------------------------\r\n";
            txtbxRecipt.Text += string.Format("Date/Time: {0}\r\n", transaction.TransactionDateTime);
            txtbxRecipt.Text += string.Format("Transaction no: {0}\r\n", transaction.TransactionID);
            txtbxRecipt.Text += "-----------------------------------\r\n";
            txtbxRecipt.Text += "Description   Size   Qty   Price\r\n";
            txtbxRecipt.Text += "-----------------------------------\r\n";
            txtbxRecipt.Text += DisplayCartItems();

            if (hasDiscount)
            {
                txtbxRecipt.Text += "\r\n";
                txtbxRecipt.Text += string.Format(
                    "Before Discount Total:  {0}",
                    beforeDiscountTotalAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                txtbxRecipt.Text += "\r\n";
                txtbxRecipt.Text += string.Format(
                    "Discounted amount:      {0}",
                    discountedValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                txtbxRecipt.Text += "\r\n";
            }

            txtbxRecipt.Text += "\r\n";
            txtbxRecipt.Text += string.Format(
                "Total      \t\t{0}\r\n",
                transactionAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

            if (!isCreditCardPayment)
            {
                txtbxRecipt.Text += "Payment mode: Cash\r\n";
                txtbxRecipt.Text += string.Format(
                    "Cash Amount received:   {0}\r\n",
                    cashPaymentInput.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                txtbxRecipt.Text += string.Format(
                    "Change: \t\t{0}\r\n",
                    changeDue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            }

            else
            {
                txtbxRecipt.Text += "Payment mode: Credit Card\r\n";
                txtbxRecipt.Text += string.Format("Credit card holder name: ");
                txtbxRecipt.Text += string.Format("{0}\r\n", creditCardHolderName);
                txtbxRecipt.Text += "Credit Card no: ";
                txtbxRecipt.Text += string.Format("{0}\r\n", creditCardNumber);
                txtbxRecipt.Text += string.Format("Card Type: {0}\r\n", cardType);
            }

            txtbxRecipt.Text += "\r\r\n";
            txtbxRecipt.Text += "THIS SERVES AS AN OFFICAL RECEIPT\r\n";
            txtbxRecipt.Text += "***********************************\r\n";
            txtbxRecipt.Text += "All apparels can be refunded/exchanged within 7 days.\r\n";
            txtbxRecipt.Text += "\r\n";
            txtbxRecipt.Text += "Please bring along the receipt of the product's receipt.\r\n";
            txtbxRecipt.Text += "***********************************\r\n";

        }

        public string DisplayCartItems()
        {
            string info = "";
            foreach (Apparel apparel in transaction.TransactionItems)
            {
                info += (transaction.TransactionItems.IndexOf(apparel) + 1) + ". " + apparel.Description + string.Format(" ({0}) x", apparel.Size) + apparel.Quantity + " -- " + (apparel.Price * apparel.Quantity).ToString("C", CultureInfo.CreateSpecificCulture("en-US")) + "\r\n";
            }
            return info;
        }

        private void CloseReceipt(object sender, EventArgs e)
        {
            WritesReceipt();
            transaction.TotalAmount = transactionAmount;
            transaction.NumberOfTransactionItems = transaction.TransactionItems.Count;
            this.Close();
        }

        private void PrintReceipt(object sender, EventArgs e)
        {
            WritesReceipt();
            GenerateAndPrintReceipt();
            transaction.TotalAmount = transactionAmount;
            transaction.NumberOfTransactionItems = transaction.TransactionItems.Count;
            this.Close();
        }

        private void WritesReceipt()
        {
            if (!Directory.Exists("TransactionReceipts"))
                Directory.CreateDirectory("TransactionReceipts");
            using (StreamWriter writer = new StreamWriter("TransactionReceipts/TransactionReceipt_" + DateTime.Parse(transaction.TransactionDateTime).ToString("ddMMMMyyyyHmmss") + ".txt"))
            {
                string line;

                line = "\tPROTOTYPE Apparel Shop\r\n";
                line += "-----------------------------------------------------------------------------\r\n";
                line += string.Format("Date/Time: {0}\r\n", transaction.TransactionDateTime);
                line += string.Format("Transaction no: {0}\r\n", transaction.TransactionID);
                line += "-----------------------------------------------------------------------------\r\n";
                line += "Description   Size   Qty   Price\r\n";
                line += "-----------------------------------------------------------------------------\r\n";
                line += DisplayCartItems();

                if (hasDiscount)
                {
                    line += "\r\n";
                    line += string.Format(
                        "Before Discount Total:  {0}",
                        beforeDiscountTotalAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    line += "\r\n";
                    line += string.Format(
                        "Discounted amount:      {0}",
                        discountedValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    line += "\r\n";
                }

                line += "\r\n";
                line += string.Format(
                    "Total      \t\t{0}\r\n",
                    transactionAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

                if (!isCreditCardPayment)
                {
                    line += "Payment mode: Cash\r\n";
                    line += string.Format(
                        "Cash Amount received:   {0}\r\n",
                        cashPaymentInput.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    line += string.Format(
                        "Change: \t\t{0}\r\n",
                        changeDue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                }

                else
                {
                    line += "Payment mode: Credit Card\r\n";
                    line += string.Format("Credit card holder name: ");
                    line += string.Format("{0}\r\n", creditCardHolderName);
                    line += "Credit Card no: ";
                    line += string.Format("{0}\r\n", creditCardNumber);
                    line += string.Format("Card Type: {0}\r\n", cardType);
                }

                line += "\r\r\n";
                line += "THIS SERVES AS AN OFFICAL RECEIPT\r\n";
                line += "*************************************************\r\n";
                line += "All apparels can be refunded/exchanged within 7 days.\r\n";
                line += "\r\n";
                line += "Please bring along the receipt of the product.\r\n";
                line += "*************************************************\r\n";
                writer.Write(line);
            }
        }

        private void GenerateAndPrintReceipt()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Consolas", 12);
            Brush brush = new SolidBrush(Color.Black);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 75;

            graphic.DrawString("PROTOTYPE Apparel Shop", font, brush, startX, startY);
            graphic.DrawString("---------------------------------------------", font, brush, startX, startY + 20);
            graphic.DrawString("Description (Size)".PadRight(20) + "Quantity".PadRight(10) + "Price", font, brush, startX, startY + 40);
            graphic.DrawString("---------------------------------------------", font, brush, startX, startY + 60);
            foreach (Apparel apparel in transaction.TransactionItems)
            {
                string productDescription = apparel.Description + " (" + apparel.Size + ")".PadRight(10);
                string productQuantity = "x " + apparel.Quantity.ToString().PadRight(10);
                string productPrice = apparel.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                string productLine = productDescription + productQuantity + productPrice;

                graphic.DrawString(productLine, font, brush, startX, startY + offset);

                offset += (int)fontHeight + 5;
            }

            
            if (hasDiscount)
            {
                offset += 20;
                graphic.DrawString("Before Discount Total".PadRight(30) + beforeDiscountTotalAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")), font, brush, startX, startY + offset);
                offset += 20;
                graphic.DrawString("Discount Value".PadRight(30) + discountedValue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")), font, brush, startX, startY + offset);
            }

            offset += 40;
            graphic.DrawString("Total".PadRight(30) + transactionAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")), font, brush, startX, startY + offset);

            offset += 20;
            if (isCreditCardPayment)
            {
                graphic.DrawString("Payment Mode: Credit Card".PadRight(30), font, brush, startX, startY + offset);
                offset += 15;
                graphic.DrawString(string.Format("Credit Card Holder Name: {0}\r\nCredit Card Number: {1}\r\nCard Type: {2}", creditCardHolderName, creditCardNumber, cardType), font, brush, startX, startY + offset);
            }

            else
            {
                graphic.DrawString("Payment Mode: Cash".PadRight(30), font, brush, startX, startY + offset);
                offset += 20;
                graphic.DrawString("Cash Received:".PadRight(30) + cashPaymentInput.ToString("C", CultureInfo.CreateSpecificCulture("en-US")), font, brush, startX, startY + offset);
                offset += 20;
                graphic.DrawString("Change:".PadRight(30) + changeDue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")), font, brush, startX, startY + offset);
            }

            offset += 70;
            graphic.DrawString("THIS SERVES AS AN OFFICAL RECEIPT".PadRight(30), font, brush, startX, startY + offset);
            offset += 20;
            graphic.DrawString("*********************************************".PadRight(30), font, brush, startX, startY + offset);
            offset += 20;
            graphic.DrawString("All apparels can be refunded/exchanged within \r\n7 days.\r\nPlease bring along the receipt of the \r\nproduct.".PadRight(30), font, brush, startX, startY + offset);
            offset += 80;
            graphic.DrawString("*********************************************".PadRight(30), font, brush, startX, startY + offset);

        }

    }


}
