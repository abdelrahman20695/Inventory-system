namespace Inventory_system
{
    partial class EditProductForm
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
            btnUpdate = new Button();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            Lable2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ControlDark;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(201, 251);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 36);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.WhiteSmoke;
            txtPrice.Location = new Point(261, 183);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 12;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.WhiteSmoke;
            txtQuantity.Location = new Point(261, 140);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 10;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.WhiteSmoke;
            txtName.Location = new Point(261, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            txtName.TextChanged += txtProductName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(135, 185);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 16;
            label2.Text = "Price";
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Lable2.Location = new Point(135, 142);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(77, 21);
            Lable2.TabIndex = 15;
            Lable2.Text = "Quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(135, 91);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 14;
            label1.Text = "Product Name";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(501, 367);
            Controls.Add(label2);
            Controls.Add(Lable2);
            Controls.Add(label1);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Name = "EditProductForm";
            Text = "EditProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtName;
        private Label label2;
        private Label Lable2;
        private Label label1;
    }
}