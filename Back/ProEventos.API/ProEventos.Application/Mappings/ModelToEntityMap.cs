using AutoMapper;
using ProEventos.Application.Models;
using ProEventos.Domain.Entities;

namespace ProEventos.Application.Mappings
{
    public class ModelToEntityMap : Profile
    {
        public ModelToEntityMap()
        {
            CreateMap<EventoAddModel, Evento>()
                .ForMember(dest => dest.Lotes, opt => opt.MapFrom(src => src.Lotes))
                .ForMember(dest => dest.RedesSociais, opt => opt.MapFrom(src => src.RedesSociais))
                .ForMember(dest => dest.PalestrantesEventos, opt => opt.MapFrom(src => src.PalestrantesEventos));

            CreateMap<EventoUpdateModel, Evento>()
                .ForMember(dest => dest.Lotes, opt => opt.MapFrom(src => src.Lotes))
                .ForMember(dest => dest.RedesSociais, opt => opt.MapFrom(src => src.RedesSociais))
                .ForMember(dest => dest.PalestrantesEventos, opt => opt.MapFrom(src => src.PalestrantesEventos));

            CreateMap<EventoModel, Evento>();
            CreateMap<LoteModel, Lote>();
            CreateMap<PalestranteEventoModel, PalestranteEvento>();
            CreateMap<RedeSocialModel, RedeSocial>();
            //CreateMap<PalestranteAddModel, Palestrante>();
        }
    }
}
