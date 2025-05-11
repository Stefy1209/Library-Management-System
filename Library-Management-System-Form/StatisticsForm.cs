using Model;

namespace Library_Management_System_Form
{
    public partial class StatisticsForm : Form
    {
        private readonly Book _book;
        
        public StatisticsForm(Book book)
        {
            _book = book;       
            
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = _book.Title;       
            loansLabel.Text = _book.Statistics.NrTimesLoaned.ToString();
            var authors = _book.Authors.Select(author => author.Name).ToList();
            authorsListBox.DataSource = authors;       
        }
    }
}
