using Model;

namespace Service;

public interface IAuthorService
{
    /// <summary>
    /// Add author to the system
    /// </summary>
    /// <param name="name">The name of the author.</param>
    void AddAuthor(string name);

    /// <summary>
    /// Removes an existing author from the system.
    /// </summary>
    /// <param name="author">The author to be removed.</param>
    void RemoveAuthor(Author author);

    /// <summary>
    /// Retrieves all authors from the system.
    /// </summary>
    /// <returns>A collection of all authors, ordered by their names.</returns>
    IEnumerable<Author> FindAllAuthors();
}