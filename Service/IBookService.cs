using Model;

namespace Service;

public interface IBookService
{
    /// <summary>
    /// Adds a new book to the service with the specified title, quantity, and authors.
    /// </summary>
    /// <param name="title">The title of the book to be added.</param>
    /// <param name="quantity">The quantity of the book to be added.</param>
    /// <param name="authors">A collection of authors associated with the book.</param>
    void AddBooks(string title, int quantity, IEnumerable<Author> authors);

    /// <summary>
    /// Removes the specified book from the service.
    /// </summary>
    /// <param name="book">The book to be removed.</param>
    void RemoveBook(Book book);

    /// <summary>
    /// Loans a book, reducing the available quantity by one and marking it as loaned.
    /// </summary>
    /// <param name="book">The book to be loaned.</param>
    void LoanBook(Book book);

    /// <summary>
    /// Loans multiple copies of a book, reducing the available quantity by the specified amount
    /// and updating its loaned status.
    /// </summary>
    /// <param name="book">The book to be loaned.</param>
    /// <param name="amount">The number of copies to be loaned.</param>
    void LoanBooks(Book book, int amount);

    /// <summary>
    /// Returns a previously loaned book, increasing the available quantity and updating its status.
    /// </summary>
    /// <param name="book">The book to be returned to the service.</param>
    void ReturnBook(Book book);

    /// <summary>
    /// Returns multiple copies of the specified book to the service, increasing its available quantity
    /// by the specified amount.
    /// </summary>
    /// <param name="book">The book to which the copies are being returned.</param>
    /// <param name="amount">The number of copies being returned.</param>
    void ReturnBooks(Book book, int amount);

    /// <summary>
    /// Updates the title of the specified book.
    /// </summary>
    /// <param name="book">The book whose title is to be changed.</param>
    /// <param name="title">The new title for the book.</param>
    void ChangeBookTitle(Book book, string title);

    /// <summary>
    /// Updates the quantity of a given book in the service.
    /// </summary>
    /// <param name="book">The book whose quantity is to be updated.</param>
    /// <param name="quantity">The new quantity to set for the book.</param>
    void ChangeBookQuantity(Book book, int quantity);

    /// <summary>
    /// Updates the authors associated with a specific book by adding or removing authors as needed.
    /// </summary>
    /// <param name="book">The book for which the authors should be updated.</param>
    /// <param name="authors">A collection of authors to be associated with the book.</param>
    void ChangeBookAuthors(Book book, IEnumerable<Author> authors);

    /// <summary>
    /// Searches for books based on the applied filters.
    /// </summary>
    /// <returns>A collection of books that match the specified title and/or author filters.</returns>
    IEnumerable<Book> SearchForBooks();

    /// <summary>
    /// Sets the title filter for book searches within the service.
    /// </summary>
    /// <param name="title">The title or partial title to filter books by. Pass null to clear the filter.</param>
    void SetTitleFilter(string? title);

    /// <summary>
    /// Sets a filter to include only books associated with the specified authors.
    /// </summary>
    /// <param name="authors">A collection of authors to filter the books by.</param>
    void SetAuthorFilter(IEnumerable<Author> authors);
}