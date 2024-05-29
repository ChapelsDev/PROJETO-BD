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
    public partial class Editar_Employees : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_Employees()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { EID, FN_Employee, LN_Employee, Email_Employee, Contact_Employee, Address_Employee };
        }

        private void button1_Click(object sender, EventArgs e) // Save
        {
            string connectionString = "Server=tcp:tech-house.database.windows.net,1433;Initial Catalog=Tech House;Persist Security Info=False;User ID=user;Password=G101234!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string query = "UPDATE [TechHouse].[Employee] SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber, EmployeeTypeID = @EmployeeType, Address = @Address WHERE EmployeeID = @Id";
            int i = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", EID.Text);
                    // Check if the textboxes are empty, if they are, use the text from the textboxes in the form
                    if (!(FN_Employee.Text == ""))
                    {
                        command.Parameters.AddWithValue("@FirstName", FN_Employee.Text);
                    }
                    else
                    {
                        FN_Employee.Text = TextBoxes[1].Text;
                        MessageBox.Show("Please enter a valid First Name");
                        i++;

                    }

                    if (!(LN_Employee.Text == ""))
                    {
                        command.Parameters.AddWithValue("@LastName", LN_Employee.Text);
                    }
                    else
                    {
                        LN_Employee.Text = TextBoxes[2].Text;
                        MessageBox.Show("Please enter a valid Last Name");
                        i++;
                    }

                    if (!(Email_Employee.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Email", Email_Employee.Text);
                    }
                    else
                    {
                        Email_Employee.Text = TextBoxes[3].Text;
                        MessageBox.Show("Please enter a valid Email");
                        i++;
                    }

                    if (!(Contact_Employee.Text == ""))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", Contact_Employee.Text);
                    }
                    else
                    {
                        Contact_Employee.Text = TextBoxes[4].Text;
                        MessageBox.Show("Please enter a valid Contact");
                        i++;
                    }

                    if (!(comboBox1.Text == ""))
                    {
                        command.Parameters.AddWithValue("@EmployeeType", comboBox1.Text.Split('-')[0].Trim());
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Employee Type");
                        i++;
                    }

                    if (!(Address_Employee.Text == ""))
                    {
                        command.Parameters.AddWithValue("@Address", Address_Employee.Text);
                    }
                    else
                    {
                        Address_Employee.Text = TextBoxes[5].Text;
                        MessageBox.Show("Please enter a valid Address");
                        i++;

                    }
                    if (i == 0)
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Employee updated successfully");
                        this.Close();
                    }
                    i = 0;
                }
            }
        }

        private void LoadEmployees(object sender, EventArgs e)
        {
            LoadEmployeeTypes();
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
                        // Limpe o ComboBox antes de preenchê-lo
                        comboBox1.Items.Clear();

                        while (reader.Read())
                        {
                            // Adicione o nome da categoria ao ComboBox
                            comboBox1.Items.Add(reader["EmployeeTypeID"].ToString() + " - " + reader["Name"].ToString());
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
