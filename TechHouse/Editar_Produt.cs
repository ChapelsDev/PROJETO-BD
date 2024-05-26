using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechHouse
{
    public partial class Editar_Produt : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_Produt()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { ProductID, ProductName, Product_Brand, Product_Price, product_qty, Product_CategoryID};
        }

        private void button1_Click(object sender, EventArgs e) // Save
        {

        }
    }
}
