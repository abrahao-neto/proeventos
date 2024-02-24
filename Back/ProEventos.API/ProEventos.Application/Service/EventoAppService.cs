using AutoMapper;
using ProEventos.Application.Dtos;
using ProEventos.Application.Interfaces;
using ProEventos.Application.Models;
using ProEventos.Domain.Entities;
using ProEventos.Domain.Interfaces.Services;

namespace ProEventos.Application.Service
{
    public class EventoAppService : IEventoAppService
    {
        private readonly IEventoDomainService? _eventoDomainService;
        private readonly IMapper _mapper;

        public EventoAppService(IEventoDomainService? eventoDomainService, IMapper mapper)
        {
            _eventoDomainService = eventoDomainService;
            _mapper = mapper;
        }

        public async Task<EventoDto> AddEvento(EventoDto model)
        {
            try
            {
                var evento = _mapper.Map<Evento>(model);

                await _eventoDomainService.AddEvento(evento);

                return _mapper.Map<EventoDto>(evento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoModel> UpdateEvento(int eventoId, EventoUpdateModel model)
        {
            try
            {
                var evento = _mapper.Map<Evento>(model);

                var result = await _eventoDomainService.UpdateEvento(eventoId, evento);

                return _mapper.Map<EventoModel>(result);
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
                return  await _eventoDomainService.DeleteEvento(eventoId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto[]> GetAllEventosAsync(bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoDomainService.GetAllEventosAsync(includePalestrantes);

                return _mapper.Map<EventoDto[]>(eventos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false)
        {
            try
            {
                var eventos = await _eventoDomainService.GetAllEventosByTemaAsync(tema, includePalestrantes);
                return _mapper.Map<EventoDto[]>(eventos);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<EventoDto> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false)
        {
            try
            {
                var evento = await _eventoDomainService.GetEventoByIdAsync(eventoId, includePalestrantes);
                return _mapper.Map<EventoDto>(evento);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
