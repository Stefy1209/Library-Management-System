namespace Library_Management_System_Form
{
    partial class AddBookForm
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
            label1 = new Label();
            label2 = new Label();
            titleTextBox = new TextBox();
            quantityNumericUpDown = new NumericUpDown();
            authorsCheckedListBox = new CheckedListBox();
            label3 = new Label();
            addBookButton = new Button();
            label4 = new Label();
            addAuthorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 116);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 172);
            label2.Name = "label2";
            label2.Size = new Size(139, 41);
            label2.TabIndex = 1;
            label2.Text = "Quantity:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(259, 110);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(376, 47);
            titleTextBox.TabIndex = 2;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(259, 172);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(372, 47);
            quantityNumericUpDown.TabIndex = 3;
            // 
            // authorsCheckedListBox
            // 
            authorsCheckedListBox.FormattingEnabled = true;
            authorsCheckedListBox.Location = new Point(259, 241);
            authorsCheckedListBox.Name = "authorsCheckedListBox";
            authorsCheckedListBox.Size = new Size(372, 224);
            authorsCheckedListBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 241);
            label3.Name = "label3";
            label3.Size = new Size(129, 41);
            label3.TabIndex = 5;
            label3.Text = "Authors:";
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(259, 495);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(272, 58);
            addBookButton.TabIndex = 6;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 611);
            label4.Name = "label4";
            label4.Size = new Size(758, 41);
            label4.TabIndex = 7;
            label4.Text = "If you do not see your author, click the following button";
            // 
            // addAuthorButton
            // 
            addAuthorButton.Location = new Point(259, 678);
            addAuthorButton.Name = "addAuthorButton";
            addAuthorButton.Size = new Size(272, 58);
            addAuthorButton.TabIndex = 8;
            addAuthorButton.Text = "Add Author";
            addAuthorButton.UseVisualStyleBackColor = true;
            addAuthorButton.Click += addAuthorButton_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 764);
            Controls.Add(addAuthorButton);
            Controls.Add(label4);
            Controls.Add(addBookButton);
            Controls.Add(label3);
            Controls.Add(authorsCheckedListBox);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(titleTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Book";
            Load += AddBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox titleTextBox;
        private NumericUpDown quantityNumericUpDown;
        private CheckedListBox authorsCheckedListBox;
        private Label label3;
        private Button addBookButton;
        private Label label4;
        private Button addAuthorButton;
    }
}