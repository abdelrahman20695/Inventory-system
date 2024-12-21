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
    public partial class SalesForm : Form
    {
        private Form1 _parentForm;
        public SalesForm(Form1 parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }

        private void btnSellProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int quantitySold;

            
            if (int.TryParse(txtQuantitySold.Text, out quantitySold) && quantitySold > 0)
            {
                var product = _parentForm.inventory.FirstOrDefault(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

                if (product != null)
                {
                    if (product.Quantity >= quantitySold)
                    {
                        product.Quantity -= quantitySold;

                        product.SalesCount += quantitySold;

                        MessageBox.Show($"تم بيع {quantitySold} من {productName} بنجاح!");
                    }
                    else
                    {
                        MessageBox.Show("الكمية المباعة أكثر من المتوفرة في المخزون.");
                    }
                }
                else
                {
                    MessageBox.Show("المنتج غير موجود في المخزون.");
                }
            }
            else
            {
                MessageBox.Show("يرجى إدخال كمية صالحة.");
            }



        }
    }
    }