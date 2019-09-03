using Sy.Core.Abstracts;

namespace Sy.Core.Entities
{
    public abstract class BaseEntity<TKey> : AuditBase, IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}