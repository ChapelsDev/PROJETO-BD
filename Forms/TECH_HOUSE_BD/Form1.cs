using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TECH_HOUSE_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTabControl();
        }

        private void InitializeTabControl()
        {
            // Cria um novo TabControl
            TabControl tabControl = new TabControl();
            tabControl.Dock = DockStyle.Fill;

            // Cria as TabPages
            TabPage tabPage1 = new TabPage("Tab 1");
            TabPage tabPage2 = new TabPage("Tab 2");
            TabPage tabPage3 = new TabPage("Tab 3");
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Dock = DockStyle.Fill;




            // Adiciona controles à primeira TabPage
            Label label1 = new Label();
            label1.Text = "Label in Tab 1";
            label1.Location = new System.Drawing.Point(20, 20);
            tabPage1.Controls.Add(label1);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new System.Drawing.Point(20, 50);
            tabPage1.Controls.Add(textBox1);

            // Adiciona controles à segunda TabPage
            Label label2 = new Label();
            label2.Text = "Label in Tab 2";
            label2.Location = new System.Drawing.Point(20, 20);
            tabPage2.Controls.Add(label2);

            Button button1 = new Button();
            button1.Text = "Button in Tab 2";
            button1.Location = new System.Drawing.Point(20, 50);
            tabPage2.Controls.Add(button1);

            // Adiciona as TabPages ao TabControl
            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            // Adiciona o TabControl ao Form
            this.Controls.Add(tabControl);
        }
    }
}
