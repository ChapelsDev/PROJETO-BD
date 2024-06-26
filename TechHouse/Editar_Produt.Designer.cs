﻿namespace TechHouse
{
    partial class Editar_Produt
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
            label7 = new Label();
            ProductID = new TextBox();
            CategoryId = new Label();
            ProductPrice = new Label();
            StockQty = new Label();
            ProductBrand = new Label();
            label13 = new Label();
            Product_Price = new TextBox();
            product_qty = new TextBox();
            Product_Brand = new TextBox();
            ProductName = new TextBox();
            Save = new Button();
            Cancel = new Button();
            Product_CategoryID = new ComboBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 31);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 63;
            label7.Text = "Product ID";
            // 
            // ProductID
            // 
            ProductID.Location = new Point(137, 28);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(234, 23);
            ProductID.TabIndex = 62;
            // 
            // CategoryId
            // 
            CategoryId.AutoSize = true;
            CategoryId.Location = new Point(63, 188);
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(66, 15);
            CategoryId.TabIndex = 61;
            CategoryId.Text = "CategoryID";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSize = true;
            ProductPrice.Location = new Point(96, 122);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(33, 15);
            ProductPrice.TabIndex = 60;
            ProductPrice.Text = "Price";
            // 
            // StockQty
            // 
            StockQty.AutoSize = true;
            StockQty.Location = new Point(44, 154);
            StockQty.Name = "StockQty";
            StockQty.Size = new Size(85, 15);
            StockQty.TabIndex = 59;
            StockQty.Text = "Stock Quantity";
            // 
            // ProductBrand
            // 
            ProductBrand.AutoSize = true;
            ProductBrand.Location = new Point(91, 91);
            ProductBrand.Name = "ProductBrand";
            ProductBrand.Size = new Size(38, 15);
            ProductBrand.TabIndex = 58;
            ProductBrand.Text = "Brand";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(92, 62);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 57;
            label13.Text = "Name";
            // 
            // Product_Price
            // 
            Product_Price.Location = new Point(137, 119);
            Product_Price.Name = "Product_Price";
            Product_Price.Size = new Size(234, 23);
            Product_Price.TabIndex = 56;
            // 
            // product_qty
            // 
            product_qty.Location = new Point(137, 151);
            product_qty.Name = "product_qty";
            product_qty.Size = new Size(234, 23);
            product_qty.TabIndex = 55;
            // 
            // Product_Brand
            // 
            Product_Brand.Location = new Point(137, 88);
            Product_Brand.Name = "Product_Brand";
            Product_Brand.Size = new Size(234, 23);
            Product_Brand.TabIndex = 53;
            // 
            // ProductName
            // 
            ProductName.Location = new Point(137, 59);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(234, 23);
            ProductName.TabIndex = 52;
            // 
            // Save
            // 
            Save.Location = new Point(137, 247);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 64;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += button1_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(296, 247);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 65;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Product_CategoryID
            // 
            Product_CategoryID.FormattingEnabled = true;
            Product_CategoryID.Location = new Point(137, 185);
            Product_CategoryID.Name = "Product_CategoryID";
            Product_CategoryID.Size = new Size(234, 23);
            Product_CategoryID.TabIndex = 66;
            // 
            // Editar_Produt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(Product_CategoryID);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label7);
            Controls.Add(ProductID);
            Controls.Add(CategoryId);
            Controls.Add(ProductPrice);
            Controls.Add(StockQty);
            Controls.Add(ProductBrand);
            Controls.Add(label13);
            Controls.Add(Product_Price);
            Controls.Add(product_qty);
            Controls.Add(Product_Brand);
            Controls.Add(ProductName);
            Name = "Editar_Produt";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar_Produt";
            Load += Editar_Produt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        public TextBox ProductID;
        private Label CategoryId;
        private Label ProductPrice;
        private Label StockQty;
        private Label ProductBrand;
        private Label label13;
        public TextBox Product_Price;
        public TextBox product_qty;
        public TextBox Product_Brand;
        public TextBox ProductName;
        private Button Save;
        private Button Cancel;
        public ComboBox Product_CategoryID;
    }
}