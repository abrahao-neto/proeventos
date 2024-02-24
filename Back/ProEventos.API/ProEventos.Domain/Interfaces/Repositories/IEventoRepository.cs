using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IEventoRepository : IBaseRepository<Evento>
    {
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int EventoId, bool includePalestrantes = false);
    }
}
