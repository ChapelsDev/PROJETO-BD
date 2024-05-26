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
    public partial class Editar_ServiceRequest : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_ServiceRequest()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { RID, Description,UID,EID,Status };
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
