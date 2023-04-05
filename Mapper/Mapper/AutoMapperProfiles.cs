using AutoMapper.DTOs;
using AutoMapper.Entities;

namespace AutoMapper.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        { 
            CreateMap<Persona, PersonaDTO>().ReverseMap();
            CreateMap<Direccion, DireccionDTO>().ReverseMap();
        }
    }
}
