using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    public partial class POS : Form
    {
        private Store store;
        private decimal cartTotal = 0;
        private BindingList<Apparel> cartItems = new BindingList<Apparel>();

        //Properties
        public Store Store
        {
            get { return store; }
            set { store = value;}
        }

        //Constructors
        public POS()
        {
            InitializeComponent();

            /* Sets the datasource (where the list box gets it's data from),  */
            /* DisplayMember (variable from the datasource for displaying     */
            /*               the values only not for calculations),           */
            /* ValueMember (variable from the datasource to use as value for  */
            /*              calculation).                                     */
            lstCartItems.DataSource = cartItems;
            lstCartItems.DisplayMember = "DisplayProductInfo";
            lstCartItems.ValueMember = "Price";
        }

        //Methods & Event Handlers
        private void MainPOS_Load(object sender, EventArgs e)
        {
            //POS setting up
            store.Name = "Protoype";
            lblStoreName.Text = store.Name.ToUpper();
            lblTotalAmt.Text = cartTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            //Loading apparels data onto POS
            CreateCategoryTabbedPanel();
            AddFemaleApparels();
            AddMaleApparels();

            //Disable delete from cart button when cart is empty
            if (!cartItems.Any())
                btnDeleteFromCart.Enabled = false;
        }

        //Displays all Males Apparels when the radio button 'Male' is clicked
        private void DisplayMaleProducts(object sender, EventArgs e)
        {
            grpbxMale.Visible = true;
            grpbxFemale.Visible = false;
        }

        //Displays all Females Apparels when the radio button 'Female' is clicked
        private void DisplayFemaleProducts(object sender, EventArgs e)
        {
            grpbxMale.Visible = false;
            grpbxFemale.Visible = true;
        }

        //Create a tabpage for each category found in the Store list of categories
        private void CreateCategoryTabbedPanel()
        {
            foreach (Category category in store.Categories)
            {
                string title = category.Description;
                TabPage newMaleCategory = new TabPage(category.Description);
                TabPage newFemaleCategory = new TabPage(category.Description);
                MCatalogue.TabPages.Add(newMaleCategory);
                FCatalogue.TabPages.Add(newFemaleCategory);
            }

        }

        //Adding all male apparels information into their respective category(tabPage)
        private void AddMaleApparels()
        {
            foreach (TabPage tp in MCatalogue.TabPages)
            {
                tp.BackColor = Color.White;

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                flp.VerticalScroll.Visible = true;
                flp.BackColor = Color.White;

                foreach (Apparel apparel in store.Apparels)
                {
                    if (apparel.Gender == 'M' && MCatalogue.TabPages.IndexOf(tp) == (apparel.Category.CategoryID - 1))
                    {
                        //Panel for each product
                        Panel panel = new Panel();
                        panel.Size = new Size(170, 270);
                        panel.BackColor = Color.White;
                        panel.BorderStyle = BorderStyle.FixedSingle;

                        //PictureBox for each product's image
                        PictureBox pb = new PictureBox();
                        pb.Location = new Point(9, 0);
                        pb.Size = new Size(150, 150);
                        pb.ImageLocation = "images/" + apparel.ImagePath;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;

                        //Label for the product's Description
                        Label productDescriptionLabel = new Label();
                        productDescriptionLabel.Location = new Point(0, 140);
                        productDescriptionLabel.Size = new Size(170, 40);
                        productDescriptionLabel.BackColor = Color.Transparent;
                        productDescriptionLabel.Text = apparel.Description;
                        productDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
                        productDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Label for the product's price
                        Label priceLabel = new Label();
                        priceLabel.Location = new Point(0, 180);
                        priceLabel.Size = new Size(170, 22);
                        priceLabel.BackColor = Color.Transparent;
                        productDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
                        priceLabel.Text = "Price: " + apparel.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        priceLabel.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Label to display text "Size: "
                        Label sizeLabel = new Label();
                        sizeLabel.Location = new Point(0, 207);
                        sizeLabel.Size = new Size(41, 16);
                        sizeLabel.BackColor = Color.Transparent;
                        sizeLabel.Text = "Size:";
                        sizeLabel.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        sizeLabel.SendToBack();

                        //ComboxBox for user to select the size of the apparel
                        ComboBox sizeSelector = new ComboBox();
                        sizeSelector.Location = new Point(41, 205);
                        sizeSelector.Size = new Size(50, 80);
                        sizeSelector.Text = "size";
                        string[] possibleSize = { "XS", "S", "M", "L", "XL" };
                        foreach (string size in possibleSize)
                        {
                            sizeSelector.Items.Add(size);
                        }
                        sizeSelector.SelectedValueChanged += UpdateProductSize;
                        sizeSelector.Tag = apparel;
                        sizeSelector.BringToFront();

                        //Label to display the text "Quantity: "
                        Label quantityLabel = new Label();
                        quantityLabel.Location = new Point(90, 207);
                        quantityLabel.Size = new Size(35, 16);
                        quantityLabel.BackColor = Color.Transparent;
                        quantityLabel.Text = "Qty:";
                        quantityLabel.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        quantityLabel.SendToBack();

                        //NumericUpDown for user to select the quantity of the apparel
                        NumericUpDown quantitySelector = new NumericUpDown();
                        quantitySelector.Location = new Point(125, 205);
                        quantitySelector.Size = new Size(40, 30);
                        quantitySelector.TextAlign = HorizontalAlignment.Right;
                        quantitySelector.ReadOnly = true;
                        quantitySelector.Maximum = 5;
                        quantitySelector.Minimum = 0;
                        quantitySelector.ValueChanged += UpdateProductQuantity;
                        quantitySelector.Tag = apparel;
                        quantitySelector.BringToFront();

                        //Button for adding the product into the cart
                        Button b = new Button();
                        b.Location = new Point(19, 235);
                        b.Size = new Size(130, 30);
                        b.BackColor = System.Drawing.Color.Transparent;
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderColor = Color.Black;
                        b.FlatAppearance.BorderSize = 2;
                        b.Text = "Add to cart";
                        b.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        b.MouseEnter += MouseHoverButton;
                        b.MouseLeave += MouseLeaveButton;
                        b.MouseDown += MouseDownButton;
                        b.Click += AddToCart;
                        b.Tag = apparel;

                        panel.Controls.Add(pb);
                        panel.Controls.Add(productDescriptionLabel);
                        panel.Controls.Add(priceLabel);
                        panel.Controls.Add(sizeLabel);
                        panel.Controls.Add(sizeSelector);
                        panel.Controls.Add(quantityLabel);
                        panel.Controls.Add(quantitySelector);
                        panel.Controls.Add(b);
                        flp.Controls.Add(panel);
                    }
                }

                tp.Controls.Add(flp);
            }
        }

        //Adding all female apparels information into their respective category(tabPage)
        private void AddFemaleApparels()
        {
            foreach (TabPage tp in FCatalogue.TabPages)
            {
                tp.BackColor = Color.White;

                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                flp.VerticalScroll.Visible = true;
                flp.BackColor = Color.White;

                foreach (Apparel apparel in store.Apparels)
                {
                    if (apparel.Gender == 'F' && FCatalogue.TabPages.IndexOf(tp) == (apparel.Category.CategoryID - 1))
                    {
                        //Panel for each product
                        Panel panel = new Panel();
                        panel.Size = new Size(170, 270);
                        panel.BackColor = Color.White;
                        panel.BorderStyle = BorderStyle.FixedSingle;

                        //PictureBox for each product's image
                        PictureBox pb = new PictureBox();
                        pb.Location = new Point(9, 0);
                        pb.Size = new Size(150, 150);
                        pb.ImageLocation = "images/" + apparel.ImagePath;
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;

                        //Label for the product's Description
                        Label productDescriptionLabel = new Label();
                        productDescriptionLabel.Location = new Point(0, 140);
                        productDescriptionLabel.Size = new Size(170, 40);
                        productDescriptionLabel.BackColor = Color.Transparent;
                        productDescriptionLabel.Text = apparel.Description;
                        productDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
                        productDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Label for the product's price
                        Label priceLabel = new Label();
                        priceLabel.Location = new Point(0, 180);
                        priceLabel.Size = new Size(170, 22);
                        priceLabel.BackColor = Color.Transparent;
                        productDescriptionLabel.TextAlign = ContentAlignment.MiddleLeft;
                        priceLabel.Text = "Price: " + apparel.Price.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        priceLabel.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                        //Label to display text "Size: "
                        Label sizeLabel = new Label();
                        sizeLabel.Location = new Point(0, 207);
                        sizeLabel.Size = new Size(41, 16);
                        sizeLabel.BackColor = Color.Transparent;
                        sizeLabel.Text = "Size:";
                        sizeLabel.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        sizeLabel.SendToBack();

                        //ComboxBox for user to select the size of the apparel
                        ComboBox sizeSelector = new ComboBox();
                        sizeSelector.Location = new Point(41, 205);
                        sizeSelector.Size = new Size(50, 80);
                        sizeSelector.Text = "size";
                        string[] possibleSize = { "XS", "S", "M", "L", "XL" };
                        foreach (string size in possibleSize)
                        {
                            sizeSelector.Items.Add(size);
                        }
                        sizeSelector.SelectedValueChanged += UpdateProductSize;
                        sizeSelector.Tag = apparel;
                        sizeSelector.BringToFront();

                        //Label to display the text "Quantity: "
                        Label quantityLabel = new Label();
                        quantityLabel.Location = new Point(90, 207);
                        quantityLabel.Size = new Size(35, 16);
                        quantityLabel.BackColor = Color.Transparent;
                        quantityLabel.Text = "Qty:";
                        quantityLabel.Font = new System.Drawing.Font("Arial", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        quantityLabel.SendToBack();

                        //NumericUpDown for user to select the quantity of the apparel
                        NumericUpDown quantitySelector = new NumericUpDown();
                        quantitySelector.Location = new Point(125, 205);
                        quantitySelector.Size = new Size(40, 30);
                        quantitySelector.TextAlign = HorizontalAlignment.Right;
                        quantitySelector.ReadOnly = true;
                        quantitySelector.Maximum = 5;
                        quantitySelector.Minimum = 0;
                        quantitySelector.ValueChanged += UpdateProductQuantity;
                        quantitySelector.Tag = apparel;
                        quantitySelector.BringToFront();

                        //Button for adding the product into the cart
                        Button b = new Button();
                        b.Location = new Point(19, 235);
                        b.Size = new Size(130, 30);
                        b.BackColor = System.Drawing.Color.Transparent;
                        b.FlatStyle = FlatStyle.Flat;
                        b.FlatAppearance.BorderColor = Color.Black;
                        b.FlatAppearance.BorderSize = 2;
                        b.Text = "Add to cart";
                        b.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        b.MouseEnter += MouseHoverButton;
                        b.MouseLeave += MouseLeaveButton;
                        b.MouseDown += MouseDownButton;
                        b.Click += AddToCart;
                        b.Tag = apparel;

                        panel.Controls.Add(pb);
                        panel.Controls.Add(productDescriptionLabel);
                        panel.Controls.Add(priceLabel);
                        panel.Controls.Add(sizeLabel);
                        panel.Controls.Add(sizeSelector);
                        panel.Controls.Add(quantityLabel);
                        panel.Controls.Add(quantitySelector);
                        panel.Controls.Add(b);
                        flp.Controls.Add(panel);
                    }
                }

                tp.Controls.Add(flp);
            }
        }

        //For 'Add to cart' button effect upon the following mouse event
        private void MouseHoverButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            b.ForeColor = Color.White;
        }

        private void MouseLeaveButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.Black;
        }

        private void MouseDownButton(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
        }

        //Updates the apparel quantity when the value is changed in the numericUpDown
        private void UpdateProductQuantity(object sender, EventArgs e)
        {
            NumericUpDown productQty = (NumericUpDown)sender;
            Apparel a = (Apparel)productQty.Tag;
            a.Quantity = (int)productQty.Value;
        }

        //Updates the apparel size when the value is changed in the comboBox
        private void UpdateProductSize(object sender, EventArgs e)
        {
            ComboBox apparelSize = (ComboBox)sender;
            Apparel a = (Apparel)apparelSize.Tag;
            a.Size = apparelSize.SelectedItem.ToString();
        }

        //Add selected apparel in to the shopping cart when 'Add to cart' button is clicked
        private void AddToCart(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Apparel a = (Apparel)b.Tag;

            if (a.Quantity == 0 || string.IsNullOrEmpty(a.Size))
            {
                MessageBox.Show("Please ensure that both a valid quantity & size has been selected.");
            }

            else if(cartItems.Contains(a))
            {
                MessageBox.Show("Item existed in your cart, please remove the item from the cart first.");
                btnDeleteFromCart.Enabled = true;
            }

            else
            {
                cartItems.Add(a);
                cartTotal += a.Price * a.Quantity;
                lstCartItems.SelectedIndex = lstCartItems.Items.Count - 1;
                lblTotalAmt.Text = cartTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                btnDeleteFromCart.Enabled = true;
            }
        }

        //Delete selected apparel from the shopping cart when 'Delete item' button is clicked
        private void DeleteItemFromCart(object sender, EventArgs e)
        {
            Apparel selectedApparel = (Apparel)lstCartItems.SelectedItem;
            cartItems.Remove(selectedApparel);

            //Checks if the listbox is empty and disabled the delete button
            //to prevent NullReferenceException
            if (!cartItems.Any())
            {
                btnDeleteFromCart.Enabled = false;
            }

            cartTotal -= (selectedApparel.Price * selectedApparel.Quantity);
            lblTotalAmt.Text = cartTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }

        //Moves to the payment form when the 'Proceed to payment' button is clicked
        private void MakePayment(object sender, EventArgs e)
        {
            if (!cartItems.Any())
            {
                MessageBox.Show(
                    "Your shopping cart is empty! Please choose an item to make a payment.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Payment payment = new Payment();
                payment.TransactionItems = cartItems;
                payment.Total = cartTotal;
                payment.DiscountCodes = store.DiscountCodes;
                payment.PaymentMade += Payment_PaymentMade;
                payment.ShowDialog();
                
            }
        }

        //Event Handler for when payment status is updated in the payment form
        private void Payment_PaymentMade(object sender, PaymentMadeEventArgs e)
        {
            if(e.SuccessfulPayment == true)
            {
                Receipt receipt = new Receipt();
                if (e.IsCashPayment == true)
                {
                    receipt.IsCreditCardPayment = false;
                    receipt.HasDiscount = e.HasDiscount;
                    receipt.BeforeDiscountTotalAmount = e.BeforeDiscountTotalAmount;
                    receipt.DiscountedValue = e.DiscountedValue;
                    receipt.TransactionAmount = e.Total;
                    receipt.CashPaymentInput = e.CashPaymentInput;
                    receipt.ChangeDue = e.ChangeDue;
                    receipt.Transaction.TransactionItems = e.TransactionItems;
                    receipt.ShowDialog();
                }

                if(e.IsCreditCardPayment == true)
                {
                    receipt.IsCreditCardPayment = true;
                    receipt.HasDiscount = e.HasDiscount;
                    receipt.BeforeDiscountTotalAmount = e.BeforeDiscountTotalAmount;
                    receipt.DiscountedValue = e.DiscountedValue;
                    receipt.TransactionAmount = e.Total;
                    receipt.CardType = e.CardType;
                    receipt.CreditCardHolderName = e.CreditCardHolderName;
                    receipt.CreditCardNumber = e.CreditCardNumber;
                    receipt.Transaction.TransactionItems = e.TransactionItems;
                    receipt.ShowDialog();
                }
                store.SuccessFulTransactions.Add(receipt.Transaction);
                ResetPOS();
            }

            else
            {
                ResetPOS();
            }
        }

        //Method to reset the POS's shopping cart total amount and items stored inside the shopping cart
        private void ResetPOS()
        {
            cartItems.Clear();
            cartTotal = 0;
            lblTotalAmt.Text = cartTotal.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
    }
}
