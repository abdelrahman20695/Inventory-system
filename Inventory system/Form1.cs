using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventory_system
{
    public partial class Form1 : Form
    {
        private bool isSimulationRunning = false; 
                                                  
        public List<Product> inventory = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
              
            AddProductForm addForm = new AddProductForm(inventory);
            addForm.ShowDialog();
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = inventory;
        }

        private void btnDisplayProducts_Click(object sender, EventArgs e)
        {

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = inventory;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
          
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvProducts.SelectedRows[0].Index;

                inventory.RemoveAt(selectedIndex);

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = inventory;

                MessageBox.Show(" „ Õ–› «·„‰ Ã »‰Ã«Õ!");
            }
            else
            {
                MessageBox.Show("Ì—ÃÏ «Œ Ì«— „‰ Ã ·Õ–›Â.");
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvProducts.SelectedRows[0].Index;

                Product selectedProduct = inventory[selectedIndex];

                EditProductForm editForm = new EditProductForm(selectedProduct);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    inventory[selectedIndex] = editForm.UpdatedProduct;

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = inventory;

                    MessageBox.Show(" „  ⁄œÌ· «·„‰ Ã »‰Ã«Õ!");
                }
            }
            else
            {
                MessageBox.Show("Ì—ÃÏ «Œ Ì«— „‰ Ã · ⁄œÌ·Â.");
            }
        }

        private void btnShowReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(this);
            reportsForm.ShowDialog();

        }

        public List<Product> GetTopSellingProducts(int topCount)
        {
            return inventory.OrderByDescending(p => p.SalesCount).Take(10).ToList();
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            if (!isSimulationRunning) 
            {
                btnSimulation.Text = "Stop Simualtion"; 
                isSimulationRunning = true; 
                StartSimulation();
            }
            else 
            {
                btnSimulation.Text = "Start Simulation"; 
                isSimulationRunning = false; 
            }
        }
        private async void StartSimulation()
        {
            Random rand = new Random();

            while (isSimulationRunning)
            {
                string randomProductName = "Product" + rand.Next(1, 1000).ToString();
                int randomQuantity = rand.Next(1, 100); 
                decimal randomPrice = rand.Next(1, 1000); 
                int randomSalesCount = rand.Next(1, 50);  

                var product = new Product(randomProductName, randomQuantity, randomPrice, randomSalesCount);
                inventory.Add(product);

                await Task.Delay(100); 
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = inventory;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel(inventory);

        }
        private void ExportToExcel(List<Product> products)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;  

            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];
            worksheet.Name = "Products Report";

            
            worksheet.Cells[1, 1] = "Product Name";
            worksheet.Cells[1, 2] = "Quantity";
            worksheet.Cells[1, 3] = "Price";
            worksheet.Cells[1, 4] = "Sales Count";

            int row = 2; 
            foreach (var product in products)
            {
                worksheet.Cells[row, 1] = product.Name;
                worksheet.Cells[row, 2] = product.Quantity;
                worksheet.Cells[row, 3] = product.Price;
                worksheet.Cells[row, 4] = product.SalesCount;
                row++;
            }

            // Õ›Ÿ «·„·› ›Ì „ﬂ«‰ „⁄Ì‰ √Ê Õ›ŸÂ »«”„ „Œ’’
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show(" „  ’œÌ— «·»Ì«‰«  ≈·Ï Excel »‰Ã«Õ!");
            }

            //  ‰ŸÌ› «·–«ﬂ—…
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(excelApp);
        }

        private void dataGridViewTopSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int SalesCount { get; set; }

        public Product(string name, int quantity, decimal price, int salesCount)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            SalesCount = salesCount; 
        }
        public Product(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            SalesCount = 0; 
        }

        public void SellProduct(int quantity)
        {
            if (Quantity >= quantity)
            {
                Quantity -= quantity;
                SalesCount += quantity; 
            }
            else
            {
                MessageBox.Show("«·ﬂ„Ì… €Ì— ﬂ«›Ì… ··»Ì⁄");
            }
        }

       
    }
}
