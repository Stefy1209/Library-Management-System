using System.ComponentModel;
using Model;
using Service;

namespace Library_Management_System_Form
{
    public partial class ModifyBookForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;       
        private readonly Book _book;
        
        private readonly BindingSource _authorsBindingSource = new();       
        
        public ModifyBookForm(IBookService bookService, IAuthorService authorService, Book book)
        {
            _bookService = bookService;       
            _authorService = authorService;       
            _book = book;       
            
            InitializeComponent();
        }

        private void ModifyBookForm_Load(object sender, EventArgs e)
        {
            LoadCheckedListBox();
            titleTextBox.Text = _book.Title;
            quantityNumericUpDown.Value = _book.Quantity;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            var title = titleTextBox.Text.Trim();
            var quantity = (int)quantityNumericUpDown.Value;
            var authors = GetSelectedAuthors();
            _bookService.ChangeBookTitle(_book, title);
            _bookService.ChangeBookQuantity(_book, quantity);
            _bookService.ChangeBookAuthors(_book, authors);
            Close();       
        }

        private void LoadCheckedListBox()
        {
            var authors = _authorService.FindAllAuthors().ToList();
            var bindingList = new BindingList<Author>(authors);
            _authorsBindingSource.DataSource = bindingList;
            authorsCheckedListBox.DataSource = _authorsBindingSource;
            authorsCheckedListBox.DisplayMember = nameof(Author.Name);

            for (var i = 0; i < authorsCheckedListBox.Items.Count; i++)
            {
                var author = (Author)authorsCheckedListBox.Items[i];
                if (_book.Authors.Any(a => a.Id == author.Id))
                {
                    authorsCheckedListBox.SetItemChecked(i, true);
                }
            }
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
    }
}
