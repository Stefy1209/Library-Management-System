using System.ComponentModel;
using Model;
using Service;

namespace Library_Management_System_Form
{
    public partial class AddBookForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        private readonly BindingSource _authorsBindingSource = new();

        public AddBookForm(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;

            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            var title = titleTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show(@"Title cannot be empty");
                return;
            }

            var quantity = (int)quantityNumericUpDown.Value;
            if (quantity == 0)
            {
                MessageBox.Show(@"Quantity cannot be 0");
                return;
            }

            var authors = GetSelectedAuthors();
            if (authors.Count == 0)
            {
                MessageBox.Show(@"At least one author must be selected");
            }

            _bookService.AddBooks(title, quantity, authors);
            Close();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            LoadCheckedListBox();
        }

        private List<Author> GetSelectedAuthors()
        {
            var selectedAuthors = new List<Author>();
            foreach (var item in authorsCheckedListBox.CheckedItems)
            {
                if (item is Author author)
                {
                    selectedAuthors.Add(author);
                }
            }
            return selectedAuthors;
        }

        private void addAuthorButton_Click(object sender, EventArgs e)
        {
            var addAuthorForm = new AddAuthor(_authorService);
            addAuthorForm.ShowDialog();
            LoadCheckedListBox();       
        }

        private void LoadCheckedListBox()
        {
            var authors = _authorService.FindAllAuthors().ToList();
            var bindingList = new BindingList<Author>(authors);
            _authorsBindingSource.DataSource = bindingList;
            authorsCheckedListBox.DataSource = _authorsBindingSource;
            authorsCheckedListBox.DisplayMember = nameof(Author.Name);
        }
    }
}
