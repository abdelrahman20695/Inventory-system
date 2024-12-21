namespace Inventory_system
{
    partial class AddProductForm
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
            label1 = new Label();
            txtProductName = new TextBox();
            Lable2 = new Label();
            txtProductQuantity = new TextBox();
            label2 = new Label();
            txtProductPrice = new TextBox();
            btnSaveProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(87, 92);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.WhiteSmoke;
            txtProductName.Location = new Point(213, 90);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Lable2.Location = new Point(87, 137);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(77, 21);
            Lable2.TabIndex = 2;
            Lable2.Text = "Quantity";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.BackColor = Color.WhiteSmoke;
            txtProductQuantity.Location = new Point(213, 139);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(100, 23);
            txtProductQuantity.TabIndex = 3;
            txtProductQuantity.TextChanged += txtProductQuantity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(87, 180);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 4;
            label2.Text = "Price";
            // 
            // txtProductPrice
            // 
            txtProductPrice.BackColor = Color.WhiteSmoke;
            txtProductPrice.Location = new Point(213, 182);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(100, 23);
            txtProductPrice.TabIndex = 5;
            txtProductPrice.TextChanged += txtProductPrice_TextChanged;
            // 
            // btnSaveProduct
            // 
            btnSaveProduct.BackColor = SystemColors.ControlDark;
            btnSaveProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSaveProduct.Location = new Point(169, 276);
            btnSaveProduct.Name = "btnSaveProduct";
            btnSaveProduct.Size = new Size(107, 36);
            btnSaveProduct.TabIndex = 6;
            btnSaveProduct.Text = "Add";
            btnSaveProduct.UseVisualStyleBackColor = false;
            btnSaveProduct.Click += btnSaveProduct_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(469, 380);
            Controls.Add(btnSaveProduct);
            Controls.Add(txtProductPrice);
            Controls.Add(label2);
            Controls.Add(txtProductQuantity);
            Controls.Add(Lable2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "EditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label Lable2;
        private TextBox txtProductQuantity;
        private Label label2;
        private TextBox txtProductPrice;
        private Button btnSaveProduct;
    }
}