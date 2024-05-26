namespace TechHouse
{
    partial class Editar_Employees
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
            label21 = new Label();
            EID = new TextBox();
            label22 = new Label();
            EmployeeTipeID = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            Contact_Employee = new TextBox();
            Address_Employee = new TextBox();
            Email_Employee = new TextBox();
            LN_Employee = new TextBox();
            FN_Employee = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(56, 27);
            label21.Name = "label21";
            label21.Size = new Size(73, 15);
            label21.TabIndex = 65;
            label21.Text = "Employee ID";
            // 
            // EID
            // 
            EID.Location = new Point(135, 24);
            EID.Name = "EID";
            EID.Size = new Size(224, 23);
            EID.TabIndex = 64;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(80, 218);
            label22.Name = "label22";
            label22.Size = new Size(49, 15);
            label22.TabIndex = 63;
            label22.Text = "Address";
            // 
            // EmployeeTipeID
            // 
            EmployeeTipeID.AutoSize = true;
            EmployeeTipeID.Location = new Point(37, 155);
            EmployeeTipeID.Name = "EmployeeTipeID";
            EmployeeTipeID.Size = new Size(86, 15);
            EmployeeTipeID.TabIndex = 62;
            EmployeeTipeID.Text = "Employee Type";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(80, 184);
            label24.Name = "label24";
            label24.Size = new Size(49, 15);
            label24.TabIndex = 61;
            label24.Text = "Contact";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(66, 94);
            label25.Name = "label25";
            label25.Size = new Size(63, 15);
            label25.TabIndex = 60;
            label25.Text = "Last Name";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(93, 123);
            label26.Name = "label26";
            label26.Size = new Size(36, 15);
            label26.TabIndex = 59;
            label26.Text = "Email";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(65, 60);
            label27.Name = "label27";
            label27.Size = new Size(64, 15);
            label27.TabIndex = 58;
            label27.Text = "First Name";
            // 
            // Contact_Employee
            // 
            Contact_Employee.Location = new Point(135, 181);
            Contact_Employee.Name = "Contact_Employee";
            Contact_Employee.Size = new Size(224, 23);
            Contact_Employee.TabIndex = 56;
            // 
            // Address_Employee
            // 
            Address_Employee.Location = new Point(135, 215);
            Address_Employee.Name = "Address_Employee";
            Address_Employee.Size = new Size(224, 23);
            Address_Employee.TabIndex = 55;
            // 
            // Email_Employee
            // 
            Email_Employee.Location = new Point(135, 120);
            Email_Employee.Name = "Email_Employee";
            Email_Employee.Size = new Size(224, 23);
            Email_Employee.TabIndex = 54;
            // 
            // LN_Employee
            // 
            LN_Employee.Location = new Point(135, 91);
            LN_Employee.Name = "LN_Employee";
            LN_Employee.Size = new Size(224, 23);
            LN_Employee.TabIndex = 53;
            // 
            // FN_Employee
            // 
            FN_Employee.Location = new Point(135, 58);
            FN_Employee.Name = "FN_Employee";
            FN_Employee.Size = new Size(224, 23);
            FN_Employee.TabIndex = 52;
            // 
            // button1
            // 
            button1.Location = new Point(160, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 66;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 67;
            // 
            // button2
            // 
            button2.Location = new Point(254, 264);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 68;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // Editar_Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label21);
            Controls.Add(EID);
            Controls.Add(label22);
            Controls.Add(EmployeeTipeID);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(Contact_Employee);
            Controls.Add(Address_Employee);
            Controls.Add(Email_Employee);
            Controls.Add(LN_Employee);
            Controls.Add(FN_Employee);
            Name = "Editar_Employees";
            Text = "Editar_Employees";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label21;
        public TextBox EID;
        private Label label22;
        private Label EmployeeTipeID;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        public TextBox Contact_Employee;
        public TextBox Address_Employee;
        public TextBox Email_Employee;
        public TextBox LN_Employee;
        public TextBox FN_Employee;
        private Button button1;
        public ComboBox comboBox1;
        private Button button2;
    }
}