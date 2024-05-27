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

        private void button33_Click_1(object sender, EventArgs e) //logica para quando clica no botão de editar
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

        private void button34_Click_1(object sender, EventArgs e) //logica para quando clica no botão de editar
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
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }

        }

        private void button35_Click_1(object sender, EventArgs e) //logica para quando clica no botão de editar
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
                    if (i == 1) { continue; }  //skip the second column porque não são textboxes
                    if (i == 4) { continue; } //skip the fifth column porque não são textboxes

                    Edi3.TextBoxes[textBoxIndex].Text = dataGridView3.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }
        }

        private void button36_Click_1(object sender, EventArgs e) //logica para quando clica no botão editar
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
                    if (i == 5) { continue; } //skip the sixth column porque não é textbox
                    Edi4.TextBoxes[textBoxIndex].Text = dataGridView4.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }
        }

        private void button37_Click_1(object sender, EventArgs e) //logica para quando clica no botão editar
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
                    if (i == 1) { continue; } //skip the second column porque não é textbox
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

        private void button38_Click_1(object sender, EventArgs e) //logica para quando clica no botão editar
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
                    if (i == 3) { continue; } //skip the fourth column porque não é textbox
                    Edi6.TextBoxes[textBoxIndex].Text = dataGridView6.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi6.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }
        }

        private void button39_Click_1(object sender, EventArgs e) //logica para quando clica no botão editar
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
                    if (i == 4) { continue; } //skip the fifth column porque não é textbox
                    Edi7.TextBoxes[textBoxIndex].Text = dataGridView7.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi7.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            if (dataGridView8.SelectedRows.Count > 0) //logica para quando clica no botão editar
            {
                // Assume that the ID of the user is in the first column of the DataGridView
                int selectedLogId = (int)dataGridView8.SelectedRows[0].Cells[0].Value;
                Editar_AcessLogs Edi8 = new Editar_AcessLogs();

                // Pass the selected user ID to the Edit form
                Edi8.LogID.Text = selectedLogId.ToString();

                int textBoxIndex = 0;
                // Fill the TextBoxes in the Edit form with the values of the selected row
                for (int i = 0; i < dataGridView8.Columns.Count; i++)
                {
                    if (i == 2) { continue; } //skip the second column porque não é textbox
                    Edi8.TextBoxes[textBoxIndex].Text = dataGridView8.SelectedRows[0].Cells[i].Value.ToString();
                    textBoxIndex++;
                }

                Edi8.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row before clicking Edit Users.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tabControl1_SelectedIndexChanged(sender, e);
            LoadProductsCategory();
            
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
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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

        private void SearchLog_Click(object sender, EventArgs e)
        {

        }

        private void SearchUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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
                    command.Parameters.AddWithValue("@CategoryID", int.Parse(Product_CategoryID.Text.Split('-')[0].Trim()));

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Product added successfully");

        }

        private void LoadProductsCategory()
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "SELECT CategoryID, Name FROM [TechHouse].[Category]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Limpe o ComboBox antes de preenchê-lo
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
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "DELETE FROM [TechHouse].[Products] WHERE ProductID = @ProductID";

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
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
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

    }
}


