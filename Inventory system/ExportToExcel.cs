using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Inventory_system
{
    internal class ExportToExcel
    {

        private void ExportToExcelM(List<Product> products)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;  

           
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
    }
}
