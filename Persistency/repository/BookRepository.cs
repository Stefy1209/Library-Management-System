using Model;
using Persistency.@interface;

namespace Persistency.repository;

public class BookRepository(LmsDbContext context) : IBookRepository
{
    public Book? FindOne(Guid id)
    {
        return context.Books.Find(id);
    }

    public IEnumerable<Book> FindAll()
    {
        return context.Books.ToHashSet();
    }

    public Book? Save(Book? entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Book cannot be null.");
        
        context.Books.Add(entity);
        return context.SaveChanges() > 0 ? null : entity;
    }

    public Book? Delete(Guid id)
    {
        var book = context.Books.Find(id);
        if (book == null)
            return null;
        
        context.Books.Remove(book);
        return context.SaveChanges() > 0 ? book : null;
    }

    public Book? Update(Book? entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Book cannot be null.");
        
        context.Books.Update(entity);
        return context.SaveChanges() > 0 ? null : entity;       
    }

    public IEnumerable<Book> FindByTitle(string? title)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Title cannot be null.", nameof(title));

        return context.Books.Where(book => book.Title.Contains(title));
    }

    public IEnumerable<Book> FindByAuthors(IEnumerable<Author> authors)
    {
        return context.Books.Where(book => authors.Any(author => author.Books.Contains(book)));       
    }

    public IEnumerable<Book> FindByTitleAndAuthors(string? title, IEnumerable<Author> authors)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Title cannot be null.", nameof(title));
        
        return context.Books.Where(book => book.Title.Contains(title) && authors.Any(author => author.Books.Contains(book)));       
    }
}