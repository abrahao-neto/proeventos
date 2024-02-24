using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Infra.Data.Contexts;

public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly DataContext _context;

    protected BaseRepository(DataContext context)
    {
        _context = context;
    }

    public void Add<T>(T entity)
    {
        _context.Add(entity);
    }

    public void Update<T>(T entity)
    {
        _context.Update(entity);
    }

    public void Delete<T>(T entity)
    {
        _context.Remove(entity);
    }

    public void DeleteRange<T>(T[] entityArray)
    {
        _context.RemoveRange(entityArray);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return (await _context.SaveChangesAsync()) > 0;
    }
}