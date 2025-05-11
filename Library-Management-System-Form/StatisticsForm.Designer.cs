namespace Library_Management_System_Form
{
    partial class StatisticsForm
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
            titleLabel = new Label();
            label2 = new Label();
            loansLabel = new Label();
            label3 = new Label();
            authorsListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 90);
            label1.Name = "label1";
            label1.Size = new Size(81, 41);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(379, 90);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(97, 41);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 143);
            label2.Name = "label2";
            label2.Size = new Size(247, 41);
            label2.TabIndex = 2;
            label2.Text = "Number of loans:";
            // 
            // loansLabel
            // 
            loansLabel.AutoSize = true;
            loansLabel.Location = new Point(379, 143);
            loansLabel.Name = "loansLabel";
            loansLabel.Size = new Size(97, 41);
            loansLabel.TabIndex = 3;
            loansLabel.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 198);
            label3.Name = "label3";
            label3.Size = new Size(129, 41);
            label3.TabIndex = 4;
            label3.Text = "Authors:";
            // 
            // authorsListBox
            // 
            authorsListBox.FormattingEnabled = true;
            authorsListBox.Location = new Point(379, 198);
            authorsListBox.Name = "authorsListBox";
            authorsListBox.Size = new Size(300, 209);
            authorsListBox.TabIndex = 5;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(authorsListBox);
            Controls.Add(label3);
            Controls.Add(loansLabel);
            Controls.Add(label2);
            Controls.Add(titleLabel);
            Controls.Add(label1);
            Name = "StatisticsForm";
            Text = "Statistics";
            Load += StatisticsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label titleLabel;
        private Label label2;
        private Label loansLabel;
        private Label label3;
        private ListBox authorsListBox;
    }
}