using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store("Sam's");
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        BindingSource vendorsBindingSource = new BindingSource();


        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemsBindingSource.DataSource = store.Items.Where(item => item.Sold == false).ToList();
            itemsListBox.DataSource = itemsBindingSource;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            cartBindingSource.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBindingSource;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBindingSource.DataSource = store.Vendors;
            vendorsListBox.DataSource = vendorsBindingSource;

            vendorsListBox.DisplayMember = "Display";
            vendorsListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            Vendor simos = new Vendor("Simos", "Pavlakis", 0.6);
            Vendor sue = new Vendor("Sue", "Yu", 0.11);

            Item mobyDick = new Item("Moby Dick", "A Book about a whale", 12.8M, false, simos);
            Item lort = new Item("Lord of the Rings", "Epic", 30.0M, false, sue);
            Item harryPotter = new Item("Harry Potter", "Epic also", 24.5M, false, simos);

            store.Vendors.Add(simos);
            store.Vendors.Add(sue);
            store.Items.Add(mobyDick);
            store.Items.Add(lort);
            store.Items.Add(harryPotter);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemsListBox.SelectedItem;

            shoppingCartData.Add(selectedItem);

            cartBindingSource.ResetBindings(false);
        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                store.Profit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            itemsBindingSource.DataSource = store.Items.Where(item => item.Sold == false).ToList();

            storeProfitValue.Text = store.ProfitDisplay();

            cartBindingSource.ResetBindings(false);
            itemsBindingSource.ResetBindings(false);
            vendorsBindingSource.ResetBindings(false);
        }
    }
}
