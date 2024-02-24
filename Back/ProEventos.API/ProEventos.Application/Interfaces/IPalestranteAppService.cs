using ProEventos.Application.Models;

namespace ProEventos.Application.Interfaces
{
    public interface IPalestranteAppService
    {
        Task<PalestranteModel> AddPalestrante(PalestranteAddModel palestrante);
        Task<PalestranteModel> UpdatePalestrante(int palestranteId, PalestranteAddModel palestrante);
        Task<bool> DeletePalestrante(int palestranteId);
        Task<PalestranteModel[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false);
        Task<PalestranteModel[]> GetAllPalestrantesAsync(bool includeEventos = false);
        Task<PalestranteModel> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos = false);
    }
}
