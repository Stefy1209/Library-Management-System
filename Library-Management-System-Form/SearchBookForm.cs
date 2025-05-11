using System.ComponentModel;
using Model;
using Service;

namespace Library_Management_System_Form
{
    public partial class SearchForm : Form
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        
        private readonly BindingSource _authorsBindingSource = new();
        
        public SearchForm(IBookService bookService, IAuthorService authorService)
        {
            _bookService = bookService;       
            _authorService = authorService;       
            
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var title = titleTextBox.Text.Trim();
            var authors = GetSelectedAuthors();
            _bookService.SetTitleFilter(title);
            _bookService.SetAuthorFilter(authors);
            Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            var authors = _authorService.FindAllAuthors().ToList();
            var bindingList = new BindingList<Author>(authors);
            _authorsBindingSource.DataSource = bindingList;
            checkedListBox1.DataSource = _authorsBindingSource;
            checkedListBox1.DisplayMember = nameof(Author.Name);
        }
        
        private List<Author> GetSelectedAuthors()
        {
            var selectedAuthors = new List<Author>();
            foreach (var item in checkedListBox1.CheckedItems)
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
