using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public class Store
    {
        private string name, storeOpeningDateTime, transactionInfo = "";
        private decimal totalRevenue;
        private BindingList<Category> categories;
        private BindingList<Apparel> apparels;
        private BindingList<Discount> discountCodes;
        private BindingList<Transaction> successfulTransactions;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string StoreOpeningDateTime
        {
            get { return storeOpeningDateTime; }
            set { storeOpeningDateTime = value; }
        }

        public BindingList<Category> Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public BindingList<Apparel> Apparels
        {
            get { return apparels; }
            set { apparels = value; }
        }

        public BindingList<Discount> DiscountCodes
        {
            get { return discountCodes; }
            set { discountCodes = value; }
        }

        public BindingList<Transaction> SuccessFulTransactions
        {
            get { return successfulTransactions; }
            set { successfulTransactions = value; }
        }

        //Constructor
        public Store()
        {
            totalRevenue = 0;
            storeOpeningDateTime = DateTime.Now.ToString();
            categories = new BindingList<Category>();
            apparels = new BindingList<Apparel>();
            discountCodes = new BindingList<Discount>();
            successfulTransactions = new BindingList<Transaction>();

            LoadCategories();
            LoadApparels();
            LoadDiscountCodes();
        }

        //Methods
        //Loading Categories data.
        public void LoadCategories()
        {
            if (!File.Exists("data/category.txt"))
            {
                MessageBox.Show("category.txt can't be found!");
            }

            else
            {
                using (StreamReader sr = new StreamReader("data/category.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        string[] strArray;
                        str = sr.ReadLine();

                        strArray = Regex.Split(str, ", ");
                        Category currentCategory = new Category();
                        currentCategory.CategoryID = int.Parse(strArray[0]);
                        currentCategory.Description = strArray[1];

                        categories.Add(currentCategory);
                    }
                }
            }
        }

        //Loading all apparels
        public void LoadApparels()
        {
            if (!File.Exists("data/products.txt"))
            {
                MessageBox.Show("Unable to load products, products.txt does not exist!");
            }

            else
            {
                using (StreamReader sr = new StreamReader("data/products.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        string[] strArray;
                        str = sr.ReadLine();

                        strArray = Regex.Split(str, ", ");
                        Apparel currentApparel = new Apparel();
                        currentApparel.ImagePath = strArray[0];
                        currentApparel.Description = strArray[1];
                        currentApparel.Price = decimal.Parse(strArray[2]);
                        currentApparel.Category = categories[int.Parse(strArray[3]) - 1]; //Prone to ArgumentOutOfRangeException
                                                                                          //when product category does not
                                                                                          //Exist in the list of categories
                        currentApparel.Gender = char.Parse(strArray[4]);

                        apparels.Add(currentApparel);
                    }
                }
            }
        }

        //Loading all discount codes
        private void LoadDiscountCodes()
        {
            if (!File.Exists("data/discount.txt"))
                MessageBox.Show("Discount codes were not loaded successfully as discount.txt could not be found");
            using (StreamReader sr = new StreamReader("data/discount.txt"))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = Regex.Split(str, ", ");
                    Discount currentDiscountCode = new Discount();
                    currentDiscountCode.Code = strArray[0];
                    currentDiscountCode.Rate = double.Parse(strArray[1]) / 100;

                    discountCodes.Add(currentDiscountCode);
                }
            }
        }

        //Generate Sales Report
        public void GenerateSalesReport()
        {
            if(!Directory.Exists("Sales Report"))
            {
                Directory.CreateDirectory("Sales Report");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("Sales Report/PrototypeSalesReport" + DateTime.Parse(storeOpeningDateTime).ToString("ddMMMMyyyy") + ".txt"))
                {
                    string line;
                    
                    foreach (Transaction transaction in successfulTransactions)
                    {
                        
                        totalRevenue += transaction.TotalAmount;

                        transactionInfo += string.Format("\r\nTransaction #{0}:\r\nTransactionID: {1}\r\nTransaction Date/Time:{2}\r\nNumber of Item(s) purchased: {3}\r\nTotal: {4}\r\n", (successfulTransactions.IndexOf(transaction) + 1), transaction.TransactionID, transaction.TransactionDateTime, transaction.NumberOfTransactionItems, transaction.TotalAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    }

                    line = "\t\tPROTOTYPE Apparel Shop\'s Sales Report\r\n";
                    line += "-----------------------------------------------------------------------------------------------------------------\r\n";
                    line += string.Format("Store Opened Date/Time(24-HR FORMAT): {0}\r\n", storeOpeningDateTime);
                    line += "-----------------------------------------------------------------------------------------------------------------\r\n";
                    line += "\t\t\tS U M M A R Y\r\n";
                    line += "-----------------------------------------------------------------------------------------------------------------\r\n";
                    line += string.Format("Total Number of Successful Transactions: {0}\r\n", successfulTransactions.Count);
                    line += string.Format("Total profit earned: {0}\r\n", totalRevenue.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
                    line += "-----------------------------------------------------------------------------------------------------------------\r\n";
                    line += "\t\t        Transactions informations\r\n";
                    line += "-----------------------------------------------------------------------------------------------------------------\r\n";
                    line += transactionInfo;
                    line += "////////////////////////////////////End of Sales Report////////////////////////////////////";

                    writer.Write(line);
                }
            }
        }

        //Print Sales Report
        public void PrintSalesReport()
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
            int offset = 80;

            graphic.DrawString("\t\tPROTOTYPE Apparel Shop\'s Sales Report", font, brush, startX, startY);
            graphic.DrawString("-----------------------------------------------------------------------------------------------------------------", font, brush, startX, startY + 20);
            graphic.DrawString(string.Format("Store Opened Date/Time(24-HR FORMAT): {0}", storeOpeningDateTime), font, brush, startX, startY + 40);
            graphic.DrawString("-----------------------------------------------------------------------------------------------------------------", font, brush, startX, startY + 60);
            graphic.DrawString("\t\t\tS U M M A R Y", font, brush, startX, startY + offset);

            offset += 20;
            graphic.DrawString("-----------------------------------------------------------------------------------------------------------------", font, brush, startX, startY + offset);

            offset += 20;
            graphic.DrawString(string.Format("Total Number of Successful Transactions: {0}", successfulTransactions.Count), font, brush, startX, startY + offset);

            offset += 20;
            graphic.DrawString(string.Format("Total profit earned: {0}", totalRevenue.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))), font, brush, startX, startY + offset);

            offset += 20;
            graphic.DrawString("-----------------------------------------------------------------------------------------------------------------", font, brush, startX, startY + offset);

            offset += 20;
            graphic.DrawString("\t\t        Transactions informations\r\n", font, brush, startX, startY + offset);

            offset += 20;
            graphic.DrawString("-----------------------------------------------------------------------------------------------------------------", font, brush, startX, startY + offset);

            offset += 20;
            foreach (Transaction transaction in successfulTransactions)
            {
                string productLine = string.Format("Transaction #{0}:\r\nTransactionID: {1}\r\nTransaction Date/Time:{2}\r\nNumber of Item(s) purchased: {3}\r\nTotal: {4}\r\n", (successfulTransactions.IndexOf(transaction) + 1), transaction.TransactionID, transaction.TransactionDateTime, transaction.NumberOfTransactionItems, transaction.TotalAmount.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

                graphic.DrawString(productLine, font, brush, startX, startY + offset);

                offset += (int)fontHeight + 100;
            }

            offset += 20;
            graphic.DrawString("////////////////////////////////////End of Sales Report////////////////////////////////////", font, brush, startX, startY + offset);
        }
    }
}
