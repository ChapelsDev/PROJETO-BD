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
    public partial class Editar_whilist : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_whilist()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { WID, UID, PID};

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void Editar_whilist_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
