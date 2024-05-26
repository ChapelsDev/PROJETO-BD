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

        }
    }
}
