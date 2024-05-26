namespace TechHouse
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
            tabControl1 = new TabControl();
            Users = new TabPage();
            button33 = new Button();
            SearchUser = new Button();
            label49 = new Label();
            Users_UserID = new TextBox();
            DeleteUser = new Button();
            AddUser = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Users_Password = new TextBox();
            Users_Contact = new TextBox();
            Users_Address = new TextBox();
            Users_Email = new TextBox();
            Users_LName = new TextBox();
            Users_FName = new TextBox();
            tabPage2 = new TabPage();
            button34 = new Button();
            SearchProduct = new Button();
            label7 = new Label();
            Products_ProductID = new TextBox();
            DeleteProduct = new Button();
            AddProduct = new Button();
            dataGridView2 = new DataGridView();
            CategoryId = new Label();
            ProductPrice = new Label();
            StockQty = new Label();
            ProductBrand = new Label();
            label13 = new Label();
            Product_Price = new TextBox();
            product_qty = new TextBox();
            Product_CategoryID = new TextBox();
            Product_Brand = new TextBox();
            Products_ProductName = new TextBox();
            tabPage3 = new TabPage();
            button35 = new Button();
            SearchOrder = new Button();
            Order_OrderDate = new DateTimePicker();
            Order_PayMethod = new ComboBox();
            label11 = new Label();
            Order_OrderID = new TextBox();
            DeleteOrder = new Button();
            AddOrder = new Button();
            dataGridView3 = new DataGridView();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            Order_ShippAddr = new TextBox();
            Orders_UserID = new TextBox();
            Order_Status = new TextBox();
            tabPage4 = new TabPage();
            button36 = new Button();
            Employ_EmpType = new ComboBox();
            SearchEmployee = new Button();
            label21 = new Label();
            Employ_EmpID = new TextBox();
            DeleteEmployee = new Button();
            AddEmployee = new Button();
            dataGridView4 = new DataGridView();
            label22 = new Label();
            EmployeeTipeID = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            Contact_Employee = new TextBox();
            Address_Employee = new TextBox();
            Email_Employee = new TextBox();
            LN_Employee = new TextBox();
            FN_Employee = new TextBox();
            tabPage5 = new TabPage();
            button37 = new Button();
            Reviews_Rating = new ComboBox();
            SearchReview = new Button();
            label8 = new Label();
            Reviews_RID = new TextBox();
            DeleteReview = new Button();
            AddReview = new Button();
            dataGridView5 = new DataGridView();
            label9 = new Label();
            label12 = new Label();
            label19 = new Label();
            label20 = new Label();
            Reviews_PID = new TextBox();
            Reviews_UID = new TextBox();
            Reviews_Comment = new TextBox();
            tabPage6 = new TabPage();
            button38 = new Button();
            Wish_DAdd = new DateTimePicker();
            SearchWhish = new Button();
            label35 = new Label();
            Whish_WID = new TextBox();
            DeleteWhish = new Button();
            AddWhish = new Button();
            dataGridView6 = new DataGridView();
            label37 = new Label();
            label40 = new Label();
            label41 = new Label();
            Whish_PID = new TextBox();
            Whish_UID = new TextBox();
            tabPage7 = new TabPage();
            button39 = new Button();
            SearchRequest = new Button();
            Request_Status = new ComboBox();
            Request_RD = new DateTimePicker();
            label10 = new Label();
            Request_RID = new TextBox();
            DeleteRequest = new Button();
            AddRequest = new Button();
            dataGridView7 = new DataGridView();
            label23 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            Request_EID = new TextBox();
            Request_UID = new TextBox();
            Request_Description = new TextBox();
            tabPage8 = new TabPage();
            button40 = new Button();
            Logs_DT = new DateTimePicker();
            SearchLog = new Button();
            label32 = new Label();
            Logs_LogID = new TextBox();
            DeleteLog = new Button();
            AddLog = new Button();
            dataGridView8 = new DataGridView();
            label33 = new Label();
            label34 = new Label();
            label36 = new Label();
            Logs_UID = new TextBox();
            Logs_Action = new TextBox();
            tabControl1.SuspendLayout();
            Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Users);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 619);
            tabControl1.TabIndex = 0;
            // 
            // Users
            // 
            Users.Controls.Add(button33);
            Users.Controls.Add(SearchUser);
            Users.Controls.Add(label49);
            Users.Controls.Add(Users_UserID);
            Users.Controls.Add(DeleteUser);
            Users.Controls.Add(AddUser);
            Users.Controls.Add(dataGridView1);
            Users.Controls.Add(label6);
            Users.Controls.Add(label5);
            Users.Controls.Add(label4);
            Users.Controls.Add(label3);
            Users.Controls.Add(label2);
            Users.Controls.Add(label1);
            Users.Controls.Add(Users_Password);
            Users.Controls.Add(Users_Contact);
            Users.Controls.Add(Users_Address);
            Users.Controls.Add(Users_Email);
            Users.Controls.Add(Users_LName);
            Users.Controls.Add(Users_FName);
            Users.Location = new Point(4, 24);
            Users.Name = "Users";
            Users.Padding = new Padding(3);
            Users.Size = new Size(1026, 591);
            Users.TabIndex = 0;
            Users.Text = "Users";
            Users.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            button33.Location = new Point(280, 560);
            button33.Name = "button33";
            button33.Size = new Size(108, 23);
            button33.TabIndex = 35;
            button33.Text = "Edit Users";
            button33.UseVisualStyleBackColor = true;
            button33.Click += button33_Click_1;
            // 
            // SearchUser
            // 
            SearchUser.Location = new Point(895, 560);
            SearchUser.Name = "SearchUser";
            SearchUser.Size = new Size(108, 23);
            SearchUser.TabIndex = 34;
            SearchUser.Text = "Search";
            SearchUser.UseVisualStyleBackColor = true;
            SearchUser.Click += SearchUser_Click;
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new Point(24, 31);
            label49.Name = "label49";
            label49.Size = new Size(44, 15);
            label49.TabIndex = 33;
            label49.Text = "User ID";
            // 
            // Users_UserID
            // 
            Users_UserID.Location = new Point(74, 28);
            Users_UserID.Name = "Users_UserID";
            Users_UserID.Size = new Size(164, 23);
            Users_UserID.TabIndex = 32;
            // 
            // DeleteUser
            // 
            DeleteUser.Location = new Point(150, 560);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(108, 23);
            DeleteUser.TabIndex = 31;
            DeleteUser.Text = "Delete User";
            DeleteUser.UseVisualStyleBackColor = true;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(22, 560);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(108, 23);
            AddUser.TabIndex = 29;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(981, 466);
            dataGridView1.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(784, 49);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 27;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(524, 51);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 26;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(784, 19);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 25;
            label4.Text = "Contact";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 48);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 24;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(545, 19);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 23;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 22;
            label1.Text = "First Name";
            // 
            // Users_Password
            // 
            Users_Password.Location = new Point(587, 48);
            Users_Password.Name = "Users_Password";
            Users_Password.PasswordChar = '*';
            Users_Password.Size = new Size(164, 23);
            Users_Password.TabIndex = 21;
            // 
            // Users_Contact
            // 
            Users_Contact.Location = new Point(839, 12);
            Users_Contact.Name = "Users_Contact";
            Users_Contact.Size = new Size(164, 23);
            Users_Contact.TabIndex = 20;
            // 
            // Users_Address
            // 
            Users_Address.Location = new Point(839, 45);
            Users_Address.Name = "Users_Address";
            Users_Address.Size = new Size(164, 23);
            Users_Address.TabIndex = 19;
            // 
            // Users_Email
            // 
            Users_Email.Location = new Point(587, 12);
            Users_Email.Name = "Users_Email";
            Users_Email.Size = new Size(164, 23);
            Users_Email.TabIndex = 18;
            // 
            // Users_LName
            // 
            Users_LName.Location = new Point(339, 45);
            Users_LName.Name = "Users_LName";
            Users_LName.Size = new Size(164, 23);
            Users_LName.TabIndex = 17;
            // 
            // Users_FName
            // 
            Users_FName.Location = new Point(339, 12);
            Users_FName.Name = "Users_FName";
            Users_FName.Size = new Size(164, 23);
            Users_FName.TabIndex = 16;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button34);
            tabPage2.Controls.Add(SearchProduct);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(Products_ProductID);
            tabPage2.Controls.Add(DeleteProduct);
            tabPage2.Controls.Add(AddProduct);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(CategoryId);
            tabPage2.Controls.Add(ProductPrice);
            tabPage2.Controls.Add(StockQty);
            tabPage2.Controls.Add(ProductBrand);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(Product_Price);
            tabPage2.Controls.Add(product_qty);
            tabPage2.Controls.Add(Product_CategoryID);
            tabPage2.Controls.Add(Product_Brand);
            tabPage2.Controls.Add(Products_ProductName);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1026, 591);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Products";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            button34.Location = new Point(278, 558);
            button34.Name = "button34";
            button34.Size = new Size(108, 23);
            button34.TabIndex = 53;
            button34.Text = "Edit Products";
            button34.UseVisualStyleBackColor = true;
            button34.Click += button34_Click_1;
            // 
            // SearchProduct
            // 
            SearchProduct.Location = new Point(896, 558);
            SearchProduct.Name = "SearchProduct";
            SearchProduct.Size = new Size(108, 23);
            SearchProduct.TabIndex = 52;
            SearchProduct.Text = "Search";
            SearchProduct.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(106, 27);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 51;
            label7.Text = "Product ID";
            // 
            // Products_ProductID
            // 
            Products_ProductID.Location = new Point(177, 24);
            Products_ProductID.Name = "Products_ProductID";
            Products_ProductID.Size = new Size(164, 23);
            Products_ProductID.TabIndex = 50;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(151, 558);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(108, 23);
            DeleteProduct.TabIndex = 49;
            DeleteProduct.Text = "Delete Product";
            DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(23, 558);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(108, 23);
            AddProduct.TabIndex = 47;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(23, 98);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(981, 443);
            dataGridView2.TabIndex = 46;
            // 
            // CategoryId
            // 
            CategoryId.AutoSize = true;
            CategoryId.Location = new Point(663, 53);
            CategoryId.Name = "CategoryId";
            CategoryId.Size = new Size(66, 15);
            CategoryId.TabIndex = 45;
            CategoryId.Text = "CategoryID";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSize = true;
            ProductPrice.Location = new Point(390, 58);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(33, 15);
            ProductPrice.TabIndex = 44;
            ProductPrice.Text = "Price";
            // 
            // StockQty
            // 
            StockQty.AutoSize = true;
            StockQty.Location = new Point(644, 27);
            StockQty.Name = "StockQty";
            StockQty.Size = new Size(85, 15);
            StockQty.TabIndex = 43;
            StockQty.Text = "Stock Quantity";
            // 
            // ProductBrand
            // 
            ProductBrand.AutoSize = true;
            ProductBrand.Location = new Point(385, 27);
            ProductBrand.Name = "ProductBrand";
            ProductBrand.Size = new Size(38, 15);
            ProductBrand.TabIndex = 41;
            ProductBrand.Text = "Brand";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(132, 58);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 40;
            label13.Text = "Name";
            // 
            // Product_Price
            // 
            Product_Price.Location = new Point(429, 55);
            Product_Price.Name = "Product_Price";
            Product_Price.Size = new Size(164, 23);
            Product_Price.TabIndex = 39;
            // 
            // product_qty
            // 
            product_qty.Location = new Point(735, 21);
            product_qty.Name = "product_qty";
            product_qty.Size = new Size(164, 23);
            product_qty.TabIndex = 38;
            // 
            // Product_CategoryID
            // 
            Product_CategoryID.Location = new Point(735, 55);
            Product_CategoryID.Name = "Product_CategoryID";
            Product_CategoryID.Size = new Size(164, 23);
            Product_CategoryID.TabIndex = 37;
            // 
            // Product_Brand
            // 
            Product_Brand.Location = new Point(429, 24);
            Product_Brand.Name = "Product_Brand";
            Product_Brand.Size = new Size(164, 23);
            Product_Brand.TabIndex = 36;
            // 
            // Products_ProductName
            // 
            Products_ProductName.Location = new Point(177, 55);
            Products_ProductName.Name = "Products_ProductName";
            Products_ProductName.Size = new Size(164, 23);
            Products_ProductName.TabIndex = 34;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button35);
            tabPage3.Controls.Add(SearchOrder);
            tabPage3.Controls.Add(Order_OrderDate);
            tabPage3.Controls.Add(Order_PayMethod);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(Order_OrderID);
            tabPage3.Controls.Add(DeleteOrder);
            tabPage3.Controls.Add(AddOrder);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(Order_ShippAddr);
            tabPage3.Controls.Add(Orders_UserID);
            tabPage3.Controls.Add(Order_Status);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1026, 591);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Orders";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button35
            // 
            button35.Location = new Point(298, 553);
            button35.Name = "button35";
            button35.Size = new Size(125, 23);
            button35.TabIndex = 71;
            button35.Text = "Edit Orders";
            button35.UseVisualStyleBackColor = true;
            button35.Click += button35_Click_1;
            // 
            // SearchOrder
            // 
            SearchOrder.Location = new Point(896, 553);
            SearchOrder.Name = "SearchOrder";
            SearchOrder.Size = new Size(108, 23);
            SearchOrder.TabIndex = 70;
            SearchOrder.Text = "Search";
            SearchOrder.UseVisualStyleBackColor = true;
            // 
            // Order_OrderDate
            // 
            Order_OrderDate.Location = new Point(143, 53);
            Order_OrderDate.Name = "Order_OrderDate";
            Order_OrderDate.Size = new Size(179, 23);
            Order_OrderDate.TabIndex = 69;
            // 
            // Order_PayMethod
            // 
            Order_PayMethod.FormattingEnabled = true;
            Order_PayMethod.Location = new Point(767, 19);
            Order_PayMethod.Name = "Order_PayMethod";
            Order_PayMethod.Size = new Size(164, 23);
            Order_PayMethod.TabIndex = 68;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(72, 22);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 67;
            label11.Text = "Order ID";
            // 
            // Order_OrderID
            // 
            Order_OrderID.Location = new Point(143, 19);
            Order_OrderID.Name = "Order_OrderID";
            Order_OrderID.Size = new Size(179, 23);
            Order_OrderID.TabIndex = 66;
            // 
            // DeleteOrder
            // 
            DeleteOrder.Location = new Point(152, 553);
            DeleteOrder.Name = "DeleteOrder";
            DeleteOrder.Size = new Size(125, 23);
            DeleteOrder.TabIndex = 65;
            DeleteOrder.Text = "Delete Order";
            DeleteOrder.UseVisualStyleBackColor = true;
            // 
            // AddOrder
            // 
            AddOrder.Location = new Point(23, 553);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(108, 23);
            AddOrder.TabIndex = 63;
            AddOrder.Text = "Add Order";
            AddOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(23, 93);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(981, 443);
            dataGridView3.TabIndex = 62;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(717, 53);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 61;
            label14.Text = "User ID";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(357, 53);
            label15.Name = "label15";
            label15.Size = new Size(99, 15);
            label15.TabIndex = 60;
            label15.Text = "Shipping Address";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(662, 22);
            label16.Name = "label16";
            label16.Size = new Size(99, 15);
            label16.TabIndex = 59;
            label16.Text = "Payment Method";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(417, 24);
            label17.Name = "label17";
            label17.Size = new Size(39, 15);
            label17.TabIndex = 58;
            label17.Text = "Status";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(72, 53);
            label18.Name = "label18";
            label18.Size = new Size(61, 15);
            label18.TabIndex = 57;
            label18.Text = "OrderDate";
            // 
            // Order_ShippAddr
            // 
            Order_ShippAddr.Location = new Point(462, 50);
            Order_ShippAddr.Name = "Order_ShippAddr";
            Order_ShippAddr.Size = new Size(164, 23);
            Order_ShippAddr.TabIndex = 56;
            // 
            // Orders_UserID
            // 
            Orders_UserID.Location = new Point(767, 50);
            Orders_UserID.Name = "Orders_UserID";
            Orders_UserID.Size = new Size(164, 23);
            Orders_UserID.TabIndex = 54;
            // 
            // Order_Status
            // 
            Order_Status.Location = new Point(462, 21);
            Order_Status.Name = "Order_Status";
            Order_Status.Size = new Size(164, 23);
            Order_Status.TabIndex = 53;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button36);
            tabPage4.Controls.Add(Employ_EmpType);
            tabPage4.Controls.Add(SearchEmployee);
            tabPage4.Controls.Add(label21);
            tabPage4.Controls.Add(Employ_EmpID);
            tabPage4.Controls.Add(DeleteEmployee);
            tabPage4.Controls.Add(AddEmployee);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Controls.Add(label22);
            tabPage4.Controls.Add(EmployeeTipeID);
            tabPage4.Controls.Add(label24);
            tabPage4.Controls.Add(label25);
            tabPage4.Controls.Add(label26);
            tabPage4.Controls.Add(label27);
            tabPage4.Controls.Add(Contact_Employee);
            tabPage4.Controls.Add(Address_Employee);
            tabPage4.Controls.Add(Email_Employee);
            tabPage4.Controls.Add(LN_Employee);
            tabPage4.Controls.Add(FN_Employee);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1026, 591);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Employees";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button36
            // 
            button36.Location = new Point(276, 558);
            button36.Name = "button36";
            button36.Size = new Size(108, 23);
            button36.TabIndex = 54;
            button36.Text = "Edit Employees";
            button36.UseVisualStyleBackColor = true;
            button36.Click += button36_Click_1;
            // 
            // Employ_EmpType
            // 
            Employ_EmpType.FormattingEnabled = true;
            Employ_EmpType.Location = new Point(615, 43);
            Employ_EmpType.Name = "Employ_EmpType";
            Employ_EmpType.Size = new Size(164, 23);
            Employ_EmpType.TabIndex = 53;
            // 
            // SearchEmployee
            // 
            SearchEmployee.Location = new Point(896, 558);
            SearchEmployee.Name = "SearchEmployee";
            SearchEmployee.Size = new Size(108, 23);
            SearchEmployee.TabIndex = 52;
            SearchEmployee.Text = "Search";
            SearchEmployee.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(23, 13);
            label21.Name = "label21";
            label21.Size = new Size(73, 15);
            label21.TabIndex = 51;
            label21.Text = "Employee ID";
            // 
            // Employ_EmpID
            // 
            Employ_EmpID.Location = new Point(102, 10);
            Employ_EmpID.Name = "Employ_EmpID";
            Employ_EmpID.Size = new Size(164, 23);
            Employ_EmpID.TabIndex = 50;
            // 
            // DeleteEmployee
            // 
            DeleteEmployee.Location = new Point(149, 558);
            DeleteEmployee.Name = "DeleteEmployee";
            DeleteEmployee.Size = new Size(108, 23);
            DeleteEmployee.TabIndex = 49;
            DeleteEmployee.Text = "Delete Employee";
            DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // AddEmployee
            // 
            AddEmployee.Location = new Point(23, 558);
            AddEmployee.Name = "AddEmployee";
            AddEmployee.Size = new Size(108, 23);
            AddEmployee.TabIndex = 47;
            AddEmployee.Text = "Add Employee";
            AddEmployee.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(23, 77);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(981, 464);
            dataGridView4.TabIndex = 46;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(785, 51);
            label22.Name = "label22";
            label22.Size = new Size(49, 15);
            label22.TabIndex = 45;
            label22.Text = "Address";
            // 
            // EmployeeTipeID
            // 
            EmployeeTipeID.AutoSize = true;
            EmployeeTipeID.Location = new Point(526, 49);
            EmployeeTipeID.Name = "EmployeeTipeID";
            EmployeeTipeID.Size = new Size(86, 15);
            EmployeeTipeID.TabIndex = 44;
            EmployeeTipeID.Text = "Employee Type";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(785, 17);
            label24.Name = "label24";
            label24.Size = new Size(49, 15);
            label24.TabIndex = 43;
            label24.Text = "Contact";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(277, 46);
            label25.Name = "label25";
            label25.Size = new Size(63, 15);
            label25.TabIndex = 42;
            label25.Text = "Last Name";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(573, 17);
            label26.Name = "label26";
            label26.Size = new Size(36, 15);
            label26.TabIndex = 41;
            label26.Text = "Email";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(276, 12);
            label27.Name = "label27";
            label27.Size = new Size(64, 15);
            label27.TabIndex = 40;
            label27.Text = "First Name";
            // 
            // Contact_Employee
            // 
            Contact_Employee.Location = new Point(840, 14);
            Contact_Employee.Name = "Contact_Employee";
            Contact_Employee.Size = new Size(164, 23);
            Contact_Employee.TabIndex = 38;
            // 
            // Address_Employee
            // 
            Address_Employee.Location = new Point(840, 48);
            Address_Employee.Name = "Address_Employee";
            Address_Employee.Size = new Size(164, 23);
            Address_Employee.TabIndex = 37;
            // 
            // Email_Employee
            // 
            Email_Employee.Location = new Point(615, 14);
            Email_Employee.Name = "Email_Employee";
            Email_Employee.Size = new Size(164, 23);
            Email_Employee.TabIndex = 36;
            // 
            // LN_Employee
            // 
            LN_Employee.Location = new Point(346, 43);
            LN_Employee.Name = "LN_Employee";
            LN_Employee.Size = new Size(164, 23);
            LN_Employee.TabIndex = 35;
            // 
            // FN_Employee
            // 
            FN_Employee.Location = new Point(346, 10);
            FN_Employee.Name = "FN_Employee";
            FN_Employee.Size = new Size(164, 23);
            FN_Employee.TabIndex = 34;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button37);
            tabPage5.Controls.Add(Reviews_Rating);
            tabPage5.Controls.Add(SearchReview);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(Reviews_RID);
            tabPage5.Controls.Add(DeleteReview);
            tabPage5.Controls.Add(AddReview);
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(Reviews_PID);
            tabPage5.Controls.Add(Reviews_UID);
            tabPage5.Controls.Add(Reviews_Comment);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1026, 591);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Reviews";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button37
            // 
            button37.Location = new Point(253, 551);
            button37.Name = "button37";
            button37.Size = new Size(94, 23);
            button37.TabIndex = 86;
            button37.Text = "Edit Reviews";
            button37.UseVisualStyleBackColor = true;
            button37.Click += button37_Click_1;
            // 
            // Reviews_Rating
            // 
            Reviews_Rating.FormattingEnabled = true;
            Reviews_Rating.Location = new Point(166, 52);
            Reviews_Rating.Name = "Reviews_Rating";
            Reviews_Rating.Size = new Size(164, 23);
            Reviews_Rating.TabIndex = 85;
            // 
            // SearchReview
            // 
            SearchReview.Location = new Point(910, 551);
            SearchReview.Name = "SearchReview";
            SearchReview.Size = new Size(94, 23);
            SearchReview.TabIndex = 84;
            SearchReview.Text = "Search";
            SearchReview.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 21);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 83;
            label8.Text = "Review ID";
            // 
            // Reviews_RID
            // 
            Reviews_RID.Location = new Point(166, 18);
            Reviews_RID.Name = "Reviews_RID";
            Reviews_RID.Size = new Size(164, 23);
            Reviews_RID.TabIndex = 82;
            // 
            // DeleteReview
            // 
            DeleteReview.Location = new Point(130, 551);
            DeleteReview.Name = "DeleteReview";
            DeleteReview.Size = new Size(94, 23);
            DeleteReview.TabIndex = 81;
            DeleteReview.Text = "Delete Review";
            DeleteReview.UseVisualStyleBackColor = true;
            // 
            // AddReview
            // 
            AddReview.Location = new Point(23, 551);
            AddReview.Name = "AddReview";
            AddReview.Size = new Size(84, 23);
            AddReview.TabIndex = 79;
            AddReview.Text = "Add Review";
            AddReview.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(23, 91);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.Size = new Size(981, 443);
            dataGridView5.TabIndex = 78;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(699, 52);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 77;
            label9.Text = "User ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(683, 21);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 75;
            label12.Text = "ProductID";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(389, 36);
            label19.Name = "label19";
            label19.Size = new Size(61, 15);
            label19.TabIndex = 74;
            label19.Text = "Comment";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(112, 52);
            label20.Name = "label20";
            label20.Size = new Size(41, 15);
            label20.TabIndex = 73;
            label20.Text = "Rating";
            // 
            // Reviews_PID
            // 
            Reviews_PID.Location = new Point(755, 18);
            Reviews_PID.Name = "Reviews_PID";
            Reviews_PID.Size = new Size(164, 23);
            Reviews_PID.TabIndex = 71;
            // 
            // Reviews_UID
            // 
            Reviews_UID.Location = new Point(755, 49);
            Reviews_UID.Name = "Reviews_UID";
            Reviews_UID.Size = new Size(164, 23);
            Reviews_UID.TabIndex = 70;
            // 
            // Reviews_Comment
            // 
            Reviews_Comment.Location = new Point(456, 33);
            Reviews_Comment.Name = "Reviews_Comment";
            Reviews_Comment.Size = new Size(164, 23);
            Reviews_Comment.TabIndex = 69;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button38);
            tabPage6.Controls.Add(Wish_DAdd);
            tabPage6.Controls.Add(SearchWhish);
            tabPage6.Controls.Add(label35);
            tabPage6.Controls.Add(Whish_WID);
            tabPage6.Controls.Add(DeleteWhish);
            tabPage6.Controls.Add(AddWhish);
            tabPage6.Controls.Add(dataGridView6);
            tabPage6.Controls.Add(label37);
            tabPage6.Controls.Add(label40);
            tabPage6.Controls.Add(label41);
            tabPage6.Controls.Add(Whish_PID);
            tabPage6.Controls.Add(Whish_UID);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(1026, 591);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "WishList";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            button38.Location = new Point(274, 558);
            button38.Name = "button38";
            button38.Size = new Size(108, 23);
            button38.TabIndex = 54;
            button38.Text = "Edit Whishlist";
            button38.UseVisualStyleBackColor = true;
            button38.Click += button38_Click_1;
            // 
            // Wish_DAdd
            // 
            Wish_DAdd.Location = new Point(359, 19);
            Wish_DAdd.Name = "Wish_DAdd";
            Wish_DAdd.Size = new Size(175, 23);
            Wish_DAdd.TabIndex = 53;
            // 
            // SearchWhish
            // 
            SearchWhish.Location = new Point(896, 558);
            SearchWhish.Name = "SearchWhish";
            SearchWhish.Size = new Size(108, 23);
            SearchWhish.TabIndex = 52;
            SearchWhish.Text = "Search";
            SearchWhish.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(554, 22);
            label35.Name = "label35";
            label35.Size = new Size(44, 15);
            label35.TabIndex = 51;
            label35.Text = "User ID";
            // 
            // Whish_WID
            // 
            Whish_WID.Location = new Point(95, 19);
            Whish_WID.Name = "Whish_WID";
            Whish_WID.Size = new Size(164, 23);
            Whish_WID.TabIndex = 50;
            // 
            // DeleteWhish
            // 
            DeleteWhish.Location = new Point(150, 558);
            DeleteWhish.Name = "DeleteWhish";
            DeleteWhish.Size = new Size(108, 23);
            DeleteWhish.TabIndex = 49;
            DeleteWhish.Text = "Delete Wishlist";
            DeleteWhish.UseVisualStyleBackColor = true;
            // 
            // AddWhish
            // 
            AddWhish.Location = new Point(23, 558);
            AddWhish.Name = "AddWhish";
            AddWhish.Size = new Size(108, 23);
            AddWhish.TabIndex = 47;
            AddWhish.Text = "Add Whishlist";
            AddWhish.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(23, 60);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.Size = new Size(981, 481);
            dataGridView6.TabIndex = 46;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(774, 22);
            label37.Name = "label37";
            label37.Size = new Size(60, 15);
            label37.TabIndex = 44;
            label37.Text = "ProductID";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(284, 22);
            label40.Name = "label40";
            label40.Size = new Size(69, 15);
            label40.TabIndex = 41;
            label40.Text = "Date Added";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(23, 27);
            label41.Name = "label41";
            label41.Size = new Size(66, 15);
            label41.TabIndex = 40;
            label41.Text = "WhishlistID";
            // 
            // Whish_PID
            // 
            Whish_PID.Location = new Point(840, 19);
            Whish_PID.Name = "Whish_PID";
            Whish_PID.PasswordChar = '*';
            Whish_PID.Size = new Size(164, 23);
            Whish_PID.TabIndex = 39;
            // 
            // Whish_UID
            // 
            Whish_UID.Location = new Point(604, 19);
            Whish_UID.Name = "Whish_UID";
            Whish_UID.Size = new Size(164, 23);
            Whish_UID.TabIndex = 34;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(button39);
            tabPage7.Controls.Add(SearchRequest);
            tabPage7.Controls.Add(Request_Status);
            tabPage7.Controls.Add(Request_RD);
            tabPage7.Controls.Add(label10);
            tabPage7.Controls.Add(Request_RID);
            tabPage7.Controls.Add(DeleteRequest);
            tabPage7.Controls.Add(AddRequest);
            tabPage7.Controls.Add(dataGridView7);
            tabPage7.Controls.Add(label23);
            tabPage7.Controls.Add(label28);
            tabPage7.Controls.Add(label29);
            tabPage7.Controls.Add(label30);
            tabPage7.Controls.Add(label31);
            tabPage7.Controls.Add(Request_EID);
            tabPage7.Controls.Add(Request_UID);
            tabPage7.Controls.Add(Request_Description);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(1026, 591);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "ServicesRequest";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            button39.Location = new Point(277, 551);
            button39.Name = "button39";
            button39.Size = new Size(108, 23);
            button39.TabIndex = 87;
            button39.Text = "Edit Request";
            button39.UseVisualStyleBackColor = true;
            button39.Click += button39_Click_1;
            // 
            // SearchRequest
            // 
            SearchRequest.Location = new Point(896, 551);
            SearchRequest.Name = "SearchRequest";
            SearchRequest.Size = new Size(108, 23);
            SearchRequest.TabIndex = 86;
            SearchRequest.Text = "Search";
            SearchRequest.UseVisualStyleBackColor = true;
            // 
            // Request_Status
            // 
            Request_Status.FormattingEnabled = true;
            Request_Status.Location = new Point(757, 47);
            Request_Status.Name = "Request_Status";
            Request_Status.Size = new Size(176, 23);
            Request_Status.TabIndex = 85;
            // 
            // Request_RD
            // 
            Request_RD.Location = new Point(757, 18);
            Request_RD.Name = "Request_RD";
            Request_RD.Size = new Size(176, 23);
            Request_RD.TabIndex = 84;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(105, 24);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 83;
            label10.Text = "Request ID";
            // 
            // Request_RID
            // 
            Request_RID.Location = new Point(174, 18);
            Request_RID.Name = "Request_RID";
            Request_RID.Size = new Size(164, 23);
            Request_RID.TabIndex = 82;
            // 
            // DeleteRequest
            // 
            DeleteRequest.Location = new Point(153, 551);
            DeleteRequest.Name = "DeleteRequest";
            DeleteRequest.Size = new Size(108, 23);
            DeleteRequest.TabIndex = 81;
            DeleteRequest.Text = "Delete Request";
            DeleteRequest.UseVisualStyleBackColor = true;
            // 
            // AddRequest
            // 
            AddRequest.Location = new Point(23, 551);
            AddRequest.Name = "AddRequest";
            AddRequest.Size = new Size(108, 23);
            AddRequest.TabIndex = 79;
            AddRequest.Text = "Add Request";
            AddRequest.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(23, 91);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.Size = new Size(981, 443);
            dataGridView7.TabIndex = 78;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(712, 50);
            label23.Name = "label23";
            label23.Size = new Size(39, 15);
            label23.TabIndex = 77;
            label23.Text = "Status";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(376, 50);
            label28.Name = "label28";
            label28.Size = new Size(73, 15);
            label28.TabIndex = 76;
            label28.Text = "Employee ID";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(675, 21);
            label29.Name = "label29";
            label29.Size = new Size(76, 15);
            label29.TabIndex = 75;
            label29.Text = "Request Date";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(405, 24);
            label30.Name = "label30";
            label30.Size = new Size(44, 15);
            label30.TabIndex = 74;
            label30.Text = "User ID";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(101, 55);
            label31.Name = "label31";
            label31.Size = new Size(67, 15);
            label31.TabIndex = 73;
            label31.Text = "Description";
            // 
            // Request_EID
            // 
            Request_EID.Location = new Point(455, 47);
            Request_EID.Name = "Request_EID";
            Request_EID.Size = new Size(164, 23);
            Request_EID.TabIndex = 72;
            // 
            // Request_UID
            // 
            Request_UID.Location = new Point(455, 18);
            Request_UID.Name = "Request_UID";
            Request_UID.Size = new Size(164, 23);
            Request_UID.TabIndex = 69;
            // 
            // Request_Description
            // 
            Request_Description.Location = new Point(174, 50);
            Request_Description.Name = "Request_Description";
            Request_Description.Size = new Size(164, 23);
            Request_Description.TabIndex = 68;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(button40);
            tabPage8.Controls.Add(Logs_DT);
            tabPage8.Controls.Add(SearchLog);
            tabPage8.Controls.Add(label32);
            tabPage8.Controls.Add(Logs_LogID);
            tabPage8.Controls.Add(DeleteLog);
            tabPage8.Controls.Add(AddLog);
            tabPage8.Controls.Add(dataGridView8);
            tabPage8.Controls.Add(label33);
            tabPage8.Controls.Add(label34);
            tabPage8.Controls.Add(label36);
            tabPage8.Controls.Add(Logs_UID);
            tabPage8.Controls.Add(Logs_Action);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(1026, 591);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "AccessLogs";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            button40.Location = new Point(240, 554);
            button40.Name = "button40";
            button40.Size = new Size(94, 23);
            button40.TabIndex = 66;
            button40.Text = "Edit Logs";
            button40.UseVisualStyleBackColor = true;
            button40.Click += button40_Click_1;
            // 
            // Logs_DT
            // 
            Logs_DT.Location = new Point(572, 15);
            Logs_DT.Name = "Logs_DT";
            Logs_DT.Size = new Size(200, 23);
            Logs_DT.TabIndex = 65;
            // 
            // SearchLog
            // 
            SearchLog.Location = new Point(910, 554);
            SearchLog.Name = "SearchLog";
            SearchLog.Size = new Size(94, 23);
            SearchLog.TabIndex = 64;
            SearchLog.Text = "Search";
            SearchLog.UseVisualStyleBackColor = true;
            SearchLog.Click += SearchLog_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(509, 18);
            label32.Name = "label32";
            label32.Size = new Size(57, 15);
            label32.TabIndex = 63;
            label32.Text = "DateTime";
            // 
            // Logs_LogID
            // 
            Logs_LogID.Location = new Point(70, 15);
            Logs_LogID.Name = "Logs_LogID";
            Logs_LogID.Size = new Size(164, 23);
            Logs_LogID.TabIndex = 62;
            // 
            // DeleteLog
            // 
            DeleteLog.Location = new Point(123, 554);
            DeleteLog.Name = "DeleteLog";
            DeleteLog.Size = new Size(94, 23);
            DeleteLog.TabIndex = 61;
            DeleteLog.Text = "Delete Log";
            DeleteLog.UseVisualStyleBackColor = true;
            // 
            // AddLog
            // 
            AddLog.Location = new Point(23, 554);
            AddLog.Name = "AddLog";
            AddLog.Size = new Size(84, 23);
            AddLog.TabIndex = 59;
            AddLog.Text = "Add Log";
            AddLog.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(23, 56);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.Size = new Size(981, 481);
            dataGridView8.TabIndex = 58;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(790, 18);
            label33.Name = "label33";
            label33.Size = new Size(44, 15);
            label33.TabIndex = 57;
            label33.Text = "User ID";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(269, 18);
            label34.Name = "label34";
            label34.Size = new Size(42, 15);
            label34.TabIndex = 56;
            label34.Text = "Action";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(23, 18);
            label36.Name = "label36";
            label36.Size = new Size(41, 15);
            label36.TabIndex = 55;
            label36.Text = "Log ID";
            // 
            // Logs_UID
            // 
            Logs_UID.Location = new Point(840, 15);
            Logs_UID.Name = "Logs_UID";
            Logs_UID.PasswordChar = '*';
            Logs_UID.Size = new Size(164, 23);
            Logs_UID.TabIndex = 54;
            // 
            // Logs_Action
            // 
            Logs_Action.Location = new Point(317, 15);
            Logs_Action.Name = "Logs_Action";
            Logs_Action.Size = new Size(164, 23);
            Logs_Action.TabIndex = 53;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 619);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Load;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            Users.ResumeLayout(false);
            Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Users;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Button DeleteUser;
        private Button AddUser;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Users_Password;
        private TextBox Users_Contact;
        private TextBox Users_Address;
        private TextBox Users_Email;
        private TextBox Users_LName;
        private TextBox Users_FName;
        private Label label49;
        private TextBox Users_UserID;
        private Label label7;
        private TextBox Products_ProductID;
        private Button DeleteProduct;
        private Button AddProduct;
        private DataGridView dataGridView2;
        private Label CategoryId;
        private Label ProductPrice;
        private Label StockQty;
        private Label ProductBrand;
        private Label label13;
        private TextBox Product_Price;
        private TextBox product_qty;
        private TextBox Product_CategoryID;
        private TextBox Product_Brand;
        private TextBox Products_ProductName;
        private Label label21;
        private TextBox Employ_EmpID;
        private Button DeleteEmployee;
        private Button AddEmployee;
        private DataGridView dataGridView4;
        private Label label22;
        private Label EmployeeTipeID;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private TextBox Contact_Employee;
        private TextBox Address_Employee;
        private TextBox Email_Employee;
        private TextBox LN_Employee;
        private TextBox FN_Employee;
        private Label label35;
        private TextBox Whish_WID;
        private Button DeleteWhish;
        private Button AddWhish;
        private DataGridView dataGridView6;
        private Label label37;
        private Label label40;
        private Label label41;
        private TextBox Whish_PID;
        private TextBox Whish_UID;
        private Label label11;
        private TextBox Order_OrderID;
        private Button DeleteOrder;
        private Button AddOrder;
        private DataGridView dataGridView3;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox Order_ShippAddr;
        private TextBox Orders_UserID;
        private TextBox Order_Status;
        private Label label8;
        private TextBox Reviews_RID;
        private Button DeleteReview;
        private Button AddReview;
        private DataGridView dataGridView5;
        private Label label9;
        private Label label12;
        private Label label19;
        private Label label20;
        private TextBox Reviews_PID;
        private TextBox Reviews_UID;
        private TextBox Reviews_Comment;
        private Label label10;
        private TextBox Request_RID;
        private Button DeleteRequest;
        private Button AddRequest;
        private DataGridView dataGridView7;
        private Label label23;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private TextBox Request_EID;
        private TextBox Request_UID;
        private TextBox Request_Description;
        private Label label32;
        private TextBox Logs_LogID;
        private Button DeleteLog;
        private Button AddLog;
        private DataGridView dataGridView8;
        private Label label33;
        private Label label34;
        private Label label36;
        private TextBox Logs_UID;
        private TextBox Logs_Action;
        private ComboBox Order_PayMethod;
        private Button SearchUser;
        private DateTimePicker Order_OrderDate;
        private Button SearchProduct;
        private Button SearchOrder;
        private Button SearchEmployee;
        private ComboBox Reviews_Rating;
        private Button SearchReview;
        private Button SearchWhish;
        private DateTimePicker Wish_DAdd;
        private DateTimePicker Request_RD;
        private Button SearchRequest;
        private ComboBox Request_Status;
        private Button SearchLog;
        private DateTimePicker Logs_DT;
        private ComboBox Employ_EmpType;
        private Button button33;
        private Button button34;
        private Button button35;
        private Button button36;
        private Button button37;
        private Button button38;
        private Button button39;
        private Button button40;
    }
}
