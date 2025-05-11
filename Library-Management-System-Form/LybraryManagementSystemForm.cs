using System.ComponentModel;
using Model;
using Service;

namespace Library_Management_System_Form
{
    public partial class LibraryManagementSystemForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        private readonly BindingSource _booksBindingSource = new();

        public LibraryManagementSystemForm(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            var books = _bookService.SearchForBooks();
            var bindingList = new BindingList<Book>(books.ToList());
            _booksBindingSource.DataSource = bindingList;
            dataGridViewBooks.AutoGenerateColumns = false;
            dataGridViewBooks.DataSource = _booksBindingSource;
            dataGridViewBooks.Refresh();
        }

        private void searchBookButton_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm(_bookService, _authorService);
            searchForm.ShowDialog();
            LoadBooks();
        }

        private void loanBookButton_Click(object sender, EventArgs e)
        {
            if (_booksBindingSource.Current is not Book book)
            {
                MessageBox.Show(@"No book selected");
                return;
            }

            try
            {
                _bookService.LoanBook(book);
                dataGridViewBooks.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            if (_booksBindingSource.Current is not Book book)
            {
                MessageBox.Show(@"No book selected");
                return;
            }

            try
            {
                _bookService.ReturnBook(book);
                dataGridViewBooks.Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(_bookService, _authorService);
            addBookForm.ShowDialog();
            LoadBooks();
        }

        private void removeBookButton_Click(object sender, EventArgs e)
        {
            if (_booksBindingSource.Current is not Book book)
            {
                MessageBox.Show(@"No book selected");
                return;
            }
            _bookService.RemoveBook(book);
            _booksBindingSource.RemoveCurrent();
        }

        private void modifyBookButton_Click(object sender, EventArgs e)
        {
            if (_booksBindingSource.Current is not Book book)
            {
                MessageBox.Show(@"No book selected");
                return;
            }
            
            var modifyBookForm = new ModifyBookForm(_bookService, _authorService, book);
            modifyBookForm.ShowDialog();
            dataGridViewBooks.Refresh();
        }
    }
}
