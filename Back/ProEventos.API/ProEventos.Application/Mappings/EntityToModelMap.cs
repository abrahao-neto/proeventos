using AutoMapper;
using ProEventos.Application.Models;
using ProEventos.Domain.Entities;

namespace ProEventos.Application.Mappings
{
    public class EntityToModelMap : Profile
    {
        public EntityToModelMap()
        {
            CreateMap<Evento, EventoModel>()
                .ForMember(dest => dest.Lotes, opt => opt.MapFrom(src => src.Lotes))
                .ForMember(dest => dest.RedesSociais, opt => opt.MapFrom(src => src.RedesSociais))
                .ForMember(dest => dest.PalestrantesEventos, opt => opt.MapFrom(src => src.PalestrantesEventos));

            CreateMap<Evento, EventoModel>();
            CreateMap<Lote, LoteModel>();
            CreateMap<PalestranteEvento, PalestranteEventoModel>();
            CreateMap<RedeSocial, RedeSocialModel>();
            //CreateMap<Palestrante, PalestranteModel>();
        }
    }
}
