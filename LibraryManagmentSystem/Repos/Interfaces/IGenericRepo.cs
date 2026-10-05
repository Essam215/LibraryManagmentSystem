namespace LibraryManagmentSystem.Repos.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
