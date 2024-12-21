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
    public partial class PurchaseForm : Form
    {
        private Form1 parentForm;

        public PurchaseForm(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            // الحصول على اسم المنتج والكمية من التكست بوكس
            string productName = txtPurchaseProductName.Text;
            int purchaseQuantity;

            // التحقق من إدخال الكمية بشكل صحيح
            if (!int.TryParse(txtPurchaseQuantity.Text, out purchaseQuantity) || purchaseQuantity <= 0)
            {
                MessageBox.Show("الرجاء إدخال كمية صحيحة.");
                return;
            }

            // البحث عن المنتج في المخزون باستخدام مرجع Form1
            var product = parentForm.inventory.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            // إذا كان المنتج موجودًا، نقوم بتحديث الكمية
            if (product != null)
            {
                product.Quantity += purchaseQuantity;  // إضافة الكمية المشتراة إلى الكمية الحالية
                MessageBox.Show($"تم إضافة {purchaseQuantity} من {productName} إلى المخزون.");
            }
            else
            {
                // إذا لم نجد المنتج في المخزون
                MessageBox.Show("المنتج غير موجود في المخزون.");
            }

            // إعادة تعيين الحقول
            txtPurchaseProductName.Clear();
            txtPurchaseQuantity.Clear();
        }
    }
}
