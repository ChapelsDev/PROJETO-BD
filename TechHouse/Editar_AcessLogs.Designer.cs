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
            textBox12 = new TextBox();
            label33 = new Label();
            label34 = new Label();
            label36 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox16 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(406, 212);
            label32.Name = "label32";
            label32.Size = new Size(57, 15);
            label32.TabIndex = 71;
            label32.Text = "DateTime";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(500, 115);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(148, 23);
            textBox12.TabIndex = 70;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(406, 115);
            label33.Name = "label33";
            label33.Size = new Size(44, 15);
            label33.TabIndex = 69;
            label33.Text = "User ID";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(24, 207);
            label34.Name = "label34";
            label34.Size = new Size(42, 15);
            label34.TabIndex = 68;
            label34.Text = "Action";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(24, 110);
            label36.Name = "label36";
            label36.Size = new Size(41, 15);
            label36.TabIndex = 67;
            label36.Text = "Log ID";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(93, 107);
            textBox13.Name = "textBox13";
            textBox13.PasswordChar = '*';
            textBox13.Size = new Size(146, 23);
            textBox13.TabIndex = 66;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(93, 204);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(146, 23);
            textBox14.TabIndex = 65;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(500, 209);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(148, 23);
            textBox16.TabIndex = 64;
            // 
            // button1
            // 
            button1.Location = new Point(292, 292);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 72;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // Editar_AcessLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(button1);
            Controls.Add(label32);
            Controls.Add(textBox12);
            Controls.Add(label33);
            Controls.Add(label34);
            Controls.Add(label36);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Controls.Add(textBox16);
            Name = "Editar_AcessLogs";
            Text = "Editar_AcessLogs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label32;
        private TextBox textBox12;
        private Label label33;
        private Label label34;
        private Label label36;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox16;
        private Button button1;
    }
}