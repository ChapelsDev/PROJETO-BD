namespace TechHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
