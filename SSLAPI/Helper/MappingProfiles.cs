using AutoMapper;
using SSLAPI.Dto;
using SSLAPI.Models;

namespace SSLAPI.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();

        }
    }
}
