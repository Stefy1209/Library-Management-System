using Model;

namespace Service;

public interface IBookService
{
    void AddBooks(string title, int quantity, IEnumerable<Author> authors);
    void RemoveBook(Book book);
    void LoanBook(Book book);
    void LoanBooks(Book book, int amount);
    void ReturnBook(Book book);
    void ReturnBooks(Book book, int amount);
    void ChangeBookTitle(Book book, string title);
    void ChangeBookQuantity(Book book, int quantity);
    void ChangeBookAuthors(Book book, IEnumerable<Author> authors);
    IEnumerable<Book> SearchForBooks();
    void SetTitleFilter(string? title);
    void SetAuthorFilter(IEnumerable<Author> authors);
}