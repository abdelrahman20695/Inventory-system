using System.Diagnostics;

namespace Inventory_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            btnDeleteProduct = new Button();
            btnEditProduct = new Button();
            btnShowReports = new Button();
            btnSimulation = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.ControlDark;
            btnAddProduct.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnAddProduct.ForeColor = Color.Black;
            btnAddProduct.Location = new Point(699, 247);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(160, 58);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToOrderColumns = true;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(-2, -2);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(446, 755);
            dgvProducts.TabIndex = 4;
            dgvProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = SystemColors.ControlDark;
            btnDeleteProduct.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnDeleteProduct.ForeColor = Color.Black;
            btnDeleteProduct.Location = new Point(940, 247);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(160, 58);
            btnDeleteProduct.TabIndex = 5;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.BackColor = SystemColors.ControlDark;
            btnEditProduct.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnEditProduct.ForeColor = Color.Black;
            btnEditProduct.Location = new Point(940, 384);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(160, 58);
            btnEditProduct.TabIndex = 6;
            btnEditProduct.Text = "Update Product";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnShowReports
            // 
            btnShowReports.BackColor = SystemColors.ControlDark;
            btnShowReports.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnShowReports.ForeColor = Color.Black;
            btnShowReports.Location = new Point(705, 384);
            btnShowReports.Name = "btnShowReports";
            btnShowReports.Size = new Size(154, 58);
            btnShowReports.TabIndex = 7;
            btnShowReports.Text = "The Store";
            btnShowReports.UseVisualStyleBackColor = false;
            btnShowReports.Click += btnShowReports_Click;
            // 
            // btnSimulation
            // 
            btnSimulation.BackColor = Color.Tomato;
            btnSimulation.BackgroundImageLayout = ImageLayout.Center;
            btnSimulation.FlatStyle = FlatStyle.Flat;
            btnSimulation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimulation.Location = new Point(1039, 38);
            btnSimulation.Name = "btnSimulation";
            btnSimulation.Size = new Size(172, 49);
            btnSimulation.TabIndex = 8;
            btnSimulation.Text = "Start Simulation";
            btnSimulation.UseVisualStyleBackColor = false;
            btnSimulation.Click += btnSimulation_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.YellowGreen;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(827, 514);
            button1.Name = "button1";
            button1.Size = new Size(154, 58);
            button1.TabIndex = 9;
            button1.Text = "Export to Excel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1259, 749);
            Controls.Add(button1);
            Controls.Add(btnSimulation);
            Controls.Add(btnShowReports);
            Controls.Add(btnEditProduct);
            Controls.Add(btnDeleteProduct);
            Controls.Add(dgvProducts);
            Controls.Add(btnAddProduct);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Inventory Managment";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddProduct;
        private DataGridView dgvProducts;
        private Button btnDeleteProduct;
        private Button btnEditProduct;
        private Button btnShowReports;
        private Button btnSimulation;
        private Button button1;
        private DataGridViewColumn ColumnName;
        private DataGridViewColumn Price;
        private DataGridViewColumn Quantity;
        private DataGridViewColumn SalesCount;
    }
}
