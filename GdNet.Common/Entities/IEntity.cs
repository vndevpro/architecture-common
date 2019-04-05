using System;

namespace GdNet.Common.Entities
{
    /// <summary>
    /// Entity base interface
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Id of the entity
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// The date that entity was created
        /// </summary>
        DateTime CreatedAt { get; set; }

        /// <summary>
        /// Who created it
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// The date that entity was updated
        /// </summary>
        DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Who updated it
        /// </summary>
        string UpdatedBy { get; set; }
    }
}