using AutoMapper;
using ProEventos.Application.Dtos;
using ProEventos.Domain.Entities;

namespace ProEventos.Application.Mappings
{
    public class ProEventosMap : Profile
    {
        public ProEventosMap() 
        {
            CreateMap<Evento, EventoDto>().ReverseMap();
        }
        
    }
}
