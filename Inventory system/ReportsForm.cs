using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace Inventory_system
{
    public partial class ReportsForm : Form
    {
        private Form1 _parentForm;
        public ReportsForm(Form1 parentForm)
        {
            _parentForm = parentForm;
            InitializeComponent();
        }
        private void LoadTopSellingProducts()
        {

            var topSellingProducts = _parentForm.inventory
                .OrderByDescending(p => p.SalesCount)
                .Take(10)
                .ToList();

            dataGridViewTopSelling.Rows.Clear();

            // تعبئة DataGridView بالبيانات
            foreach (var product in topSellingProducts)
            {
                dataGridViewTopSelling.Rows.Add(product.Name, product.Price, product.Quantity, product.SalesCount);
            }
        }
        private int lowStockThreshold = 20;

        private void ReportsForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLowStock_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
            if (form1 != null)
            {
                // الحصول على المنتجات الناقصة
                var lowStockProducts = form1.inventory
                    .Where(p => p.Quantity <= lowStockThreshold).ToList();

                // تنظيف DataGridView
                dataGridViewTopSelling.Rows.Clear();
                dataGridViewTopSelling.Columns.Clear();

                // إعداد الأعمدة في DataGridView
                dataGridViewTopSelling.Columns.Add("ProductName", "Name ");
                dataGridViewTopSelling.Columns.Add("Price", "Price");
                dataGridViewTopSelling.Columns.Add("Quantity", "Quantity");
                dataGridViewTopSelling.Columns.Add("SalesCount", "Sales Count ");

                foreach (DataGridViewColumn column in dataGridViewTopSelling.Columns)
                {
                    column.Width = 120;
                }

                // إذا لم يكن هناك منتجات ناقصة
                if (lowStockProducts.Count == 0)
                {
                    MessageBox.Show("لا توجد منتجات ناقصة في المخزون.", "المخزون جيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // تعبئة DataGridView بالبيانات
                    foreach (var product in lowStockProducts)
                    {
                        dataGridViewTopSelling.Rows.Add(product.Name, product.Price, product.Quantity, product.SalesCount);
                    }

                    MessageBox.Show($"تم عرض {lowStockProducts.Count} منتج ناقص في المخزون.", "تقرير المنتجات الناقصة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTotalProducts_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
            if (form1 != null)
            {
                int totalProducts = form1.inventory.Count;
                MessageBox.Show($"إجمالي عدد المنتجات في المخزون: {totalProducts}", "إجمالي المنتجات", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTotalStockValue_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
            if (form1 != null)
            {
                decimal totalValue = form1.inventory.Sum(p => p.Price * p.Quantity);
                MessageBox.Show($"إجمالي قيمة المخزون الكلية: {totalValue:C}", "قيمة المخزون", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTopProducts_Click(object sender, EventArgs e)
        {
            LoadTopSellingProducts();

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            // فتح نافذة المبيعات
            SalesForm salesForm = new SalesForm(_parentForm);
            salesForm.ShowDialog();  // لفتح نافذة المبيعات بشكل متحكم فيه


        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            // فتح نافذة المشتريات
            PurchaseForm purchaseForm = new PurchaseForm(_parentForm);
            purchaseForm.ShowDialog();  // لفتح نافذة المشتريات بشكل متحكم فيه

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLowSelling_Click(object sender, EventArgs e)
        {
            // استدعاء الدالة لجلب المنتجات الأقل مبيعًا
            var lowSellingProducts = _parentForm.inventory
                .OrderBy(p => p.SalesCount)
                .Take(10)
                .ToList();

            // عرض البيانات في الـ DataGridView
            dataGridViewTopSelling.Rows.Clear(); // تنظيف أي بيانات سابقة
            foreach (var product in lowSellingProducts)
            {
                dataGridViewTopSelling.Rows.Add(product.Name, product.Price, product.Quantity, product.SalesCount);
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(_parentForm.inventory);
        }

        private void ExportToExcel(List<Product> products)
        {
            // إنشاء تطبيق Excel
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;  // جعل Excel مرئيًا

            // إنشاء ملف جديد
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Products Report";

            // إضافة عناوين الأعمدة
            worksheet.Cells[1, 1] = "اسم المنتج";
            worksheet.Cells[1, 2] = "الكمية";
            worksheet.Cells[1, 3] = "السعر";
            worksheet.Cells[1, 4] = "عدد المبيعات";

            // إضافة البيانات من قائمة المنتجات
            int row = 2; // البداية من الصف الثاني لأن الصف الأول يحتوي على العناوين
            foreach (var product in products)
            {
                worksheet.Cells[row, 1] = product.Name;
                worksheet.Cells[row, 2] = product.Quantity;
                worksheet.Cells[row, 3] = product.Price;
                worksheet.Cells[row, 4] = product.SalesCount;
                row++;
            }

            // حفظ الملف في مكان معين أو حفظه باسم مخصص
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("تم تصدير البيانات إلى Excel بنجاح!");
            }

            // تنظيف الذاكرة
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);
        }

        private void ReportsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
