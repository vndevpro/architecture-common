using GdNet.Common.Services;
using System.Collections.Generic;

namespace GdNet.Common.Entities.Repositories
{
    /// <summary>
    /// Repository base class
    /// </summary>
    public interface IRepositoryBase<T> where T : IEntity
    {
        /// <summary>
        /// Get by id of entity, will throw an exception if it doesn't exist
        /// </summary>
        T GetById(int id);

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Search for entities
        /// </summary>
        IEnumerable<T> GetAllBy(string propertyName, object propertyValue);

        /// <summary>
        /// Create or update an entity
        /// </summary>
        OperationResult CreateOrUpdate(T entity);

        /// <summary>
        /// Delete an entity
        /// </summary>
        OperationResult DeleteById(int id);
    }
}