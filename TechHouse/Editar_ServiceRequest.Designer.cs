namespace TechHouse
{
    partial class Editar_ServiceRequest
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
            label10 = new Label();
            RID = new TextBox();
            label23 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            Description = new TextBox();
            Save = new Button();
            Cancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            UserID = new ComboBox();
            EmployeeID = new ComboBox();
            Status = new ComboBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(75, 29);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 95;
            label10.Text = "Request ID";
            // 
            // RID
            // 
            RID.Location = new Point(153, 26);
            RID.Name = "RID";
            RID.Size = new Size(199, 23);
            RID.TabIndex = 94;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(99, 87);
            label23.Name = "label23";
            label23.Size = new Size(39, 15);
            label23.TabIndex = 93;
            label23.Text = "Status";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(65, 145);
            label28.Name = "label28";
            label28.Size = new Size(73, 15);
            label28.TabIndex = 92;
            label28.Text = "Employee ID";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(62, 174);
            label29.Name = "label29";
            label29.Size = new Size(76, 15);
            label29.TabIndex = 91;
            label29.Text = "Request Date";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(94, 116);
            label30.Name = "label30";
            label30.Size = new Size(44, 15);
            label30.TabIndex = 90;
            label30.Text = "User ID";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(71, 58);
            label31.Name = "label31";
            label31.Size = new Size(67, 15);
            label31.TabIndex = 89;
            label31.Text = "Description";
            // 
            // Description
            // 
            Description.Location = new Point(153, 55);
            Description.Name = "Description";
            Description.Size = new Size(199, 23);
            Description.TabIndex = 84;
            // 
            // Save
            // 
            Save.Location = new Point(153, 232);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 96;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(277, 232);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 97;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 171);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 98;
            // 
            // UserID
            // 
            UserID.FormattingEnabled = true;
            UserID.Location = new Point(153, 113);
            UserID.Name = "UserID";
            UserID.Size = new Size(199, 23);
            UserID.TabIndex = 99;
            // 
            // EmployeeID
            // 
            EmployeeID.FormattingEnabled = true;
            EmployeeID.Location = new Point(153, 142);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(200, 23);
            EmployeeID.TabIndex = 100;
            // 
            // Status
            // 
            Status.FormattingEnabled = true;
            Status.Location = new Point(153, 84);
            Status.Name = "Status";
            Status.Size = new Size(199, 23);
            Status.TabIndex = 101;
            // 
            // Editar_ServiceRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(Status);
            Controls.Add(EmployeeID);
            Controls.Add(UserID);
            Controls.Add(dateTimePicker1);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label10);
            Controls.Add(RID);
            Controls.Add(label23);
            Controls.Add(label28);
            Controls.Add(label29);
            Controls.Add(label30);
            Controls.Add(label31);
            Controls.Add(Description);
            Name = "Editar_ServiceRequest";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar_ServiceRequest";
            Load += Editar_ServiceRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        public TextBox RID;
        private Label label23;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        public TextBox Description;
        private Button Save;
        private Button Cancel;
        public DateTimePicker dateTimePicker1;
        public ComboBox UserID;
        public ComboBox EmployeeID;
        public ComboBox Status;
    }
}