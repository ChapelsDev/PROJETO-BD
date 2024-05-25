using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


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

        private void button33_Click_1(object sender, EventArgs e)
        {
            Editar Edi1 = new Editar();
            Edi1.ShowDialog();
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            Editar_Produt Edi2 = new Editar_Produt();
            Edi2.ShowDialog();
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            Editar_Order Edi3 = new Editar_Order();
            Edi3.ShowDialog();
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            Editar_Employees Edi4 = new Editar_Employees();
            Edi4.ShowDialog();
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            Editar_Reviews Edi5 = new Editar_Reviews();
            Edi5.ShowDialog();
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            Editar_whilist Edi6 = new Editar_whilist();
            Edi6.ShowDialog();
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            Editar_ServiceRequest Edi7 = new Editar_ServiceRequest();
            Edi7.ShowDialog();
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            Editar_AcessLogs Edi8 = new Editar_AcessLogs();
            Edi8.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
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
    }

}

