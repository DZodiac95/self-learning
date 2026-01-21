namespace Studying.Day_2
{
    public class EntityRepository<T> where T : IEntity, new()
    {
        private readonly List<T> _data = new();
        public void Add(T entity) => _data.Add(entity);
        public IEnumerable<T> List() => _data;
        public void Delete(T entity) => _data.Remove(entity);
    }
}
