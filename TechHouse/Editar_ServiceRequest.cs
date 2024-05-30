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

namespace TechHouse
{
    public partial class Editar_ServiceRequest : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_ServiceRequest()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { RID, Description };
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[ServicesRequests] SET UserID = @UserID, EmployeeID = @EmployeeID, RequestDate = @DateAdded , Description = @Description, Status = @Status WHERE RequestID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", RID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(UserID.Text == ""))
                    {
                        int userID;
                        if (int.TryParse(UserID.Text.Split('-')[0].Trim(), out userID))
                        {
                            command.Parameters.AddWithValue("@UserID", userID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a UserID");
                        i++;

                    }

                    if (!(EmployeeID.Text == ""))
                    {
                        int employeeID;
                        if (int.TryParse(EmployeeID.Text.Split('-')[0].Trim(), out employeeID))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select EmployeeID");
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

                    if(!(Description.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Description", Description.Text);
                    }
                    else
                    {
                        Description.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a Description");
                        i++;
                    }

                    if (!(Status.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Status", Status.Text);
                    }
                    else
                    {
                        Status.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a Status");
                        i++;
                    }

                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Request updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Editar_ServiceRequest_Load(object sender, EventArgs e)
        {
            LoadUserService();
            LoadServiceEmployee();
            LoadServiceStatus();
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
                        // Limpe o ComboBox antes de preenchê-lo
                        EmployeeID.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            EmployeeID.Items.Add(reader["EmployeeID"].ToString() + " - " + reader["FirstName"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }

            }
        }

        private void LoadServiceStatus()
        {
            Status.Items.Clear();
            Status.Items.Add("Pending");
            Status.Items.Add("In Progress");
            Status.Items.Add("Completed");
        }
    }
}
