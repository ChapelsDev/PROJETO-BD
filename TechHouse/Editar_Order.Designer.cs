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
            Status = new TextBox();
            Save = new Button();
            Cancel = new Button();
            PaymentMethod = new ComboBox();
            OrderDate = new DateTimePicker();
            UserID = new ComboBox();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(95, 37);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 79;
            label11.Text = "Order ID";
            // 
            // OrderID
            // 
            OrderID.Location = new Point(152, 34);
            OrderID.Name = "OrderID";
            OrderID.Size = new Size(211, 23);
            OrderID.TabIndex = 78;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(103, 213);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 77;
            label14.Text = "User ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(48, 174);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 76;
            label15.Text = "Shipping Address";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(48, 138);
            label16.Name = "label16";
            label16.Size = new Size(99, 15);
            label16.TabIndex = 75;
            label16.Text = "Payment Method";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(103, 103);
            label17.Name = "label17";
            label17.Size = new Size(39, 15);
            label17.TabIndex = 74;
            label17.Text = "Status";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(81, 71);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 73;
            label18.Text = "OrderDate";
            // 
            // ShippingAddress
            // 
            ShippingAddress.Location = new Point(152, 171);
            ShippingAddress.Name = "ShippingAddress";
            ShippingAddress.Size = new Size(211, 23);
            ShippingAddress.TabIndex = 72;
            // 
            // Status
            // 
            Status.Location = new Point(152, 100);
            Status.Name = "Status";
            Status.Size = new Size(211, 23);
            Status.TabIndex = 69;
            // 
            // Save
            // 
            Save.Location = new Point(169, 264);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 80;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(268, 264);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 81;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // PaymentMethod
            // 
            PaymentMethod.FormattingEnabled = true;
            PaymentMethod.Location = new Point(152, 135);
            PaymentMethod.Name = "PaymentMethod";
            PaymentMethod.Size = new Size(211, 23);
            PaymentMethod.TabIndex = 82;
            PaymentMethod.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(152, 68);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(211, 23);
            OrderDate.TabIndex = 83;
            // 
            // UserID
            // 
            UserID.FormattingEnabled = true;
            UserID.Location = new Point(152, 210);
            UserID.Name = "UserID";
            UserID.Size = new Size(211, 23);
            UserID.TabIndex = 84;
            // 
            // Editar_Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(UserID);
            Controls.Add(OrderDate);
            Controls.Add(PaymentMethod);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label11);
            Controls.Add(OrderID);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(ShippingAddress);
            Controls.Add(Status);
            Name = "Editar_Order";
            Text = "Editar_Order";
            Load += LoadOrder;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        public TextBox OrderID;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        public TextBox ShippingAddress;
        public TextBox Status;
        private Button Save;
        private Button Cancel;
        public ComboBox PaymentMethod;
        public DateTimePicker OrderDate;
        public ComboBox UserID;
    }
}