namespace Inventory_system
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLowStock = new Button();
            btnTotalProducts = new Button();
            btnTopProducts = new Button();
            btnSales = new Button();
            btnPurchases = new Button();
            dataGridViewTopSelling = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            SalesCount = new DataGridViewTextBoxColumn();
            btnLowSelling = new Button();
            btnExportToExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopSelling).BeginInit();
            SuspendLayout();
            // 
            // btnLowStock
            // 
            btnLowStock.BackColor = SystemColors.ControlDark;
            btnLowStock.BackgroundImageLayout = ImageLayout.Zoom;
            btnLowStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLowStock.Location = new Point(721, 383);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(148, 54);
            btnLowStock.TabIndex = 0;
            btnLowStock.Text = "Running out";
            btnLowStock.UseVisualStyleBackColor = false;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnTotalProducts
            // 
            btnTotalProducts.BackColor = SystemColors.ControlDark;
            btnTotalProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btnTotalProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTotalProducts.Location = new Point(973, 383);
            btnTotalProducts.Name = "btnTotalProducts";
            btnTotalProducts.Size = new Size(148, 54);
            btnTotalProducts.TabIndex = 1;
            btnTotalProducts.Text = "Total Numper Of Products";
            btnTotalProducts.UseVisualStyleBackColor = false;
            btnTotalProducts.Click += btnTotalProducts_Click;
            // 
            // btnTopProducts
            // 
            btnTopProducts.BackColor = SystemColors.ControlDark;
            btnTopProducts.BackgroundImageLayout = ImageLayout.Zoom;
            btnTopProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTopProducts.Location = new Point(973, 283);
            btnTopProducts.Name = "btnTopProducts";
            btnTopProducts.Size = new Size(148, 54);
            btnTopProducts.TabIndex = 3;
            btnTopProducts.Text = "Best Selling";
            btnTopProducts.UseVisualStyleBackColor = false;
            btnTopProducts.Click += btnTopProducts_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = SystemColors.ControlDark;
            btnSales.BackgroundImageLayout = ImageLayout.Zoom;
            btnSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSales.Location = new Point(721, 185);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(148, 54);
            btnSales.TabIndex = 4;
            btnSales.Text = "Sales";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnPurchases
            // 
            btnPurchases.BackColor = SystemColors.ControlDark;
            btnPurchases.BackgroundImageLayout = ImageLayout.Zoom;
            btnPurchases.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPurchases.Location = new Point(973, 185);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(148, 54);
            btnPurchases.TabIndex = 5;
            btnPurchases.Text = "Purchase";
            btnPurchases.UseVisualStyleBackColor = false;
            btnPurchases.Click += btnPurchases_Click;
            // 
            // dataGridViewTopSelling
            // 
            dataGridViewTopSelling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTopSelling.Columns.AddRange(new DataGridViewColumn[] { ColumnName, Price, Quantity, SalesCount });
            dataGridViewTopSelling.Location = new Point(0, 1);
            dataGridViewTopSelling.Name = "dataGridViewTopSelling";
            dataGridViewTopSelling.Size = new Size(523, 725);
            dataGridViewTopSelling.TabIndex = 6;
            dataGridViewTopSelling.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 120;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.Width = 120;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            Quantity.Width = 120;
            // 
            // SalesCount
            // 
            SalesCount.HeaderText = "SalesCount";
            SalesCount.Name = "SalesCount";
            SalesCount.Width = 120;
            // 
            // btnLowSelling
            // 
            btnLowSelling.BackColor = SystemColors.ControlDark;
            btnLowSelling.BackgroundImageLayout = ImageLayout.Zoom;
            btnLowSelling.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLowSelling.Location = new Point(721, 283);
            btnLowSelling.Name = "btnLowSelling";
            btnLowSelling.Size = new Size(148, 54);
            btnLowSelling.TabIndex = 7;
            btnLowSelling.Text = "Least Selling";
            btnLowSelling.UseVisualStyleBackColor = false;
            btnLowSelling.Click += btnLowSelling_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.YellowGreen;
            btnExportToExcel.BackgroundImageLayout = ImageLayout.Zoom;
            btnExportToExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExportToExcel.Location = new Point(846, 480);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(148, 54);
            btnExportToExcel.TabIndex = 8;
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1301, 727);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnLowSelling);
            Controls.Add(dataGridViewTopSelling);
            Controls.Add(btnPurchases);
            Controls.Add(btnSales);
            Controls.Add(btnTopProducts);
            Controls.Add(btnTotalProducts);
            Controls.Add(btnLowStock);
            Name = "ReportsForm";
            Load += ReportsForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTopSelling).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLowStock;
        private Button btnTotalProducts;
        private Button btnTopProducts;
        private Button btnSales;
        private Button btnPurchases;
        private DataGridView dataGridViewTopSelling;
        private Button btnLowSelling;
        private Button btnExportToExcel;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn SalesCount;
    }
}