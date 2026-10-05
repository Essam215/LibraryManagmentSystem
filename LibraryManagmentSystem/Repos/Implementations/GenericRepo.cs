using LibraryManagmentSystem.Data;
using LibraryManagmentSystem.Repos.Interfaces;

namespace LibraryManagmentSystem.Repos.Implementations
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly LibraryContext _context;

        public GenericRepo(LibraryContext context)
        {
            _context = context;
        }

        public void Add(T item)
        {
            _context.Add(item);
        }

        public void Delete(T item)
        {
            _context.Remove(item);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id)!;
        }

        public void Update(T item)
        {
            _context.Update(item);
        }
    }
}
