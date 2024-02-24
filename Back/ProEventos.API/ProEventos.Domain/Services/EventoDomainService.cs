using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Repositories;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Domain.Services
{
    public class EventoDomainService : IEventoDomainService
    {
        private readonly IEventoRepository? _eventoRepository;

        public EventoDomainService(IEventoRepository? eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        public async Task<Evento> AddEvento(Evento evento)
        {
            try
            {
                _eventoRepository.Add(evento);

                if (await _eventoRepository.SaveChangesAsync())
                    return await _eventoRepository.GetEventoByIdAsync(evento.Id, false);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> UpdateEvento(int eventoId, Evento evento)
        {
            try
            {
                var entity = await _eventoRepository.GetEventoByIdAsync(eventoId, false);

                if (entity == null) 
                    return null;

                evento.Id = entity.Id;

                _eventoRepository.Update(evento);

                if (await _eventoRepository.SaveChangesAsync())
                    return await _eventoRepository.GetEventoByIdAsync(evento.Id, false);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteEvento(int eventoId)
        {
            try
            {
                var entity = await _eventoRepository.GetEventoByIdAsync(eventoId, false);

                if (entity == null)
                    throw new Exception("Evento para delete não encontrado.");

                _eventoRepository.Delete<Evento>(entity);
                return await _eventoRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosAsync(includePalestrantes);
                if (eventos == null)
                    return null;

                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoRepository.GetAllEventosByTemaAsync(tema, includePalestrantes);
                if (eventos == null)
                    return null;

                return eventos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            try
            {
                var evento = await _eventoRepository.GetEventoByIdAsync(eventoId, includePalestrantes);
                if (evento == null)
                    return null;

                return evento;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
