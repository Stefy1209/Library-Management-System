using Model;

namespace Service;

public interface IAuthorService
{
    void AddAuthor(string name);
    void RemoveAuthor(Author author);
    IEnumerable<Author> FindAllAuthors();
}