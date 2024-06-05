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
    public partial class Editar_whilist : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_whilist()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { WID };

        }

        private void Editar_whilist_Load(object sender, EventArgs e)
        {
            LoadWhishUser();
            LoadWhishProduct();

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
                        // Limpe o ComboBox antes de preenchê-lo
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
                        // Limpe o ComboBox antes de preenchê-lo
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // Save
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[Wishlist] SET UserID = @UserID, ProductID = @ProductID, DateAdded = @DateAdded WHERE WishlistID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", WID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(Whishlist_UserID.Text == ""))
                    {
                        command.Parameters.AddWithValue("@UserID", Whishlist_UserID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please select a UserID");
                        i++;

                    }

                    if (!(WhishlistPID.Text == ""))
                    {
                        command.Parameters.AddWithValue("@ProductID", WhishlistPID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please select ProductID");
                        i++;
                    }

                    if (!(dateTimePicker1.Text == ""))
                    {
                        string formattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@DateAdded", formattedDate);
                    }
                    else
                    {
                        MessageBox.Show("Please select a Date");
                        i++;
                    }

                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Whishlist updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }
        }
    }
}
