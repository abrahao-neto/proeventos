using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Repositories
{
    public interface IPalestranteRepository : IBaseRepository<Palestrante>
    {
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false);
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos = false);
    }
}
