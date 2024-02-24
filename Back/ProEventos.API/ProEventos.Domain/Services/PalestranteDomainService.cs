using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Domain.Services
{
    public class PalestranteDomainService : IPalestranteDomainService
    {
        public Task<Palestrante> AddPalestrante(Palestrante palestrante)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> UpdatePalestrante(int palestranteId, Palestrante palestrante)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePalestrante(int palestranteId)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos = false)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos = false)
        {
            throw new NotImplementedException();
        }

        public Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos = false)
        {
            throw new NotImplementedException();
        }
    }
}
