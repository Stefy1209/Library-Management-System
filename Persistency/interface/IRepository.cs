using Model;

namespace Persistency.@interface;

/// <summary>
/// CRUD operation repository interface.
/// </summary>
/// <typeparam name="TId">Type TEntity must have an attribute of type TId.</typeparam>
/// <typeparam name="TEntity">Type of entity saved in repository.</typeparam>
public interface IRepository<in TId, TEntity> where TEntity : Entity<TId> where TId : notnull
{
    /// <summary>
    /// Returns a nullable entity of type TEntity with the given id, or null if not found.
    /// </summary>
    /// <param name="id">The id of the entity to be returned. Must not be null.</param>
    /// <returns>A nullable TEntity (TEntity?), which may be null if no entity with the given id is found.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the id is null.</exception>
    TEntity? FindOne(TId? id);
    
    /// <summary>
    /// Returns all entities of type TEntity.
    /// </summary>
    /// <returns>A collection of TEntity objects.</returns>
    IEnumerable<TEntity> FindAll();
    
    /// <summary>
    /// Saves the given entity in the repository.
    /// </summary>
    /// <param name="entity">The given entity to be saved. Must not be null.</param>
    /// <returns>Null if the entity is saved, the entity otherwise(id already exists).</returns>
    /// <exception cref="ArgumentNullException">Thrown when the entity is null.</exception>
    TEntity? Save(TEntity? entity);
    
    /// <summary>
    /// Deletes the entity with the given id from the repository.
    /// </summary>
    /// <param name="id">The id of the entity to be deleted. Must not be null.</param>
    /// <returns>The entity with the given id if it is deleted, null otherwise.</returns>
    /// <exception cref="ArgumentNullException">Thrown when id is null.</exception>
    TEntity? Delete(TId? id);
    
    /// <summary>
    /// Updates the entity from the table which has the same id with the provided entity.
    /// </summary>
    /// <param name="entity">The given entity to be saved. Must not be null.</param>
    /// <returns>Null if a table is updated, the entity otherwise.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the entity is null.</exception>>
    TEntity? Update(TEntity? entity);
}