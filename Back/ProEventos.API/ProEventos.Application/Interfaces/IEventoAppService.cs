using ProEventos.Application.Dtos;
using ProEventos.Application.Models;

namespace ProEventos.Application.Interfaces
{
    public interface IEventoAppService
    {
        Task<EventoDto> AddEvento(EventoDto model);
        Task<EventoModel> UpdateEvento(int eventoId, EventoUpdateModel model);
        Task<bool> DeleteEvento(int eventoId);
        Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<EventoDto[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<EventoDto> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}
