namespace Library_Management_System_Form
{
    partial class AddAuthor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NameTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 135);
            label1.Name = "label1";
            label1.Size = new Size(104, 41);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(168, 135);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(379, 47);
            NameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(217, 245);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += AddToSystem;
            // 
            // AddAuthor
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 389);
            Controls.Add(button1);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "AddAuthor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NameTextBox;
        private Button button1;
    }
}
