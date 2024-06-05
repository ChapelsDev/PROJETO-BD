using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TechHouse
{
    public partial class Editar_Produt : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_Produt()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { ProductID, ProductName, Product_Brand, Product_Price, product_qty };
        }

        private void button1_Click(object sender, EventArgs e) // Save
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[Products] SET Name = @ProductName, Brand = @Brand, Price = @Price, StockQty = @StockQty, CategoryID = @CategoryID WHERE ProductID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", ProductID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(ProductName.Text == ""))
                    {
                        command.Parameters.AddWithValue("@ProductName", ProductName.Text);
                    }
                    else
                    {
                        ProductName.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a valid Product Name");
                        i++;

                    }

                    if (!(Product_Brand.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Brand", Product_Brand.Text);
                    }
                    else
                    {
                        Product_Brand.Text = TextBoxes[2].Text;
                        MessageBox.Show("Please enter a valid Product Brand");
                        i++;
                    }

                    if (!(Product_Price.Text == ""))
                    {
                        decimal price;
                        if (decimal.TryParse(Product_Price.Text, out price))
                        {
                            command.Parameters.AddWithValue("@Price", price);
                        }
                    }
                    else
                    {
                        Product_Price.Text = TextBoxes[3].Text;
                        MessageBox.Show("Please enter a valid Product Price");
                        i++;
                    }

                    if (!(product_qty.Text == ""))
                    {
                        int stockQty;
                        if (int.TryParse(product_qty.Text, out stockQty))
                        {
                            command.Parameters.AddWithValue("@StockQty", stockQty);
                        }
                    }
                    else
                    {
                        product_qty.Text = TextBoxes[4].Text;
                        MessageBox.Show("Please enter a valid Contact");
                        i++;
                    }

                    if (!(Product_CategoryID.Text == ""))
                    {
                        command.Parameters.AddWithValue("@CategoryID", int.Parse(Product_CategoryID.Text.Split('-')[0].Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Category ID");
                        i++;
                    }
                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Product updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }


        }

        private void Editar_Produt_Load(object sender, EventArgs e)
        {
            LoadProductsCategory();
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
