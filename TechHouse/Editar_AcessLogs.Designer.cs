namespace TechHouse
{
    partial class Editar_AcessLogs
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
            label32 = new Label();
            UserID = new TextBox();
            label33 = new Label();
            label34 = new Label();
            label36 = new Label();
            LogID = new TextBox();
            LogAction = new TextBox();
            Save = new Button();
            Cancel = new Button();
            LogDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(47, 157);
            label32.Name = "label32";
            label32.Size = new Size(57, 15);
            label32.TabIndex = 71;
            label32.Text = "DateTime";
            // 
            // UserID
            // 
            UserID.Location = new Point(133, 52);
            UserID.Name = "UserID";
            UserID.Size = new Size(214, 23);
            UserID.TabIndex = 70;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(47, 60);
            label33.Name = "label33";
            label33.Size = new Size(44, 15);
            label33.TabIndex = 69;
            label33.Text = "User ID";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(49, 204);
            label34.Name = "label34";
            label34.Size = new Size(42, 15);
            label34.TabIndex = 68;
            label34.Text = "Action";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(47, 110);
            label36.Name = "label36";
            label36.Size = new Size(41, 15);
            label36.TabIndex = 67;
            label36.Text = "Log ID";
            // 
            // LogID
            // 
            LogID.Location = new Point(133, 102);
            LogID.Name = "LogID";
            LogID.PasswordChar = '*';
            LogID.Size = new Size(214, 23);
            LogID.TabIndex = 66;
            // 
            // LogAction
            // 
            LogAction.AccessibleDescription = "LogAction";
            LogAction.Location = new Point(133, 196);
            LogAction.Name = "LogAction";
            LogAction.Size = new Size(214, 23);
            LogAction.TabIndex = 65;
            // 
            // Save
            // 
            Save.Location = new Point(145, 255);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 72;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(243, 255);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 73;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // LogDate
            // 
            LogDate.AccessibleDescription = "LogDate";
            LogDate.Location = new Point(133, 149);
            LogDate.Name = "LogDate";
            LogDate.Size = new Size(214, 23);
            LogDate.TabIndex = 74;
            // 
            // Editar_AcessLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(LogDate);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label32);
            Controls.Add(UserID);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label36);
            Controls.Add(LogID);
            Controls.Add(LogAction);
            Name = "Editar_AcessLogs";
            Text = "Editar_AcessLogs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label32;
        public TextBox UserID;
        private Label label33;
        private Label label34;
        private Label label36;
        public TextBox LogID;
        public TextBox LogAction;
        private Button Save;
        private Button Cancel;
        private DateTimePicker LogDate;
    }
}