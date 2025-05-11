namespace Library_Management_System_Form
{
    partial class LibraryManagementSystemForm
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
            dataGridViewBooks = new DataGridView();
            TitleBook = new DataGridViewTextBoxColumn();
            QuantityBook = new DataGridViewTextBoxColumn();
            LoanedQuantity = new DataGridViewTextBoxColumn();
            searchBookButton = new Button();
            loanBookButton = new Button();
            returnBookButton = new Button();
            addBookButton = new Button();
            removeBookButton = new Button();
            modifyBookButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.AllowUserToAddRows = false;
            dataGridViewBooks.AllowUserToDeleteRows = false;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { TitleBook, QuantityBook, LoanedQuantity });
            dataGridViewBooks.Location = new Point(12, 12);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.ReadOnly = true;
            dataGridViewBooks.RowHeadersWidth = 102;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(987, 577);
            dataGridViewBooks.TabIndex = 0;
            // 
            // TitleBook
            // 
            TitleBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TitleBook.DataPropertyName = "Title";
            TitleBook.HeaderText = "Title";
            TitleBook.MinimumWidth = 12;
            TitleBook.Name = "TitleBook";
            TitleBook.ReadOnly = true;
            TitleBook.Resizable = DataGridViewTriState.False;
            // 
            // QuantityBook
            // 
            QuantityBook.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            QuantityBook.DataPropertyName = "Quantity";
            QuantityBook.HeaderText = "Quantity";
            QuantityBook.MinimumWidth = 12;
            QuantityBook.Name = "QuantityBook";
            QuantityBook.ReadOnly = true;
            QuantityBook.Resizable = DataGridViewTriState.False;
            // 
            // LoanedQuantity
            // 
            LoanedQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanedQuantity.DataPropertyName = "LoanedQuantity";
            LoanedQuantity.HeaderText = "Loaned";
            LoanedQuantity.MinimumWidth = 12;
            LoanedQuantity.Name = "LoanedQuantity";
            LoanedQuantity.ReadOnly = true;
            LoanedQuantity.Resizable = DataGridViewTriState.False;
            // 
            // searchBookButton
            // 
            searchBookButton.Location = new Point(1060, 116);
            searchBookButton.Name = "searchBookButton";
            searchBookButton.Size = new Size(498, 58);
            searchBookButton.TabIndex = 6;
            searchBookButton.Text = "Search Book";
            searchBookButton.UseVisualStyleBackColor = true;
            searchBookButton.Click += searchBookButton_Click;
            // 
            // loanBookButton
            // 
            loanBookButton.Location = new Point(1060, 180);
            loanBookButton.Name = "loanBookButton";
            loanBookButton.Size = new Size(498, 58);
            loanBookButton.TabIndex = 7;
            loanBookButton.Text = "Loan Book";
            loanBookButton.UseVisualStyleBackColor = true;
            loanBookButton.Click += loanBookButton_Click;
            // 
            // returnBookButton
            // 
            returnBookButton.Location = new Point(1060, 244);
            returnBookButton.Name = "returnBookButton";
            returnBookButton.Size = new Size(498, 58);
            returnBookButton.TabIndex = 8;
            returnBookButton.Text = "Return Book";
            returnBookButton.UseVisualStyleBackColor = true;
            returnBookButton.Click += returnBookButton_Click;
            // 
            // addBookButton
            // 
            addBookButton.Location = new Point(1060, 308);
            addBookButton.Name = "addBookButton";
            addBookButton.Size = new Size(498, 58);
            addBookButton.TabIndex = 9;
            addBookButton.Text = "Add Book";
            addBookButton.UseVisualStyleBackColor = true;
            addBookButton.Click += addBookButton_Click;
            // 
            // removeBookButton
            // 
            removeBookButton.Location = new Point(1060, 372);
            removeBookButton.Name = "removeBookButton";
            removeBookButton.Size = new Size(498, 58);
            removeBookButton.TabIndex = 10;
            removeBookButton.Text = "Remove Book";
            removeBookButton.UseVisualStyleBackColor = true;
            removeBookButton.Click += removeBookButton_Click;
            // 
            // modifyBookButton
            // 
            modifyBookButton.Location = new Point(1060, 436);
            modifyBookButton.Name = "modifyBookButton";
            modifyBookButton.Size = new Size(495, 58);
            modifyBookButton.TabIndex = 11;
            modifyBookButton.Text = "Modify Book";
            modifyBookButton.UseVisualStyleBackColor = true;
            modifyBookButton.Click += modifyBookButton_Click;
            // 
            // LibraryManagementSystemForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1610, 601);
            Controls.Add(modifyBookButton);
            Controls.Add(removeBookButton);
            Controls.Add(addBookButton);
            Controls.Add(returnBookButton);
            Controls.Add(loanBookButton);
            Controls.Add(searchBookButton);
            Controls.Add(dataGridViewBooks);
            Name = "LibraryManagementSystemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBooks;
        private Button searchBookButton;
        private Button loanBookButton;
        private Button returnBookButton;
        private Button addBookButton;
        private Button removeBookButton;
        private DataGridViewTextBoxColumn TitleBook;
        private DataGridViewTextBoxColumn QuantityBook;
        private DataGridViewTextBoxColumn LoanedQuantity;
        private Button modifyBookButton;
    }
}
