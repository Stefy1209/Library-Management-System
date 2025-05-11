namespace Library_Management_System_Form
{
    partial class SearchForm
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
            titleTextBox = new TextBox();
            label2 = new Label();
            checkedListBox1 = new CheckedListBox();
            searchButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 124);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(245, 124);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(432, 47);
            titleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 200);
            label2.Name = "label2";
            label2.Size = new Size(129, 41);
            label2.TabIndex = 2;
            label2.Text = "Authors:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(245, 200);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(432, 224);
            checkedListBox1.TabIndex = 3;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(245, 452);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(285, 58);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search Book";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(searchButton);
            Controls.Add(checkedListBox1);
            Controls.Add(label2);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            Load += SearchForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private Label label2;
        private CheckedListBox checkedListBox1;
        private Button searchButton;
    }
}