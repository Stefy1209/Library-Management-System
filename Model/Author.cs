namespace Model;

public sealed class Author : Entity<Guid>
{
    private readonly HashSet<Book> _books = [];
    
    public string Name { get; private set; } = string.Empty;
    public IReadOnlyCollection<Book> Books => _books;
    
    public Author() {}
    public Author(Guid id, string name)
    {
        Id = id;
        SetName(name);       
    }
    
    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.", nameof(name));
        Name = name;       
    }
    
    public void AddBook(Book book)
    {
        if (_books.Add(book))
            book.AddAuthor(this);
    }
    
    public void RemoveBook(Book book)
    {
        if (_books.Remove(book))
            book.RemoveAuthor(this);
    }
}