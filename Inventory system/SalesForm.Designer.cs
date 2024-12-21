namespace Inventory_system
{
    partial class SalesForm
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
            btnSellProduct = new Button();
            txtProductName = new TextBox();
            txtQuantitySold = new TextBox();
            Lable2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSellProduct
            // 
            btnSellProduct.BackColor = SystemColors.ControlDark;
            btnSellProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSellProduct.Location = new Point(183, 260);
            btnSellProduct.Name = "btnSellProduct";
            btnSellProduct.Size = new Size(100, 40);
            btnSellProduct.TabIndex = 0;
            btnSellProduct.Text = "Ok";
            btnSellProduct.UseVisualStyleBackColor = false;
            btnSellProduct.Click += btnSellProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.WhiteSmoke;
            txtProductName.Location = new Point(232, 93);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(100, 23);
            txtProductName.TabIndex = 1;
            // 
            // txtQuantitySold
            // 
            txtQuantitySold.BackColor = Color.WhiteSmoke;
            txtQuantitySold.Location = new Point(232, 168);
            txtQuantitySold.Name = "txtQuantitySold";
            txtQuantitySold.Size = new Size(100, 23);
            txtQuantitySold.TabIndex = 2;
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Lable2.Location = new Point(106, 168);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(77, 21);
            Lable2.TabIndex = 13;
            Lable2.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(106, 95);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 12;
            label4.Text = "Product Name";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(454, 368);
            Controls.Add(Lable2);
            Controls.Add(label4);
            Controls.Add(txtQuantitySold);
            Controls.Add(txtProductName);
            Controls.Add(btnSellProduct);
            Name = "SalesForm";
            Text = "Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSellProduct;
        private TextBox txtProductName;
        private TextBox txtQuantitySold;
        private Label Lable2;
        private Label label4;
    }
}