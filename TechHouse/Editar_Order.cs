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
    public partial class Editar_Order : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_Order()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { OrderID, Status, ShippingAddress};
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[Orders] SET OrderDate = @OrderDate, Status = @Status, ShippingAddress = @ShippingAddress, PaymentMethod = @PaymentMethod, UserID = @UserID WHERE OrderID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", OrderID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(OrderDate.Text == ""))
                    {
                        string formattedDate = OrderDate.Value.ToString("yyyy-MM-dd");
                        command.Parameters.AddWithValue("@OrderDate", formattedDate);
                    }

                    if (!(Status.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Status", Status.Text);
                    }
                    else
                    {
                        Status.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a valid Status");
                        i++;

                    }
                    if (!(ShippingAddress.Text == ""))
                    {
                        command.Parameters.AddWithValue("@ShippingAddress", ShippingAddress.Text);
                    }
                    else
                    {
                        ShippingAddress.Text = TextBoxes[2].Text;
                        MessageBox.Show("Please enter a valid Shipping Address");
                        i++;
                    }

                    if (!(UserID.Text == ""))
                    {
                        command.Parameters.AddWithValue("@UserID", UserID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid UserID");
                        i++;
                    }

                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Order updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }


        }

        private void LoadOrder(object sender, EventArgs e)
        {
            LoadOrderUser();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentMethod.Items.Add("Credit Card");
            PaymentMethod.Items.Add("Debit Card");
            PaymentMethod.Items.Add("Paypal");
            PaymentMethod.Items.Add("Cash");

        }

        private void LoadOrderUser()
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
    }
}
