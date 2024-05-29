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
            WID = new TextBox();
            label37 = new Label();
            label40 = new Label();
            label41 = new Label();
            textBox30 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            Whishlist_UserID = new ComboBox();
            WhishlistPID = new ComboBox();
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
            // WID
            // 
            WID.Location = new Point(136, 39);
            WID.Name = "WID";
            WID.Size = new Size(200, 23);
            WID.TabIndex = 58;
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
            // 
            // textBox30
            // 
            textBox30.Location = new Point(833, 203);
            textBox30.Name = "textBox30";
            textBox30.PasswordChar = '*';
            textBox30.Size = new Size(72, 23);
            textBox30.TabIndex = 54;
            // 
            // button1
            // 
            button1.Location = new Point(136, 255);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 61;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(261, 255);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 62;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(136, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 63;
            // 
            // Whishlist_UserID
            // 
            Whishlist_UserID.FormattingEnabled = true;
            Whishlist_UserID.Location = new Point(136, 138);
            Whishlist_UserID.Name = "Whishlist_UserID";
            Whishlist_UserID.Size = new Size(200, 23);
            Whishlist_UserID.TabIndex = 64;
            // 
            // WhishlistPID
            // 
            WhishlistPID.FormattingEnabled = true;
            WhishlistPID.Location = new Point(136, 186);
            WhishlistPID.Name = "WhishlistPID";
            WhishlistPID.Size = new Size(200, 23);
            WhishlistPID.TabIndex = 65;
            // 
            // Editar_whilist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(WhishlistPID);
            Controls.Add(Whishlist_UserID);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label35);
            Controls.Add(WID);
            Controls.Add(label37);
            Controls.Add(label40);
            Controls.Add(label41);
            Controls.Add(textBox30);
            Name = "Editar_whilist";
            Text = "Editar_whilist";
            Load += Editar_whilist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label35;
        public TextBox WID;
        private Label label37;
        private Label label40;
        private Label label41;
        private TextBox textBox30;
        private Button button1;
        private Button button2;
        public DateTimePicker dateTimePicker1;
        public ComboBox Whishlist_UserID;
        public ComboBox WhishlistPID;
    }
}