using ProEventos.Application.Interfaces;
using ProEventos.Application.Models;

namespace ProEventos.Application.Service
{
    public class PalestranteAppService : IPalestranteAppService
    {
        public Task<PalestranteModel> AddPalestrante(PalestranteAddModel palestrante)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteModel> UpdatePalestrante(int palestranteId, PalestranteAddModel palestrante)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePalestrante(int palestranteId)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteModel[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteModel[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false)
        {
            throw new NotImplementedException();
        }

        public Task<PalestranteModel> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos = false)
        {
            throw new NotImplementedException();
        }
    }
}
