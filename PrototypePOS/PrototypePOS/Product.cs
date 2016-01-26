using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePOS
{
    public class Product
    {
        private string description, imagePath;
        private Category category;
        private decimal price;
        private int quantity;

        //Properties
        public string Description
        {
            get { return description; }
            set {  description = value; }
        }

        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public Category Category
        {
            get { return category; }
            set { category = value; }
        }

        public decimal Price
        {
            get { return price; }
            set {  price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        
        public virtual string DisplayProductInfo
        {
            get { return Description + "\t" + quantity + "\t" + (price * quantity).ToString("C", CultureInfo.CreateSpecificCulture("en-US")); }
        }
    }
}
