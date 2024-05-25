namespace TechHouse
{
    partial class Editar_Order
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
            label11 = new Label();
            OrderID = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            ShippingAddress = new TextBox();
            PaymentMethod = new TextBox();
            Orders_UserID = new TextBox();
            Status = new TextBox();
            OrderDate = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 49);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 79;
            label11.Text = "Order ID";
            // 
            // OrderID
            // 
            OrderID.Location = new Point(66, 49);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(115, 23);
            OrderID.TabIndex = 78;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(593, 109);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 77;
            label14.Text = "User ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(251, 106);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 76;
            label15.Text = "Shipping Address";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(550, 52);
            label16.Name = "label16";
            label16.Size = new Size(99, 15);
            label16.TabIndex = 75;
            label16.Text = "Payment Method";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(311, 54);
            label17.Name = "label17";
            label17.Size = new Size(39, 15);
            label17.TabIndex = 74;
            label17.Text = "Status";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(-1, 101);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 73;
            label18.Text = "OrderDate";
            // 
            // ShippingAddress
            // 
            ShippingAddress.Location = new Point(356, 101);
            ShippingAddress.Name = "ShippingAddress";
            ShippingAddress.Size = new Size(115, 23);
            ShippingAddress.TabIndex = 72;
            // 
            // PaymentMethod
            // 
            PaymentMethod.Location = new Point(655, 49);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(115, 23);
            PaymentMethod.TabIndex = 71;
            // 
            // Orders_UserID
            // 
            Orders_UserID.Location = new Point(655, 106);
            Orders_UserID.Name = "Orders_UserID";
            Orders_UserID.Size = new Size(115, 23);
            Orders_UserID.TabIndex = 70;
            // 
            // Status
            // 
            Status.Location = new Point(356, 51);
            Status.Name = "Status";
            Status.Size = new Size(115, 23);
            Status.TabIndex = 69;
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(66, 98);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(115, 23);
            OrderDate.TabIndex = 68;
            // 
            // button1
            // 
            button1.Location = new Point(369, 205);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 80;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Editar_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(OrderID);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(ShippingAddress);
            Controls.Add(PaymentMethod);
            Controls.Add(Orders_UserID);
            Controls.Add(Status);
            Controls.Add(OrderDate);
            Name = "Editar_Order";
            Text = "Editar_Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private TextBox OrderID;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox ShippingAddress;
        private TextBox PaymentMethod;
        private TextBox Orders_UserID;
        private TextBox Status;
        private TextBox OrderDate;
        private Button button1;
    }
}