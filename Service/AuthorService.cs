using Model;
using Persistency.@interface;

namespace Service;

public class AuthorService(IAuthorRepository authorRepository) : IAuthorService
{
    public void AddAuthor(string name)
    {
        var author = new Author(Guid.NewGuid(), name);
        authorRepository.Save(author);       
    }

    public void RemoveAuthor(Author author)
    {
        authorRepository.Delete(author.Id);
    }

    public IEnumerable<Author> FindAllAuthors()
    {
        return authorRepository.FindAll().OrderBy(author => author.Name);
    }
}