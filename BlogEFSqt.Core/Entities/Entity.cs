using BlogEFSqt.Core.Interfaces;

namespace BlogEFSqt.Core.Entities
{
    public abstract class Entity: IEntity
    {
        public int Id { get; set; }
    }
}
