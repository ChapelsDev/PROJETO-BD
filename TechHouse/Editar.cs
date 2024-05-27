using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechHouse
{
    public partial class Editar : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { UserID, FirstName, LastName, Email, Contact, Password, Address };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Editar_Load_1(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e) // Save
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[User] SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, Password = @Password, Address = @Address WHERE UserID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", UserID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(FirstName.Text == ""))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName.Text);
                    }
                    else
                    {
                        FirstName.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a valid First Name");
                        i++;

                    }

                    if (!(LastName.Text == ""))
                    {
                        command.Parameters.AddWithValue("@LastName", LastName.Text);
                    }
                    else
                    {
                        LastName.Text = TextBoxes[2].Text;
                        MessageBox.Show("Please enter a valid Last Name");
                        i++;

                    }

                    if (!(Email.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Email", Email.Text);
                    }
                    else
                    {
                        Email.Text = TextBoxes[3].Text;
                        MessageBox.Show("Please enter a valid Email");
                        i++;
                    }

                    if (!(Contact.Text == ""))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", Contact.Text);
                    }
                    else
                    {
                        Contact.Text = TextBoxes[4].Text;
                        MessageBox.Show("Please enter a valid Contact");
                        i++;
                    }

                    if (!(Password.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Password", Password.Text);
                    }
                    else
                    {
                        Password.Text = TextBoxes[5].Text;
                        MessageBox.Show("Please enter a valid Password");
                        i++;
                    }

                    if (!(Address.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Address", Address.Text);
                    }
                    else
                    {
                        Address.Text = TextBoxes[6].Text;
                        MessageBox.Show("Please enter a valid Address");
                        i++;

                    }
                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("User updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }


        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
