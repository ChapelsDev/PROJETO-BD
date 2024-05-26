using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TechHouse
{
    public partial class Editar_AcessLogs : Form
    {
        public List<System.Windows.Forms.TextBox> TextBoxes { get; set; }
        public System.Windows.Forms.TextBox[] TextBox { get; set; }
        public Editar_AcessLogs()
        {
            InitializeComponent();
            TextBoxes = new List<System.Windows.Forms.TextBox> { LogID, LogAction, UserID };

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
