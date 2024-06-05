using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TechHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show("Form1 is being initialized");
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

        }

        private void button33_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o de editar User
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedUserId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                Editar Edi1 = new Editar();

                // Pass the selected user ID to the Edit form
                Edi1.UserID.Text = selectedUserId.ToString();

                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    Edi1.TextBoxes[i].Text = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                }

                Edi1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }

        }

        private void button34_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o de editar Produto
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedPID = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                Editar_Produt Edi2 = new Editar_Produt();

                // Pass the selected user ID to the Edit form
                Edi2.ProductID.Text = selectedPID.ToString();
                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    if (i == 5) { Edi2.Product_CategoryID.Text = dataGridView2.SelectedRows[0].Cells[i].Value.ToString(); continue; }
                    Edi2.TextBoxes[textBoxIndex].Text = dataGridView2.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Products.");
            }

        }

        private void button35_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o de editar Order
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedOrderId = (int)dataGridView3.SelectedRows[0].Cells[0].Value;
                Editar_Order Edi3 = new Editar_Order();

                // Pass the selected user ID to the Edit form
                Edi3.OrderID.Text = selectedOrderId.ToString();
                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView3.Columns.Count; i++)
                {
                    if (i == 1)
                    {
                        string date = dataGridView3.SelectedRows[0].Cells[i].Value.ToString();
                        Edi3.OrderDate.Value = DateTime.Parse(date);
                        continue;
                    }
                    if (i == 2) { Edi3.Status.Text = dataGridView3.SelectedRows[0].Cells[i].Value.ToString(); continue; }
                    if (i == 4) { Edi3.PaymentMethod.Text = dataGridView3.SelectedRows[0].Cells[i].Value.ToString(); continue; }

                    if (i == 5) { Edi3.UserID.Text = dataGridView3.SelectedRows[0].Cells[i].Value.ToString(); continue; }

                    Edi3.TextBoxes[textBoxIndex].Text = dataGridView3.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Order.");
            }
        }

        private void button36_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o editar Employee
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedEID = (int)dataGridView4.SelectedRows[0].Cells[0].Value;
                Editar_Employees Edi4 = new Editar_Employees();

                // Pass the selected user ID to the Edit form
                Edi4.EID.Text = selectedEID.ToString();

                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView4.Columns.Count; i++)
                {
                    if (i == 5) { Edi4.comboBox1.Text = dataGridView4.SelectedRows[0].Cells[5].Value.ToString(); continue; } //skip the sixth column porque n�o � textbox
                    Edi4.TextBoxes[textBoxIndex].Text = dataGridView4.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Employee.");
            }
        }

        private void button37_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o editar Review
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedRID = (int)dataGridView5.SelectedRows[0].Cells[0].Value;
                Editar_Reviews Edi5 = new Editar_Reviews();

                // Pass the selected user ID to the Edit form
                Edi5.RID.Text = selectedRID.ToString();

                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView5.Columns.Count; i++)
                {
                    if (i == 1) { Edi5.Rating.Text = dataGridView5.SelectedRows[0].Cells[i].Value.ToString(); continue; } //skip the second column porque n�o � textbox
                    if (i == 3) { Edi5.UserID.Text = dataGridView5.SelectedRows[0].Cells[i].Value.ToString(); continue; } //skip the fourth column porque n�o � textbox
                    if (i == 4) { Edi5.ProductID.Text = dataGridView5.SelectedRows[0].Cells[i].Value.ToString(); continue; } //skip the fifth column porque n�o � textbox

                    Edi5.TextBoxes[textBoxIndex].Text = dataGridView5.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi5.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }
        }

        private void button38_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o editar Whishlist
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedWID = (int)dataGridView6.SelectedRows[0].Cells[0].Value;
                Editar_whilist Edi6 = new Editar_whilist();

                // Pass the selected user ID to the Edit form
                Edi6.WID.Text = selectedWID.ToString();

                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView6.Columns.Count; i++)
                {
                    if (i == 1) { Edi6.Whishlist_UserID.Text = dataGridView6.SelectedRows[0].Cells[i].Value.ToString(); continue; }
                    if (i == 2) { Edi6.WhishlistPID.Text = dataGridView6.SelectedRows[0].Cells[i].Value.ToString(); continue; }
                    if (i == 3)
                    {
                        string date = dataGridView6.SelectedRows[0].Cells[i].Value.ToString();
                        Edi6.dateTimePicker1.Value = DateTime.Parse(date);
                        continue;
                    }
                    Edi6.TextBoxes[textBoxIndex].Text = dataGridView6.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Whishlist.");
            }
        }

        private void button39_Click_1(object sender, EventArgs e) //logica para quando clica no bot�o editar Service Request
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedRID = (int)dataGridView7.SelectedRows[0].Cells[0].Value;
                Editar_ServiceRequest Edi7 = new Editar_ServiceRequest();

                // Pass the selected user ID to the Edit form
                Edi7.RID.Text = selectedRID.ToString();

                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView7.Columns.Count; i++)
                {
                    if (i == 2) { Edi7.UserID.Text = dataGridView7.SelectedRows[0].Cells[i].Value.ToString(); continue; } //skip the third column porque n�o � textbox
                    if (i == 3) { Edi7.EmployeeID.Text = dataGridView7.SelectedRows[0].Cells[i].Value.ToString(); continue; } //skip the fourth column porque n�o � textbox
                    if (i == 4) { Edi7.dateTimePicker1.Value = DateTime.Parse(dataGridView7.SelectedRows[0].Cells[i].Value.ToString()); continue; } //skip the fifth column porque n�o � textbox
                    if (i == 5) { Edi7.Status.Text = dataGridView7.SelectedRows[0].Cells[i].Value.ToString(); continue; } //skip the sixth column porque n�o � textbox
                    Edi7.TextBoxes[textBoxIndex].Text = dataGridView7.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi7.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Service Request.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
            LoadProductsCategory();
            LoadOrderUser();
            LoadPayMethod();
            LoadEmployeeTypes();
            LoadUserReview();
            LoadProductReview();
            LoadReviewRating();
            LoadWhishProduct();
            LoadWhishUser();
            LoadUserService();
            LoadServiceEmployee();
            LoadServiceStatus();
            LoadUserLog();
            LoadOrderStatus();
        }
        public void FillDataGridView(DataGridView dataGridView, string connectionString, string tableName)
        {
            //MessageBox.Show("FillDataGridView is being called");
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView.DataSource = table;
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string tableName;

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    tableName = "[TechHouse].[User]";
                    FillDataGridView(dataGridView1, connectionString, tableName);
                    break;
                case 1:
                    tableName = "[TechHouse].[Products]";
                    FillDataGridView(dataGridView2, connectionString, tableName);
                    break;
                case 2:
                    tableName = "[TechHouse].[Orders]";
                    FillDataGridView(dataGridView3, connectionString, tableName);
                    break;
                case 3:
                    tableName = "[TechHouse].[Employee]";
                    FillDataGridView(dataGridView4, connectionString, tableName);
                    break;
                case 4:
                    tableName = "[TechHouse].[Reviews]";
                    FillDataGridView(dataGridView5, connectionString, tableName);
                    break;
                case 5:
                    tableName = "[TechHouse].[Wishlist]";
                    FillDataGridView(dataGridView6, connectionString, tableName);
                    break;
                case 6:
                    tableName = "[TechHouse].[ServicesRequests]";
                    FillDataGridView(dataGridView7, connectionString, tableName);
                    break;
                case 7:
                    tableName = "[TechHouse].[AccessLogs]";
                    FillDataGridView(dataGridView8, connectionString, tableName);
                    break;


            }
        }

        //////////////////////////////////////////////////  USERS TAB PAGE  //////////////////////////////////////////////////

        private void AddUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "INSERT INTO [TechHouse].[User] (FirstName, LastName, Email, PhoneNumber, Password, Address) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @Password, @Address)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", Users_FName.Text); //The textboxes are named Users_FName, Users_LName, etc.
                    command.Parameters.AddWithValue("@LastName", Users_LName.Text);
                    command.Parameters.AddWithValue("@Email", Users_Email.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", Users_Contact.Text);
                    command.Parameters.AddWithValue("@Password", Users_Password.Text);
                    command.Parameters.AddWithValue("@Address", Users_Address.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User added successfully");
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "DELETE FROM [TechHouse].[User] WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedUserId = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@UserID", selectedUserId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("User deleted successfully");
        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[User] WHERE 1=1");

            if (!string.IsNullOrEmpty(Users_FName.Text))
            {
                query.Append($" AND FirstName LIKE '%{Users_FName.Text}%'");
            }

            if (!string.IsNullOrEmpty(Users_LName.Text))
            {
                query.Append($" AND LastName LIKE '%{Users_LName.Text}%'");
            }

            if (!string.IsNullOrEmpty(Users_UserID.Text))
            {
                query.Append($" AND UserID LIKE '%{Users_UserID.Text}%'");
            }

            if (!string.IsNullOrEmpty(Users_Email.Text))
            {
                query.Append($" AND Email LIKE '%{Users_Email.Text}%'");
            }

            if (!string.IsNullOrEmpty(Users_Contact.Text))
            {
                query.Append($" AND PhoneNumber LIKE '%{Users_Contact.Text}%'");
            }

            if (!string.IsNullOrEmpty(Users_Address.Text))
            {
                query.Append($" AND Address LIKE '%{Users_Address.Text}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

        }

        //////////////////////////////////////////////////  PRODUCTS TAB PAGE  //////////////////////////////////////////////////


        private void AddProduct_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "INSERT INTO [TechHouse].[Products] (Name, Brand, Price, StockQty, CategoryID) VALUES (@Name, @Brand, @Price, @StockQty, @CategoryID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", Products_ProductName.Text);
                    command.Parameters.AddWithValue("@Brand", Product_Brand.Text);
                    decimal price;
                    if (decimal.TryParse(Product_Price.Text, out price))
                    {
                        command.Parameters.AddWithValue("@Price", price);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid price.");
                        return;
                    }
                    int stockQty;
                    if (int.TryParse(product_qty.Text, out stockQty))
                    {
                        command.Parameters.AddWithValue("@StockQty", stockQty);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid stock quantity.");
                        return;
                    }
                    if (Product_CategoryID.Text == null || Product_CategoryID.Text == "")
                    {
                        MessageBox.Show("Please select a category");
                        return;
                    }
                    command.Parameters.AddWithValue("@CategoryID", int.Parse(Product_CategoryID.Text.Split('-')[0].Trim()));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product added successfully");

        }

        private void LoadProductsCategory()
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "SELECT CategoryID, Name FROM [TechHouse].[Category]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Product_CategoryID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Product_CategoryID.Items.Add(reader["CategoryID"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [TechHouse].[Product] WHERE UserID = @ProductID";
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedProductId = (int)dataGridView2.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@ProductID", selectedProductId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product deleted successfully");
        }

        private void SearchProduct_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[Products] WHERE 1=1");

            if (!string.IsNullOrEmpty(Products_ProductName.Text))
            {
                query.Append($" AND Name LIKE '%{Products_ProductName.Text}%'");
            }

            if (!string.IsNullOrEmpty(Product_Brand.Text))
            {
                query.Append($" AND Brand LIKE '%{Product_Brand.Text}%'");
            }

            if (!string.IsNullOrEmpty(Products_ProductID.Text))
            {
                query.Append($" AND ProductID LIKE '%{Products_ProductID.Text}%'");
            }

            if (!string.IsNullOrEmpty(Product_Price.Text))
            {
                query.Append($" AND Price LIKE '%{Product_Price.Text}%'");
            }

            if (!string.IsNullOrEmpty(product_qty.Text))
            {
                query.Append($" AND StockQty LIKE '%{product_qty.Text}%'");
            }

            if (!string.IsNullOrEmpty(Product_CategoryID.Text))
            {
                query.Append($" AND CategoryID LIKE '%{(Product_CategoryID.Text.Split('-')[0].Trim())}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        //////////////////////////////////////////////////  ORDERS TAB PAGE  //////////////////////////////////////////////////
        private void AddOrder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "INSERT INTO [TechHouse].[Orders] (OrderDate, Status, ShippingAddress, PaymentMethod, UserID) VALUES (@OrderDate, @Status, @ShippingAddress, @PaymentMethod, @UserID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string formattedDate = Order_OrderDate.Value.ToString("yyyy-MM-dd");
                    command.Parameters.AddWithValue("@OrderDate", formattedDate); //The textboxes are named Users_FName, Users_LName, etc.
                    if (Order_Status.Text == null || Order_Status.Text == "")
                    {
                        MessageBox.Show("Please select a status");
                        return;
                    }
                    command.Parameters.AddWithValue("@Status", Order_Status.Text);
                    command.Parameters.AddWithValue("@ShippingAddress", Order_ShippAddr.Text);
                    if (Order_PayMethod.Text == null || Order_PayMethod.Text == "")
                    {
                        MessageBox.Show("Please select a payment method");
                        return;
                    }
                    command.Parameters.AddWithValue("@PaymentMethod", Order_PayMethod.Text);
                    if (Orders_UserID.Text == null || Orders_UserID.Text == "")
                    {
                        MessageBox.Show("Please select a user");
                        return;
                    }
                    command.Parameters.AddWithValue("@UserID", Orders_UserID.Text.Split('-')[0].Trim());

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order added successfully to User " + Orders_UserID.Text);

        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "DELETE FROM [TechHouse].[Orders] WHERE OrderID = @OrderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedOrderId = (int)dataGridView3.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@OrderID", selectedOrderId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Order deleted successfully");
        }

        private void SearchOrder_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string orderdateNotChanged = Order_OrderDate.Value.ToString();
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[Order] WHERE 1=1");
            if ((!string.IsNullOrEmpty(Order_OrderDate.Value.ToString())) && Order_OrderDate.Value.ToString() != orderdateNotChanged)
            {
                string formattedDate = Order_OrderDate.Value.ToString("yyyy-MM-dd");
                query.Append($" AND OrderDate LIKE '%{formattedDate}%'");
            }

            if (!string.IsNullOrEmpty(Order_Status.Text))
            {
                query.Append($" AND Status LIKE '%{Order_Status.Text}%'");
            }

            if (!string.IsNullOrEmpty(Order_OrderID.Text))
            {
                query.Append($" AND OrderID LIKE '%{Order_OrderID.Text}%'");
            }

            if (!string.IsNullOrEmpty(Order_ShippAddr.Text))
            {
                query.Append($" AND ShippingAddress LIKE '%{Order_ShippAddr.Text}%'");
            }

            if (!string.IsNullOrEmpty(Order_PayMethod.Text))
            {
                query.Append($" AND PaymentMethod LIKE '%{Order_PayMethod.Text}%'");
            }

            if (!string.IsNullOrEmpty(Orders_UserID.Text))
            {
                query.Append($" AND UserID LIKE '%{(Orders_UserID.Text.Split('-')[0].Trim())}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView3.DataSource = table;
                    dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

        }


        private void LoadOrderUser()
        {
            string connectionString = "Data Source=tcp:mednat.ieeta.pt\\SQLSERVER,8101;Persist Security Info=True;User ID=p1g10;Password=G10123!;Encrypt=False";
            string query = "SELECT UserID,FirstName FROM [TechHouse].[User]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Orders_UserID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Orders_UserID.Items.Add(reader["UserID"].ToString() + " - " + reader["FirstName"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadPayMethod()
        {
            Order_PayMethod.Items.Clear();
            Order_PayMethod.Items.Add("Credit Card");
            Order_PayMethod.Items.Add("Debit Card");
            Order_PayMethod.Items.Add("Paypal");
            Order_PayMethod.Items.Add("Cash");
        }

        private void LoadOrderStatus()
        {
            Order_Status.Items.Clear();
            Order_Status.Items.Add("Pending");
            Order_Status.Items.Add("Processing");
            Order_Status.Items.Add("Shipped");
            Order_Status.Items.Add("Delivered");
            Order_Status.Items.Add("Cancelled");
        }

        bool isOrderDateChanged = false;
        private void Order_OrderDate_ValueChanged(object sender, EventArgs e)
        {
            isOrderDateChanged = true;
        }

        //////////////////////////////////////////////////  EMPLOYEES TAB PAGE  //////////////////////////////////////////////////

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO [TechHouse].[Employee] (FirstName, LastName, Email, PhoneNumber, EmployeeTypeID, Address) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @EmployeeTypeID, @Address)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", FN_Employee.Text); //The textboxes are named Users_FName, Users_LName, etc.
                    command.Parameters.AddWithValue("@LastName", LN_Employee.Text);
                    command.Parameters.AddWithValue("@Email", Email_Employee.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", Contact_Employee.Text);
                    int EmployeeType;
                    if (int.TryParse(Employ_EmpType.Text.Split('-')[0].Trim(), out EmployeeType))
                    {
                        command.Parameters.AddWithValue("@EmployeeTypeID", EmployeeType);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a EmployeeTypeID.");
                        return;
                    }
                    command.Parameters.AddWithValue("@Address", Address_Employee.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Employee added successfully");
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM [TechHouse].[Employee] WHERE EmployeeID = @EmployeeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedEmployeeId = (int)dataGridView4.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@EmployeeID", selectedEmployeeId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Employee deleted successfully");

        }

        private void SearchEmployee_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[Employee] WHERE 1=1");

            if (!string.IsNullOrEmpty(FN_Employee.Text))
            {
                query.Append($" AND FirstName LIKE '%{FN_Employee.Text}%'");
            }

            if (!string.IsNullOrEmpty(LN_Employee.Text))
            {
                query.Append($" AND LastName LIKE '%{LN_Employee.Text}%'");
            }

            if (!string.IsNullOrEmpty(Employ_EmpID.Text))
            {
                query.Append($" AND EmployeeID LIKE '%{Employ_EmpID.Text}%'");
            }

            if (!string.IsNullOrEmpty(Email_Employee.Text))
            {
                query.Append($" AND Email LIKE '%{Email_Employee.Text}%'");
            }

            if (!string.IsNullOrEmpty(Contact_Employee.Text))
            {
                query.Append($" AND PhoneNumber LIKE '%{Contact_Employee.Text}%'");
            }

            if (!string.IsNullOrEmpty(Address_Employee.Text))
            {
                query.Append($" AND Address LIKE '%{Address_Employee.Text}%'");
            }

            if (!string.IsNullOrEmpty(Employ_EmpType.Text))
            {
                query.Append($" AND EmployeeTypeID LIKE '%{Employ_EmpType.Text.Split('-')[0].Trim()}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView4.DataSource = table;
                    dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

        }

        private void LoadEmployeeTypes()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT EmployeeTypeID,Name FROM [TechHouse].[EmployeeType]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Employ_EmpType.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Employ_EmpType.Items.Add(reader["EmployeeTypeID"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }
            }
        }


        //////////////////////////////////////////////////  REVIEWS TAB PAGE  //////////////////////////////////////////////////

        private void AddReview_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO [TechHouse].[Reviews] (Rating, Comment, UserID, ProductID) VALUES (@Rating, @Comment, @UserID, @ProductID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Comment", Reviews_Comment.Text);

                    int Rating;
                    if (int.TryParse(Reviews_Rating.Text.Split('-')[0].Trim(), out Rating))
                    {
                        command.Parameters.AddWithValue("@Rating", Rating);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid rating.");
                        return;
                    }

                    int UserID;
                    if (int.TryParse(Reviews_UID.Text.Split('-')[0].Trim(), out UserID))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID);
                    }
                    else
                    {
                        MessageBox.Show("Please select a UserID.");
                        return;
                    }

                    int ProductID;
                    if (int.TryParse(Reviews_PID.Text.Split('-')[0].Trim(), out ProductID))
                    {
                        command.Parameters.AddWithValue("@ProductID", ProductID);
                    }
                    else
                    {
                        MessageBox.Show("Please select a ProductID.");
                        return;
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Review added successfully");
        }

        private void LoadUserReview()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT UserID,FirstName FROM [TechHouse].[User]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Reviews_UID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Reviews_UID.Items.Add(reader["UserID"].ToString() + " - " + reader["FirstName"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadProductReview()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT ProductID,Name,Brand FROM [TechHouse].[Products]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Reviews_PID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Reviews_PID.Items.Add(reader["ProductID"].ToString() + " - " + reader["Brand"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadReviewRating()
        {
            Reviews_Rating.Items.Clear();
            Reviews_Rating.Items.Add("1 - Very Bad");
            Reviews_Rating.Items.Add("2 - Bad");
            Reviews_Rating.Items.Add("3 - Average");
            Reviews_Rating.Items.Add("4 - Good");
            Reviews_Rating.Items.Add("5 - Excellent");
        }

        private void DeleteReview_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM [TechHouse].[Reviews] WHERE ReviewID = @ReviewID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedReviewId = (int)dataGridView5.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@ReviewID", selectedReviewId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Review deleted successfully");
        }

        private void SearchReview_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[Reviews] WHERE 1=1");

            if (!string.IsNullOrEmpty(Reviews_Rating.Text))
            {
                query.Append($" AND Rating LIKE '%{Reviews_Rating.Text.Split('-')[0].Trim()}%'");
            }

            if (!string.IsNullOrEmpty(Reviews_Comment.Text))
            {
                query.Append($" AND Comment LIKE '%{Reviews_Comment.Text}%'");
            }

            if (!string.IsNullOrEmpty(Reviews_RID.Text))
            {
                query.Append($" AND ReviewID LIKE '%{Reviews_RID.Text}%'");
            }

            if (!string.IsNullOrEmpty(Reviews_UID.Text))
            {
                query.Append($" AND UserID LIKE '%{Reviews_UID.Text.Split('-')[0].Trim()}%'");
            }

            if (!string.IsNullOrEmpty(Reviews_PID.Text))
            {
                query.Append($" AND ProductID LIKE '%{Reviews_PID.Text.Split('-')[0].Trim()}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView5.DataSource = table;
                    dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        //////////////////////////////////////////////////  WISHLIST TAB PAGE  //////////////////////////////////////////////////

        private void AddWhish_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO [TechHouse].[Wishlist] (UserID, ProductID, DateAdded) VALUES (@UserID, @ProductID, @DateAdded)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string formattedDate = Wish_DAdd.Value.ToString("yyyy-MM-dd");
                    command.Parameters.AddWithValue("@DateAdded", formattedDate); //The textboxes are named Users_FName, Users_LName, etc.
                    if (WhishlistPID.Text == null || WhishlistPID.Text == "")
                    {
                        MessageBox.Show("Please select a Product");
                        return;
                    }
                    command.Parameters.AddWithValue("@ProductID", WhishlistPID.Text.Split('-')[0].Trim());
                    if (Whishlist_UserID.Text == null || Whishlist_UserID.Text == "")
                    {
                        MessageBox.Show("Please select a user");
                        return;
                    }
                    command.Parameters.AddWithValue("@UserID", Whishlist_UserID.Text.Split('-')[0].Trim());

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product added successfully to User " + Whishlist_UserID.Text + " Whishlist");
        }

        private void LoadWhishUser()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT UserID,FirstName FROM [TechHouse].[User]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Whishlist_UserID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Whishlist_UserID.Items.Add(reader["UserID"].ToString() + " - " + reader["FirstName"].ToString());
                        }
                    }
                }

            }
        }

        private void LoadWhishProduct()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT ProductID,Name,Brand FROM [TechHouse].[Products]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        WhishlistPID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            WhishlistPID.Items.Add(reader["ProductID"].ToString() + " - " + reader["Brand"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }
            }
        }
        private void DeleteWhish_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM [TechHouse].[Wishlist] WHERE WishlistID = @WhishlistID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedWhishId = (int)dataGridView6.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@WhishlistID", selectedWhishId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Whishlist deleted successfully");
        }

        private void SearchWhish_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[Wishlist] WHERE 1=1");

            if (WhishdateChanged == true)
            {
                string formattedDate = Wish_DAdd.Value.ToString("yyyy-MM-dd");
                query.Append($" AND DateAdded LIKE '%{formattedDate}%'");
            }

            if (!string.IsNullOrEmpty(Whishlist_UserID.Text))
            {
                query.Append($" AND UserID LIKE '%{Whishlist_UserID.Text.Split('-')[0].Trim()}%'");
            }

            if (!string.IsNullOrEmpty(WhishlistPID.Text))
            {
                query.Append($" AND ProductID LIKE '%{WhishlistPID.Text.Split('-')[0].Trim()}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView6.DataSource = table;
                    dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        bool WhishdateChanged = false;
        private void Wish_DAdd_ValueChanged(object sender, EventArgs e)
        {
            WhishdateChanged = true;
        }


        //////////////////////////////////////////////////  SERVICE REQUEST TAB PAGE  //////////////////////////////////////////////////

        private void AddRequest_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "INSERT INTO [TechHouse].[ServicesRequests] (Description, UserID, EmployeeID, RequestDate, Status) VALUES (@Description, @UserID, @EmployeeID, @RequestDate, @Status)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string formattedDate = Request_RD.Value.ToString("yyyy-MM-dd");
                    command.Parameters.AddWithValue("@RequestDate", formattedDate); //The textboxes are named Users_FName, Users_LName, etc.
                    if (Request_EID.Text == null || Request_EID.Text == "")
                    {
                        MessageBox.Show("Please select a user");
                        return;
                    }
                    command.Parameters.AddWithValue("@EmployeeID", Request_EID.Text.Split('-')[0].Trim());
                    if (Request_UID.Text == null || Request_UID.Text == "")
                    {
                        MessageBox.Show("Please select a user");
                        return;
                    }
                    command.Parameters.AddWithValue("@UserID", Request_UID.Text.Split('-')[0].Trim());
                    command.Parameters.AddWithValue("@Description", Request_Description.Text);
                    command.Parameters.AddWithValue("@Status", Request_Status.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Service Added Sucessfully for User " + Request_UID.Text);
        }

        private void LoadUserService()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT UserID,FirstName FROM [TechHouse].[User]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Request_UID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Request_UID.Items.Add(reader["UserID"].ToString() + " - " + reader["FirstName"].ToString());
                        }
                    }
                }

            }
        }

        private void LoadServiceEmployee()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT Employee.EmployeeID, Employee.FirstName, EmployeeType.Name FROM [TechHouse].[Employee] INNER JOIN [TechHouse].[EmployeeType] ON Employee.EmployeeTypeID = EmployeeType.EmployeeTypeID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Request_EID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Request_EID.Items.Add(reader["EmployeeID"].ToString() + " - " + reader["FirstName"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }

            }
        }

        private void LoadServiceStatus()
        {
            Request_Status.Items.Clear();
            Request_Status.Items.Add("Pending");
            Request_Status.Items.Add("In Progress");
            Request_Status.Items.Add("Completed");
        }

        private void DeleteRequest_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM [TechHouse].[ServicesRequests] WHERE RequestID = @RequestID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedRequestId = (int)dataGridView7.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@RequestID", selectedRequestId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Request deleted successfully");
        }

        private void SearchRequest_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[ServicesRequests] WHERE 1=1");

            if (RequestdateChanged == true)
            {
                string formattedDate = Request_RD.Value.ToString("yyyy-MM-dd");
                query.Append($" AND RequestDate LIKE '%{formattedDate}%'");
            }

            if (!string.IsNullOrEmpty(Request_UID.Text))
            {
                query.Append($" AND UserID LIKE '%{Request_UID.Text.Split('-')[0].Trim()}%'");
            }

            if (!string.IsNullOrEmpty(Request_EID.Text))
            {
                query.Append($" AND EmployeeID LIKE '%{Request_EID.Text.Split('-')[0].Trim()}%'");
            }

            if (!string.IsNullOrEmpty(Request_Description.Text))
            {
                query.Append($" AND Description LIKE '%{Request_Description.Text}%'");
            }

            if (!string.IsNullOrEmpty(Request_Status.Text))
            {
                query.Append($" AND Status LIKE '%{Request_Status.Text}%'");
            }

            if (!string.IsNullOrEmpty(Request_RID.Text))
            {
                query.Append($" AND RequestID LIKE '%{Request_RID.Text}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView7.DataSource = table;
                    dataGridView7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        bool RequestdateChanged = false;
        private void Request_RD_ValueChanged(object sender, EventArgs e)
        {
            RequestdateChanged = true;
        }


        //////////////////////////////////////////////////  ACCESS lOGS TAB PAGE  //////////////////////////////////////////////////


        private void DeleteLog_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM [TechHouse].[AccessLogs] WHERE LogID = @LogID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Assume that the ID of the user is in the first column of the DataGridView
                    int selectedLogId = (int)dataGridView8.SelectedRows[0].Cells[0].Value;
                    command.Parameters.AddWithValue("@LogID", selectedLogId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Log deleted successfully");
        }

        private void LoadUserLog()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT UserID,FirstName FROM [TechHouse].[User]";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preench�-lo
                        Log_UID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            Log_UID.Items.Add(reader["UserID"].ToString() + " - " + reader["FirstName"].ToString());
                        }
                    }
                }

            }
        }
        private void SearchLog_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            StringBuilder query = new StringBuilder("SELECT * FROM [TechHouse].[AccessLogs] WHERE 1=1");
            string DateNotChanged = Logs_DT.Value.ToString();

            if (!string.IsNullOrEmpty(Log_UID.Text))
            {
                query.Append($" AND UserID LIKE '%{Log_UID.Text.Split('-')[0].Trim()}%'");
            }

            if (LogdateChanged == true)
            {
                DateTime logDate;
                if (DateTime.TryParse(Logs_DT.Text, out logDate))
                {
                    string formattedDate = logDate.ToString("yyyy-MM-dd");
                    query.Append($" AND CAST(DateTime AS DATE) = '{formattedDate}'");
                }
            }

            if (!string.IsNullOrEmpty(Logs_Action.Text))
            {
                query.Append($" AND Action LIKE '%{Logs_Action.Text}%'");
            }

            if (!string.IsNullOrEmpty(Logs_LogID.Text))
            {
                query.Append($" AND LogID LIKE '%{Logs_LogID.Text}%'");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query.ToString(), connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView8.DataSource = table;
                    dataGridView8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

        }

        bool LogdateChanged = false;
        private void Logs_DT_ValueChanged(object sender, EventArgs e)
        {
            LogdateChanged = true;

        }
    }
}



