using Model;
using Persistency.@interface;

namespace Service;

public class BookService(IBookRepository bookRepository) : IBookService
{
    private string? _titleFilter = string.Empty;
    private ISet<Author> _authorsFilter = new HashSet<Author>();

    public void AddBooks(string title, int quantity, IEnumerable<Author> authors)
    {
        var book = new Book(Guid.NewGuid(), title, quantity);
        foreach (var author in authors)
            book.AddAuthor(author);
        bookRepository.Save(book);
    }

    public void RemoveBook(Book book)
    {
        bookRepository.Delete(book.Id);       
    }

    public void LoanBook(Book book)
    {
        book.LoanBook();
        bookRepository.Update(book);
    }

    public void LoanBooks(Book book, int amount)
    {
        book.LoanBooks(amount);
        bookRepository.Update(book);
    }

    public void ReturnBook(Book book)
    {
        book.ReturnBook();
        bookRepository.Update(book);       
    }

    public void ReturnBooks(Book book, int amount)
    {
        book.ReturnBooks(amount);
        bookRepository.Update(book);
    }

    public void ChangeBookTitle(Book book, string title)
    {
        book.SetTitle(title);
        bookRepository.Update(book);
    }

    public void ChangeBookQuantity(Book book, int quantity)
    {
        book.SetQuantity(quantity);
        bookRepository.Update(book);       
    }

    public void ChangeBookAuthors(Book book, IEnumerable<Author> authors)
    {
        var enumerable = authors.ToList();
        var authorsToRemove = book.Authors.Except(enumerable).ToList();
        var authorsToAdd = enumerable.Except(book.Authors).ToList();
        
        foreach (var author in authorsToRemove)
            book.RemoveAuthor(author);
        
        foreach (var author in authorsToAdd)
            book.AddAuthor(author);
        
        bookRepository.Update(book);
    }

    public IEnumerable<Book> SearchForBooks()
    {
        if (string.IsNullOrWhiteSpace(_titleFilter) && _authorsFilter.Count == 0)
            return bookRepository.FindAll();

        if (!string.IsNullOrWhiteSpace(_titleFilter) && _authorsFilter.Count != 0)
            return bookRepository.FindByTitleAndAuthors(_titleFilter, _authorsFilter);

        if (!string.IsNullOrWhiteSpace(_titleFilter))
            return bookRepository.FindByTitle(_titleFilter);

        return bookRepository.FindByAuthors(_authorsFilter);
    }

    public void SetTitleFilter(string? title)
    {
        _titleFilter = title;
    }

    public void SetAuthorFilter(IEnumerable<Author> authors)
    {
        _authorsFilter = authors.ToHashSet();
    }
}