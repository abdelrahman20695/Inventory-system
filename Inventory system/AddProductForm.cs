using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_system
{
    public partial class AddProductForm : Form
    {
        private List<Product> inventory;
        public AddProductForm(List<Product> inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {

            string name = txtProductName.Text;
            int quantity = int.Parse(txtProductQuantity.Text);
            decimal price = decimal.Parse(txtProductPrice.Text);

            inventory.Add(new Product ( Name = name,  quantity,  price ));
            MessageBox.Show("تمت إضافة المنتج بنجاح!");
            this.Close();
        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
