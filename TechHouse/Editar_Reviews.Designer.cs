namespace TechHouse
{
    partial class Editar_Reviews
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
            label8 = new Label();
            RID = new TextBox();
            label9 = new Label();
            label12 = new Label();
            label19 = new Label();
            label20 = new Label();
            Comment = new TextBox();
            Save = new Button();
            Cancel = new Button();
            Rating = new ComboBox();
            ProductID = new ComboBox();
            UserID = new ComboBox();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 29);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 93;
            label8.Text = "Review ID";
            // 
            // RID
            // 
            RID.Location = new Point(138, 21);
            RID.Name = "RID";
            RID.Size = new Size(216, 23);
            RID.TabIndex = 92;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 129);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 91;
            label9.Text = "User ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(72, 95);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 90;
            label12.Text = "ProductID";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(65, 163);
            label19.Name = "label19";
            label19.Size = new Size(61, 15);
            label19.TabIndex = 89;
            label19.Text = "Comment";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(85, 65);
            label20.Name = "label20";
            label20.Size = new Size(41, 15);
            label20.TabIndex = 88;
            label20.Text = "Rating";
            // 
            // Comment
            // 
            Comment.Location = new Point(138, 160);
            Comment.Name = "Comment";
            Comment.Size = new Size(216, 23);
            Comment.TabIndex = 85;
            // 
            // Save
            // 
            Save.Location = new Point(138, 224);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 94;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Cancel
            // 
            Cancel.Location = new Point(279, 224);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 23);
            Cancel.TabIndex = 95;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Rating
            // 
            Rating.FormattingEnabled = true;
            Rating.Location = new Point(138, 57);
            Rating.Name = "Rating";
            Rating.Size = new Size(216, 23);
            Rating.TabIndex = 96;
            // 
            // ProductID
            // 
            ProductID.FormattingEnabled = true;
            ProductID.Location = new Point(138, 95);
            ProductID.Name = "ProductID";
            ProductID.Size = new Size(216, 23);
            ProductID.TabIndex = 97;
            // 
            // UserID
            // 
            UserID.FormattingEnabled = true;
            UserID.Location = new Point(138, 129);
            UserID.Name = "UserID";
            UserID.Size = new Size(216, 23);
            UserID.TabIndex = 98;
            // 
            // Editar_Reviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 310);
            Controls.Add(UserID);
            Controls.Add(ProductID);
            Controls.Add(Rating);
            Controls.Add(Cancel);
            Controls.Add(Save);
            Controls.Add(label8);
            Controls.Add(RID);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(Comment);
            Name = "Editar_Reviews";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Editar_Reviews";
            Load += LoadReviews;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        public TextBox RID;
        private Label label9;
        private Label label12;
        private Label label19;
        private Label label20;
        public TextBox PID;
        public TextBox UID;
        public TextBox Comment;
        private Button Save;
        private Button Cancel;
        public ComboBox Rating;
        public ComboBox ProductID;
        public ComboBox UserID;
    }
}