namespace TechHouse
{
    partial class Editar_whilist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label35 = new Label();
            textBox29 = new TextBox();
            label37 = new Label();
            label40 = new Label();
            label41 = new Label();
            textBox30 = new TextBox();
            textBox33 = new TextBox();
            textBox35 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(86, 141);
            label35.Name = "label35";
            label35.Size = new Size(44, 15);
            label35.TabIndex = 59;
            label35.Text = "User ID";
            // 
            // textBox29
            // 
            textBox29.Location = new Point(136, 39);
            textBox29.Name = "textBox29";
            textBox29.Size = new Size(200, 23);
            textBox29.TabIndex = 58;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(70, 189);
            label37.Name = "label37";
            label37.Size = new Size(60, 15);
            label37.TabIndex = 57;
            label37.Text = "ProductID";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(61, 91);
            label40.Name = "label40";
            label40.Size = new Size(69, 15);
            label40.TabIndex = 56;
            label40.Text = "Date Added";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(64, 42);
            label41.Name = "label41";
            label41.Size = new Size(66, 15);
            label41.TabIndex = 55;
            label41.Text = "WhishlistID";
            label41.Click += label41_Click;
            // 
            // textBox30
            // 
            textBox30.Location = new Point(833, 203);
            textBox30.Name = "textBox30";
            textBox30.PasswordChar = '*';
            textBox30.Size = new Size(72, 23);
            textBox30.TabIndex = 54;
            // 
            // textBox33
            // 
            textBox33.Location = new Point(136, 88);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(200, 23);
            textBox33.TabIndex = 53;
            // 
            // textBox35
            // 
            textBox35.Location = new Point(136, 138);
            textBox35.Name = "textBox35";
            textBox35.Size = new Size(200, 23);
            textBox35.TabIndex = 52;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 60;
            // 
            // button1
            // 
            button1.Location = new Point(136, 255);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 61;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(261, 255);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 62;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Editar_whilist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label35);
            Controls.Add(textBox29);
            Controls.Add(label37);
            Controls.Add(label40);
            Controls.Add(label41);
            Controls.Add(textBox30);
            Controls.Add(textBox33);
            Controls.Add(textBox35);
            Name = "Editar_whilist";
            Text = "Editar_whilist";
            Load += Editar_whilist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label35;
        private TextBox textBox29;
        private Label label37;
        private Label label40;
        private Label label41;
        private TextBox textBox30;
        private TextBox textBox33;
        private TextBox textBox35;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}