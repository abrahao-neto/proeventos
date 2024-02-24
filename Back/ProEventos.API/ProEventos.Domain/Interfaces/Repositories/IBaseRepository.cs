using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add<T>(T entity);
        void Update<T>(T entity);
        void Delete<T>(T entity);
        void DeleteRange<T>(T[] entity);
        Task<bool> SaveChangesAsync();

        


    }
}
