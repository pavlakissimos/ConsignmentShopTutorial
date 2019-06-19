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
        private Store store = new Store();

        public ConsignmentShop()
        {
            InitializeComponent();
        }

        private void SetupData()
        {
            Vendor simos = new Vendor("Simos", "Pavlakis", 0.6);
            Vendor sue = new Vendor("Sue", "Yu", 0.11);
            store.Vendors.Add(simos);
            store.Vendors.Add(sue);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
