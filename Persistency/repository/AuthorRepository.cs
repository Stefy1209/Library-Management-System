using Microsoft.EntityFrameworkCore;
using Model;
using Persistency.@interface;

namespace Persistency.repository;

public class AuthorRepository(LmsDbContext context) : IAuthorRepository
{
    public Author? FindOne(Guid id)
    {
        return context.Authors.Find(id);
    }

    public IEnumerable<Author> FindAll()
    {
        return context.Authors.Include(author => author.Books).ToHashSet();
    }

    public Author? Save(Author? entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Author cannot be null.");
        
        context.Authors.Add(entity);
        return context.SaveChanges() > 0 ? null : entity;       
    }

    public Author? Delete(Guid id)
    {
        var author = context.Authors.Find(id);
        if (author == null)
            return null;
        
        context.Authors.Remove(author);
        return context.SaveChanges() > 0 ? author : null;
    }

    public Author? Update(Author? entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Author cannot be null.");
        
        context.Authors.Update(entity);
        return context.SaveChanges() > 0 ? null : entity;
    }
}