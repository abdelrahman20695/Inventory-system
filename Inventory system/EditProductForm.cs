using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_system
{

    public partial class EditProductForm : Form
    {
        public Product UpdatedProduct { get; private set; }

        public EditProductForm(Product product)
        {
            InitializeComponent();

            // تعبئة الحقول ببيانات المنتج
            txtName.Text = product.Name;
            txtQuantity.Text = product.Quantity.ToString();
            txtPrice.Text = product.Price.ToString();

            // إعداد المنتج للتحديث
            UpdatedProduct = product;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // التحقق من صحة المدخلات
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("يرجى ملء جميع الحقول.");
                return;
            }

            // تحديث بيانات المنتج
            UpdatedProduct.Name = txtName.Text;
            UpdatedProduct.Quantity = int.Parse(txtQuantity.Text);
            UpdatedProduct.Price = decimal.Parse(txtPrice.Text);  // هنا يتم استخدام decimal.Parse بدلاً من double.Parse

            // إغلاق النافذة وإرجاع النتيجة
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
