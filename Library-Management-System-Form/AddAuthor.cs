using Service;

namespace Library_Management_System_Form
{
    public partial class AddAuthor : Form
    {
        private readonly IAuthorService _authorService;
        
        public AddAuthor(IAuthorService authorService)
        {
            InitializeComponent();
            
            _authorService = authorService;       
        }

        private void AddToSystem(object sender, EventArgs e)
        {
            var name = NameTextBox.Text.Trim();
            _authorService.AddAuthor(name);
            Close();
        }
    }
}