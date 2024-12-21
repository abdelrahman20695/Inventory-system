namespace Inventory_system
{
    partial class PurchaseForm
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
            txtPurchaseQuantity = new TextBox();
            txtPurchaseProductName = new TextBox();
            btnAddPurchase = new Button();
            Lable2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtPurchaseQuantity
            // 
            txtPurchaseQuantity.BackColor = Color.WhiteSmoke;
            txtPurchaseQuantity.Location = new Point(244, 168);
            txtPurchaseQuantity.Name = "txtPurchaseQuantity";
            txtPurchaseQuantity.Size = new Size(100, 23);
            txtPurchaseQuantity.TabIndex = 7;
            // 
            // txtPurchaseProductName
            // 
            txtPurchaseProductName.BackColor = Color.WhiteSmoke;
            txtPurchaseProductName.Location = new Point(244, 105);
            txtPurchaseProductName.Name = "txtPurchaseProductName";
            txtPurchaseProductName.Size = new Size(100, 23);
            txtPurchaseProductName.TabIndex = 6;
            // 
            // btnAddPurchase
            // 
            btnAddPurchase.BackColor = SystemColors.ControlDark;
            btnAddPurchase.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPurchase.Location = new Point(182, 254);
            btnAddPurchase.Name = "btnAddPurchase";
            btnAddPurchase.Size = new Size(98, 39);
            btnAddPurchase.TabIndex = 5;
            btnAddPurchase.Text = "Ok";
            btnAddPurchase.UseVisualStyleBackColor = false;
            btnAddPurchase.Click += btnAddPurchase_Click;
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Lable2.Location = new Point(119, 170);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(77, 21);
            Lable2.TabIndex = 11;
            Lable2.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(119, 107);
            label4.Name = "label4";
            label4.Size = new Size(120, 21);
            label4.TabIndex = 10;
            label4.Text = "Product Name";
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(428, 351);
            Controls.Add(Lable2);
            Controls.Add(label4);
            Controls.Add(txtPurchaseQuantity);
            Controls.Add(txtPurchaseProductName);
            Controls.Add(btnAddPurchase);
            Name = "PurchaseForm";
            Text = "Purchases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPurchaseQuantity;
        private TextBox txtPurchaseProductName;
        private Button btnAddPurchase;
        private Label Lable2;
        private Label label4;
    }
}