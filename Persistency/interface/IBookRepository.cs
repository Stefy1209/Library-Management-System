using Model;

namespace Persistency.@interface;

public interface IBookRepository : IRepository<Guid, Book>
{
    /// <summary>
    /// Returns all books that have the given title. The search is case-sensitive
    /// </summary>
    /// <param name="title">The title of the books to be returned. Must not be null.</param>
    /// <returns>A collection of books that have the given title.</returns>
    /// <exception cref="ArgumentException">Thrown when the title is null.</exception>
    IEnumerable<Book> FindByTitle(string? title);
    
    /// <summary>
    /// Returns all books that have the given authors.
    /// </summary>
    /// <param name="authors">The authors of the books to be returned</param>
    /// <returns>A collection of books that have the given authors</returns>
    IEnumerable<Book> FindByAuthors(IEnumerable<Author> authors);
    
    /// <summary>
    /// Returns all books that have the given title and authors.
    /// </summary>
    /// <param name="title">The title of the books to be returned.</param>
    /// <param name="authors">The authors of the books to be returned.</param>
    /// <returns>A collection of books that have the given title and authors.</returns>
    IEnumerable<Book> FindByTitleAndAuthors(string? title, IEnumerable<Author> authors);
}