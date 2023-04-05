using AutoMapper.DTOs;
using AutoMapper.Entities;

namespace AutoMapper.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Persona, PersonaDTO>().ForMember(dto => dto.Direcciones,
                ent => ent.MapFrom(p => p.Direcciones.OrderByDescending(d => d.Id)));
            CreateMap<Direccion, DireccionDTO>();
        }
    }
}
