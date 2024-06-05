using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechHouse
{
    public partial class Editar_Reviews : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_Reviews()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { RID, Comment };
        }

        private void LoadReviews(object sender, EventArgs e)
        {
            LoadProductReview();
            LoadUserReview();
            LoadReviewRating();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[Reviews] SET Rating = @Rating, Comment = @Comment, UserID = @UID, ProductID = @PID WHERE ReviewID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", RID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(Rating.Text == ""))
                    {
                        int Ratings;
                        if (int.TryParse(Rating.Text.Split('-')[0].Trim(), out Ratings))
                        {
                            command.Parameters.AddWithValue("@Rating", Ratings);
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid rating.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Rating");
                        i++;

                    }

                    if (!(Comment.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Comment", Comment.Text);
                    }
                    else
                    {
                        Comment.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a valid Comment");
                        i++;
                    }

                    if (!(UserID.Text == ""))
                    {

                        int userID;
                        if (int.TryParse(UserID.Text.Split('-')[0].Trim(), out userID))
                        {
                            command.Parameters.AddWithValue("@UID", userID);
                        }
                        else
                        {
                            MessageBox.Show("Please select a UserID.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid User");
                        i++;
                    }

                    if (!(ProductID.Text == ""))
                    {
                        int productID;
                        if (int.TryParse(ProductID.Text.Split('-')[0].Trim(), out productID))
                        {
                            command.Parameters.AddWithValue("@PID", productID);
                        }
                        else
                        {
                            MessageBox.Show("Please select a ProductID.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid Product");
                        i++;
                    }


                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Review updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }
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
                        // Limpe o ComboBox antes de preenchê-lo
                        UserID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            UserID.Items.Add(reader["UserID"].ToString() + " - " + reader["FirstName"].ToString());
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
                        // Limpe o ComboBox antes de preenchê-lo
                        ProductID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            ProductID.Items.Add(reader["ProductID"].ToString() + " - " + reader["Brand"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }
            }
        }

        private void LoadReviewRating()
        {
            Rating.Items.Clear();
            Rating.Items.Add("1 - Very Bad");
            Rating.Items.Add("2 - Bad");
            Rating.Items.Add("3 - Average");
            Rating.Items.Add("4 - Good");
            Rating.Items.Add("5 - Excellent");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
