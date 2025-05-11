namespace Library_Management_System_Form
{
    partial class ModifyBookForm
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
            label3 = new Label();
            titleTextBox = new TextBox();
            quantityNumericUpDown = new NumericUpDown();
            authorsCheckedListBox = new CheckedListBox();
            modifyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 113);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 173);
            label2.Name = "label2";
            label2.Size = new Size(139, 41);
            label2.TabIndex = 1;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 235);
            label3.Name = "label3";
            label3.Size = new Size(129, 41);
            label3.TabIndex = 2;
            label3.Text = "Authors:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(280, 107);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(362, 47);
            titleTextBox.TabIndex = 3;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(280, 167);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(362, 47);
            quantityNumericUpDown.TabIndex = 4;
            // 
            // authorsCheckedListBox
            // 
            authorsCheckedListBox.FormattingEnabled = true;
            authorsCheckedListBox.Location = new Point(280, 235);
            authorsCheckedListBox.Name = "authorsCheckedListBox";
            authorsCheckedListBox.Size = new Size(362, 224);
            authorsCheckedListBox.TabIndex = 6;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(280, 490);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(278, 58);
            modifyButton.TabIndex = 7;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // ModifyBookForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(modifyButton);
            Controls.Add(authorsCheckedListBox);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(titleTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ModifyBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify Book";
            Load += ModifyBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox titleTextBox;
        private NumericUpDown quantityNumericUpDown;
        private CheckedListBox authorsCheckedListBox;
        private Button modifyButton;
    }
}