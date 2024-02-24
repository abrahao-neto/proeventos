using ProEventos.Domain.Entities;

namespace ProEventos.Domain.Interfaces.Services
{
    public interface IPalestranteDomainService
    {
        Task<Palestrante> AddPalestrante(Palestrante palestrante);
        Task<Palestrante> UpdatePalestrante(int palestranteId, Palestrante palestrante);
        Task<bool> DeletePalestrante(int palestranteId);
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false);
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos = false);
    }
}
