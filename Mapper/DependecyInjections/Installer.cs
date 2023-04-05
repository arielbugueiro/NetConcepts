using AutoMapper;
using AutoMapper.Mapper;

namespace Mapper.DependecyInjections
{
    public static class Installer
    {
        public static void AddMapper(this IServiceCollection service)
        {
            //Configuration for Mapper
            service.AddSingleton(new MapperConfiguration(mc => mc.AddProfile(new AutoMapperProfiles())).CreateMapper());
        }
    }
}
